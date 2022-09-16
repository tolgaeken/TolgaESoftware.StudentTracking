using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class ServiceType:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Hizmet Türü Adı","txtServiceTypeName")]
        public string ServiceTypeName { get; set; }
        public ServiceTypeEnum ServiceTypeEnum { get; set; } = ServiceTypeEnum.Education;

        [StringLength(500)]
        public string Statement { get; set; }
    }
}