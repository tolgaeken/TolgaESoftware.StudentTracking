using System.ComponentModel.DataAnnotations;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class InstitutionInformations:BaseEntity
    {

        [Required,StringLength(50),RequiredField("Kurum Adı","txtInstitutionName")]
        public string InstitutionName { get; set; }

        [StringLength(20)]
        public string TaxNumber { get; set; }

        [StringLength(50)]
        public string TaxAdministration { get; set; }

        [RequiredField("İl Adı","txtProvince")]
        public long ProvinceId { get; set; }
        public Province Province { get; set; }

        [RequiredField("İlçe Adı","txtDistrict")]
        public long DistrictId { get; set; }
        public District District { get; set; }
    }
}