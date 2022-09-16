using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using TolgaESoftware.Dal.Interfaces;
using TolgaESoftware.StudentTracking.Common.Message;

namespace TolgaESoftware.Dal.Base
{
    public class UnitOfWork<T>:IUnitOfWork<T>
    where T:class
    {
        #region Variables
        private readonly DbContext _context; 
        #endregion

        public UnitOfWork(DbContext context)
        {
            if (context==null)return;
            _context = context;
        }

        public IRepository<T> Rep => new Repository<T>(_context);
        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                var sqlException = (SqlException) exception.InnerException?.InnerException;
                if (sqlException == null)
                {
                    Messages.ErrorMessage(exception.Message);
                    return false;
                }

                switch (sqlException.Number)
                {
                    case 208:
                        Messages.ErrorMessage("İşlem Yapmak İstediğiniz Tablo Veritabanında Mevcut Değildir.");
                        break;
                    case 547:
                        Messages.ErrorMessage("Seçilen Kartın İşlem Görmüş Hareketleri Var, Kart Silinemez.");
                        break;
                    case 2601:
                    case 2627:
                        Messages.ErrorMessage("Girmiş Olduğunuz Id Daha Önce Kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.ErrorMessage("İşlem Yapmak İstediğiniz Veritabanı Sunucuda Bulunamadı.");
                        break;
                    case 18456:
                        Messages.ErrorMessage("Sunucuya Bağlanılmak İstenilen Kullanıcı Adı veya Parola Hatalıdır.");
                        break;
                    default:
                        Messages.ErrorMessage(sqlException.Message);
                        break;
                }

                return false;
            }
            catch (Exception exception)
            {
                Messages.ErrorMessage(exception.Message);
                return false;
            }

            return true;
        }

        #region Dispose
        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)_context.Dispose();
                
                _disposedValue = true;
            }
        }

      
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


    }
}