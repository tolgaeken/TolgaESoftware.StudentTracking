using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.PaymentMethodForms
{
    public partial class PaymentMethodListForm : BaseListForm
    {
        public PaymentMethodListForm()
        {
            InitializeComponent();
            Bll = new PaymentMethodBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.PaymentMethod;
            FormShow = new ShowEditForms<PaymentMethodEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((PaymentMethodBll) Bll).List(FilterFunctions.Filter<PaymentMethod>(ShowActiveCards));
        }
    }
}