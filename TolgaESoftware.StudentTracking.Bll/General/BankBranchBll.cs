using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class BankBranchBll:BaseGeneralBll<BankBranch>,IBaseCommonBll
    {
        public BankBranchBll() : base(CardType.BankBranch) { }
        public BankBranchBll(Control control) : base(control, CardType.BankBranch) { }
    }
}