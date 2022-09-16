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
    public class PromotionInformationsBll : BaseActionBll<PromotionInformations, StudentTrackingContext>, IBaseActionSelectBll<PromotionInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<PromotionInformations, bool>> filter)
        {
            return List(filter, p => new PromotionInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                PromotionId = p.PromotionId,
                Code = p.Promotion.Code,
                PromotionName = p.Promotion.PromotionName
            }).ToList();
        }
    }
}