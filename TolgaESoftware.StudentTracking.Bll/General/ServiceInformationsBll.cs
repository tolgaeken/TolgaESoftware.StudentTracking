using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class ServiceInformationsBll : BaseActionBll<ServiceInformations, StudentTrackingContext>, IBaseActionSelectBll<ServiceInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<ServiceInformations, bool>> filter)
        {
            return List(filter, p => new ServiceInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                ServiceId = p.ServiceId,
                ServiceName = p.Cancelled ? p.Service.ServiceName + " - ( ««« İptal Edildi »»» )" : p.Service.ServiceName,
                ServiceTypeId = p.ServiceTypeId,
                ServiceTypeEnum = p.ServiceType.ServiceTypeEnum,
                SchoolBusId = p.SchoolBusId,
                SchoolBusName = p.SchoolBus.SchoolBusName,
                TransactionDate = p.TransactionDate,
                StartDate = p.StartDate,
                GrossPrice = p.GrossPrice,
                ShortTermDeductedPrice = p.ShortTermDeductedPrice,
                NetPrice = p.NetPrice,
                Cancelled = p.Cancelled,
                NumberOfEducationTermDateDays = p.NumberOfEducationTermDateDays,
                NumberOfTakenServiceDays = p.NumberOfTakenServiceDays,
                DailyPrice = p.DailyPrice,
                CancellationDate = p.CancellationDate,
                CancellationReasonId = p.CancellationReasonId,
                CancellationReasonName = p.CancellationReason.CancellationReasonName,
                SchoolToGoesId = p.SchoolToGoesId,
                SchoolToGoesName = p.SchoolToGoes.SchoolName,
                CancellationStatement = p.CancellationStatement
            }).OrderByDescending(p => p.Cancelled)
                .ThenBy(p => p.CancellationDate)
                .ThenBy(p => p.Id).ToList();
        }

        public IEnumerable<BillTakenServicesList> BillPlanList(Expression<Func<ServiceInformations, bool>> filter)
        {
            return List(filter, p => new
            {
                ServiceInfo = p,
                GuardianshipInformations = p.Accrue.ContactInformations.Where(c => c.Guardianship).Select(c => new
                {
                    c.Contact,
                    c.Kinship
                }).FirstOrDefault(),

                ServiceInformations = p.Accrue.ServiceInformations.Where(c => c.ServiceId == p.ServiceId).GroupBy(c => c.ServiceId).DefaultIfEmpty().Select(c => new
                {
                    ServiceName = c.Select(z => z.Service.ServiceName).FirstOrDefault(),
                    GrossService = c.Select(z => z.GrossPrice).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedService = c.Select(z => z.ShortTermDeductedPrice).DefaultIfEmpty(0).Sum(),
                    NetService = c.Select(z => z.NetPrice).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                DiscountInformations = p.Accrue.DiscountInformations.Where(c => c.ServiceId == p.ServiceId).GroupBy(c => c.ServiceId).DefaultIfEmpty().Select(c => new
                {
                    GrossDiscount = c.Select(z => z.GrossDiscount).DefaultIfEmpty(0).Sum(),
                    ShortTermDeductedDiscount = c.Select(z => z.ShortTermDeductedDiscount).DefaultIfEmpty(0).Sum(),
                    NetDiscount = c.Select(z => z.NetDiscount).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

            }).Select(p => new BillTakenServicesList
            {
                ServiceId = p.ServiceInfo.ServiceId,
                AccrueId = p.ServiceInfo.AccrueId,
                SchoolNumber = p.ServiceInfo.Accrue.Code,
                Name = p.ServiceInfo.Accrue.Student.Name,
                Lastname = p.ServiceInfo.Accrue.Student.Lastname,
                ClassName = p.ServiceInfo.Accrue.Class.ClassName,
                GuardianshipName = p.GuardianshipInformations.Contact.Name,
                GuardianshipLastname = p.GuardianshipInformations.Contact.Lastname,
                GuardianshipKinshipName = p.GuardianshipInformations.Kinship.KinshipName,
                GuardianshipVocationName = p.GuardianshipInformations.Contact.Vocation.VocationName,
                ServiceName = p.ServiceInformations.ServiceName,
                GrossPrice = p.ServiceInformations.NetService,
                Discount = p.DiscountInformations.NetDiscount,
                NetPrice = p.ServiceInformations.NetService - p.DiscountInformations.NetDiscount
            }).OrderBy(p => p.ServiceName).Distinct().ToList();
        }
    }
}