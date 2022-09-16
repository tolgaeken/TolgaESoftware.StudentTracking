using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.CustomerForms
{
    public partial class CustomerListForm : BaseListForm
    {
        public CustomerListForm()
        {
            InitializeComponent();
            Bll = new CustomerBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Customer;
            FormShow = new ShowEditForms<CustomerEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((CustomerBll) Bll).List(FilterFunctions.Filter<Customer>(ShowActiveCards));
        }
    }
}