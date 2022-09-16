using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using TolgaESoftware.Dal.Interfaces;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.Base
{
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext
    {
        #region Variables
        private readonly Control _control;
        private IUnitOfWork<T> _unitOfWork; 
        #endregion

        private bool Validation(ProcessType processType, BaseEntity oldEntity, BaseEntity currentEntity,
            Expression<Func<T, bool>> filter)
        {
            var errorControl = GetValidationErrorControl();
            

            if (errorControl == null) return true;
            _control.Controls[errorControl].Focus();
            return false;

            string GetValidationErrorControl()
            {
                string DuplicateCode()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<Code>())
                    {
                        if (property.Attribute == null) continue;

                        if ((processType == ProcessType.EntityInsert || oldEntity.Code == currentEntity.Code) && processType == ProcessType.EntityUpdate) continue;

                        if (_unitOfWork.Rep.Count(filter) < 1) continue;

                        Messages.DuplicateRecordErrorMessage(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }

                    return null;
                }

                string IncorrectData()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<RequiredField>())
                    {
                        if (property.Attribute == null) continue;

                        var value = property.Property.GetValue(currentEntity);

                        if (property.Property.PropertyType == typeof(long))
                            if ((long)value == 0) value = null;

                        if (!String.IsNullOrEmpty(value?.ToString())) continue;
                        Messages.WrongDataMessage(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }

                    return null;
                }

                return IncorrectData() ?? DuplicateCode();
            }
        }

        protected BaseBll()
        {
        }

        protected BaseBll(Control control)
        {
            _control = control;
        }

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter,
            Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (!Validation(ProcessType.EntityInsert, null, entity, filter)) return false;
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if(!Validation(ProcessType.EntityUpdate,oldEntity,currentEntity,filter)) return false;
            var changingFields = oldEntity.GetChangingFields(currentEntity);
            if (changingFields.Count == 0) return true;
            _unitOfWork.Rep.Update(currentEntity.EntityConvert<T>(), changingFields);
            return _unitOfWork.Save();
        }

        protected bool BaseDelete(BaseEntity entity, CardType cardType, bool getMessage = true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            if (getMessage)
            {
                if (Messages.DeletionMessage(cardType.ToName()) != DialogResult.Yes) return false;
            }

            _unitOfWork.Rep.Delete(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected string BaseGetNewCode(CardType cardType, Expression<Func<T, string>> filter,
            Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.GetNewCode(cardType, filter, where);
        }

        protected string BaseGetNewStudentNumber(CardType cardType, Expression<Func<T, string>> filter,
            Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.GetNewStudentNumber(filter, where);
        }

        #region Dispose

        public void Dispose()
        {
            _control?.Dispose();
            _unitOfWork?.Dispose();
        }

        #endregion
    }
}