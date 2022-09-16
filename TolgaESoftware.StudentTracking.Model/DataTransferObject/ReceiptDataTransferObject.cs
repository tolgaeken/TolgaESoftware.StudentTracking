using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class ReceiptSingle:Receipt
    {
        public string AccountName { get; set; }
    }

    public class ReceiptList : BaseEntity
    {
        public DateTime Date { get; set; }
        public ReceiptType ReceiptType { get; set; }
        public ReceiptAccountType AccountType { get; set; }
        public decimal SumOfReceipt { get; set; }
        public int NumberOfAction { get; set; }
        public string AccountName { get; set; }
        }
}