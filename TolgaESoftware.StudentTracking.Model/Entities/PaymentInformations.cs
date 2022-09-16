using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class PaymentInformations:BaseActionEntity
    {
        public PaymentType PaymentType { get; set; }
        public byte BlockedDay { get; set; }

        [Column(TypeName = "date")]
        public DateTime EntryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime PaymentTerm { get; set; }

        [Column(TypeName = "date")]
        public DateTime AccountTransferDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(20)]
        public string TrackNumber { get; set; }
       
        [StringLength(20)]
        public string DocumentNumber { get; set; }

        [StringLength(20)]
        public string AccountNumber { get; set; }

        [StringLength(50)]
        public string PrincipalDebtor { get; set; }

        [StringLength(50)]
        public string Endorser { get; set; }

        [Required,StringLength(100)]
        public string PriceAsText { get; set; }

        [Required,StringLength(100)]
        public string PaymentTermAsTxt { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }


        public long AccrueId { get; set; }
        public Accrue Accrue { get; set; }

        public long PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public long? BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public long? BankId { get; set; }
        public Bank Bank { get; set; }

        public long? BankBranchId { get; set; }
        public BankBranch BankBranch { get; set; }

        public ICollection<ReceiptActions> ReceiptActions { get; set; }
    }
}