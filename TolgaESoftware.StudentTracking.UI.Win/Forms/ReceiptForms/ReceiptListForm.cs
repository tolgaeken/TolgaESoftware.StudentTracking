using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms
{
    public partial class ReceiptListForm : BaseListForm
    {
        public ReceiptListForm()
        {
            InitializeComponent();

            Bll = new ReceiptBll();

            ShowItems = new BarItem[] { btnNewReceipt };
            HideItems = new BarItem[] { btnNew, btnDelete, barDelete, barDeleteStatement };
            barInsertStatement.Caption = "Yeni Makbuz";
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Receipt;
            FormShow = new ShowEditForms<ReceiptEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((ReceiptBll)Bll).List(p => p.TermId == MainForm.TermId && p.BranchId == MainForm.BranchId);
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            long id = 0;

            base.Button_ItemClick(sender, e);

            if (e.Item == btnNewReceipt)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }

            else if (e.Item == btnSendingToLawyer) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.SendingToLawyer, ReceiptAccountType.Lawyer);

            else if (e.Item == btnCollectedViaLawyer) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.CollectedViaLawyer, ReceiptAccountType.Lawyer);

            else if (e.Item == btnChargedToBank) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.ChargedToBank, ReceiptAccountType.Bank);

            else if (e.Item == btnBlocking) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.Blocking, ReceiptAccountType.Pos);

            else if (e.Item == btnUnblocking) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.Unblocking, ReceiptAccountType.Pos);

            else if (e.Item == btnSendingToBank) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.SendingToBank, ReceiptAccountType.Bank);

            else if (e.Item == btnCollectedViaBank) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.CollectedViaBank, ReceiptAccountType.Bank);

            else if (e.Item == btnProfiting) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.Profiting, ReceiptAccountType.Customer);

            else if (e.Item == btnOffsetting) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.Offsetting, ReceiptAccountType.Offset);

            else if (e.Item == btnMarkAsPaid) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.MarkAsPaid, ReceiptAccountType.Customer);

            else if (e.Item == btnRefundToCustomer) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.RefundToCustomer, ReceiptAccountType.Refund);

            else if (e.Item == btnRefundToWallet) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.RefundToWallet, ReceiptAccountType.Bank);

            else if (e.Item == btnFreeRefundToWallet) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.FreeRefundToWallet, ReceiptAccountType.Bank);

            else if (e.Item == btnSendingToAnotherBranch) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.SendingToAnotherBranch, ReceiptAccountType.Transfer);

            else if (e.Item == btnApproveIncomingDocument) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.ApproveIncomingDocument, ReceiptAccountType.Transfer);

            else if (e.Item == btnChargedToVault) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.ChargedToVault, ReceiptAccountType.Vault);

            else if (e.Item == btnMarkAsUnpaid) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.MarkAsUnpaid, ReceiptAccountType.Dubious);

            else if (e.Item == btnImpossibleCollect) id = ShowEditForms<ReceiptEditForm>
                .ShowDialogEditForm(CardType.Receipt, -1, ReceiptType.ImpossibleCollect, ReceiptAccountType.Dubious);

            if (id > 0)
                ShowEditFormDefault(id);

            table.Focus();
        }

        protected override void ShowEditForm(long id)
        {
            var entity = table.GetRow<ReceiptList>();

            if(entity == null) return;

            var result = ShowEditForms<ReceiptEditForm>.ShowDialogEditForm(CardType.Receipt, id, entity.ReceiptType,entity.AccountType);
            ShowEditFormDefault(result);
        }
    }
}