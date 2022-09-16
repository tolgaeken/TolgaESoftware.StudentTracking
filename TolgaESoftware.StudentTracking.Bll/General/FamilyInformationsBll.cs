using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class FamilyInformationsBll : BaseActionBll<FamilyInformations, StudentTrackingContext>, IBaseActionSelectBll<FamilyInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<FamilyInformations, bool>> filter)
        {
            return List(filter, p => new FamilyInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                InformationName = p.FamilyInfo.FamilyInfoName,
                Statement = p.Statement,
            }).ToList();
        }
    }
}