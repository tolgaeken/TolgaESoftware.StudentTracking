using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General.FormReports
{
    public class NetPriceReportBll : BaseBll<Accrue, StudentTrackingContext>
    {
        public IEnumerable<NetPriceReportList> List(Expression<Func<Accrue, bool>> filter, IEnumerable<long> serviceTypes)
        {
            return BaseList(filter, p => new
            {
                Accrue = p,

                GuardianshipInformations = p.ContactInformations.Where(c => c.Guardianship).Select(c => new
                {
                    c.Contact,
                    c.Kinship
                }).FirstOrDefault(),

                ServiceInformations = p.ServiceInformations.Where(c => serviceTypes.Contains(c.ServiceId)).GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    GrossService = c.Select(z => z.GrossPrice).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedService = c.Select(z => z.ShortTermDeductedPrice).DefaultIfEmpty(0).Sum(),
                    NetService = c.Select(z => z.NetPrice).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),

                DiscountInformations = p.DiscountInformations.Where(c => serviceTypes.Contains(c.ServiceId)).GroupBy(c => c.AccrueId).DefaultIfEmpty().Select(c => new
                {
                    GrossDiscount = c.Select(z => z.GrossDiscount).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedDiscount = c.Select(z => z.ShortTermDeductedDiscount).DefaultIfEmpty(0).Sum(),
                    NetDiscount = c.Select(z => z.NetDiscount).DefaultIfEmpty(0).Sum()
                }).FirstOrDefault(),


            }).Select(p => new NetPriceReportList
            {
                StudentId = p.Accrue.StudentId,
                AccrueId = p.Accrue.Id,
                StudentNumber = p.Accrue.Code,
                SchoolNumber = p.Accrue.SchoolNumber,
                TrIdentityNumber = p.Accrue.Student.TrIdentityNumber,
                Name = p.Accrue.Student.Name,
                Lastname = p.Accrue.Student.Lastname,
                Gender = p.Accrue.Student.Gender,
                Phone = p.Accrue.Student.Phone,
                RegistrationDate = p.Accrue.RegistrationDate,
                CancelStatus = p.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                EnrollmentType = p.Accrue.EnrollmentType,
                EnrollmentStatus = p.Accrue.EnrollmentStatus,
                ClassName = p.Accrue.Class.ClassName,
                ComesFromSchool = p.Accrue.ComesFromSchool.SchoolName,
                QuotaType = p.Accrue.Quota.QuotaName,
                ForeignLanguageName = p.Accrue.ForeignLanguage.ForeignLanguageName,
                GuideName = p.Accrue.Guide.GuideNameLastname,
                IncentName = p.Accrue.Incent.IncentName,
                BranchId = p.Accrue.BranchId,
                BranchName = p.Accrue.Branch.BranchName,
                TermId = p.Accrue.TermId,
                SpecialCode1 = p.Accrue.SpecialCode1.SpecialCodeName,
                SpecialCode2 = p.Accrue.SpecialCode2.SpecialCodeName,
                SpecialCode3 = p.Accrue.SpecialCode3.SpecialCodeName,
                SpecialCode4 = p.Accrue.SpecialCode4.SpecialCodeName,
                SpecialCode5 = p.Accrue.SpecialCode5.SpecialCodeName,
                GuardianshipName = p.GuardianshipInformations.Contact.Name,
                GuardianshipLastname = p.GuardianshipInformations.Contact.Lastname,
                GuardianshipKinshipName = p.GuardianshipInformations.Kinship.KinshipName,
                GuardianshipVocationName = p.GuardianshipInformations.Contact.Vocation.VocationName,
                GuardianshipWorkplaceName = p.GuardianshipInformations.Contact.Workplace.WorkplaceName,
                GuardianshipJobName = p.GuardianshipInformations.Contact.Job.JobName,
                GrossService = p.ServiceInformations.GrossService,
                ShortTermDeductedService = p.ServiceInformations.ShortTermDeductedService,
                NetService = p.ServiceInformations.NetService,
                GrossDiscount = p.DiscountInformations.GrossDiscount,
                ShortTermDeductedDiscount = p.DiscountInformations.ShortTermDeductedDiscount,
                NetDiscount = p.DiscountInformations.NetDiscount,
                NetPrice = p.ServiceInformations.NetService - p.DiscountInformations.NetDiscount,
                DiscountPercentage = p.ServiceInformations.NetService == 0 ? 0 : p.DiscountInformations.NetDiscount / p.ServiceInformations.NetService * 100,
            }).OrderBy(p => p.StudentNumber).ToList();
        }
    }
}