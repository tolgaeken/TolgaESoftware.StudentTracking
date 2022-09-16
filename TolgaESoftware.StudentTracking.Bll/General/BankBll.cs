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
    public class BankBll:BaseGeneralBll<Bank>,IBaseGeneralBll,IBaseCommonBll
    {
        public BankBll() : base(CardType.Bank) { }
        public BankBll(Control control) : base(control, CardType.Bank) { }

        public override BaseEntity Single(Expression<Func<Bank, bool>> filter)
        {
            return BaseSingle(filter, p => new BankSingle
            {
                Id = p.Id,
                Code = p.Code,
                BankName = p.BankName,
                SpecialCode1Id = p.SpecialCode1Id,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Id = p.SpecialCode2Id,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Bank, bool>> filter)
        {
            return BaseList(filter, p => new BankList
            {
                Id = p.Id,
                Code = p.Code,
                BankName = p.BankName,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}