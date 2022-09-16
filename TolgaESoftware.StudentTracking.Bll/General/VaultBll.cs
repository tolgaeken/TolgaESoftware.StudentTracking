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
    public class VaultBll:BaseGeneralBll<Vault>,IBaseCommonBll
    {
        public VaultBll() : base(CardType.Vault) { }
        public VaultBll(Control control) : base(control, CardType.Vault) { }

        public override BaseEntity Single(Expression<Func<Vault, bool>> filter)
        {
            return BaseSingle(filter, p => new VaultSingle
            {
                Id = p.Id,
                Code = p.Code,
                VaultName = p.VaultName,
                SpecialCode1Id = p.SpecialCode1Id,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Id = p.SpecialCode2Id,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                BranchId = p.BranchId,
                TermId = p.TermId,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Vault, bool>> filter)
        {
            return BaseList(filter, p => new VaultList
            {
                Id = p.Id,
                Code = p.Code,
                VaultName = p.VaultName,
                SpecialCode1Name = p.SpecialCode1.SpecialCodeName,
                SpecialCode2Name = p.SpecialCode2.SpecialCodeName,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}
