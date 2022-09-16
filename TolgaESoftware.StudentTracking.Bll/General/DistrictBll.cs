using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class DistrictBll : BaseGeneralBll<District>, IBaseCommonBll
    {
        public DistrictBll():base(CardType.District) { }

        public DistrictBll(Control control):base(control,CardType.District) { }
    }
}
