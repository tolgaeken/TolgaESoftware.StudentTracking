using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class InstitutionBll:BaseGeneralAdminBll<Institution>,IBaseGeneralBll,IBaseCommonBll
    {
        public InstitutionBll() : base(CardType.Institution) { }
        public InstitutionBll(Control control) : base(control, CardType.Institution) { }
    }
}