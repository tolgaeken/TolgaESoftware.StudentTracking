using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class BankAccount:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Banka Hesap Adı","txtBankAccountName")]
        public string BankAccountName { get; set; }

        [Required,StringLength(30),RequiredField("Banka Hesap Numarası","txtBankAccountNumber")]
        public string AccountNumber { get; set; }

        [Required,StringLength(32),RequiredField("IBAN Numarası","txtIbanNumber")]
        public string IbanNumber { get; set; }

        public BankAccountType BankAccountType { get; set; } = BankAccountType.DemandDepositAccount;

        [Column(TypeName = "date")]
        public DateTime AccountOpeningDate { get; set; } = DateTime.Now.Date;

        public byte BlockedDay { get; set; }

        [StringLength(30)]
        public string WorkplaceNumber { get; set; }

        [StringLength(30)]
        public string TerminalNumber { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public long BranchId { get; set; }

        [RequiredField("Banka Adı" , "txtBankName")]
        public long BankId { get; set; }
        public Bank Bank { get; set; }

        [RequiredField("Banka Şube Adı","txtBankBranchName")]
        public long BankBranchId { get; set; }
        public BankBranch BankBranch { get; set; }

        public long? SpecialCode1Id { get; set; }
        public SpecialCode SpecialCode1 { get; set; }

        public long? SpecialCode2Id { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
    }
}