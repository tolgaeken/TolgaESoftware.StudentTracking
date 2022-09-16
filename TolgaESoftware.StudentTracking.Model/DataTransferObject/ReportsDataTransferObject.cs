using System;
using TolgaESoftware.StudentTracking.Common.Enums;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    public class GeneralReportList
    {
        public long StudentId { get; set; }
        public long AccrueId { get; set; }
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentNumber { get; set; }
        public string SchoolNumber { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public int Girl { get; set; }
        public int Boy { get; set; }
        public string Phone { get; set; }
        public BloodGroups? BloodGroup { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? BirthDate { get; set; }
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
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public string ClassName { get; set; }
        public string ComesFromSchool { get; set; }
        public string QuotaType { get; set; }
        public string ForeignLanguageName { get; set; }
        public string GuideName { get; set; }
        public string IncentName { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string BranchName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public string GuardianshipTrIdentityNumber { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string GuardianshipWorkplaceName { get; set; }
        public string GuardianshipJobName { get; set; }
        public string GuardianshipFatherName { get; set; }
        public string GuardianshipMotherName { get; set; }
        public string GuardianshipBirthPlace { get; set; }
        public DateTime? GuardianshipBirthDate { get; set; }
        public BloodGroups? GuardianshipBloodGroup { get; set; }
        public string GuardianshipHomePhone { get; set; }
        public string GuardianshipWorkplacePhoneInternal1 { get; set; }
        public string GuardianshipWorkplacePhoneInternal2 { get; set; }
        public string GuardianshipMobilePhone1 { get; set; }
        public string GuardianshipMobilePhone2 { get; set; }
        public string GuardianshipHomeAddress { get; set; }
        public string GuardianshipHomeAddressDistrictName { get; set; }
        public string GuardianshipHomeAddressProvinceName { get; set; }
        public string GuardianshipWorkplaceAddress { get; set; }
        public string GuardianshipWorkplaceAddressDistrictName { get; set; }
        public string GuardianshipWorkplaceAddressProvinceName { get; set; }
        public string GuardianshipIbanNumber { get; set; }
        public string GuardianshipCardNumber { get; set; }
        public string GuardianshipWebAddress { get; set; }
        public string GuardianshipEMail { get; set; }
        public decimal GrossService { get; set; }
        public decimal ShortTermDeductedService { get; set; }
        public decimal NetService { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        public decimal NetPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Open { get; set; }
        public decimal Cheque { get; set; }
        public decimal Cash { get; set; }
        public decimal Epos { get; set; }
        public decimal Sps { get; set; }
        public decimal Pos { get; set; }
        public decimal Indenture { get; set; }
        public decimal SumOfPay { get; set; }
        public decimal Collected { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Refund { get; set; }
        public decimal PaymentBack { get; set; }
        public decimal NetPayment { get; set; }
        public decimal Remaining { get; set; }
    }

    public class TakenServiceReportList
    {
        public long StudentId { get; set; }
        public long AccrueId { get; set; }
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentNumber { get; set; }
        public string SchoolNumber { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public string ClassName { get; set; }
        public string ComesFromSchool { get; set; }
        public string QuotaType { get; set; }
        public string ForeignLanguageName { get; set; }
        public string GuideName { get; set; }
        public string IncentName { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string BranchName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string GuardianshipWorkplaceName { get; set; }
        public string GuardianshipJobName { get; set; }
    }

    public class NetPriceReportList
    {
        public long StudentId { get; set; }
        public long AccrueId { get; set; }
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentNumber { get; set; }
        public string SchoolNumber { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public string ClassName { get; set; }
        public string ComesFromSchool { get; set; }
        public string QuotaType { get; set; }
        public string ForeignLanguageName { get; set; }
        public string GuideName { get; set; }
        public string IncentName { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string BranchName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string GuardianshipWorkplaceName { get; set; }
        public string GuardianshipJobName { get; set; }
        public decimal GrossService { get; set; }
        public decimal ShortTermDeductedService { get; set; }
        public decimal NetService { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        public decimal NetPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
    }

    public class PriceAndPaymentReportList
    {
        public long StudentId { get; set; }
        public long AccrueId { get; set; }
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentNumber { get; set; }
        public string SchoolNumber { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public string ClassName { get; set; }
        public string ComesFromSchool { get; set; }
        public string QuotaType { get; set; }
        public string ForeignLanguageName { get; set; }
        public string GuideName { get; set; }
        public string IncentName { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string BranchName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string GuardianshipWorkplaceName { get; set; }
        public string GuardianshipJobName { get; set; }
        public decimal GrossService { get; set; }
        public decimal ShortTermDeductedService { get; set; }
        public decimal NetService { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        public decimal NetPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Open { get; set; }
        public decimal Cheque { get; set; }
        public decimal Cash { get; set; }
        public decimal Epos { get; set; }
        public decimal Sps { get; set; }
        public decimal Pos { get; set; }
        public decimal Indenture { get; set; }
        public decimal SumOfPay { get; set; }
        public decimal Collected { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Refund { get; set; }
        public decimal PaymentBack { get; set; }
        public decimal NetPayment { get; set; }
        public decimal Remaining { get; set; }
    }

    public class DiscountDistributionReportList
    {
        public long StudentId { get; set; }
        public long AccrueId { get; set; }
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentNumber { get; set; }
        public string SchoolNumber { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public string ClassName { get; set; }
        public string ComesFromSchool { get; set; }
        public string QuotaType { get; set; }
        public string ForeignLanguageName { get; set; }
        public string GuideName { get; set; }
        public string IncentName { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string BranchName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string GuardianshipKinshipName { get; set; }
        public string GuardianshipVocationName { get; set; }
        public string GuardianshipWorkplaceName { get; set; }
        public string GuardianshipJobName { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
    }

    public class VocationalGroupReportList
    {
        public string BranchName { get; set; }
        public string VocationName { get; set; }
        public int RenewedEnrollment { get; set; }
        public int NewEnrollment  { get; set; }
        public int TransferEnrollment  { get; set; }
        public int SumOfEnrollment { get; set; }
        public decimal GrossService { get; set; }
        public decimal ShortTermDeductedService { get; set; }
        public decimal NetService { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        public decimal Open { get; set; }
        public decimal Cheque { get; set; }
        public decimal Cash { get; set; }
        public decimal Epos { get; set; }
        public decimal Sps { get; set; }
        public decimal Pos { get; set; }
        public decimal Indenture { get; set; }
        public decimal SumOfPay { get; set; }
        public decimal Collected { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Refund { get; set; }
        public decimal PaymentBack { get; set; }
    }

    public class MonthlyEnrollmentReportList
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public int RenewedEnrollment { get; set; }
        public int NewEnrollment  { get; set; }
        public int TransferEnrollment  { get; set; }
        public int SumOfEnrollment { get; set; }
        public decimal GrossService { get; set; }
        public decimal ShortTermDeductedService { get; set; }
        public decimal NetService { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        public decimal Open { get; set; }
        public decimal Cheque { get; set; }
        public decimal Cash { get; set; }
        public decimal Epos { get; set; }
        public decimal Sps { get; set; }
        public decimal Pos { get; set; }
        public decimal Indenture { get; set; }
        public decimal SumOfPay { get; set; }
        public decimal Collected { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Refund { get; set; }
        public decimal PaymentBack { get; set; }
    }
    
    public class IncomeDistributionReportList
    {
        public int Year { get; set; }
        public Months Month { get; set; }
        public decimal Open { get; set; }
        public decimal Cheque { get; set; }
        public decimal Cash { get; set; }
        public decimal Epos { get; set; }
        public decimal Sps { get; set; }
        public decimal Pos { get; set; }
        public decimal Indenture { get; set; }
        public decimal SumOfPay { get; set; }
        public decimal Collected { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Refund { get; set; }
        public int NumberOfInstallment { get; set; }
    }

    public class PriceAveragesReportList
    {
        public string BranchName { get; set; }
        public string ClassGroupName { get; set; }
        public string ClassName { get; set; }
        public string BranchGroupName { get; set; }
        public int? BranchRowNumber { get; set; }
        public int UnpaidStudent { get; set; }
        public int PaidStudent  { get; set; }
        public int NumberOfClass  { get; set; }
        public decimal GrossService { get; set; }
        public decimal ShortTermDeductedService { get; set; }
        public decimal NetService { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        
    }

    public class PaymentDocumentsReportList
    {
        public long AccrueId { get; set; }
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentBranchName { get; set; }
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string ClassGroupName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string DocumentBranchName { get; set; }
        public int WalletNumber { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime AccountTransferDate { get; set; }
        public decimal Price { get; set; }
        public decimal Refund { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Collected { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Remaining { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public byte BlockedDay { get; set; }
        public string BankAccountName { get; set; }
        public string TrackNumber { get; set; }
        public string Statement { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastProcessPlace { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
    }
    
    public class CollectReportList
    {
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentBranchName { get; set; }
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string ClassGroupName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string DocumentBranchName { get; set; }
        public int WalletNumber { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime AccountTransferDate { get; set; }
        public decimal Price { get; set; }
        public decimal PriceBeforeTransaction { get; set; }
        public decimal TransactionPrice { get; set; }
        public decimal Remaining { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public byte BlockedDay { get; set; }
        public string BankAccountName { get; set; }
        public string TrackNumber { get; set; }
        public string Statement { get; set; }
        public long ReceiptId { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public ReceiptType ReceiptType { get; set; }
        public ReceiptAccountType ReceiptAccountType { get; set; }
        public string ProcessPlace { get; set; }
        public string DebtCollector { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
    }

    public class OverdueReceivablesReportList
    {
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public string StudentBranchName { get; set; }
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public string ClassGroupName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string DocumentBranchName { get; set; }
        public int WalletNumber { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime AccountTransferDate { get; set; }
        public decimal Price { get; set; }
        public decimal Refund { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Collected { get; set; }
        public decimal OnCollect { get; set; }
        public decimal Remaining { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public byte BlockedDay { get; set; }
        public string BankAccountName { get; set; }
        public string TrackNumber { get; set; }
        public string Statement { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastProcessPlace { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public string GuardianshipName { get; set; }
        public string GuardianshipLastname { get; set; }
        public string Kinship { get; set; }
        public string Vocation { get; set; }
        public string HomePhone { get; set; }
        public string WorkplacePhoneInternal1 { get; set; }
        public string WorkplacePhoneInternal2 { get; set; }
        public string MobilePhone1 { get; set; }
        public string MobilePhone2 { get; set; }
        public string Workplace { get; set; }
        public string Job { get; set; }
    }
}