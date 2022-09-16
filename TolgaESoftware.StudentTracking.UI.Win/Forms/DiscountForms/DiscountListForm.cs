using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountForms
{
    public partial class DiscountListForm : BaseListForm
    {
        public DiscountListForm()
        {
            InitializeComponent();
            Bll = new DiscountBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Discount;
            FormShow = new ShowEditForms<DiscountEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((DiscountBll) Bll).List(p => p.Status == ShowActiveCards
                                                                        && p.BranchId == MainForm.BranchId
                                                                        && p.TermId == MainForm.TermId);
        }
    }
}