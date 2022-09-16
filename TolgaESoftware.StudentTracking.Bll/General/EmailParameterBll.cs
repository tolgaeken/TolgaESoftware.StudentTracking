using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class EmailParameterBll:BaseGeneralBll<EmailParameter>,IBaseGeneralBll,IBaseCommonBll
    {
        public EmailParameterBll() {}
        public EmailParameterBll(Control control) : base(control) { }
    }
}