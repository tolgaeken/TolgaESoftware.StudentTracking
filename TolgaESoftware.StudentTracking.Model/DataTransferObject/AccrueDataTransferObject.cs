using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class AccrueSingle : Accrue
    {
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string ClassName { get; set; }
        public string ComesFromSchoolName { get; set; }
        public string QuotaName { get; set; }
        public string ForeignLanguageName { get; set; }
        public string GuideName { get; set; }
        public string IncentName { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string SpecialCode3Name { get; set; }
        public string SpecialCode4Name { get; set; }
        public string SpecialCode5Name { get; set; }
        public string BranchName { get; set; }
        public string TermName { get; set; }
    }

    public class AccrueList : BaseEntity
    {
        public long StudentId { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SchoolNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public NextTermEnrollmentStatus NextTermEnrollmentStatus { get; set; }
        public string NextTermEnrollmentStatusStatement { get; set; }
        public string ClassName { get; set; }
        public string ComesFromSchoolName { get; set; }
        public string QuotaName { get; set; }
        public string ForeignLanguageName { get; set; }
        public string GuideName { get; set; }
        public string IncentName { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string SpecialCode3Name { get; set; }
        public string SpecialCode4Name { get; set; }
        public string SpecialCode5Name { get; set; }
        public string BranchName { get; set; }
        public string TermName { get; set; }
        public bool Status { get; set; }
    }

    public class StudentAccrueList
    {
        public long AccrueId { get; set; }
        public long BranchId { get; set; }
        public string BranchName { get; set; }
        public long TermId { get; set; }
        public string TermName { get; set; }
        public decimal GrossService { get; set; }
        public decimal ShortTermDeductedService { get; set; }
        public decimal NetService { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal NetPrice { get; set; }
    }
}