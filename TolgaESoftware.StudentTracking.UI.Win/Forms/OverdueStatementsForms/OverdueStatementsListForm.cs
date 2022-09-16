using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankBranchForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.OverdueStatementsForms
{
    public partial class OverdueStatementsListForm : BaseListForm
    {
        #region Variables
        private readonly int _paymentInformationsId;
        #endregion

        public OverdueStatementsListForm(params object[]prm)
        {
            InitializeComponent();
            Bll = new OverdueStatementsBll();
            HideItems = new BarItem[] {btnSelect};

            _paymentInformationsId = (int)prm[0];
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Statement;
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((OverdueStatementsBll)Bll).List(p => p.PaymentInformationsId == _paymentInformationsId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<OverdueStatementsEditForm>.ShowDialogEditForm(CardType.Statement, id,_paymentInformationsId);
            ShowEditFormDefault(result);
        }
    }
}