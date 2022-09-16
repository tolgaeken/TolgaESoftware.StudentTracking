using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.Dal.Interfaces;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.Base
{
    public class BaseActionBll<T, TContext> : IBaseBll ,IBaseActionGeneralBll where T : BaseActionEntity where TContext : DbContext
    {
        #region Variables
        private IUnitOfWork<T> _unitOfWork; 
        #endregion

        protected IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter,
            Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        public virtual bool InsertSingle(BaseActionEntity entity)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }
        
        public virtual bool Insert(IList<BaseActionEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            _unitOfWork.Rep.Insert(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public virtual bool Update(IList<BaseActionEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            _unitOfWork.Rep.Update(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public bool Delete(IList<BaseActionEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            _unitOfWork.Rep.Delete(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        #region Dispose

        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }

        #endregion
    }
}