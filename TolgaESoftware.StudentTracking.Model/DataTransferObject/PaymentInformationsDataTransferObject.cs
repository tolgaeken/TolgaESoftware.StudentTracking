using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class PaymentInformationsList:PaymentInformations,IBaseActionEntity
    {
        public string AccrueName { get; set; }
        public string PaymentMethodName { get; set; }
        public string BankAccountName { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string BranchName { get; set; }
        public string BranchProvinceName { get; set; }
        public decimal Collect { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Refund { get; set; }
        public decimal Remaining { get; set; }
        public long? LastActionId { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastProcessPlace { get; set; }
        public DocumentStatus DocumentStatus { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class PaymentInformationsReport
    {
        public PaymentType PaymentType { get; set; }
        public int WalletNumber { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime AccountTransferDate { get; set; }
        public string BankAccountName { get; set; }
        public string TrackNumber { get; set; }
        public byte BlockedDay { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public string Statement { get; set; }
        public decimal Price { get; set; }
        public decimal Collect { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Refund { get; set; }
        public decimal Remaining { get; set; }
        public string PriceAsText { get; set; }
        public string PaymentTermAsText { get; set; }
        public string BranchName { get; set; }
        public string BranchProvinceName { get; set; }
        public DocumentStatus DocumentStatus { get; set; }

    }
}