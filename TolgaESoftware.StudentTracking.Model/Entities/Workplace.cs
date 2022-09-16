using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Workplace:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("İşyeri Adı","txtWorkplaceName")]
        public string WorkplaceName { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }
    }
}