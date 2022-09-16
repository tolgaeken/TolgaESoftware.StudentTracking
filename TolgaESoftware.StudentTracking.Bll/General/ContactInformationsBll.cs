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
    public class ContactInformationsBll : BaseActionBll<ContactInformations, StudentTrackingContext>, IBaseActionSelectBll<ContactInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<ContactInformations, bool>> filter)
        {
            return List(filter, p => new ContactInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                ContactId = p.ContactId,
                TrIdentityNumber = p.Contact.TrIdentityNumber,
                Name = p.Contact.Name,
                Lastname = p.Contact.Lastname,
                HomePhone = p.Contact.HomePhone,
                WorkplacePhone1 = p.Contact.WorkplacePhone1,
                WorkplacePhone2 = p.Contact.WorkplacePhone2,
                InternalPhone1 = p.Contact.InternalPhone1,
                InternalPhone2 = p.Contact.InternalPhone2,
                MobilePhone1 = p.Contact.MobilePhone1,
                MobilePhone2 = p.Contact.MobilePhone2,
                HomeAddress = p.Contact.HomeAddress,
                HomeAddressProvinceName = p.Contact.HomeAddressProvince.ProvinceName,
                HomeAddressDistrictName = p.Contact.HomeAddressDistrict.DistrictName,
                WorkplaceAddress = p.Contact.WorkplaceAddress,
                WorkplaceAddressProvinceName = p.Contact.WorkplaceAddressProvince.ProvinceName,
                WorkplaceAddressDistrictName = p.Contact.WorkplaceAddressDistrict.DistrictName,
                KinshipId = p.KinshipId,
                KinshipName = p.Kinship.KinshipName,
                VocationName = p.Contact.Vocation.VocationName,
                WorkplaceName = p.Contact.Workplace.WorkplaceName,
                JobName = p.Contact.Job.JobName,
                Guardianship = p.Guardianship,
                BillingAddress = p.BillingAddress
            }).ToList();
        }
    }
}