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
    public class IncomeDistributionReportBll : BaseActionBll<PaymentInformations, StudentTrackingContext>
    {
        public IEnumerable<IncomeDistributionReportList> List(Expression<Func<PaymentInformations, bool>> filter, GroupingType calculationType)
        {
            return List(filter, p => new
            {
                Payment = p,


                Collected = p.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.CollectedViaLawyer ||
                                                        y.DocumentStatus == DocumentStatus.CollectedViaBank ||
                                                        y.DocumentStatus == DocumentStatus.Unblocking ||
                                                        y.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                                                        y.DocumentStatus == DocumentStatus.PartlyCollect ||
                                                        y.DocumentStatus == DocumentStatus.Offsetting ||
                                                        y.DocumentStatus == DocumentStatus.MarkAsPaid ||
                                                        y.DocumentStatus == DocumentStatus.ChargedToVault ||
                                                        y.DocumentStatus == DocumentStatus.ChargedToBank)
                        .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum(),

                Refund = p.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.RefundToCustomer)
                        .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum(),

                OnCollect = p.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.SendingToLawyer ||
                                                        y.DocumentStatus == DocumentStatus.SendingToBank ||
                                                        y.DocumentStatus == DocumentStatus.Profiting ||
                                                        y.DocumentStatus == DocumentStatus.Blocking)
                        .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum() -
                            p.ReceiptActions.Where(y => y.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                                                        y.DocumentStatus == DocumentStatus.CollectedViaLawyer ||
                                                        y.DocumentStatus == DocumentStatus.CollectedViaBank ||
                                                        y.DocumentStatus == DocumentStatus.Unblocking ||
                                                        y.DocumentStatus == DocumentStatus.MarkAsPaid ||
                                                        y.DocumentStatus == DocumentStatus.RefundToWallet ||
                                                        y.DocumentStatus == DocumentStatus.FreeRefundToWallet)
                                .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum(),



            }).GroupBy(p => calculationType == GroupingType.ByEntryDate
                                ? new { p.Payment.EntryDate.Year, p.Payment.EntryDate.Month }
                            : calculationType == GroupingType.ByAccountTransferDate
                                ? new { p.Payment.AccountTransferDate.Year, p.Payment.AccountTransferDate.Month }
                            : new { p.Payment.PaymentTerm.Year, p.Payment.PaymentTerm.Month })
                .Select(p => new IncomeDistributionReportList
                {
                    Year = p.Select(c => calculationType == GroupingType.ByEntryDate
                                            ? c.Payment.EntryDate.Year
                                       : calculationType == GroupingType.ByAccountTransferDate
                                            ? c.Payment.AccountTransferDate.Year
                                       : c.Payment.PaymentTerm.Year).FirstOrDefault(),
                    Month = (Months) p.Select(c => calculationType == GroupingType.ByEntryDate
                                                        ? c.Payment.EntryDate.Month
                                                 : calculationType == GroupingType.ByAccountTransferDate
                                                        ? c.Payment.AccountTransferDate.Month
                                                 : c.Payment.PaymentTerm.Month).FirstOrDefault(),
                    NumberOfInstallment = p.Count(),
                    //Month = p.Select(c=>c.Accrue.RegistrationDate).First().ToString("MMMM"),
                    Open = p.Where(c => c.Payment.PaymentType == PaymentType.Open).Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    Cheque = p.Where(c => c.Payment.PaymentType == PaymentType.Cheque).Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    Cash = p.Where(c => c.Payment.PaymentType == PaymentType.Cash).Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    Epos =p.Where(c => c.Payment.PaymentType == PaymentType.Epos).Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    Sps = p.Where(c => c.Payment.PaymentType == PaymentType.Sps).Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    Pos = p.Where(c => c.Payment.PaymentType == PaymentType.Pos).Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    Indenture = p.Where(c => c.Payment.PaymentType == PaymentType.Indenture).Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    SumOfPay = p.Select(c=>c.Payment.Price).DefaultIfEmpty(0).Sum(),
                    Collected = p.Select(c => c.Collected).DefaultIfEmpty(0).Sum(),
                    Refund = p.Select(c => c.Refund).DefaultIfEmpty(0).Sum(),
                    OnCollect = p.Select(c => c.OnCollect).DefaultIfEmpty(0).Sum()
                }).ToList();
        }
    }
}