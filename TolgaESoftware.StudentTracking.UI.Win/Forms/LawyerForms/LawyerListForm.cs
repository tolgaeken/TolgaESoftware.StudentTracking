using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.LawyerForms
{
    public partial class LawyerListForm : BaseListForm
    {
        public LawyerListForm()
        {
            InitializeComponent();
            Bll= new LawyerBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Lawyer;
            FormShow = new ShowEditForms<LawyerEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((LawyerBll) Bll).List(FilterFunctions.Filter<Lawyer>(ShowActiveCards));
        }
    }
}