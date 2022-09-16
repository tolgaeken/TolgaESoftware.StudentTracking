using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class RoleAuthorizationsBll : BaseActionBll<RoleAuthorizations, StudentTrackingContext>, IBaseActionSelectBll<RoleAuthorizations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<RoleAuthorizations, bool>> filter)
        {
            return List(filter, p => new RoleAuthorizationsList
            {
                Id = p.Id,
                RoleId = p.RoleId,
                CardType = p.CardType,
                CanRead = p.CanRead,
                CanAdd = p.CanAdd,
                CanChange = p.CanChange,
                CanDelete = p.CanDelete
            }).AsEnumerable().OrderBy(p=>p.CardType.ToName()).ToList();
        }
    }
}