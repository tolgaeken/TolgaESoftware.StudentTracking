using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class RoleBll : BaseGeneralBll<Role>, IBaseGeneralBll, IBaseCommonBll
    {
        public RoleBll() : base(CardType.Role) { }
        public RoleBll(Control control) : base(control,CardType.Role) { }
    }
}