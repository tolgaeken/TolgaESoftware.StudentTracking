using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class QuotaBll:BaseGeneralBll<Quota>,IBaseGeneralBll,IBaseCommonBll
    {
        public QuotaBll() : base(CardType.Quota) { }
        public QuotaBll(Control control) : base(control, CardType.Quota) { }
    }
}