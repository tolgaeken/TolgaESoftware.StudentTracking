using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.Interfaces
{
    public interface IBaseActionSelectBll<T>
    {
        IEnumerable<BaseActionEntity> List(Expression<Func<T, bool>> filter);
    }
}