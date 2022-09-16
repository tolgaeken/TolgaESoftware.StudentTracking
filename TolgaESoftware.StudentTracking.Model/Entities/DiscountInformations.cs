using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class DiscountInformations : BaseActionEntity
    {
        public int? ServiceActionId { get; set; }

        [Column(TypeName = "date")]
        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CancellationDate { get; set; }

        [Column(TypeName = "money")]
        public decimal GrossDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal ShortTermDeductedDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal NetDiscount { get; set; }

        public bool Cancelled { get; set; }

        public bool PercentageDiscount { get; set; }

        public bool ManuallyEnteredPrice { get; set; }

        [StringLength(1000)]
        public string CancellationStatement { get; set; }


        public Accrue Accrue { get; set; }
        public long AccrueId { get; set; }

        public Discount Discount { get; set; }
        public long DiscountId { get; set; }

        public Service Service { get; set; }
        public long ServiceId { get; set; }

        public CancellationReason CancellationReason { get; set; }
        public long? CancellationReasonId { get; set; }
    }
}