using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolBusForms
{
    public partial class SchoolBusListForm : BaseListForm
    {
        public SchoolBusListForm()
        {
            InitializeComponent();
            Bll = new SchoolBusBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.SchoolBus;
            FormShow = new ShowEditForms<SchoolBusEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((SchoolBusBll) Bll).List(p => p.Status == ShowActiveCards
                                                                         && p.BranchId == MainForm.BranchId
                                                                         && p.TermId == MainForm.TermId);
        }
    }
}