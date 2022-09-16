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
    public class DiscountBll:BaseGeneralBll<Discount>,IBaseCommonBll
    {
        public DiscountBll() : base(CardType.Discount) { }
        public DiscountBll(Control control) : base(control, CardType.Discount) { }

        public override BaseEntity Single(Expression<Func<Discount, bool>> filter)
        {
            return BaseSingle(filter, p => new DiscountSingle
            {
                Id = p.Id,
                Code = p.Code,
                DiscountName = p.DiscountName,
                DiscountTypeId = p.DiscountTypeId,
                DiscountTypeName = p.DiscountType.DiscountTypeName,
                BranchId = p.BranchId,
                TermId = p.TermId,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Discount, bool>> filter)
        {
            return BaseList(filter, p => new DiscountList
            {
                Id = p.Id,
                Code = p.Code,
                DiscountName = p.DiscountName,
                DiscountTypeId = p.DiscountTypeId,
                DiscountTypeName = p.DiscountType.DiscountTypeName,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}