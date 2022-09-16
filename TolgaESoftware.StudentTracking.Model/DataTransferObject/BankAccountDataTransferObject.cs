using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class BankAccountSingle : BankAccount
    {
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
    }

    public class BankAccountList : BaseEntity
    {
        public string BankAccountName { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string AccountNumber { get; set; }
        public string IbanNumber { get; set; }
        public BankAccountType BankAccountType { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        public byte BlockedDay { get; set; }
        public string WorkplaceNumber { get; set; }
        public string TerminalNumber { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string Statement { get; set; }
    }
}