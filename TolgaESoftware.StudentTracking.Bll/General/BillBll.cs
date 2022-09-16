using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class BillBll : BaseActionBll<Bill, StudentTrackingContext>, IBaseActionSelectBll<Bill>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<Bill, bool>> filter)
        {
            return List(filter, p => new BillPlanList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                Statement = p.Statement,
                PlanDate = p.PlanDate,
                PlanPrice = p.PlanPrice,
                PlanDiscountPrice = p.PlanDiscountPrice,
                PlanNetPrice = p.PlanNetPrice,
                BillNumber = p.BillNumber,
                AccrueDate = p.AccrueDate,
                AccruePrice = p.AccruePrice,
                AccrueDiscountPrice = p.AccrueDiscountPrice,
                AccrueNetPrice = p.AccrueNetPrice
            }).OrderBy(p=>p.PlanDate).ToList();
        }

        public IEnumerable<BaseActionEntity> BillAccrueList(Expression<Func<Bill, bool>> filter)
        {
            return List(filter, p => new
            {
                Bill = p,
                GuardianshipInformations = p.Accrue.ContactInformations.Where(c=>c.Guardianship).Select(z=> new
                {
                    z.Contact,
                    z.Kinship
                }).FirstOrDefault()

            }).Select(p => new BillPlanList
            {
                Id = p.Bill.Id,
                AccrueId = p.Bill.AccrueId,
                SchoolNumber = p.Bill.Accrue.Code,
                TrIdentityNumber = p.Bill.Accrue.Student.TrIdentityNumber,
                Name = p.Bill.Accrue.Student.Name,
                Lastname = p.Bill.Accrue.Student.Lastname,
                ClassName = p.Bill.Accrue.Class.ClassName,
                RegistrationDate = p.Bill.Accrue.RegistrationDate,
                EnrollmentType = p.Bill.Accrue.EnrollmentType,
                EnrollmentStatus = p.Bill.Accrue.EnrollmentStatus,
                CancelStatus = p.Bill.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                GuardianshipTrIdentityNumber = p.GuardianshipInformations.Contact.TrIdentityNumber,
                GuardianshipName = p.GuardianshipInformations.Contact.Name,
                GuardianshipLastname = p.GuardianshipInformations.Contact.Lastname,
                GuardianshipKinshipName = p.GuardianshipInformations.Kinship.KinshipName,
                GuardianshipVocationName = p.GuardianshipInformations.Contact.Vocation.VocationName,

                GuardianshipHomeAddress = p.GuardianshipInformations.Contact.HomeAddress,
                GuardianshipHomeAddressDistrictId = p.GuardianshipInformations.Contact.HomeAddressDistrictId,
                GuardianshipHomeAddressDistrictName = p.GuardianshipInformations.Contact.HomeAddressDistrict.DistrictName,
                GuardianshipHomeAddressProvinceId = p.GuardianshipInformations.Contact.HomeAddressProvinceId,
                GuardianshipHomeAddressProvinceName = p.GuardianshipInformations.Contact.HomeAddressProvince.ProvinceName,

                GuardianshipWorkplaceAddress = p.GuardianshipInformations.Contact.WorkplaceAddress,
                GuardianshipWorkplaceAddressDistrictId = p.GuardianshipInformations.Contact.WorkplaceAddressDistrictId,
                GuardianshipWorkplaceAddressDistrictName = p.GuardianshipInformations.Contact.WorkplaceAddressDistrict.DistrictName,
                GuardianshipWorkplaceAddressProvinceId = p.GuardianshipInformations.Contact.WorkplaceAddressProvinceId,
                GuardianshipWorkplaceAddressProvinceName = p.GuardianshipInformations.Contact.WorkplaceAddressProvince.ProvinceName,

                SpecialCode1 = p.Bill.Accrue.SpecialCode1.SpecialCodeName,
                SpecialCode2 = p.Bill.Accrue.SpecialCode2.SpecialCodeName,
                SpecialCode3 = p.Bill.Accrue.SpecialCode3.SpecialCodeName,
                SpecialCode4 = p.Bill.Accrue.SpecialCode4.SpecialCodeName,
                SpecialCode5 = p.Bill.Accrue.SpecialCode5.SpecialCodeName,

                Statement = p.Bill.Statement,
                PlanDate = p.Bill.PlanDate,
                PlanPrice = p.Bill.PlanPrice,
                PlanDiscountPrice = p.Bill.PlanDiscountPrice,
                PlanNetPrice = p.Bill.PlanNetPrice,
                BillNumber = p.Bill.BillNumber,
                AccrueDate = p.Bill.AccrueDate,
                AccruePrice = p.Bill.AccruePrice,
                AccrueDiscountPrice = p.Bill.AccrueDiscountPrice,
                AccrueNetPrice = p.Bill.AccrueNetPrice,
                TaxPercentage = p.Bill.TaxPercentage,
                TaxExcludedPrice = p.Bill.TaxExcludedPrice,
                TaxPrice = p.Bill.TaxPrice,
                SumOfPrice = p.Bill.SumOfPrice,
                PriceAsText = p.Bill.PriceAsText,
                TaxType = p.Bill.TaxType,
                BillAddress = p.Bill.BillAddress,
                BillAddressDistrictName = p.Bill.BillAddressDistrict.DistrictName,
                BillAddressProvinceName = p.Bill.BillAddressProvince.ProvinceName,
                Branch = p.Bill.Accrue.Branch.BranchName,
                Term = p.Bill.Accrue.Term.TermName
            }).OrderBy(p=>p.ClassName).ToList();
        }

        public IEnumerable<DateTime> BillTermList(Expression<Func<Bill, bool>> filter)
        {
            return List(filter, p => new
            {
                p.PlanDate
                
            }).GroupBy(p=>p.PlanDate).Select(p=>p.Key).ToList();
        }

        public int MaxBillNumber(Expression<Func<Bill, bool>> filter)
        {
            return List(filter, p => new
            {
                p.BillNumber
            }).DefaultIfEmpty().Max(p=>p.BillNumber??0);
        }
    }
}
