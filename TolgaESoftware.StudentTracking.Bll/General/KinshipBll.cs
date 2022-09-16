using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class KinshipBll:BaseGeneralBll<Kinship>,IBaseGeneralBll,IBaseCommonBll
    {
        public KinshipBll() : base(CardType.Kinship) { }
        public KinshipBll(Control control) : base(control, CardType.Kinship) { }
    }
}