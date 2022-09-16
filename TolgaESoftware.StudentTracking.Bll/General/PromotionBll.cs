using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class PromotionBll:BaseGeneralBll<Promotion>,IBaseCommonBll
    {
        public PromotionBll() : base(CardType.Promotion) { }
        public PromotionBll(Control control) : base(control, CardType.Promotion) { }
    }
}