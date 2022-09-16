using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class School:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Okul Adı","txtSchoolName")]
        public string SchoolName { get; set; }

        [RequiredField("İl Adı","txtProvince")]
        public long ProvinceId { get; set; }

        [RequiredField("İlçe Adı","txtDistrict")]
        public long DistrictId { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public Province Province { get; set; }
        public District District { get; set; }
    }
}