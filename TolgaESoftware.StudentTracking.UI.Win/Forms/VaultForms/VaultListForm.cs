using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.VaultForms
{
    public partial class VaultListForm : BaseListForm
    {
        public VaultListForm()
        {
            InitializeComponent();

            Bll= new VaultBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Vault;
            FormShow = new ShowEditForms<VaultEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((VaultBll) Bll).List(p => p.Status == ShowActiveCards
                                                                        && p.BranchId == MainForm.BranchId
                                                                        && p.TermId == MainForm.TermId);
        }
    }
}