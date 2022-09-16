using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class ReceiptBll : BaseGeneralBll<Receipt>, IBaseCommonBll
    {
        public ReceiptBll() : base(CardType.Receipt) { }
        public ReceiptBll(Control control) : base(control, CardType.Receipt) { }

        public override BaseEntity Single(Expression<Func<Receipt, bool>> filter)
        {
            return BaseSingle(filter, p => new ReceiptSingle
            {
                Id = p.Id,
                Code = p.Code,
                Date = p.Date,
                ReceiptType = p.ReceiptType,
                AccountType = p.AccountType,
                LawyerAccountId = p.LawyerAccountId,
                BankAccountId = p.BankAccountId,
                CustomerAccountId = p.CustomerAccountId,
                VaultAccountId = p.VaultAccountId,
                BranchAccountId = p.BranchAccountId,
                AccountName = p.AccountType == ReceiptAccountType.Lawyer ? p.LawyerAccount.NameLastname :

                              p.AccountType == ReceiptAccountType.Bank || p.AccountType == ReceiptAccountType.Epos ||
                              p.AccountType == ReceiptAccountType.Sps || p.AccountType == ReceiptAccountType.Pos ? p.BankAccount.BankAccountName :

                              p.AccountType == ReceiptAccountType.Customer || p.AccountType == ReceiptAccountType.Offset ? p.CustomerAccount.CustomerName :
                              p.AccountType == ReceiptAccountType.Vault ? p.VaultAccount.VaultName :
                              p.AccountType == ReceiptAccountType.Transfer ? p.BranchAccount.BranchName : null,
                NumberOfAction = p.NumberOfAction,
                SumOfReceipt = p.SumOfReceipt,
                TermId = p.TermId,
                BranchId = p.BranchId
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Receipt, bool>> filter)
        {
            return BaseList(filter, p => new ReceiptList
            {
                Id = p.Id,
                Code = p.Code,
                Date = p.Date,
                ReceiptType = p.ReceiptType,
                AccountType = p.AccountType,
                AccountName = p.AccountType == ReceiptAccountType.Lawyer ? p.LawyerAccount.NameLastname :

                              p.AccountType == ReceiptAccountType.Bank || p.AccountType == ReceiptAccountType.Epos ||
                              p.AccountType == ReceiptAccountType.Sps || p.AccountType == ReceiptAccountType.Pos ? p.BankAccount.BankAccountName :

                              p.AccountType == ReceiptAccountType.Customer || p.AccountType == ReceiptAccountType.Offset ? p.CustomerAccount.CustomerName :
                              p.AccountType == ReceiptAccountType.Vault ? p.VaultAccount.VaultName :
                              p.AccountType == ReceiptAccountType.Transfer ? p.BranchAccount.BranchName : null,
                NumberOfAction = p.NumberOfAction,
                SumOfReceipt = p.SumOfReceipt
            }).OrderBy(p => p.Code).ToList();
        }

        public override bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, CardType.Receipt, false);
        }
    }
}