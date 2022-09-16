using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class SpecialCodeBll:BaseGeneralBll<SpecialCode>,IBaseCommonBll
    {
        public SpecialCodeBll() : base(CardType.SpecialCode) { }
        public SpecialCodeBll(Control control) : base(control, CardType.SpecialCode) { }
    }
}