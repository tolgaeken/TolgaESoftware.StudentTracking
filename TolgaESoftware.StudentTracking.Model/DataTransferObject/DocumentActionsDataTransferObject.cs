using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class DocumentActionsList:BaseActionEntity
    {
        public new long Id { get; set; }
        public long BranchId { get; set; }
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string StudentBranchName { get; set; }
        public int PaymentInformationsId { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime AccountTransferDate { get; set; }
        public decimal Price { get; set; }
        public decimal PriceBeforeTransaction { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public decimal TransactionPrice { get; set; }
        public DateTime Date { get; set; }
        public string ReceiptNumber { get; set; }
        public ReceiptType ReceiptType { get; set; }
        public ReceiptAccountType AccountType { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
    }
}