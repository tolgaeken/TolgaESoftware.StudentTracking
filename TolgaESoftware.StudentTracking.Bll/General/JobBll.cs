using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class JobBll:BaseGeneralBll<Job>,IBaseGeneralBll,IBaseCommonBll
    {
        public JobBll() : base(CardType.Job) { }
        public JobBll(Control control) : base(control, CardType.Job) { }
    }

}