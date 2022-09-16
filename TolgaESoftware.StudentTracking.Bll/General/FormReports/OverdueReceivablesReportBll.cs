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
    public class OverdueReceivablesReportBll: BaseActionBll<PaymentInformations, StudentTrackingContext>
    {
        public IEnumerable<OverdueReceivablesReportList> List(Expression<Func<PaymentInformations, bool>> filter, IEnumerable<DocumentStatus> documentStatuses)
        {
            return List(filter, p => new
            {
                Payment = p,
                p.Accrue,

                Sums = p.ReceiptActions.GroupBy(c => c.PaymentInformationsId).DefaultIfEmpty().Select(c => new
                {
                    Collected = c.Where(y => y.DocumentStatus == DocumentStatus.CollectedViaLawyer ||
                                                        y.DocumentStatus == DocumentStatus.CollectedViaBank ||
                                                        y.DocumentStatus == DocumentStatus.Unblocking ||
                                                        y.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                                                        y.DocumentStatus == DocumentStatus.PartlyCollect ||
                                                        y.DocumentStatus == DocumentStatus.Offsetting ||
                                                        y.DocumentStatus == DocumentStatus.MarkAsPaid ||
                                                        y.DocumentStatus == DocumentStatus.ChargedToVault ||
                                                        y.DocumentStatus == DocumentStatus.ChargedToBank)
                          .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum(),

                    Refund = c.Where(y => y.DocumentStatus == DocumentStatus.RefundToCustomer)
                          .Select(y => y.TransactionPrice).DefaultIfEmpty(0).Sum(),

                    OnCollect = c.Where(y => y.DocumentStatus == DocumentStatus.SendingToLawyer ||
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

                    DocumentStatus = c.Any() ? c.OrderByDescending(z => z.Id).FirstOrDefault().DocumentStatus : DocumentStatus.OnWallet,

                    DocumentBranchName = c.Any() ? c.OrderByDescending(z => z.Id).FirstOrDefault().OldBranch.BranchName : p.Accrue.Branch.BranchName,

                    LastActionDate = (DateTime?)c.OrderByDescending(z => z.Id).FirstOrDefault().Receipt.Date,

                    LastProcessPlace = c.OrderByDescending(z => z.Id)
                        .Select(z => z.Receipt.LawyerAccountId != null ? z.Receipt.LawyerAccount.NameLastname
                                   : z.Receipt.BankAccountId != null ? z.Receipt.BankAccount.BankAccountName
                                   : z.Receipt.CustomerAccountId != null ? z.Receipt.CustomerAccount.CustomerName
                                   : z.Receipt.VaultAccountId != null ? z.Receipt.VaultAccount.VaultName
                                   : z.Receipt.BranchAccountId != null ? z.Receipt.BranchAccount.BranchName : null
                                   ).FirstOrDefault()
                }).FirstOrDefault(),

                GuardianshipInformations = p.Accrue.ContactInformations.Where(c=>c.Guardianship).Select(c=> new
                {
                    c.Contact,
                    c.Kinship
                }).FirstOrDefault(),

            }).Select(p => new OverdueReceivablesReportList
            {
                BranchId = p.Payment.Accrue.BranchId,
                StudentBranchName = p.Payment.Accrue.Branch.BranchName,
                TermId = p.Payment.Accrue.TermId,
                StudentNumber = p.Payment.Accrue.Code,
                Name = p.Payment.Accrue.Student.Name,
                Lastname = p.Payment.Accrue.Student.Lastname,
                RegistrationDate = p.Payment.Accrue.RegistrationDate,
                EnrollmentType = p.Payment.Accrue.EnrollmentType,
                EnrollmentStatus = p.Payment.Accrue.EnrollmentStatus,
                CancelStatus = p.Payment.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                ClassName = p.Payment.Accrue.Class.ClassName,
                ClassGroupName = p.Payment.Accrue.Class.ClassGroup.GroupName,
                DocumentBranchName = p.Sums.DocumentBranchName,
                PaymentMethodName = p.Payment.PaymentMethod.PaymentMethodName,
                WalletNumber = p.Payment.Id,
                EntryDate = p.Payment.EntryDate,
                PaymentTerm = p.Payment.PaymentTerm,
                AccountTransferDate = p.Payment.AccountTransferDate,
                PrincipalDebtor = p.Payment.PrincipalDebtor,
                Endorser = p.Payment.Endorser,
                BankName = p.Payment.Bank.BankName,
                BankBranchName = p.Payment.BankBranch.BankBranchName,
                DocumentNumber = p.Payment.DocumentNumber,
                AccountNumber = p.Payment.AccountNumber,
                BlockedDay = p.Payment.BlockedDay,
                BankAccountName = p.Payment.BankAccount.BankAccountName,
                TrackNumber = p.Payment.TrackNumber,
                Price = p.Payment.Price,
                Refund = p.Sums.Refund,
                NetPrice = p.Payment.Price - p.Sums.Refund,
                Collected = p.Sums.Collected,
                OnCollect = p.Sums.OnCollect,
                Remaining = p.Payment.Price - (p.Sums.Collected + p.Sums.Refund),
                DocumentStatus = p.Sums.DocumentStatus,
                LastActionDate = p.Sums.LastActionDate,
                LastProcessPlace = p.Sums.LastProcessPlace,
                Statement = p.Payment.Statement,
                SpecialCode1 = p.Payment.Accrue.SpecialCode1.SpecialCodeName,
                SpecialCode2 = p.Payment.Accrue.SpecialCode2.SpecialCodeName,
                SpecialCode3 = p.Payment.Accrue.SpecialCode3.SpecialCodeName,
                SpecialCode4 = p.Payment.Accrue.SpecialCode4.SpecialCodeName,
                SpecialCode5 = p.Payment.Accrue.SpecialCode5.SpecialCodeName,
                GuardianshipName = p.GuardianshipInformations.Contact.Name,
                GuardianshipLastname = p.GuardianshipInformations.Contact.Lastname,
                Kinship = p.GuardianshipInformations.Kinship.KinshipName,
                Vocation = p.GuardianshipInformations.Contact.Vocation.VocationName,
                HomePhone = p.GuardianshipInformations.Contact.HomePhone,

                WorkplacePhoneInternal1 = p.GuardianshipInformations.Contact.WorkplacePhone1 == null && 
                                          p.GuardianshipInformations.Contact.InternalPhone1 == null ? null :
                    p.GuardianshipInformations.Contact.WorkplacePhone1 + " / " + p.GuardianshipInformations.Contact.InternalPhone1,

                WorkplacePhoneInternal2 = p.GuardianshipInformations.Contact.WorkplacePhone2 == null && 
                                          p.GuardianshipInformations.Contact.InternalPhone2 == null ? null :
                    p.GuardianshipInformations.Contact.WorkplacePhone2 + " / " + p.GuardianshipInformations.Contact.InternalPhone2,

                MobilePhone1 = p.GuardianshipInformations.Contact.MobilePhone1,
                MobilePhone2 = p.GuardianshipInformations.Contact.MobilePhone2,
                Workplace = p.GuardianshipInformations.Contact.Workplace.WorkplaceName,
                Job = p.GuardianshipInformations.Contact.Job.JobName
            }).Where(p => documentStatuses.Contains(p.DocumentStatus)).OrderBy(p => p.WalletNumber).ToList();
        }
    }
}