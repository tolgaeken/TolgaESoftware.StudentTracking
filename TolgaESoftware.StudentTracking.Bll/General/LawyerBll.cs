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
    public class LawyerBll:BaseGeneralBll<Lawyer>,IBaseGeneralBll,IBaseCommonBll
    {
        public LawyerBll() : base(CardType.Lawyer) { }
        public LawyerBll(Control control) : base(control, CardType.Lawyer) { }

        public override BaseEntity Single(Expression<Func<Lawyer, bool>> filter)
        {
            return BaseSingle(filter, p => new LawyerSingle
            {
                Id = p.Id,
                Code = p.Code,
                TrIdentityNumber = p.TrIdentityNumber,
                NameLastname = p.NameLastname,
                ContractNumber = p.ContractNumber,
                ContractStartDate = p.ContractStartDate,
                ContractEndDate = p.ContractEndDate,
                SpecialCode1Id = p.SpecialCode1Id,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Id = p.SpecialCode2Id,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Lawyer, bool>> filter)
        {
            return BaseList(filter, p => new LawyerList
            {
                Id = p.Id,
                Code = p.Code,
                TrIdentityNumber = p.TrIdentityNumber,
                NameLastname = p.NameLastname,
                ContractNumber = p.ContractNumber,
                ContractStartDate = p.ContractStartDate,
                ContractEndDate = p.ContractEndDate,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}