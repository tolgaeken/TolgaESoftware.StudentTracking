using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class DocumentActionsBll : BaseActionBll<ReceiptActions, StudentTrackingContext>, IBaseActionSelectBll<ReceiptActions>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<ReceiptActions, bool>> filter)
        {
            return List(filter, p => new DocumentActionsList
            {
                Id = p.Receipt.Id,
                BranchId = p.Receipt.BranchId,
                StudentNumber = p.PaymentInformations.Accrue.Student.Code,
                Name = p.PaymentInformations.Accrue.Student.Name,
                Lastname = p.PaymentInformations.Accrue.Student.Lastname,
                ClassName = p.PaymentInformations.Accrue.Class.ClassName,
                StudentBranchName = p.PaymentInformations.Accrue.Branch.BranchName,
                PaymentInformationsId = p.PaymentInformationsId,
                PaymentMethodName = p.PaymentInformations.PaymentMethod.PaymentMethodName,
                EntryDate = p.PaymentInformations.EntryDate,
                PaymentTerm = p.PaymentInformations.PaymentTerm,
                AccountTransferDate = p.PaymentInformations.AccountTransferDate,
                Price = p.PaymentInformations.Price,
                PriceBeforeTransaction = p.PriceBeforeTransaction,
                TransactionPrice = p.TransactionPrice,
                PrincipalDebtor = p.PaymentInformations.PrincipalDebtor,
                Endorser = p.PaymentInformations.Endorser,
                BankName = p.PaymentInformations.Bank.BankName,
                BankBranchName = p.PaymentInformations.BankBranch.BankBranchName,
                DocumentNumber = p.PaymentInformations.DocumentNumber,
                AccountNumber = p.PaymentInformations.AccountNumber,
                Date = p.Receipt.Date,
                ReceiptNumber = p.Receipt.Code,
                ReceiptType = p.Receipt.ReceiptType,
                AccountType = p.Receipt.AccountType,
                DocumentStatus = p.DocumentStatus
            }).OrderBy(p => new { p.Date, p.ReceiptNumber }).ToList();
        }
    }
}