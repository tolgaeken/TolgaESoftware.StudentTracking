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
    public class BankAccountBll:BaseGeneralBll<BankAccount>,IBaseCommonBll
    {
        public BankAccountBll() : base(CardType.BankAccount) { }
        public BankAccountBll(Control control) : base(control, CardType.BankAccount) { }

        public override BaseEntity Single(Expression<Func<BankAccount, bool>> filter)
        {
            return BaseSingle(filter, p => new BankAccountSingle
            {
                Id = p.Id,
                Code = p.Code,
                BankAccountName = p.BankAccountName,
                BankAccountType = p.BankAccountType,
                BankId = p.BankId,
                BankName = p.Bank.BankName,
                BankBranchId = p.BankBranchId,
                BankBranchName = p.BankBranch.BankBranchName,
                AccountOpeningDate = p.AccountOpeningDate,
                AccountNumber = p.AccountNumber,
                IbanNumber = p.IbanNumber,
                BlockedDay = p.BlockedDay,
                WorkplaceNumber = p.WorkplaceNumber,
                TerminalNumber = p.TerminalNumber,
                SpecialCode1Id = p.SpecialCode1Id,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Id = p.SpecialCode2Id,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement,
                BranchId = p.BranchId,
                Status = p.Status,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<BankAccount, bool>> filter)
        {
            return BaseList(filter, p => new BankAccountList
            {
                Id = p.Id,
                Code = p.Code,
                BankAccountName = p.BankAccountName,
                BankAccountType = p.BankAccountType,
                BankName = p.Bank.BankName,
                BankBranchName = p.BankBranch.BankBranchName,
                AccountOpeningDate = p.AccountOpeningDate,
                AccountNumber = p.AccountNumber,
                IbanNumber = p.IbanNumber,
                BlockedDay = p.BlockedDay,
                WorkplaceNumber = p.WorkplaceNumber,
                TerminalNumber = p.TerminalNumber,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement,
            }).OrderBy(p => p.Code).ToList();
        }
    }
}