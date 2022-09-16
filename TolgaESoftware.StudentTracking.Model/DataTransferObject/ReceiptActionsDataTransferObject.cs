using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class ReceiptActionsList : ReceiptActions, IBaseActionEntity
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string StudentBranchName { get; set; }
        public string DocumentBranchName { get; set; }
        public string PaymentMethodName { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime AccountTransferDate { get; set; }
        public string TrackNumber { get; set; }
        public decimal Price { get; set; }
        public string BankAccountName { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public long? LastActionId { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastProcessPlace { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class ReceiptActionsReport
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string BranchName { get; set; }
        public int WalletNumber { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime PaymentTerm { get; set; }
        public decimal Price { get; set; }
        public decimal PriceBeforeTransaction { get; set; }
        public decimal TransactionPrice { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public string BankAndBranchName { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Date { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptType { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string DocumentStatus { get; set; }
    }
}