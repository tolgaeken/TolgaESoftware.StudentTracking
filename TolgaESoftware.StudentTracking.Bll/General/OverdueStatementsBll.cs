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
    public class OverdueStatementsBll:BaseGeneralBll<OverdueStatements>,IBaseCommonBll
    {
        public OverdueStatementsBll() : base(CardType.Statement) { }
        public OverdueStatementsBll(Control control) : base(control, CardType.Statement) { }

        public override BaseEntity Single(Expression<Func<OverdueStatements, bool>> filter)
        {
            return BaseSingle(filter, p => new OverdueStatementsSingle
            {
                Id = p.Id,
                Code = p.Code,
                PaymentInformationsId = p.PaymentInformationsId,
                UserName = p.User.Code,
                DateTime = p.DateTime,
                Statement = p.Statement,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<OverdueStatements, bool>> filter)
        {
            return BaseList(filter, p => new OverdueStatementsList
            {
                Id = p.Id,
                Code = p.Code,
                UserName = p.User.Code,
                DateTime = p.DateTime,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}