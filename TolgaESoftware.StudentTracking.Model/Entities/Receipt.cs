using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Receipt:BaseEntity
    {
        [Index("IX_Code",IsUnique = false),Code("Makbuz No","txtReceiptNumber"),RequiredField("Makbuz No","txtReceiptNumber")]
        public override string Code { get; set; }

        [Column (TypeName = "date")]
        public DateTime Date { get; set; }

        public ReceiptType ReceiptType { get; set; } = ReceiptType.ChargedToVault;

        public ReceiptAccountType AccountType { get; set; } = ReceiptAccountType.Vault;

        [Column(TypeName = "money")]
        public decimal SumOfReceipt { get; set; }

        public int NumberOfAction { get; set; }


        public long? LawyerAccountId { get; set; }
        public Lawyer LawyerAccount { get; set; }

        public long? BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public long? CustomerAccountId { get; set; }
        public Customer CustomerAccount { get; set; }

        public long? VaultAccountId { get; set; }
        public Vault VaultAccount { get; set; }

        public long? BranchAccountId { get; set; }
        public Branch BranchAccount { get; set; }

        public long TermId { get; set; }
        public Term Term { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}