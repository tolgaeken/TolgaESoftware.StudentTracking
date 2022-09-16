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
    public class CollectReportBll : BaseActionBll<ReceiptActions, StudentTrackingContext>
    {
        public IEnumerable<CollectReportList> List(Expression<Func<ReceiptActions, bool>> filter)
        {
            return List(filter, p => new CollectReportList
            {
                BranchId = p.Receipt.BranchId,
                StudentBranchName = p.PaymentInformations.Accrue.Branch.BranchName,
                TermId = p.Receipt.TermId,
                StudentNumber = p.PaymentInformations.Accrue.Code,
                Name = p.PaymentInformations.Accrue.Student.Name,
                Lastname = p.PaymentInformations.Accrue.Student.Lastname,
                RegistrationDate = p.PaymentInformations.Accrue.RegistrationDate,
                EnrollmentType = p.PaymentInformations.Accrue.EnrollmentType,
                EnrollmentStatus = p.PaymentInformations.Accrue.EnrollmentStatus,
                CancelStatus = p.PaymentInformations.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                ClassName = p.PaymentInformations.Accrue.Class.ClassName,
                ClassGroupName = p.PaymentInformations.Accrue.Class.ClassGroup.GroupName,
                DocumentBranchName = p.Receipt.Branch.BranchName,
                PaymentMethodName = p.PaymentInformations.PaymentMethod.PaymentMethodName,
                WalletNumber = p.PaymentInformations.Id,
                EntryDate = p.PaymentInformations.EntryDate,
                PaymentTerm = p.PaymentInformations.PaymentTerm,
                AccountTransferDate = p.PaymentInformations.AccountTransferDate,
                PrincipalDebtor = p.PaymentInformations.PrincipalDebtor,
                Endorser = p.PaymentInformations.Endorser,
                BankName = p.PaymentInformations.Bank.BankName,
                BankBranchName = p.PaymentInformations.BankBranch.BankBranchName,
                DocumentNumber = p.PaymentInformations.DocumentNumber,
                AccountNumber = p.PaymentInformations.AccountNumber,
                BlockedDay = p.PaymentInformations.BlockedDay,
                BankAccountName = p.PaymentInformations.BankAccount.BankAccountName,
                TrackNumber = p.PaymentInformations.TrackNumber,
                Price = p.PaymentInformations.Price,
                PriceBeforeTransaction = p.PriceBeforeTransaction,
                TransactionPrice = p.TransactionPrice,
                Remaining = p.PriceBeforeTransaction - p.TransactionPrice,
                DocumentStatus = p.DocumentStatus,
                Statement = p.PaymentInformations.Statement,
                ReceiptId = p.ReceiptId,
                ReceiptNumber = p.Receipt.Code,
                ReceiptDate = p.Receipt.Date,
                ReceiptType = p.Receipt.ReceiptType,
                ReceiptAccountType = p.Receipt.AccountType,
                DebtCollector = p.User.Code,

                ProcessPlace = p.Receipt.LawyerAccountId != null ? p.Receipt.LawyerAccount.NameLastname
                             : p.Receipt.BankAccountId != null ? p.Receipt.BankAccount.BankAccountName
                             : p.Receipt.CustomerAccountId != null ? p.Receipt.CustomerAccount.CustomerName
                             : p.Receipt.VaultAccountId != null ? p.Receipt.VaultAccount.VaultName
                             : p.Receipt.BranchAccountId != null ? p.Receipt.BranchAccount.BranchName : null,

                SpecialCode1 = p.PaymentInformations.Accrue.SpecialCode1.SpecialCodeName,
                SpecialCode2 = p.PaymentInformations.Accrue.SpecialCode2.SpecialCodeName,
                SpecialCode3 = p.PaymentInformations.Accrue.SpecialCode3.SpecialCodeName,
                SpecialCode4 = p.PaymentInformations.Accrue.SpecialCode4.SpecialCodeName,
                SpecialCode5 = p.PaymentInformations.Accrue.SpecialCode5.SpecialCodeName,

            }).OrderBy(p=>p.ReceiptDate).ToList();
        }
    }
}