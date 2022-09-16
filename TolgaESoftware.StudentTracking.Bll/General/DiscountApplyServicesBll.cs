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
    public class DiscountApplyServicesBll:BaseActionBll<DiscountApplyServices,StudentTrackingContext>,IBaseActionSelectBll<DiscountApplyServices>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<DiscountApplyServices, bool>> filter)
        {
            return List(filter, p => new DiscountApplyServicesList
            {
                Id = p.Id,
                DiscountId = p.DiscountId,
                ServiceId = p.ServiceId,
                ServiceName = p.Service.ServiceName,
                DiscountPrice = p.DiscountPrice,
                DiscountPercentage = p.DiscountPercentage,
                BranchId = p.BranchId,
                TermId = p.TermId
            }).ToList();
        }
    }
}