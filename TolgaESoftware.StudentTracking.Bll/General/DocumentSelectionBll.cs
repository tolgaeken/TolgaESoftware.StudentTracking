using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class DocumentSelectionBll : BaseActionBll<PaymentInformations, StudentTrackingContext>
    {
        public IEnumerable<BaseEntity> List(Expression<Func<PaymentInformations, bool>> filter,
            ReceiptType receiptType, ReceiptAccountType accountType, PaymentType paymentType, long? accountId, long branchId)
        {
            return List(filter, p => new
            {
                PaymentInformations = p,
                p.Accrue,
                Sums = p.ReceiptActions.GroupBy(c => c.PaymentInformationsId).DefaultIfEmpty().Select(c => new
                {
                    Collect = c.Where(z => z.DocumentStatus == DocumentStatus.CollectedViaLawyer ||
                                           z.DocumentStatus == DocumentStatus.CollectedViaBank ||
                                           z.DocumentStatus == DocumentStatus.Unblocking ||
                                           z.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                                           z.DocumentStatus == DocumentStatus.PartlyCollect ||
                                           z.DocumentStatus == DocumentStatus.Offsetting ||
                                           z.DocumentStatus == DocumentStatus.MarkAsPaid ||
                                           z.DocumentStatus == DocumentStatus.ChargedToBank ||
                                           z.DocumentStatus == DocumentStatus.ChargedToVault)
                        .Select(z => z.TransactionPrice).DefaultIfEmpty(0).Sum(),

                    Refund = c.Where(z => z.DocumentStatus == DocumentStatus.RefundToCustomer).Select(z => z.TransactionPrice).DefaultIfEmpty(0).Sum(),

                    DocumentStatus = c.Any() ? c.OrderByDescending(z => z.Id).FirstOrDefault().DocumentStatus : DocumentStatus.OnWallet,

                    LastActionId = (int?)c.Max(z => z.Id),

                    LastActionDate = (DateTime?)c.OrderByDescending(z => z.Id).FirstOrDefault().Receipt.Date,

                    LastAccountId = c.OrderByDescending(z => z.Id)
                        .Select(z => z.Receipt.LawyerAccountId ??
                                   z.Receipt.BankAccountId ??
                                   z.Receipt.CustomerAccountId ??
                                   z.Receipt.VaultAccountId ??
                                   z.Receipt.BranchAccountId).FirstOrDefault(),

                    AccountType = c.Any() ? c.OrderByDescending(z => z.Id).FirstOrDefault().Receipt.AccountType : 0,

                    DocumentBranchName = c.Any() ? c.OrderByDescending(z => z.Id).FirstOrDefault().OldBranch.BranchName : p.Accrue.Branch.BranchName,

                    BranchId = !c.Any() ? p.Accrue.BranchId :
                            c.OrderByDescending(z => z.Id).FirstOrDefault().DocumentStatus == DocumentStatus.WaitingConfirmation ?
                            c.OrderByDescending(z => z.Id).FirstOrDefault().NewBranchId :
                            c.OrderByDescending(z => z.Id).FirstOrDefault().OldBranchId,

                    LastProcessPlace = c.OrderByDescending(z => z.Id)
                        .Select(z => z.Receipt.LawyerAccountId != null ? z.Receipt.LawyerAccount.NameLastname :
                                z.Receipt.BankAccountId != null ? z.Receipt.BankAccount.BankAccountName :
                                z.Receipt.CustomerAccountId != null ? z.Receipt.CustomerAccount.CustomerName :
                                z.Receipt.VaultAccountId != null ? z.Receipt.VaultAccount.VaultName :
                                z.Receipt.BranchAccountId != null ? z.Receipt.BranchAccount.BranchName : null).FirstOrDefault()

                }).FirstOrDefault()

            }).Where(c => c.Sums.BranchId == branchId).Where(c =>
                        receiptType == ReceiptType.SendingToLawyer ?
                            (c.Sums.DocumentStatus == DocumentStatus.MarkAsUnpaid ||
                             c.Sums.DocumentStatus == DocumentStatus.FreeRefundToWallet) &&
                            (c.PaymentInformations.PaymentType == PaymentType.Open ||
                             c.PaymentInformations.PaymentType == PaymentType.Cheque ||
                             c.PaymentInformations.PaymentType == PaymentType.Cash ||
                             c.PaymentInformations.PaymentType == PaymentType.Indenture) :

                        receiptType == ReceiptType.CollectedViaLawyer ?
                            (c.Sums.DocumentStatus == DocumentStatus.SendingToLawyer ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer) &&
                             c.Sums.LastAccountId == accountId :

                        receiptType == ReceiptType.SendingToBank ||
                        receiptType == ReceiptType.Profiting ?
                            (c.Sums.DocumentStatus == DocumentStatus.OnWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.RefundToWallet) &&
                            (c.PaymentInformations.PaymentType == PaymentType.Cheque ||
                             c.PaymentInformations.PaymentType == PaymentType.Indenture) :

                        receiptType == ReceiptType.SendingToAnotherBranch ?
                            (c.Sums.DocumentStatus == DocumentStatus.OnWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.RefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.FreeRefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.MarkAsUnpaid ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollect) &&
                            (c.PaymentInformations.PaymentType == PaymentType.Open ||
                             c.PaymentInformations.PaymentType == PaymentType.Cash ||
                             c.PaymentInformations.PaymentType == PaymentType.Cheque ||
                             c.PaymentInformations.PaymentType == PaymentType.Indenture) :

                        receiptType == ReceiptType.Blocking ?
                             c.Sums.DocumentStatus == DocumentStatus.OnWallet &&
                             c.PaymentInformations.PaymentType == paymentType :

                        receiptType == ReceiptType.Unblocking ?
                             c.Sums.DocumentStatus == DocumentStatus.Blocking &&
                             c.PaymentInformations.PaymentType == paymentType &&
                             c.Sums.LastAccountId == accountId :
                             //c.Sums.LastActionId == accountId :

                        receiptType == ReceiptType.ApproveIncomingDocument ?
                             c.Sums.DocumentStatus == DocumentStatus.WaitingConfirmation &&
                             c.Sums.LastAccountId == accountId :

                        receiptType == ReceiptType.MarkAsUnpaid ?
                            (c.Sums.DocumentStatus == DocumentStatus.OnWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollect ||
                             c.Sums.DocumentStatus == DocumentStatus.RefundToWallet) &&
                            (c.PaymentInformations.PaymentType == PaymentType.Open ||
                             c.PaymentInformations.PaymentType == PaymentType.Cheque ||
                             c.PaymentInformations.PaymentType == PaymentType.Cash ||
                             c.PaymentInformations.PaymentType == PaymentType.Indenture) :

                       receiptType == ReceiptType.Offsetting ?
                            (c.Sums.DocumentStatus == DocumentStatus.OnWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollect ||
                             c.Sums.DocumentStatus == DocumentStatus.RefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.FreeRefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.MarkAsUnpaid) &&
                            (c.PaymentInformations.PaymentType == PaymentType.Open ||
                             c.PaymentInformations.PaymentType == PaymentType.Cheque ||
                             c.PaymentInformations.PaymentType == PaymentType.Cash ||
                             c.PaymentInformations.PaymentType == PaymentType.Indenture) :

                       receiptType == ReceiptType.RefundToCustomer ?
                             c.Sums.DocumentStatus == DocumentStatus.OnWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollect ||
                             c.Sums.DocumentStatus == DocumentStatus.RefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.FreeRefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.MarkAsUnpaid :

                       receiptType == ReceiptType.MarkAsPaid ?
                             c.Sums.DocumentStatus == DocumentStatus.Profiting :

                       receiptType == ReceiptType.RefundToWallet ?
                            (c.Sums.DocumentStatus == DocumentStatus.Profiting ||
                             c.Sums.DocumentStatus == DocumentStatus.SendingToBank) &&
                             c.Sums.AccountType == accountType &&
                             c.Sums.LastAccountId == accountId :

                       receiptType == ReceiptType.FreeRefundToWallet ?
                            (c.Sums.DocumentStatus == DocumentStatus.Profiting ||
                             c.Sums.DocumentStatus == DocumentStatus.SendingToLawyer ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                             c.Sums.DocumentStatus == DocumentStatus.SendingToBank) &&
                             c.Sums.AccountType == accountType &&
                             c.Sums.LastAccountId == accountId :
                             //c.Sums.LastActionId == accountId :

                       //receiptType == ReceiptType.FreeRefundToWallet ?
                       //    (c.Sums.DocumentStatus == DocumentStatus.Profiting ||
                       //     c.Sums.DocumentStatus == DocumentStatus.SendingToLawyer ||
                       //     c.Sums.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                       //     c.Sums.DocumentStatus == DocumentStatus.SendingToBank) &&
                       //     c.Sums.AccountType == accountType :

                       receiptType == ReceiptType.RefundToCustomer ?
                            (c.Sums.DocumentStatus == DocumentStatus.Profiting ||
                             c.Sums.DocumentStatus == DocumentStatus.SendingToLawyer ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                             c.Sums.DocumentStatus == DocumentStatus.Unblocking || // Modified Later
                             c.Sums.DocumentStatus == DocumentStatus.SendingToBank) &&
                             c.Sums.AccountType == accountType &&
                             c.Sums.LastAccountId == accountId :

                       receiptType == ReceiptType.ChargedToVault ||
                       receiptType == ReceiptType.ChargedToBank ?
                            (c.Sums.DocumentStatus == DocumentStatus.MarkAsUnpaid ||
                             c.Sums.DocumentStatus == DocumentStatus.PartlyCollect ||
                             c.Sums.DocumentStatus == DocumentStatus.OnWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.RefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.FreeRefundToWallet) &&
                            (c.PaymentInformations.PaymentType == PaymentType.Open ||
                             c.PaymentInformations.PaymentType == PaymentType.Cash ||
                             c.PaymentInformations.PaymentType == PaymentType.Indenture) :

                       receiptType == ReceiptType.ImpossibleCollect ?
                             c.Sums.DocumentStatus == DocumentStatus.MarkAsUnpaid ||
                             c.Sums.DocumentStatus == DocumentStatus.RefundToWallet ||
                             c.Sums.DocumentStatus == DocumentStatus.FreeRefundToWallet :

                       receiptType == ReceiptType.CollectedViaBank ?
                             c.Sums.DocumentStatus == DocumentStatus.SendingToBank &&
                             c.Sums.LastAccountId == accountId : c.Sums.DocumentStatus == 0

            ).Select(p => new DocumentSelectionList
            {
                PaymentInformationsId = p.PaymentInformations.Id,
                Name = p.Accrue.Student.Name,
                Lastname = p.Accrue.Student.Lastname,
                StudentNumber = p.Accrue.Student.Code,
                ClassName = p.Accrue.Class.ClassName,
                StudentBranchName = p.Accrue.Branch.BranchName,
                DocumentBranchName = p.Sums.DocumentBranchName,
                PaymentMethodName = p.PaymentInformations.PaymentMethod.PaymentMethodName,
                PaymentType = p.PaymentInformations.PaymentType,
                BankAccountName = p.PaymentInformations.BankAccount.BankAccountName,
                TrackNumber = p.PaymentInformations.TrackNumber,
                EntryDate = p.PaymentInformations.EntryDate,
                PaymentTerm = p.PaymentInformations.PaymentTerm,
                AccountTransferDate = p.PaymentInformations.AccountTransferDate,
                Price = p.PaymentInformations.Price,
                Collect = p.Sums.Collect,
                Refund = p.Sums.Refund,
                Remaining = p.PaymentInformations.Price - (p.Sums.Collect + p.Sums.Refund),
                BankName = p.PaymentInformations.Bank.BankName,
                BankBranchName = p.PaymentInformations.BankBranch.BankBranchName,
                AccountNumber = p.PaymentInformations.AccountNumber,
                DocumentNumber = p.PaymentInformations.DocumentNumber,
                PrincipalDebtor = p.PaymentInformations.PrincipalDebtor,
                Endorser = p.PaymentInformations.Endorser,
                Statement = p.PaymentInformations.Statement,
                LastActionId = p.Sums.LastActionId,
                LastActionDate = p.Sums.LastActionDate,
                LastProcessPlace = p.Sums.LastProcessPlace,
                DocumentStatus = p.Sums.DocumentStatus,
                AccountType = p.Sums.AccountType,
                BranchId = p.Sums.BranchId
            }).OrderBy(p => p.PaymentTerm).ToList();
        }
    }
}