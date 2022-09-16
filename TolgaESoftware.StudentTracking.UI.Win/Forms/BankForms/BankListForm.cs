using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankBranchForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BankForms
{
    public partial class BankListForm : BaseListForm
    {
        public BankListForm()
        {
            InitializeComponent();

            Bll= new BankBll();
            btnLinkedCards.Caption = "Şube Kartları";
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Bank;
            FormShow = new ShowEditForms<BankEditForm>();
            Navigator = longNavigator.navigator;

            if (IsMdiChild) ShowItems=new BarItem[] {btnLinkedCards};
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((BankBll) Bll).List(FilterFunctions.Filter<Bank>(ShowActiveCards));
        }

        protected override void OpenLinkedCard()
        {
            var entity = table.GetRow<BankList>();
            if (entity == null) return;
            ShowListForms<BankBranchListForm>.ShowListForm(CardType.BankBranch, entity.Id, entity.BankName);
        }
    }
}