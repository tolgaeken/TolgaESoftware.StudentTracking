using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class ContactSingle:Contact
    {
        public string IdentityProvinceName { get; set; }
        public string IdentityDistrictName { get; set; }
        public string HomeAddressProvinceName { get; set; }
        public string HomeAddressDistrictName { get; set; }
        public string WorkplaceAddressProvinceName { get; set; }
        public string WorkplaceAddressDistrictName { get; set; }
        public string VocationName { get; set; }
        public string WorkplaceName { get; set; }
        public string JobName { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
    }

    public class ContactList : BaseEntity
    {
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? BirthDate { get; set; }
        public BloodGroups BloodGroups { get; set; }
        public string IdentitySerialNumber { get; set; }
        public string IdentityRowNumber { get; set; }
        public string IdentityProvinceName { get; set; }
        public string IdentityDistrictName { get; set; }
        public string IdentityNeighborhood { get; set; }
        public string IdentityBindingNumber { get; set; }
        public string IdentityFamilyRowNumber { get; set; }
        public string IdentityPersonRowNumber { get; set; }
        public string IdentityGivenPlace { get; set; }
        public string IdentityGivenReason { get; set; }
        public string IdentityRegisterNumber { get; set; }
        public DateTime? IdentityGivenDate { get; set; }
        public string HomePhone { get; set; }
        public string WorkplacePhone1 { get; set; }
        public string WorkplacePhone2 { get; set; }
        public string InternalPhone1 { get; set; }
        public string InternalPhone2 { get; set; }
        public string MobilePhone1 { get; set; }
        public string MobilePhone2 { get; set; }
        public string Web { get; set; }
        public string EMail { get; set; }
        public string HomeAddress { get; set; }
        public string HomeAddressProvinceName { get; set; }
        public string HomeAddressDistrictName { get; set; }
        public string WorkplaceAddress { get; set; }
        public string WorkplaceAddressProvinceName { get; set; }
        public string WorkplaceAddressDistrictName { get; set; }
        public string IbanNumber { get; set; }
        public string VocationName { get; set; }
        public string WorkplaceName { get; set; }
        public string JobName { get; set; }
        public string CardNumber { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string Statement { get; set; }
    }
}