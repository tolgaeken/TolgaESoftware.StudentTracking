using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Guide:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Rehber Adı Soyadı","txtGuideNameLastname")]
        public string GuideNameLastname { get; set; }

        [StringLength(17)]
        public string Phone1 { get; set; }

        [StringLength(17)]
        public string Phone2 { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }
    }
}