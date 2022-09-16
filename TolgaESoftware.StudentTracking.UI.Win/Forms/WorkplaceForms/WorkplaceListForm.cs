using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.WorkplaceForms
{
    public partial class WorkplaceListForm : BaseListForm
    {
        public WorkplaceListForm()
        {
            InitializeComponent();
            Bll = new WorkplaceBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.Workplace;
            FormShow = new ShowEditForms<WorkplaceEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((WorkplaceBll) Bll).List(FilterFunctions.Filter<Workplace>(ShowActiveCards));
        }
    }
}