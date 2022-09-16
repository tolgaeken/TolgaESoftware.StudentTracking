using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Customer:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Cari Adı","txtCustomerName")]
        public string CustomerName { get; set; }

        [StringLength(14)]
        public string TrIdentityNumber { get; set; }
        [StringLength(17)]
        public string Phone1 { get; set; }
        [StringLength(17)]
        public string Phone2 { get; set; }
        [StringLength(17)]
        public string Phone3 { get; set; }
        [StringLength(17)]
        public string Phone4 { get; set; }
        [StringLength(17)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Web { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(50)]
        public string TaxAdministration { get; set; }

        [StringLength(20)]
        public string TaxNumber { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public long? SpecialCode1Id { get; set; }
        public SpecialCode SpecialCode1 { get; set; }

        public long? SpecialCode2Id { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
    }
}