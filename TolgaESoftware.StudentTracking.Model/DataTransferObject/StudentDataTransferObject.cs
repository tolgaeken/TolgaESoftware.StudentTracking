using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class StudentSingle:Student
    {
        public string IdentityProvinceName { get; set; }
        public string IdentityDistrictName { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string SpecialCode3Name { get; set; }
        public string SpecialCode4Name { get; set; }
        public string SpecialCode5Name { get; set; }
    }

    public class StudentList:BaseEntity
    {
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? BirthDate { get; set; }
        public BloodGroups BloodGroups { get; set; }
        public string IdentitySerialNumber { get; set; }
        public string IdentityRowNumber { get; set; }
        public string IdentityNeighborhood { get; set; }
        public string IdentityBindingNumber { get; set; }
        public string IdentityFamilyRowNumber { get; set; }
        public string IdentityPersonRowNumber { get; set; }
        public string IdentityGivenPlace { get; set; }
        public string IdentityGivenReason { get; set; }
        public string IdentityRegisterNumber { get; set; }
        public DateTime? IdentityGivenDate { get; set; }
        public string Statement { get; set; }
        public string IdentityProvinceName { get; set; }
        public string IdentityDistrictName { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string SpecialCode3Name { get; set; }
        public string SpecialCode4Name { get; set; }
        public string SpecialCode5Name { get; set; }
    }

    [HighlightedClass]
    public class StudentReport:IBaseEntity
    {
        public string StudentNumber { get; set; }
        public string SchoolNumber { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string NameLastname { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? BirthDate { get; set; }
        public BloodGroups BloodGroups { get; set; }
        public string IdentitySerialNumber { get; set; }
        public string IdentityRowNumber { get; set; }
        public string IdentityNeighborhood { get; set; }
        public string IdentityBindingNumber { get; set; }
        public string IdentityFamilyRowNumber { get; set; }
        public string IdentityPersonRowNumber { get; set; }
        public string IdentityGivenPlace { get; set; }
        public string IdentityGivenReason { get; set; }
        public string IdentityRegisterNumber { get; set; }
        public DateTime? IdentityGivenDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public string Statement { get; set; }
        public string IdentityProvinceName { get; set; }
        public string IdentityDistrictName { get; set; }
        public string Class { get; set; }
        public string ComesFromSchool { get; set; }
        public string Quota { get; set; }
        public string Guide { get; set; }
        public string ForeignLanguage { get; set; }
        public string Incent { get; set; }
        public string TermName { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string BranchAddressProvinceName { get; set; }
        public string BranchAddressDistrictName { get; set; }
        public string BranchPhoneNumber { get; set; }
        public string BranchFax { get; set; }
        public string BranchIbanNumber { get; set; }
        public byte[] BranchLogo { get; set; }
        public ContactInformationsReport GuardianshipInformations { get; set; }
        public ContactInformationsReport MotherInformations { get; set; }
        public ContactInformationsReport FatherInformations { get; set; }
    }
}