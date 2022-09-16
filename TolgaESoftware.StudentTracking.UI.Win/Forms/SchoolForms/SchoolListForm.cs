using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolForms
{
    public partial class SchoolListForm : BaseListForm
    {
        public SchoolListForm()
        {
            InitializeComponent();
            Bll = new SchoolBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.School;
            FormShow = new ShowEditForms<SchoolEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((SchoolBll)Bll).List(FilterFunctions.Filter<School>(ShowActiveCards));
        }
    }
}