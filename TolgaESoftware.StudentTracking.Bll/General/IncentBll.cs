using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class IncentBll:BaseGeneralBll<Incent>,IBaseGeneralBll,IBaseCommonBll
    {
        public IncentBll() : base(CardType.Incent) { }
        public IncentBll(Control control) : base(control, CardType.Incent) { }
    }
}