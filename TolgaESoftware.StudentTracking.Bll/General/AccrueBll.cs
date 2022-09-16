using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class AccrueBll : BaseGeneralBll<Accrue>, IBaseCommonBll
    {
        public AccrueBll() : base(CardType.Accrue) { }
        public AccrueBll(Control control) : base(control, CardType.Accrue) { }

        public override BaseEntity Single(Expression<Func<Accrue, bool>> filter)
        {
            return BaseSingle(filter, p => new AccrueSingle
            {
                Id = p.Id,
                Code = p.Code,
                StudentId = p.StudentId,
                TrIdentityNumber = p.Student.TrIdentityNumber,
                Name = p.Student.Name,
                Lastname = p.Student.Lastname,
                FatherName = p.Student.FatherName,
                MotherName = p.Student.MotherName,
                SchoolNumber = p.SchoolNumber,
                RegistrationDate = p.RegistrationDate,
                EnrollmentType = p.EnrollmentType,
                EnrollmentStatus = p.EnrollmentStatus,
                ClassId = p.ClassId,
                ClassName = p.Class.ClassName,
                ComesFromSchoolId = p.ComesFromSchoolId,
                ComesFromSchoolName = p.ComesFromSchool.SchoolName,
                QuotaId = p.QuotaId,
                QuotaName = p.Quota.QuotaName,
                ForeignLanguageId = p.ForeignLanguageId,
                ForeignLanguageName = p.ForeignLanguage.ForeignLanguageName,
                GuideId = p.GuideId,
                GuideName = p.Guide.GuideNameLastname,
                IncentId = p.IncentId,
                IncentName = p.Incent.IncentName,
                NextTermEnrollmentStatus = p.NextTermEnrollmentStatus,
                NextTermEnrollmentStatusStatement = p.NextTermEnrollmentStatusStatement,
                SpecialCode1Id = p.SpecialCode1Id,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Id = p.SpecialCode2Id,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                SpecialCode3Id = p.SpecialCode3Id,
                SpecialCode3Name = p.SpecialCode3.SpecialCodeName,
                SpecialCode4Id = p.SpecialCode4Id,
                SpecialCode4Name = p.SpecialCode4.SpecialCodeName,
                SpecialCode5Id = p.SpecialCode5Id,
                SpecialCode5Name = p.SpecialCode5.SpecialCodeName,
                BranchId = p.BranchId,
                TermId = p.TermId,
                Status = p.Status
            });
        }

        public StudentReport SingleDetail(Expression<Func<Accrue, bool>> filter)
        {
            return BaseSingle(filter, p => new StudentReport
            {
                StudentNumber = p.Code,
                SchoolNumber = p.SchoolNumber,
                TrIdentityNumber = p.Student.TrIdentityNumber,
                Name = p.Student.Name,
                Lastname = p.Student.Lastname,
                NameLastname = p.Student.Name + " " + p.Student.Lastname,
                Gender = p.Student.Gender,
                Phone = p.Student.Phone,
                BloodGroups = p.Student.BloodGroups,
                FatherName = p.Student.FatherName,
                MotherName = p.Student.MotherName,
                BirthPlace = p.Student.BirthPlace,
                BirthDate = p.Student.BirthDate,
                IdentitySerialNumber = p.Student.IdentitySerialNumber,
                IdentityRowNumber = p.Student.IdentityRowNumber,
                IdentityProvinceName = p.Student.IdentityProvince.ProvinceName,
                IdentityDistrictName = p.Student.IdentityDistrict.DistrictName,
                IdentityNeighborhood = p.Student.IdentityNeighborhood,
                IdentityBindingNumber = p.Student.IdentityBindingNumber,
                IdentityFamilyRowNumber = p.Student.IdentityFamilyRowNumber,
                IdentityPersonRowNumber = p.Student.IdentityPersonRowNumber,
                IdentityGivenPlace = p.Student.IdentityGivenPlace,
                IdentityGivenReason = p.Student.IdentityGivenReason,
                IdentityRegisterNumber = p.Student.IdentityRegisterNumber,
                IdentityGivenDate = p.Student.IdentityGivenDate,
                RegistrationDate = p.RegistrationDate,
                EnrollmentType = p.EnrollmentType,
                EnrollmentStatus = p.EnrollmentStatus,
                Class = p.Class.ClassName,
                ComesFromSchool = p.ComesFromSchool.SchoolName,
                Quota = p.Quota.QuotaName,
                ForeignLanguage = p.ForeignLanguage.ForeignLanguageName,
                Guide = p.Guide.GuideNameLastname,
                Incent = p.Incent.IncentName,
                TermName = p.Term.TermName,
                BranchName = p.Branch.BranchName,
                BranchAddress = p.Branch.Address,
                BranchAddressProvinceName = p.Branch.AddressProvince.ProvinceName,
                BranchAddressDistrictName = p.Branch.AddressDistrict.DistrictName,
                BranchPhoneNumber = p.Branch.Phone,
                BranchFax = p.Branch.Fax,
                BranchIbanNumber = p.Branch.IbanNumber,
                BranchLogo = p.Branch.Logo,

                GuardianshipInformations = p.ContactInformations.Where(c => c.Guardianship).Select(c => new ContactInformationsReport
                {
                    TrIdentityNumber = c.Contact.TrIdentityNumber,
                    Name = c.Contact.Name,
                    Lastname = c.Contact.Lastname,
                    NameLastname = c.Contact.Name + " " + c.Contact.Lastname,
                    HomePhone = c.Contact.HomePhone,
                    WorkplacePhone1 = c.Contact.WorkplacePhone1,
                    WorkplacePhone2 = c.Contact.WorkplacePhone2,
                    InternalPhone1 = c.Contact.InternalPhone1,
                    InternalPhone2 = c.Contact.InternalPhone2,
                    WorkplacePhoneInternal1 = c.Contact.WorkplacePhone1 + " / " + c.Contact.InternalPhone1,
                    WorkplacePhoneInternal2 = c.Contact.WorkplacePhone2 + " / " + c.Contact.InternalPhone2,
                    MobilePhone1 = c.Contact.MobilePhone1,
                    MobilePhone2 = c.Contact.MobilePhone2,
                    HomeAddress = c.Contact.HomeAddress,

                    HomeAddressProvinceName = c.Contact.HomeAddressProvince.ProvinceName,
                    HomeAddressDistrictName = c.Contact.HomeAddressDistrict.DistrictName,
                    HomeAddressProvinceDistrict = c.Contact.HomeAddress + " - " +
                                                    c.Contact.HomeAddressDistrict.DistrictName + " / " +
                                                    c.Contact.HomeAddressProvince.ProvinceName,

                    WorkplaceAddressProvinceName = c.Contact.WorkplaceAddressProvince.ProvinceName,
                    WorkplaceAddressDistrictName = c.Contact.WorkplaceAddressDistrict.DistrictName,
                    WorkplaceAddressProvinceDistrict = c.Contact.WorkplaceAddress + " - " +
                                                    c.Contact.WorkplaceAddressDistrict.DistrictName + " / " +
                                                    c.Contact.WorkplaceAddressProvince.ProvinceName,

                    KinshipName = c.Kinship.KinshipName,
                    VocationName = c.Contact.Vocation.VocationName,
                    WorkplaceName = c.Contact.Workplace.WorkplaceName,
                    JobName = c.Contact.Job.JobName

                }).FirstOrDefault(),

                MotherInformations = p.ContactInformations.Where(c => c.Kinship.KinshipName == "Anne").Select(c => new ContactInformationsReport
                {
                    TrIdentityNumber = c.Contact.TrIdentityNumber,
                    Name = c.Contact.Name,
                    Lastname = c.Contact.Lastname,
                    NameLastname = c.Contact.Name + " " + c.Contact.Lastname,
                    HomePhone = c.Contact.HomePhone,
                    WorkplacePhone1 = c.Contact.WorkplacePhone1,
                    WorkplacePhone2 = c.Contact.WorkplacePhone2,
                    InternalPhone1 = c.Contact.InternalPhone1,
                    InternalPhone2 = c.Contact.InternalPhone2,
                    WorkplacePhoneInternal1 = c.Contact.WorkplacePhone1 + " / " + c.Contact.InternalPhone1,
                    WorkplacePhoneInternal2 = c.Contact.WorkplacePhone2 + " / " + c.Contact.InternalPhone2,
                    MobilePhone1 = c.Contact.MobilePhone1,
                    MobilePhone2 = c.Contact.MobilePhone2,
                    HomeAddress = c.Contact.HomeAddress,

                    HomeAddressProvinceName = c.Contact.HomeAddressProvince.ProvinceName,
                    HomeAddressDistrictName = c.Contact.HomeAddressDistrict.DistrictName,
                    HomeAddressProvinceDistrict = c.Contact.HomeAddress + " - " +
                                                   c.Contact.HomeAddressDistrict.DistrictName + " / " +
                                                   c.Contact.HomeAddressProvince.ProvinceName,

                    WorkplaceAddressProvinceName = c.Contact.WorkplaceAddressProvince.ProvinceName,
                    WorkplaceAddressDistrictName = c.Contact.WorkplaceAddressDistrict.DistrictName,
                    WorkplaceAddressProvinceDistrict = c.Contact.WorkplaceAddress + " - " +
                                                   c.Contact.WorkplaceAddressDistrict.DistrictName + " / " +
                                                   c.Contact.WorkplaceAddressProvince.ProvinceName,

                    KinshipName = c.Kinship.KinshipName,
                    VocationName = c.Contact.Vocation.VocationName,
                    WorkplaceName = c.Contact.Workplace.WorkplaceName,
                    JobName = c.Contact.Job.JobName

                }).FirstOrDefault(),

                FatherInformations = p.ContactInformations.Where(c => c.Kinship.KinshipName == "Baba").Select(c => new ContactInformationsReport
                {
                    TrIdentityNumber = c.Contact.TrIdentityNumber,
                    Name = c.Contact.Name,
                    Lastname = c.Contact.Lastname,
                    NameLastname = c.Contact.Name + " " + c.Contact.Lastname,
                    HomePhone = c.Contact.HomePhone,
                    WorkplacePhone1 = c.Contact.WorkplacePhone1,
                    WorkplacePhone2 = c.Contact.WorkplacePhone2,
                    InternalPhone1 = c.Contact.InternalPhone1,
                    InternalPhone2 = c.Contact.InternalPhone2,
                    WorkplacePhoneInternal1 = c.Contact.WorkplacePhone1 + " / " + c.Contact.InternalPhone1,
                    WorkplacePhoneInternal2 = c.Contact.WorkplacePhone2 + " / " + c.Contact.InternalPhone2,
                    MobilePhone1 = c.Contact.MobilePhone1,
                    MobilePhone2 = c.Contact.MobilePhone2,
                    HomeAddress = c.Contact.HomeAddress,

                    HomeAddressProvinceName = c.Contact.HomeAddressProvince.ProvinceName,
                    HomeAddressDistrictName = c.Contact.HomeAddressDistrict.DistrictName,
                    HomeAddressProvinceDistrict = c.Contact.HomeAddress + " - " +
                                                  c.Contact.HomeAddressDistrict.DistrictName + " / " +
                                                  c.Contact.HomeAddressProvince.ProvinceName,

                    WorkplaceAddressProvinceName = c.Contact.WorkplaceAddressProvince.ProvinceName,
                    WorkplaceAddressDistrictName = c.Contact.WorkplaceAddressDistrict.DistrictName,
                    WorkplaceAddressProvinceDistrict = c.Contact.WorkplaceAddress + " - " +
                                                  c.Contact.WorkplaceAddressDistrict.DistrictName + " / " +
                                                  c.Contact.WorkplaceAddressProvince.ProvinceName,

                    KinshipName = c.Kinship.KinshipName,
                    VocationName = c.Contact.Vocation.VocationName,
                    WorkplaceName = c.Contact.Workplace.WorkplaceName,
                    JobName = c.Contact.Job.JobName

                }).FirstOrDefault(),
            });
        }

        public BaseEntity SingleSummary(Expression<Func<Accrue, bool>> filter)
        {
            return BaseSingle(filter, p => p);
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Accrue, bool>> filter)
        {
            return BaseList(filter, p => new AccrueList
            {
                Id = p.Id,
                Code = p.Code,
                StudentId = p.StudentId,
                TrIdentityNumber = p.Student.TrIdentityNumber,
                Name = p.Student.Name,
                Lastname = p.Student.Lastname,
                FatherName = p.Student.FatherName,
                MotherName = p.Student.MotherName,
                SchoolNumber = p.SchoolNumber,
                RegistrationDate = p.RegistrationDate,
                EnrollmentType = p.EnrollmentType,
                EnrollmentStatus = p.EnrollmentStatus,
                ClassName = p.Class.ClassName,
                ComesFromSchoolName = p.ComesFromSchool.SchoolName,
                QuotaName = p.Quota.QuotaName,
                ForeignLanguageName = p.ForeignLanguage.ForeignLanguageName,
                GuideName = p.Guide.GuideNameLastname,
                IncentName = p.Incent.IncentName,
                NextTermEnrollmentStatus = p.NextTermEnrollmentStatus,
                NextTermEnrollmentStatusStatement = p.NextTermEnrollmentStatusStatement,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                SpecialCode3Name = p.SpecialCode3.SpecialCodeName,
                SpecialCode4Name = p.SpecialCode4.SpecialCodeName,
                SpecialCode5Name = p.SpecialCode5.SpecialCodeName,
                BranchName = p.Branch.BranchName,
                TermName = p.Term.TermName,
                Status = p.Status,

            }).OrderBy(p => p.Code).ToList();
        }

        public IEnumerable<BillList> BillAccrueList(Expression<Func<Accrue, bool>> filter)
        {
            return BaseList(filter, p => new
            {
                Accrue = p,
                GuardianshipInformations = p.ContactInformations.Where(c => c.Guardianship).Select(c => new
                {
                    c.Contact,
                    c.Kinship
                }).FirstOrDefault(),

                ServiceInformations = p.ServiceInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    NetService = c.Select(z => z.NetPrice).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                DiscountInformations = p.DiscountInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    NetDiscount = c.Select(z => z.NetDiscount).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                BillInformations = p.BillInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    Statement = c.Select(z => z.Statement).FirstOrDefault(),
                    PlanPrice = c.Select(z => z.PlanPrice).DefaultIfEmpty(0).Sum(),
                    PlanDiscountPrice = c.Select(z => z.PlanDiscountPrice).DefaultIfEmpty(0).Sum(),
                    PlanNetPrice = c.Select(z => z.PlanNetPrice).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

            }).Select(p => new BillList
            {
                Id = p.Accrue.Id,
                StudentNumber = p.Accrue.Code,
                Name = p.Accrue.Student.Name,
                Lastname = p.Accrue.Student.Lastname,
                ClassName = p.Accrue.Class.ClassName,
                RegistrationDate = p.Accrue.RegistrationDate,
                EnrollmentType = p.Accrue.EnrollmentType,
                EnrollmentStatus = p.Accrue.EnrollmentStatus,
                CancelStatus = p.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                GuardianshipName = p.GuardianshipInformations.Contact.Name,
                GuardianshipLastname = p.GuardianshipInformations.Contact.Lastname,
                GuardianshipKinshipName = p.GuardianshipInformations.Kinship.KinshipName,
                GuardianshipVocationName = p.GuardianshipInformations.Contact.Vocation.VocationName,
                ServicePrice = p.ServiceInformations.NetService,
                ServiceDiscount = p.DiscountInformations.NetDiscount,
                ServiceNetPrice = p.ServiceInformations.NetService - p.DiscountInformations.NetDiscount,
                PlanPrice = p.BillInformations.PlanPrice,
                PlanDiscount = p.BillInformations.PlanDiscountPrice,
                PlanNetPrice = p.BillInformations.PlanNetPrice,
                SpecialCode1 = p.Accrue.SpecialCode1.SpecialCodeName,
                SpecialCode2 = p.Accrue.SpecialCode2.SpecialCodeName,
                SpecialCode3 = p.Accrue.SpecialCode3.SpecialCodeName,
                SpecialCode4 = p.Accrue.SpecialCode4.SpecialCodeName,
                SpecialCode5 = p.Accrue.SpecialCode5.SpecialCodeName,
            }).OrderBy(p => p.StudentNumber).ToList();
        }

        public IEnumerable<StudentAccrueList> StudentAccrueList(Expression<Func<Accrue, bool>> filter)
        {
            return BaseList(filter, p => new
            {
                Accrue = p,

                ServiceInformations = p.ServiceInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    GrossService = c.Select(z => z.GrossPrice).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedService = c.Select(z => z.ShortTermDeductedPrice).DefaultIfEmpty(0).Sum(),
                    NetService = c.Select(z => z.NetPrice).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                DiscountInformations = p.DiscountInformations.GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    GrossDiscount = c.Select(z => z.GrossDiscount).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedDiscount = c.Select(z => z.ShortTermDeductedDiscount).DefaultIfEmpty(0).Sum(),
                    NetDiscount = c.Select(z => z.NetDiscount).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault()

            }).Select(p => new StudentAccrueList
            {
                AccrueId = p.Accrue.Id,
                BranchId = p.Accrue.BranchId,
                BranchName = p.Accrue.Branch.BranchName,
                TermId = p.Accrue.TermId,
                TermName = p.Accrue.Term.TermName,
                GrossService = p.ServiceInformations.GrossService,
                ShortTermDeductedService = p.ServiceInformations.ShortTermDeductedService,
                NetService = p.ServiceInformations.NetService,
                GrossDiscount = p.DiscountInformations.GrossDiscount,
                ShortTermDeductedDiscount = p.DiscountInformations.ShortTermDeductedDiscount,
                NetDiscount = p.DiscountInformations.NetDiscount,
                NetPrice = p.ServiceInformations.NetService - p.DiscountInformations.NetDiscount,
                DiscountPercentage = p.ServiceInformations.NetService == 0 ? 0 : p.DiscountInformations.NetDiscount / p.ServiceInformations.NetService * 100
            }).OrderBy(p => p.AccrueId).ToList();
        }
    }
}