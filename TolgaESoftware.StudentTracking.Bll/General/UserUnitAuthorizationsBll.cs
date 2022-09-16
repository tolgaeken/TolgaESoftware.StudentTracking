using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class UserUnitAuthorizationsBll : BaseActionBll<UserUnitAuthorizations, StudentTrackingContext>, IBaseActionSelectBll<UserUnitAuthorizations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<UserUnitAuthorizations, bool>> filter)
        {
            return List(filter, p => new UserUnitAuthorizationsList
            {
                Id = p.Id,
                Code = p.CardType == CardType.Branch ? p.Branch.Code : p.Term.Code,
                CardType = p.CardType,
                BranchId = p.BranchId,
                BranchName = p.Branch.BranchName,
                TermId = p.TermId,
                TermName = p.Term.TermName
            }).ToList();
        }
    }
}