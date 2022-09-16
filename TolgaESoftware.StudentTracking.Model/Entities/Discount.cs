using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Discount:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("İndirim Adı","txtDiscountName")]
        public string DiscountName { get; set; }
    
        [StringLength(500)]
        public string Statement { get; set; }

        [RequiredField("İndirim Türü Adı","txtDiscountType")]
        public long DiscountTypeId { get; set; }
        public DiscountType DiscountType { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }

        public long TermId { get; set; }
        public Term Term { get; set; }

        [InverseProperty("Discount")]
        public ICollection<DiscountApplyServices> DiscountApplyServices { get; set; }
    }
}