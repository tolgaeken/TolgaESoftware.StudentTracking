using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.QuotaForms
{
    public partial class QuotaListForm : BaseListForm
    {
        public QuotaListForm()
        {
            InitializeComponent();
            Bll = new QuotaBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.Quota;
            FormShow = new ShowEditForms<QuotaEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((QuotaBll) Bll).List(FilterFunctions.Filter<Quota>(ShowActiveCards));
        }
    }
}