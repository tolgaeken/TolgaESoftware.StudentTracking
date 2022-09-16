using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.Base
{
    public class BaseGeneralAdminBll<T>:BaseBll<T,StudentTrackingAdminContext> where T : BaseEntity
    {
        #region Variables
        private CardType _cardType; 
        #endregion

        public BaseGeneralAdminBll(CardType cardType) { _cardType = cardType; }

        public BaseGeneralAdminBll(Control control, CardType cardType) : base(control) { _cardType = cardType; }

        public virtual BaseEntity Single(Expression<Func<T, bool>> filter)
        {
            return BaseSingle(filter, p => p);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<T,bool>> filter)
        {
            return BaseList(filter, p => p).OrderBy(p=>p.Code).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, p => p.Code == entity.Code);
        }

        public bool Insert(BaseEntity entity,Expression<Func<T,bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity,BaseEntity currententity)
        {
            return BaseUpdate(oldEntity, currententity, p => p.Code == currententity.Code);
        }

        public bool Update(BaseEntity oldEntity,BaseEntity currententity,Expression<Func<T,bool>> filter)
        {
            return BaseUpdate(oldEntity, currententity, filter);
        }


        public virtual bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, _cardType,false);
        }

        public string GetNewCode()
        {
            return BaseGetNewCode(_cardType, p => p.Code);
        }

        public string GetNewCode(Expression<Func<T,bool>> filter)
        {
            return BaseGetNewCode(_cardType, p => p.Code,filter);
        }

        public string GetNewStudentNumber(Expression<Func<T,bool>> filter)
        {
            return BaseGetNewStudentNumber(_cardType, p => p.Code,filter);
        }
    }
}