using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class SpecialCode:BaseEntity
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Özel Kod Adı","txtSpecialCodeName")]
        public string SpecialCodeName { get; set; }

        [Required]
        public SpecialCodeType SpecialCodeType { get; set; }

        [Required]
        public CardType SpecialCodeCardType { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }
    }
}