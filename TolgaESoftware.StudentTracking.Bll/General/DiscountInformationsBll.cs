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
    public class DiscountInformationsBll : BaseActionBll<DiscountInformations, StudentTrackingContext>, IBaseActionSelectBll<DiscountInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<DiscountInformations, bool>> filter)
        {
            return List(filter, p => new DiscountInformationsList
                {
                    Id = p.Id,
                    AccrueId = p.AccrueId,
                    DiscountId = p.DiscountId,
                    DiscountName = p.Cancelled ? p.Discount.DiscountName + " - ( ««« İptal Edildi »»» )" : p.Discount.DiscountName,
                    ServiceId = p.ServiceId,
                    ServiceName = p.Service.ServiceName,
                    TransactionDate = p.TransactionDate,
                    GrossDiscount = p.GrossDiscount,
                    ShortTermDeductedDiscount = p.ShortTermDeductedDiscount,
                    NetDiscount = p.NetDiscount,
                    PercentageDiscount = p.PercentageDiscount,
                    ManuallyEnteredPrice = p.ManuallyEnteredPrice,
                    ServiceActionId = p.ServiceActionId,
                    Cancelled = p.Cancelled,
                    CancellationDate = p.CancellationDate,
                    CancellationReasonId = p.CancellationReasonId,
                    CancellationReasonName = p.CancellationReason.CancellationReasonName,
                    CancellationStatement = p.CancellationStatement
                }).OrderByDescending(p=>p.Cancelled)
                .ThenBy(p=>p.CancellationDate)
                .ThenBy(p=>p.Id).ToList();
        }
    }
}
