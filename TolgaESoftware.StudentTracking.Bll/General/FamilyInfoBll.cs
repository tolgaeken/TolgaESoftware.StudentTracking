using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class FamilyInfoBll:BaseGeneralBll<FamilyInfo>,IBaseGeneralBll,IBaseCommonBll
    {
        public FamilyInfoBll() : base(CardType.FamilyInfo) { }
        public FamilyInfoBll(Control control) : base(control, CardType.FamilyInfo) { }
    }
}