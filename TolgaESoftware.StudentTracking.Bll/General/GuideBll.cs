using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class GuideBll:BaseGeneralBll<Guide>,IBaseGeneralBll,IBaseCommonBll
    {
        public GuideBll() : base(CardType.Guide) { }
        public GuideBll(Control control) : base(control, CardType.Guide) { }
    }
}