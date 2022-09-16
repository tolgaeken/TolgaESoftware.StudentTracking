using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General.FormReports
{
    public class PriceAveragesReportBll : BaseBll<Accrue, StudentTrackingContext>
    {
        public IEnumerable<PriceAveragesReportList> List(Expression<Func<Accrue, bool>> filter)
        {
            return BaseList(filter, p => new
            {
                Accrue = p,
                p.Class,
                p.Class.ClassGroup,
                p.Branch,

                ServiceInformations = p.ServiceInformations.GroupBy(c => new { c.Accrue.BranchId, c.Accrue.ClassId }).DefaultIfEmpty().Select(c => new
                {
                    GrossService = c.Select(z => z.GrossPrice).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedService = c.Select(z => z.ShortTermDeductedPrice).DefaultIfEmpty(0).Sum(),
                    NetService = c.Select(z => z.NetPrice).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                DiscountInformations = p.DiscountInformations.GroupBy(c => new { c.Accrue.BranchId, c.Accrue.ClassId }).DefaultIfEmpty().Select(c => new
                {
                    GrossDiscount = c.Select(z => z.GrossDiscount).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedDiscount = c.Select(z => z.ShortTermDeductedDiscount).DefaultIfEmpty(0).Sum(),
                    NetDiscount = c.Select(z => z.NetDiscount).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault()

            }).AsEnumerable().GroupBy(p => new { p.Accrue.BranchId, p.Accrue.ClassId }).Select(p => new PriceAveragesReportList
            {
                ClassName = p.Select(c => c.Accrue.Class.ClassName).FirstOrDefault(),
                ClassGroupName = p.Select(c => c.Accrue.Class.ClassGroup.GroupName).FirstOrDefault(),
                BranchName = p.Select(c => c.Accrue.Branch.BranchName).FirstOrDefault(),
                BranchGroupName = p.Select(c => c.Accrue.Branch.GroupName).FirstOrDefault(),
                BranchRowNumber = p.Select(c => c.Accrue.Branch.RowNumber).FirstOrDefault(),
                PaidStudent = p.Where(c => c.Accrue.QuotaId == null && c.Accrue.Status).Select(c => c.Accrue.Id).Count(),
                UnpaidStudent = p.Where(c => c.Accrue.QuotaId != null && c.Accrue.Status).Select(c => c.Accrue.Id).Count(),
                GrossService = p.Select(c => c.ServiceInformations.GrossService).DefaultIfEmpty(0).Sum(),
                ShortTermDeductedService = p.Select(c => c.ServiceInformations.ShortTermDeductedService).DefaultIfEmpty(0).Sum(),
                NetService = p.Select(c => c.ServiceInformations.NetService).DefaultIfEmpty(0).Sum(),
                GrossDiscount = p.Select(c => c.DiscountInformations.GrossDiscount).DefaultIfEmpty(0).Sum(),
                ShortTermDeductedDiscount = p.Select(c => c.DiscountInformations.ShortTermDeductedDiscount).DefaultIfEmpty(0).Sum(),
                NetDiscount = p.Select(c => c.DiscountInformations.NetDiscount).DefaultIfEmpty(0).Sum(),
                NumberOfClass = 1
            }).Where(p => (p.PaidStudent + p.UnpaidStudent) > 0).OrderBy(p => p.ClassName).ToList();
        }
    }
}