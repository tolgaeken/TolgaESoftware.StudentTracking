using System;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    public class DocumentSelectionList : BaseEntity
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string StudentBranchName { get; set; }
        public int PaymentInformationsId { get; set; }
        public string DocumentBranchName { get; set; }
        public string PaymentMethodName { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime AccountTransferDate { get; set; }
        public string TrackNumber { get; set; }
        public decimal Price { get; set; }
        public decimal Collect { get; set; }
        public decimal Refund { get; set; }
        public decimal Remaining { get; set; }
        public string BankAccountName { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public string Statement { get; set; }
        public long? LastActionId { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastProcessPlace { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public ReceiptAccountType AccountType { get; set; }
        public long? BranchId { get; set; }
    }
}