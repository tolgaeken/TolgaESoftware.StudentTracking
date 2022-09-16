using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.Interfaces
{
    public interface IBaseGeneralBll
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity,BaseEntity currentEntity);
        string GetNewCode();
    }
}