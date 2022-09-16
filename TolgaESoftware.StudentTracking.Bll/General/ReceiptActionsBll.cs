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
    public class ReceiptActionsBll : BaseActionBll<ReceiptActions, StudentTrackingContext>, IBaseActionSelectBll<ReceiptActions>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<ReceiptActions, bool>> filter)
        {
            return List(filter, p => new ReceiptActionsList
            {
                Id = p.Id,
                ReceiptId = p.ReceiptId,
                StudentNumber = p.PaymentInformations.Accrue.Student.Code,
                Name = p.PaymentInformations.Accrue.Student.Name,
                Lastname = p.PaymentInformations.Accrue.Student.Lastname,
                ClassName = p.PaymentInformations.Accrue.Class.ClassName,
                StudentBranchName = p.PaymentInformations.Accrue.Branch.BranchName,
                PaymentInformationsId = p.PaymentInformationsId,
                PaymentMethodName = p.PaymentInformations.PaymentMethod.PaymentMethodName,
                PaymentType = p.PaymentInformations.PaymentType,
                TrackNumber = p.PaymentInformations.TrackNumber,
                EntryDate = p.PaymentInformations.EntryDate,
                PaymentTerm = p.PaymentInformations.PaymentTerm,
                AccountTransferDate = p.PaymentInformations.AccountTransferDate,
                Price = p.PaymentInformations.Price,
                PriceBeforeTransaction = p.PriceBeforeTransaction,
                TransactionPrice = p.TransactionPrice,
                UserId = p.UserId,
                OldBranchId = p.OldBranchId,
                NewBranchId = p.NewBranchId,
                BankAccountName = p.PaymentInformations.BankAccount.BankAccountName,
                BankName = p.PaymentInformations.Bank.BankName,
                BankBranchName = p.PaymentInformations.BankBranch.BankBranchName,
                DocumentNumber = p.PaymentInformations.DocumentNumber,
                AccountNumber = p.PaymentInformations.AccountNumber,
                PrincipalDebtor = p.PaymentInformations.PrincipalDebtor,
                Endorser = p.PaymentInformations.Endorser,

                LastActionId = p.PaymentInformations.ReceiptActions.Where(c => c.PaymentInformationsId == p.PaymentInformations.Id)
                    .Max(c => c.Id),

                LastActionDate = p.PaymentInformations.ReceiptActions.Where(c => c.PaymentInformationsId == p.PaymentInformations.Id)
                    .Max(c => c.Receipt.Date),

                DocumentStatus = p.DocumentStatus == 0 ? DocumentStatus.OnWallet : p.DocumentStatus,

                DocumentBranchName = p.PaymentInformations.ReceiptActions.Where(c => c.PaymentInformationsId == p.PaymentInformations.Id)
                    .Max(c => c.OldBranch.BranchName),

                LastProcessPlace = p.PaymentInformations.ReceiptActions.Where(c => c.PaymentInformationsId == p.PaymentInformations.Id)
                    .Max(c => c.Receipt.LawyerAccountId != null ? c.Receipt.LawyerAccount.NameLastname :
                              c.Receipt.BankAccountId != null ? c.Receipt.BankAccount.BankAccountName :
                              c.Receipt.CustomerAccountId != null ? c.Receipt.CustomerAccount.CustomerName :
                              c.Receipt.VaultAccountId != null ? c.Receipt.VaultAccount.VaultName :
                              c.Receipt.BranchAccountId != null ? c.Receipt.BranchAccount.BranchName :
                              null)
            }).ToList();
        }
    }
}