using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class ForeignLanguageBll:BaseGeneralBll<ForeignLanguage>,IBaseGeneralBll,IBaseCommonBll
    {
        public ForeignLanguageBll() : base(CardType.ForeignLanguage) { }
        public ForeignLanguageBll(Control control) : base(control, CardType.ForeignLanguage) { }
    }
}