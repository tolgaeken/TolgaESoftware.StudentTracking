using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class ContactInformationsList:ContactInformations,IBaseActionEntity
    {
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string HomePhone { get; set; }
        public string WorkplacePhone1 { get; set; }
        public string WorkplacePhone2 { get; set; }
        public string InternalPhone1 { get; set; }
        public string InternalPhone2 { get; set; }
        public string MobilePhone1 { get; set; }
        public string MobilePhone2 { get; set; }
        public string HomeAddress { get; set; }
        public string HomeAddressProvinceName { get; set; }
        public string HomeAddressDistrictName { get; set; }
        public string WorkplaceAddress { get; set; }
        public string WorkplaceAddressProvinceName { get; set; }
        public string WorkplaceAddressDistrictName { get; set; }
        public string KinshipName { get; set; }
        public string VocationName { get; set; }
        public string WorkplaceName { get; set; }
        public string JobName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class ContactInformationsReport
    {
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string NameLastname { get; set; }
        public string HomePhone { get; set; }
        public string WorkplacePhone1 { get; set; }
        public string WorkplacePhone2 { get; set; }
        public string InternalPhone1 { get; set; }
        public string InternalPhone2 { get; set; }
        public string WorkplacePhoneInternal1 { get; set; }
        public string WorkplacePhoneInternal2 { get; set; }
        public string MobilePhone1 { get; set; }
        public string MobilePhone2 { get; set; }
        public string HomeAddress { get; set; }
        public string HomeAddressProvinceName { get; set; }
        public string HomeAddressDistrictName { get; set; }
        public string HomeAddressProvinceDistrict { get; set; }
        public string WorkplaceAddress { get; set; }
        public string WorkplaceAddressProvinceName { get; set; }
        public string WorkplaceAddressDistrictName { get; set; }
        public string WorkplaceAddressProvinceDistrict { get; set; }
        public string KinshipName { get; set; }
        public string VocationName { get; set; }
        public string WorkplaceName { get; set; }
        public string JobName { get; set; }
    }
}