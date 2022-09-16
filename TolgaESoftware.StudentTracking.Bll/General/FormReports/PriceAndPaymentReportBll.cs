using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General.FormReports
{
    public class PriceAndPaymentReportBll : BaseBll<Accrue, StudentTrackingContext>
    {
        public IEnumerable<PriceAndPaymentReportList> List(Expression<Func<Accrue, bool>> filter)
        {
            return BaseList(filter, p => new
            {
                Accrue = p,

                GuardianshipInformations = p.ContactInformations.Where(c => c.Guardianship).Select(c => new
                {
                    c.Contact,
                    c.Kinship
                }).FirstOrDefault(),

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

            }).Select(p => new PriceAndPaymentReportList()
            {
                StudentId = p.Accrue.StudentId,
                AccrueId = p.Accrue.Id,
                StudentNumber = p.Accrue.Code,
                SchoolNumber = p.Accrue.SchoolNumber,
                TrIdentityNumber = p.Accrue.Student.TrIdentityNumber,
                Name = p.Accrue.Student.Name,
                Lastname = p.Accrue.Student.Lastname,
                Gender = p.Accrue.Student.Gender,
                Phone = p.Accrue.Student.Phone,
                RegistrationDate = p.Accrue.RegistrationDate,
                CancelStatus = p.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                EnrollmentType = p.Accrue.EnrollmentType,
                EnrollmentStatus = p.Accrue.EnrollmentStatus,
                ClassName = p.Accrue.Class.ClassName,
                ComesFromSchool = p.Accrue.ComesFromSchool.SchoolName,
                QuotaType = p.Accrue.Quota.QuotaName,
                ForeignLanguageName = p.Accrue.ForeignLanguage.ForeignLanguageName,
                GuideName = p.Accrue.Guide.GuideNameLastname,
                IncentName = p.Accrue.Incent.IncentName,
                BranchId = p.Accrue.BranchId,
                BranchName = p.Accrue.Branch.BranchName,
                TermId = p.Accrue.TermId,
                SpecialCode1 = p.Accrue.SpecialCode1.SpecialCodeName,
                SpecialCode2 = p.Accrue.SpecialCode2.SpecialCodeName,
                SpecialCode3 = p.Accrue.SpecialCode3.SpecialCodeName,
                SpecialCode4 = p.Accrue.SpecialCode4.SpecialCodeName,
                SpecialCode5 = p.Accrue.SpecialCode5.SpecialCodeName,
                GuardianshipName = p.GuardianshipInformations.Contact.Name,
                GuardianshipLastname = p.GuardianshipInformations.Contact.Lastname,
                GuardianshipKinshipName = p.GuardianshipInformations.Kinship.KinshipName,
                GuardianshipVocationName = p.GuardianshipInformations.Contact.Vocation.VocationName,
                GuardianshipWorkplaceName = p.GuardianshipInformations.Contact.Workplace.WorkplaceName,
                GuardianshipJobName = p.GuardianshipInformations.Contact.Job.JobName,
                GrossService = p.ServiceInformations.GrossService,
                ShortTermDeductedService = p.ServiceInformations.ShortTermDeductedService,
                NetService = p.ServiceInformations.NetService,
                GrossDiscount = p.DiscountInformations.GrossDiscount,
                ShortTermDeductedDiscount = p.DiscountInformations.ShortTermDeductedDiscount,
                NetDiscount = p.DiscountInformations.NetDiscount,
                NetPrice = p.ServiceInformations.NetService - p.DiscountInformations.NetDiscount,
                DiscountPercentage = p.ServiceInformations.NetService == 0 ? 0 : p.DiscountInformations.NetDiscount / p.ServiceInformations.NetService * 100,
                Open = p.PaymentInformations.Open,
                Cheque = p.PaymentInformations.Cheque,
                Cash = p.PaymentInformations.Cash,
                Epos = p.PaymentInformations.Epos,
                Sps = p.PaymentInformations.Sps,
                Pos = p.PaymentInformations.Pos,
                Indenture = p.PaymentInformations.Indenture,
                SumOfPay = p.PaymentInformations.SumOfPay,
                Collected = p.PaymentInformations.Collected,
                Refund = p.PaymentInformations.Refund,
                OnCollect = p.PaymentInformations.OnCollect,
                PaymentBack = p.RefundInformations.PaymentBack,
                Remaining = p.PaymentInformations.SumOfPay - (p.PaymentInformations.Refund + p.PaymentInformations.Collected),
                NetPayment = p.PaymentInformations.SumOfPay - (p.PaymentInformations.Refund + p.RefundInformations.PaymentBack),
            }).OrderBy(p => p.StudentNumber).ToList();
        }
    }
}