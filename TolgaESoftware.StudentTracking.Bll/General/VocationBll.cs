using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class VocationBll:BaseGeneralBll<Vocation>,IBaseGeneralBll,IBaseCommonBll
    {
        public VocationBll() : base(CardType.Vocation) { }
        public VocationBll(Control control) : base(control, CardType.Vocation) { }
    }

}