using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class DiscountApplyServices:BaseActionEntity
    {
        [Column(TypeName = "money")]
        public decimal DiscountPrice { get; set; }
        public byte DiscountPercentage { get; set; }

        public long DiscountId { get; set; }
        public Discount Discount { get; set; }

        public long ServiceId { get; set; }
        public Service Service { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }

        public long TermId { get; set; }
        public Term Term { get; set; }
    }
}