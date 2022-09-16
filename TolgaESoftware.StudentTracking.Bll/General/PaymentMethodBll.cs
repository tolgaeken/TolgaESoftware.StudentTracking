using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class PaymentMethodBll:BaseGeneralBll<PaymentMethod>,IBaseGeneralBll,IBaseCommonBll
    {
        public PaymentMethodBll() : base(CardType.PaymentMethod) { }
        public PaymentMethodBll(Control control) : base(control, CardType.PaymentMethod) { }
    }
}