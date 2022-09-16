using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BankBranchForms
{
    public partial class BankBranchListForm : BaseListForm
    {

        #region Variables
        private readonly long _bankId;
        private readonly string _bankName; 
        #endregion

        public BankBranchListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new BankBranchBll();

            _bankId = (long) prm[0];
            _bankName = prm[1].ToString();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.BankBranch;
            Navigator = longNavigator.navigator;
            Text = Text + $" - ( {_bankName} )"; 
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((BankBranchBll) Bll).List(p=>p.Status==ShowActiveCards && p.BankId==_bankId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<BankBranchEditForm>.ShowDialogEditForm(CardType.BankBranch,id,_bankId,_bankName);
            ShowEditFormDefault(result);
        }
    }
}