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
    public class ReportBll:BaseGeneralBll<Report>,IBaseGeneralBll,IBaseCommonBll
    {
        public ReportBll() : base(CardType.Report) { }
        public ReportBll(Control control) : base(control, CardType.Report) { }

        public override IEnumerable<BaseEntity> List(Expression<Func<Report, bool>> filter)
        {
            return BaseList(filter, p => new ReportList
            {
                Id = p.Id,
                Code = p.Code,
                ReportName = p.ReportName,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}