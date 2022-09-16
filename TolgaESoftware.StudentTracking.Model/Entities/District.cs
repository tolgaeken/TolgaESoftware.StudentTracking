using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class District:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("İlçe Adı","txtDistrictName")]
        public string DistrictName { get; set; }
        [StringLength(500)]
        public string Statement { get; set; }

        public long ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}