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
    public class BranchBll:BaseGeneralBll<Branch>, IBaseGeneralBll,IBaseCommonBll
    {
        public BranchBll() : base(CardType.Branch) { }
        public BranchBll(Control control) : base(control, CardType.Branch) { }

        public override BaseEntity Single(Expression<Func<Branch, bool>> filter)
        {
            return BaseSingle(filter, p => new BranchSingle
            {
                Id = p.Id,
                Code = p.Code,
                BranchName = p.BranchName,
                Address = p.Address,
                AddressProvinceId = p.AddressProvinceId,
                AddressProvinceName = p.AddressProvince.ProvinceName,
                AddressDistrictId = p.AddressDistrictId,
                AddressDistrictName = p.AddressDistrict.DistrictName,
                Phone = p.Phone,
                Fax = p.Fax,
                IbanNumber = p.IbanNumber,
                GroupName = p.GroupName,
                RowNumber = p.RowNumber,
                Logo = p.Logo,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Branch, bool>> filter)
        {
            return BaseList(filter, p => new BranchList
            {
                Id = p.Id,
                Code = p.Code,
                BranchName = p.BranchName,
                Address = p.Address,
                AddressProvinceName = p.AddressProvince.ProvinceName,
                AddressDistrictName = p.AddressDistrict.DistrictName,
                Phone = p.Phone,
                Fax = p.Fax,
                IbanNumber = p.IbanNumber,
                GroupName = p.GroupName,
                RowNumber = p.RowNumber
            }).OrderBy(p => p.Code).ToList();
        }
    }
}