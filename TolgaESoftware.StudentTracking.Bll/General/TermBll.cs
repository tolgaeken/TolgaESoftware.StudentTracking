using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class TermBll:BaseGeneralBll<Term>,IBaseGeneralBll,IBaseCommonBll
    {
        public TermBll() : base(CardType.Term) { }
        public TermBll(Control control) : base(control, CardType.Term) { }
    }
}