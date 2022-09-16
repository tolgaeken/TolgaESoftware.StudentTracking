using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Lawyer:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Adı Soyadı","txtNameLastname")]
        public string NameLastname { get; set; }

        [StringLength(14)]
        public string TrIdentityNumber { get; set; }

        [StringLength(20)]
        public string ContractNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractEndDate { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public long? SpecialCode1Id { get; set; }
        public SpecialCode SpecialCode1 { get; set; }

        public long? SpecialCode2Id { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
    }
}