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
    public class ContactBll : BaseGeneralBll<Contact>, IBaseGeneralBll, IBaseCommonBll
    {
        public ContactBll() : base(CardType.Contact) { }
        public ContactBll(Control control) : base(control, CardType.Contact) { }

        public override BaseEntity Single(Expression<Func<Contact, bool>> filter)
        {
            return BaseSingle(filter, p => new ContactSingle
            {
                Id = p.Id,
                Code = p.Code,
                TrIdentityNumber = p.TrIdentityNumber,
                Name = p.Name,
                Lastname = p.Lastname,
                FatherName = p.FatherName,
                MotherName = p.MotherName,
                BirthPlace = p.BirthPlace,
                BirthDate = p.BirthDate,
                BloodGroups = p.BloodGroups,
                IdentitySerialNumber = p.IdentitySerialNumber,
                IdentityRowNumber = p.IdentityRowNumber,
                IdentityProvinceId = p.IdentityProvinceId,
                IdentityProvinceName = p.IdentityProvince.ProvinceName,
                IdentityDistrictId = p.IdentityDistrictId,
                IdentityDistrictName = p.IdentityDistrict.DistrictName,
                IdentityNeighborhood = p.IdentityNeighborhood,
                IdentityBindingNumber = p.IdentityBindingNumber,
                IdentityFamilyRowNumber = p.IdentityFamilyRowNumber,
                IdentityPersonRowNumber = p.IdentityPersonRowNumber,
                IdentityGivenPlace = p.IdentityGivenPlace,
                IdentityGivenReason = p.IdentityGivenReason,
                IdentityRegisterNumber = p.IdentityRegisterNumber,
                IdentityGivenDate = p.IdentityGivenDate,
                HomePhone = p.HomePhone,
                WorkplacePhone1 = p.WorkplacePhone1,
                WorkplacePhone2 = p.WorkplacePhone2,
                InternalPhone1 = p.InternalPhone1,
                InternalPhone2 = p.InternalPhone2,
                MobilePhone1 = p.MobilePhone1,
                MobilePhone2 = p.MobilePhone2,
                Web = p.Web,
                EMail = p.EMail,
                HomeAddress = p.HomeAddress,
                HomeAddressProvinceId = p.HomeAddressProvinceId,
                HomeAddressProvinceName = p.HomeAddressProvince.ProvinceName,
                HomeAddressDistrictId = p.HomeAddressDistrictId,
                HomeAddressDistrictName = p.HomeAddressDistrict.DistrictName,
                WorkplaceAddress = p.WorkplaceAddress,
                WorkplaceAddressProvinceId = p.WorkplaceAddressProvinceId,
                WorkplaceAddressProvinceName = p.WorkplaceAddressProvince.ProvinceName,
                WorkplaceAddressDistrictId = p.WorkplaceAddressDistrictId,
                WorkplaceAddressDistrictName = p.WorkplaceAddressDistrict.DistrictName,
                VocationId = p.VocationId,
                VocationName = p.Vocation.VocationName,
                WorkplaceId = p.WorkplaceId,
                WorkplaceName = p.Workplace.WorkplaceName,
                JobId = p.JobId,
                JobName = p.Job.JobName,
                IbanNumber = p.IbanNumber,
                CardNumber = p.CardNumber,
                SpecialCode1Id = p.SpecialCode1Id,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Id = p.SpecialCode2Id,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement,
                Status = p.Status,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Contact, bool>> filter)
        {
            return BaseList(filter, p => new ContactList
            {
                Id = p.Id,
                Code = p.Code,
                TrIdentityNumber = p.TrIdentityNumber,
                Name = p.Name,
                Lastname = p.Lastname,
                FatherName = p.FatherName,
                MotherName = p.MotherName,
                BirthPlace = p.BirthPlace,
                BirthDate = p.BirthDate,
                BloodGroups = p.BloodGroups,
                IdentitySerialNumber = p.IdentitySerialNumber,
                IdentityRowNumber = p.IdentityRowNumber,
                IdentityProvinceName = p.IdentityProvince.ProvinceName,
                IdentityDistrictName = p.IdentityDistrict.DistrictName,
                IdentityNeighborhood = p.IdentityNeighborhood,
                IdentityBindingNumber = p.IdentityBindingNumber,
                IdentityFamilyRowNumber = p.IdentityFamilyRowNumber,
                IdentityPersonRowNumber = p.IdentityPersonRowNumber,
                IdentityGivenPlace = p.IdentityGivenPlace,
                IdentityGivenReason = p.IdentityGivenReason,
                IdentityRegisterNumber = p.IdentityRegisterNumber,
                IdentityGivenDate = p.IdentityGivenDate,
                HomePhone = p.HomePhone,
                WorkplacePhone1 = p.WorkplacePhone1,
                WorkplacePhone2 = p.WorkplacePhone2,
                InternalPhone1 = p.InternalPhone1,
                InternalPhone2 = p.InternalPhone2,
                MobilePhone1 = p.MobilePhone1,
                MobilePhone2 = p.MobilePhone2,
                Web = p.Web,
                EMail = p.EMail,
                HomeAddress = p.HomeAddress,
                HomeAddressProvinceName = p.HomeAddressProvince.ProvinceName,
                HomeAddressDistrictName = p.HomeAddressDistrict.DistrictName,
                WorkplaceAddress = p.WorkplaceAddress,
                WorkplaceAddressProvinceName = p.WorkplaceAddressProvince.ProvinceName,
                WorkplaceAddressDistrictName = p.WorkplaceAddressDistrict.DistrictName,
                VocationName = p.Vocation.VocationName,
                WorkplaceName = p.Workplace.WorkplaceName,
                JobName = p.Job.JobName,
                IbanNumber = p.IbanNumber,
                CardNumber = p.CardNumber,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement,
            }).OrderBy(p => p.Code).ToList();
        }
    }
}
