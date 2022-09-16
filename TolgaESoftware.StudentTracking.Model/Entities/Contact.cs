using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Contact:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [StringLength(14)]
        public string TrIdentityNumber { get; set; }

        [Required,StringLength(50),RequiredField("Adı","txtName")]
        public string Name { get; set; }

        [Required,StringLength(50),RequiredField("Soyadı","txtLastname")]
        public string Lastname { get; set; }

        [StringLength(30)]
        public string FatherName { get; set; }

        [StringLength(30)]
        public string MotherName { get; set; }

        [StringLength(30)]
        public string BirthPlace { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        public BloodGroups BloodGroups { get; set; } = BloodGroups.Empty;

        [StringLength(3)]
        public string IdentitySerialNumber { get; set; }

        [StringLength(6)]
        public string IdentityRowNumber { get; set; }

        [StringLength(30)]
        public string IdentityNeighborhood { get; set; }

        [StringLength(20)]
        public string IdentityBindingNumber { get; set; }

        [StringLength(20)]
        public string IdentityFamilyRowNumber { get; set; }

        [StringLength(20)]
        public string IdentityPersonRowNumber { get; set; }

        [StringLength(30)]
        public string IdentityGivenPlace { get; set; }

        [StringLength(30)]
        public string IdentityGivenReason { get; set; }

        [StringLength(20)]
        public string IdentityRegisterNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IdentityGivenDate { get; set; }

        [StringLength(17)]
        public string HomePhone { get; set; }

        [StringLength(17)]
        public string WorkplacePhone1 { get; set; }

        [StringLength(17)]
        public string WorkplacePhone2 { get; set; }

        [StringLength(6)]
        public string InternalPhone1 { get; set; }

        [StringLength(6)]
        public string InternalPhone2 { get; set; }

        [StringLength(17)]
        public string MobilePhone1 { get; set; }

        [StringLength(17)]
        public string MobilePhone2 { get; set; }

        [StringLength(100)]
        public string Web { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(250)]
        public string HomeAddress { get; set; }

        [StringLength(250)]
        public string WorkplaceAddress { get; set; }

        [StringLength(32)]
        public string IbanNumber { get; set; }

        [StringLength(19)]
        public string CardNumber { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }



        public Province IdentityProvince { get; set; }
        public long? IdentityProvinceId { get; set; }
        
        public Province HomeAddressProvince { get; set; }
        public long? HomeAddressProvinceId { get; set; }
        
        public Province WorkplaceAddressProvince { get; set; }
        public long? WorkplaceAddressProvinceId { get; set; }

        public District IdentityDistrict { get; set; }
        public long? IdentityDistrictId { get; set; }

        public District HomeAddressDistrict { get; set; }
        public long? HomeAddressDistrictId { get; set; }

        public District WorkplaceAddressDistrict { get; set; }
        public long? WorkplaceAddressDistrictId { get; set; }

        public Vocation Vocation { get; set; }
        public long? VocationId { get; set; }

        public Workplace Workplace { get; set; }
        public long? WorkplaceId { get; set; }

        public Job Job { get; set; }
        public long? JobId { get; set; }

        public SpecialCode SpecialCode1 { get; set; }
        public long? SpecialCode1Id { get; set; }

        public SpecialCode SpecialCode2 { get; set; }
        public long? SpecialCode2Id { get; set; }
    }
}