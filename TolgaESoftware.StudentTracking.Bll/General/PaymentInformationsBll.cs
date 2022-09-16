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
    public class PaymentInformationsBll : BaseActionBll<PaymentInformations, StudentTrackingContext>, IBaseActionSelectBll<PaymentInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<PaymentInformations, bool>> filter)
        {
            return List(filter, p => new
            {
                PaymentDocument = p,
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

                    OnCollect = c.Where(z => z.DocumentStatus == DocumentStatus.SendingToLawyer ||
                                           z.DocumentStatus == DocumentStatus.SendingToBank ||
                                           z.DocumentStatus == DocumentStatus.Profiting ||
                                           z.DocumentStatus == DocumentStatus.Blocking)
                                    .Select(z => z.TransactionPrice).DefaultIfEmpty(0).Sum() -

                                c.Where(z => z.DocumentStatus == DocumentStatus.CollectedViaLawyer ||
                                             z.DocumentStatus == DocumentStatus.CollectedViaBank ||
                                             z.DocumentStatus == DocumentStatus.Unblocking ||
                                             z.DocumentStatus == DocumentStatus.PartlyCollectedViaLawyer ||
                                             z.DocumentStatus == DocumentStatus.MarkAsPaid ||
                                             z.DocumentStatus == DocumentStatus.RefundToWallet ||
                                             z.DocumentStatus == DocumentStatus.FreeRefundToWallet)
                                    .Select(z => z.TransactionPrice).DefaultIfEmpty(0).Sum(),

                    DocumentStatus = c.Any() ? c.OrderByDescending(z => z.Id).FirstOrDefault().DocumentStatus : DocumentStatus.OnWallet,

                    LastActionId = (int?)c.Max(z => z.Id),

                    LastActionDate = (DateTime?)c.OrderByDescending(z => z.Id).FirstOrDefault().Receipt.Date,

                    LastProcessPlace = c.OrderByDescending(z => z.Id)
                        .Select(z => z.Receipt.LawyerAccountId != null ? z.Receipt.LawyerAccount.NameLastname :
                                z.Receipt.BankAccountId != null ? z.Receipt.BankAccount.BankAccountName :
                                z.Receipt.CustomerAccountId != null ? z.Receipt.CustomerAccount.CustomerName :
                                z.Receipt.VaultAccountId != null ? z.Receipt.VaultAccount.VaultName :
                                z.Receipt.BranchAccountId != null ? z.Receipt.BranchAccount.BranchName : null).FirstOrDefault()

                }).FirstOrDefault()
            }).Select(p => new PaymentInformationsList
            {
                Id = p.PaymentDocument.Id,
                AccrueId = p.PaymentDocument.AccrueId,
                PaymentMethodId = p.PaymentDocument.PaymentMethodId,
                PaymentMethodName = p.PaymentDocument.PaymentMethod.PaymentMethodName,
                PaymentType = p.PaymentDocument.PaymentType,
                BankAccountId = p.PaymentDocument.BankAccountId,
                BankAccountName = p.PaymentDocument.BankAccount.BankAccountName,
                BlockedDay = p.PaymentDocument.BlockedDay,
                EntryDate = p.PaymentDocument.EntryDate,
                PaymentTerm = p.PaymentDocument.PaymentTerm,
                AccountTransferDate = p.PaymentDocument.AccountTransferDate,
                Price = p.PaymentDocument.Price,
                TrackNumber = p.PaymentDocument.TrackNumber,
                BankId = p.PaymentDocument.BankId,
                BankName = p.PaymentDocument.Bank.BankName,
                BankBranchId = p.PaymentDocument.BankBranchId,
                BankBranchName = p.PaymentDocument.BankBranch.BankBranchName,
                DocumentNumber = p.PaymentDocument.DocumentNumber,
                AccountNumber = p.PaymentDocument.AccountNumber,
                PrincipalDebtor = p.PaymentDocument.PrincipalDebtor,
                Endorser = p.PaymentDocument.Endorser,
                PriceAsText = p.PaymentDocument.PriceAsText,
                PaymentTermAsTxt = p.PaymentDocument.PaymentTermAsTxt,
                Statement = p.PaymentDocument.Statement,
                BranchName = p.PaymentDocument.Accrue.Branch.BranchName,
                BranchProvinceName = p.PaymentDocument.Accrue.Branch.AddressProvince.ProvinceName,
                Collect = p.Sums.Collect,
                OnCollect = p.Sums.OnCollect,
                Refund = p.Sums.Refund,
                Remaining = p.PaymentDocument.Price - (p.Sums.Collect + p.Sums.Refund),
                DocumentStatus = p.Sums.DocumentStatus,
                LastActionId = p.Sums.LastActionId,
                LastActionDate = p.Sums.LastActionDate,
                LastProcessPlace = p.Sums.LastProcessPlace
            }).ToList();
        }
    }
}
