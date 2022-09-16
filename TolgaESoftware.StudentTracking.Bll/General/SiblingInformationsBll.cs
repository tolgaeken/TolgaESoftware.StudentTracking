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
    public class SiblingInformationsBll : BaseActionBll<SiblingInformations, StudentTrackingContext>, IBaseActionSelectBll<SiblingInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<SiblingInformations, bool>> filter)
        {
            return List(filter, p => new SiblingInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                SiblingAccrueId = p.SiblingAccrueId,
                Name = p.SiblingAccrue.Student.Name,
                Lastname = p.SiblingAccrue.Student.Lastname,
                ClassName = p.SiblingAccrue.Class.ClassName,
                EnrollmentType = p.SiblingAccrue.EnrollmentType,
                EnrollmentStatus = p.SiblingAccrue.EnrollmentStatus,
                CancelStatus = p.SiblingAccrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                BranchId = p.SiblingAccrue.BranchId,
                BranchName = p.SiblingAccrue.Branch.BranchName,
                TermId = p.SiblingAccrue.TermId
            }).ToList();
        }
    }
}
