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
    public class CustomerBll:BaseGeneralBll<Customer>,IBaseGeneralBll,IBaseCommonBll
    {
        public CustomerBll() : base(CardType.Customer) { }
        public CustomerBll(Control control) : base(control, CardType.Customer) { }

        public override BaseEntity Single(Expression<Func<Customer, bool>> filter)
        {
            return BaseSingle(filter, p => new CustomerSingle
            {
                Id = p.Id,
                Code = p.Code,
                CustomerName = p.CustomerName,
                TrIdentityNumber = p.TrIdentityNumber,
                Phone1 = p.Phone1,
                Phone2 = p.Phone2,
                Phone3 = p.Phone3,
                Phone4 = p.Phone4,
                Fax = p.Fax,
                Web = p.Web,
                EMail = p.EMail,
                TaxAdministration = p.TaxAdministration,
                TaxNumber = p.TaxNumber,
                Address = p.Address,
                SpecialCode1Id = p.SpecialCode1Id,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Id = p.SpecialCode2Id,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement,
                Status = p.Status,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Customer, bool>> filter)
        {
            return BaseList(filter, p => new CustomerList
            {
                Id = p.Id,
                Code = p.Code,
                CustomerName = p.CustomerName,
                TrIdentityNumber = p.TrIdentityNumber,
                Phone1 = p.Phone1,
                Phone2 = p.Phone2,
                Phone3 = p.Phone3,
                Phone4 = p.Phone4,
                Fax = p.Fax,
                Web = p.Web,
                EMail = p.EMail,
                TaxAdministration = p.TaxAdministration,
                TaxNumber = p.TaxNumber,
                Address = p.Address,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}