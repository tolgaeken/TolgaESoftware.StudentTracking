using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class CancellationReasonBll:BaseGeneralBll<CancellationReason>,IBaseGeneralBll,IBaseCommonBll
    {
        public CancellationReasonBll() : base(CardType.CancellationReason) { }
        public CancellationReasonBll(Control control) : base(control, CardType.CancellationReason) { }
    }
}