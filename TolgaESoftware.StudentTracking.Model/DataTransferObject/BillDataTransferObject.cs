using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class BillList
    {
        public long Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public TaxType TaxType { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal ServiceDiscount { get; set; }
        public decimal ServiceNetPrice { get; set; }
        public decimal PlanPrice { get; set; }
        public decimal PlanDiscount { get; set; }
        public decimal PlanNetPrice { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
    }

    [NotMapped]
    public class BillPlanList : Bill, IBaseActionEntity
    {
        public DateTime RegistrationDate { get; set; }
        // public TaxType TaxType { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string SchoolNumber { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string GuardianshipTrIdentityNumber { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string GuardianshipHomeAddress { get; set; }
        public long? GuardianshipHomeAddressProvinceId { get; set; }
        public string GuardianshipHomeAddressProvinceName { get; set; }
        public long? GuardianshipHomeAddressDistrictId { get; set; }
        public string GuardianshipHomeAddressDistrictName { get; set; }
        public string GuardianshipWorkplaceAddress { get; set; }
        public long? GuardianshipWorkplaceAddressProvinceId { get; set; }
        public string GuardianshipWorkplaceAddressProvinceName { get; set; }
        public long? GuardianshipWorkplaceAddressDistrictId { get; set; }
        public string GuardianshipWorkplaceAddressDistrictName { get; set; }
        public string BillAddressProvinceName { get; set; }
        public string BillAddressDistrictName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public string Branch { get; set; }
        public string Term { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    public class BillTakenServicesList
    {
        public long ServiceId { get; set; }
        public long AccrueId { get; set; }
        public string SchoolNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string ServiceName { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal NetPrice { get; set; }
    }

    [HighlightedClass]
    public class BillReport : IBaseEntity
    {
        public long AccrueId { get; set; }
        public string SchoolNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string TrIdentityNumber { get; set; }
        public string GuardianshipTrIdentityNumber { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string BillAddress { get; set; }
        public string BillAddressProvinceName { get; set; }
        public string BillAddressDistrictName { get; set; }
        public int? BillNumber { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NetPrice { get; set; }
        public TaxType? TaxType { get; set; }
        public byte? TaxPercentage { get; set; }
        public decimal? TaxExcludedPrice { get; set; }
        public decimal? TaxPrice { get; set; }
        public decimal? SumOfPrice { get; set; }
        public decimal? PlanPrice { get; set; }
        public decimal? PlanDiscount { get; set; }
        public decimal? PlanNetPrice { get; set; }
        public string PriceAsText { get; set; }
        public string Branch { get; set; }
        public string Term { get; set; }
        public string Statement { get; set; }
    }
}