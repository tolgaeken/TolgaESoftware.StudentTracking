using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class WorkplaceBll:BaseGeneralBll<Workplace>,IBaseGeneralBll,IBaseCommonBll
    {
        public WorkplaceBll() : base(CardType.Workplace) { }
        public WorkplaceBll(Control control) : base(control, CardType.Workplace) { }
    }
}