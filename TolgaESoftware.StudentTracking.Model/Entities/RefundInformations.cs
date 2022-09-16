using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class RefundInformations:BaseActionEntity
    {
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public RefundAccountType AccountType { get; set; }

        [Description("money")]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }


        public long AccrueId { get; set; }
        public Accrue Accrue { get; set; }

        public long? BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public long? VaultId { get; set; }
        public Vault Vault { get; set; }

    }
}