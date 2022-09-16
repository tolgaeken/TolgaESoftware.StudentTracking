using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Student:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [StringLength(14)]
        public string TrIdentityNumber { get; set; }

        [Required,StringLength(50),RequiredField("Adı","txtName")]
        public string Name { get; set; }

        [Required, StringLength(50), RequiredField("Soyadı", "txtLastname")]
        public string Lastname { get; set; }

        public Gender Gender { get; set; }// = Gender.Boy;

        [StringLength(17)]
        public string Phone { get; set; }

        public BloodGroups BloodGroups { get; set; } = BloodGroups.Empty;

        [StringLength(30)]
        public string FatherName { get; set; }

        [StringLength(30)]
        public string MotherName { get; set; }

        [StringLength(30)]
        public string BirthPlace { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

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

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public SpecialCode SpecialCode1 { get; set; }
        public long? SpecialCode1Id { get; set; }

        public SpecialCode SpecialCode2 { get; set; }
        public long? SpecialCode2Id { get; set; }

        public SpecialCode SpecialCode3 { get; set; }
        public long? SpecialCode3Id { get; set; }

        public SpecialCode SpecialCode4 { get; set; }
        public long? SpecialCode4Id { get; set; }

        public SpecialCode SpecialCode5 { get; set; }
        public long? SpecialCode5Id { get; set; }

        public Province IdentityProvince { get; set; }
        public long? IdentityProvinceId { get; set; }

        public District IdentityDistrict { get; set; }
        public long? IdentityDistrictId { get; set; }
    }
}