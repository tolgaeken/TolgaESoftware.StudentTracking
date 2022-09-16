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
    public class MonthlyEnrollmentReportBll : BaseBll<Accrue, StudentTrackingContext>
    {
        public IEnumerable<MonthlyEnrollmentReportList> List(Expression<Func<Accrue, bool>> filter)
        {
            return BaseList(filter, p => new
            {
                Accrue = p,

                ServiceInformations = p.ServiceInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    GrossService = c.Select(z => z.GrossPrice).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedService = c.Select(z => z.ShortTermDeductedPrice).DefaultIfEmpty(0).Sum(),
                    NetService = c.Select(z => z.NetPrice).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                DiscountInformations = p.DiscountInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    GrossDiscount = c.Select(z => z.GrossDiscount).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedDiscount = c.Select(z => z.ShortTermDeductedDiscount).DefaultIfEmpty(0).Sum(),
                    NetDiscount = c.Select(z => z.NetDiscount).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                PaymentInformations = p.PaymentInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    Open = c.Where(z => z.PaymentType == PaymentType.Open).Select(z => z.Price).DefaultIfEmpty(0).Sum(),
                    Cheque = c.Where(z => z.PaymentType == PaymentType.Cheque).Select(z => z.Price).DefaultIfEmpty(0).Sum(),
                    Cash = c.Where(z => z.PaymentType == PaymentType.Cash).Select(z => z.Price).DefaultIfEmpty(0).Sum(),
                    Epos = c.Where(z => z.PaymentType == PaymentType.Epos).Select(z => z.Price).DefaultIfEmpty(0).Sum(),
                    Sps = c.Where(z => z.PaymentType == PaymentType.Sps).Select(z => z.Price).DefaultIfEmpty(0).Sum(),
                    Pos = c.Where(z => z.PaymentType == PaymentType.Pos).Select(z => z.Price).DefaultIfEmpty(0).Sum(),
                    Indenture = c.Where(z => z.PaymentType == PaymentType.Indenture).Select(z => z.Price).DefaultIfEmpty(0).Sum(),
                    SumOfPay = c.Select(z => z.Price).DefaultIfEmpty(0).Sum(),

                    Collected = c.Select(z => z.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.CollectedViaLawyer ||
                                                                        y.DocumentStatus == DocumentStatus.CollectedViaBank ||
                                                                        y.DocumentStatus == DocumentStatus.Unblocking ||
                                                                        y.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                                                                        y.DocumentStatus == DocumentStatus.PartlyCollect ||
                                                                        y.DocumentStatus == DocumentStatus.Offsetting ||
                                                                        y.DocumentStatus == DocumentStatus.MarkAsPaid ||
                                                                        y.DocumentStatus == DocumentStatus.ChargedToVault ||
                                                                        y.DocumentStatus == DocumentStatus.ChargedToBank)
                        .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum(),

                    Refund = c.Select(z => z.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.RefundToCustomer)
                        .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum(),

                    OnCollect = c.Select(z => z.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.SendingToLawyer ||
                                                                        y.DocumentStatus == DocumentStatus.SendingToBank ||
                                                                        y.DocumentStatus == DocumentStatus.Profiting ||
                                                                        y.DocumentStatus == DocumentStatus.Blocking)
                        .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum() -
                                c.Select(z => z.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                                                                         y.DocumentStatus == DocumentStatus.CollectedViaLawyer ||
                                                                         y.DocumentStatus == DocumentStatus.CollectedViaBank ||
                                                                         y.DocumentStatus == DocumentStatus.Unblocking ||
                                                                         y.DocumentStatus == DocumentStatus.MarkAsPaid ||
                                                                         y.DocumentStatus == DocumentStatus.RefundToWallet ||
                                                                         y.DocumentStatus == DocumentStatus.FreeRefundToWallet)
                                    .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum()).DefaultIfEmpty(0).Sum()

                }).FirstOrDefault(),

                RefundInformations = p.RefundInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    PaymentBack = c.Select(y => y.Price).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

            }).AsEnumerable().GroupBy(p => new { p.Accrue.RegistrationDate.Year , p.Accrue.RegistrationDate.Month }).Select(p => new MonthlyEnrollmentReportList
            {
                Year = p.Key.Year,
                Month = ((Months)p.Key.Month).ToName(),
                //Month = p.Select(c=>c.Accrue.RegistrationDate).First().ToString("MMMM"),
                RenewedEnrollment = p.Count(c => c.Accrue.EnrollmentType == EnrollmentType.RenewedEnrollment),
                NewEnrollment = p.Count(c => c.Accrue.EnrollmentType == EnrollmentType.NewEnrollment),
                TransferEnrollment = p.Count(c => c.Accrue.EnrollmentType == EnrollmentType.TransferEnrollment),
                SumOfEnrollment = p.Count(),
                GrossService = p.Select(c => c.ServiceInformations.GrossService).DefaultIfEmpty(0).Sum(),
                ShortTermDeductedService = p.Select(c => c.ServiceInformations.ShortTermDeductedService).DefaultIfEmpty(0).Sum(),
                NetService = p.Select(c => c.ServiceInformations.NetService).DefaultIfEmpty(0).Sum(),
                GrossDiscount = p.Select(c => c.DiscountInformations.GrossDiscount).DefaultIfEmpty(0).Sum(),
                ShortTermDeductedDiscount = p.Select(c => c.DiscountInformations.ShortTermDeductedDiscount).DefaultIfEmpty(0).Sum(),
                NetDiscount = p.Select(c => c.DiscountInformations.NetDiscount).DefaultIfEmpty(0).Sum(),
                Open = p.Select(c => c.PaymentInformations.Open).DefaultIfEmpty(0).Sum(),
                Cheque = p.Select(c => c.PaymentInformations.Cheque).DefaultIfEmpty(0).Sum(),
                Cash = p.Select(c => c.PaymentInformations.Cash).DefaultIfEmpty(0).Sum(),
                Epos = p.Select(c => c.PaymentInformations.Epos).DefaultIfEmpty(0).Sum(),
                Sps = p.Select(c => c.PaymentInformations.Sps).DefaultIfEmpty(0).Sum(),
                Pos = p.Select(c => c.PaymentInformations.Pos).DefaultIfEmpty(0).Sum(),
                Indenture = p.Select(c => c.PaymentInformations.Indenture).DefaultIfEmpty(0).Sum(),
                SumOfPay = p.Select(c => c.PaymentInformations.SumOfPay).DefaultIfEmpty(0).Sum(),
                Collected = p.Select(c => c.PaymentInformations.Collected).DefaultIfEmpty(0).Sum(),
                Refund = p.Select(c => c.PaymentInformations.Refund).DefaultIfEmpty(0).Sum(),
                OnCollect = p.Select(c => c.PaymentInformations.OnCollect).DefaultIfEmpty(0).Sum(),
                PaymentBack = p.Select(c => c.RefundInformations.PaymentBack).DefaultIfEmpty(0).Sum(),
            }).ToList();
        }
    }
}