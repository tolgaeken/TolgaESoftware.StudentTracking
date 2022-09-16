using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class DiscountTypeBll:BaseGeneralBll<DiscountType>,IBaseGeneralBll,IBaseCommonBll
    {
        public DiscountTypeBll() : base(CardType.DiscountType) { }
        public DiscountTypeBll(Control control) : base(control, CardType.DiscountType) { }
    }
}