using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.VocationForms
{
    public partial class VocationListForm : BaseListForm
    {
        public VocationListForm()
        {
            InitializeComponent();
            Bll = new VocationBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.Vocation;
            FormShow = new ShowEditForms<VocationEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((VocationBll) Bll).List(FilterFunctions.Filter<Vocation>(ShowActiveCards));
        }
    }
}