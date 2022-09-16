using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class ClassGroupBll:BaseGeneralBll<ClassGroup>,IBaseGeneralBll,IBaseCommonBll
    {
        public ClassGroupBll() : base(CardType.ClassGroup) { }
        public ClassGroupBll(Control control) : base(control, CardType.ClassGroup) { }
    }
}