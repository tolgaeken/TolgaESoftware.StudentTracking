using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Service:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Hizmet Adı","txtServiceName")]
        public string ServiceName { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        [RequiredField("Hizmet Türü Adı","txtServiceType")]
        public long ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }

        public long TermId { get; set; }
        public Term Term { get; set; }
    }
}