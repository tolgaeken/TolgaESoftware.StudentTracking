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
    public class StudentBll : BaseGeneralBll<Student>, IBaseGeneralBll, IBaseCommonBll
    {
        public StudentBll() : base(CardType.Student) { }
        public StudentBll(Control control) : base(control, CardType.Student) { }

        public override BaseEntity Single(Expression<Func<Student, bool>> filter)
        {
            return BaseSingle(filter, p => new StudentSingle
            {
                Id = p.Id,
                Code = p.Code,
                TrIdentityNumber = p.TrIdentityNumber,
                Name = p.Name,
                Lastname = p.Lastname,
                Gender = p.Gender,
                Phone = p.Phone,
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
                Image = p.Image,
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
                Statement = p.Statement,
                Status = p.Status,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Student, bool>> filter)
        {
            return BaseList(filter, p => new StudentList
            {
                Id = p.Id,
                Code = p.Code,
                TrIdentityNumber = p.TrIdentityNumber,
                Name = p.Name,
                Lastname = p.Lastname,
                Gender = p.Gender,
                Phone = p.Phone,
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
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                SpecialCode3Name = p.SpecialCode3.SpecialCodeName,
                SpecialCode4Name = p.SpecialCode4.SpecialCodeName,
                SpecialCode5Name = p.SpecialCode5.SpecialCodeName,
                Statement = p.Statement,
            }).OrderBy(p => p.Code).ToList();
        }
    }
}