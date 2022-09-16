using System.Collections.Generic;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.Interfaces
{
    public interface IBaseActionGeneralBll
    {
        bool Insert(IList<BaseActionEntity> entities);
        bool Update(IList<BaseActionEntity> entities);
        bool Delete(IList<BaseActionEntity> entities);
    }
}