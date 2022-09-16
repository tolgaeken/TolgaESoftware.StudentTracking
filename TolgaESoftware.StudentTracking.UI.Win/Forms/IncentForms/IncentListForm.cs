using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.IncentForms
{
    public partial class IncentListForm : BaseListForm
    {
        public IncentListForm()
        {
            InitializeComponent();
            Bll = new IncentBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.Incent;
            FormShow = new ShowEditForms<IncentEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((IncentBll) Bll).List(FilterFunctions.Filter<Incent>(ShowActiveCards));
        }
    }
}