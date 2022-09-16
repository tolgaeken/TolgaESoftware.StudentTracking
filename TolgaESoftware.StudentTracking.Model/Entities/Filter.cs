using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Filter : BaseEntity
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(100),RequiredField("Filtre Adı","txtFilterName")]
        public string FilterName { get; set; }

        [Required,StringLength(1000),RequiredField("Filtre Metni","txtFilterText")]
        public string FilterText { get; set; }

        [Required]
        public CardType CardType { get; set; }
    }
}