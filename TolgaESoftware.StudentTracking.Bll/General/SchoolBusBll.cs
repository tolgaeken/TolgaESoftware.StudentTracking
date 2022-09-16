using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class SchoolBusBll : BaseGeneralBll<SchoolBus>, IBaseCommonBll
    {
        public SchoolBusBll() : base(CardType.SchoolBus) { }
        public SchoolBusBll(Control control) : base(control, CardType.SchoolBus) { }
    }
}