using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.FamilyInfoForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.CancellationReasonForms
{
    public partial class CancellationReasonListForm : BaseListForm
    {
        public CancellationReasonListForm()
        {
            InitializeComponent();
            Bll = new CancellationReasonBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.CancellationReason;
            FormShow = new ShowEditForms<CancellationReasonEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((CancellationReasonBll) Bll).List(FilterFunctions.Filter<CancellationReason>(ShowActiveCards));
        }
    }
}