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
    public class ClassBll:BaseGeneralBll<Class>,IBaseCommonBll
    {
        public ClassBll() : base(CardType.Class) { }
        public ClassBll(Control control) : base(control, CardType.Class) { }

        public override BaseEntity Single(Expression<Func<Class, bool>> filter)
        {
            return BaseSingle(filter, p => new ClassSingle
            {
                Id = p.Id,
                Code = p.Code,
                ClassName = p.ClassName,
                ClassGroupId = p.ClassGroupId,
                GroupName = p.ClassGroup.GroupName,
                TargetNumberOfStudents = p.TargetNumberOfStudents,
                TargetProfit = p.TargetProfit,
                BranchId = p.BranchId,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Class, bool>> filter)
        {
            return BaseList(filter, p => new ClassList
            {
                Id = p.Id,
                Code = p.Code,
                ClassName = p.ClassName,
                GroupName = p.ClassGroup.GroupName,
                TargetNumberOfStudents = p.TargetNumberOfStudents,
                TargetProfit = p.TargetProfit,
                Statement = p.Statement,
            }).OrderBy(p=>p.Code).ToList();
        }
    }
}