using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.GuideForms
{
    public partial class GuideListForm : BaseListForm
    {
        public GuideListForm()
        {
            InitializeComponent();
            Bll = new GuideBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Guide;
            FormShow = new ShowEditForms<GuideEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((GuideBll)Bll).List(FilterFunctions.Filter<Guide>(ShowActiveCards));
        }
    }
}