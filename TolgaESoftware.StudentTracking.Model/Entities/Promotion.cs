using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Promotion:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Promosyon Adı","txtPromotionName")]
        public string PromotionName { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }

        public long TermId { get; set; }
        public Term Term { get; set; }
    }
}