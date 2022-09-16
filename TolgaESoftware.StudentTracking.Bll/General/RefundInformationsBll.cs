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
    public class RefundInformationsBll : BaseActionBll<RefundInformations, StudentTrackingContext>, IBaseActionSelectBll<RefundInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<RefundInformations, bool>> filter)
        {
            return List(filter, p => new RefundInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                Date = p.Date,
                AccountType = p.AccountType,
                AccountId = p.AccountType == RefundAccountType.Vault ? p.VaultId : p.BankAccountId,
                AccountName = p.AccountType == RefundAccountType.Vault ? p.Vault.VaultName : p.BankAccount.BankAccountName,
                BankAccountId = p.BankAccountId,
                VaultId = p.VaultId,
                Price = p.Price,
                Statement = p.Statement
            }).ToList();
        }
    }
}