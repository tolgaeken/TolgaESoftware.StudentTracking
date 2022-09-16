using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.GeneralEditFormTable
{
    public partial class ReceiptActionsTable : BaseTable
    {
        public ReceiptActionsTable()
        {
            InitializeComponent();
            Bll = new ReceiptActionsBll();
            Table = table;
            EventsLoad();
            ShowItems = new BarItem[] { btnDocumentActions };
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((ReceiptActionsBll)Bll).List(p => p.ReceiptId == OwnerForm.Id).ToBindingList<ReceiptActionsList>();
        }

        protected override void AddAction()
        {
            if (((ReceiptEditForm)OwnerForm).WrongData()) return;

            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<ReceiptActionsList>().Where(p => !p.Delete)
                .Select(p => (long)p.PaymentInformationsId).ToList();

            var entities =
                ShowListForms<DocumentSelectionListForm>
                    .ShowDialogListForm(CardType.DocumentSelection, UnlistedData, true,
                                          ((ReceiptEditForm)OwnerForm).ReceiptType,
                                          ((ReceiptEditForm)OwnerForm).txtAccountType.Text.GetEnum<ReceiptAccountType>(),
                                          ((ReceiptEditForm)OwnerForm).txtAccount.Id)
                    .EntityListConvert<DocumentSelectionList>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new ReceiptActionsList
                {
                    ReceiptId = OwnerForm.Id,
                    StudentNumber = entity.StudentNumber,
                    Name = entity.Name,
                    Lastname = entity.Lastname,
                    ClassName = entity.ClassName,
                    StudentBranchName = entity.StudentBranchName,
                    DocumentBranchName = entity.DocumentBranchName,
                    PaymentInformationsId = entity.PaymentInformationsId,
                    PaymentMethodName = entity.PaymentMethodName,
                    PaymentType = entity.PaymentType,
                    BankAccountName = entity.BankAccountName,
                    TrackNumber = entity.TrackNumber,
                    EntryDate = entity.EntryDate,
                    PaymentTerm = entity.PaymentTerm,
                    AccountTransferDate = entity.AccountTransferDate,
                    Price = entity.Price,
                    PriceBeforeTransaction = entity.Price - (entity.Collect + entity.Refund),
                    TransactionPrice = entity.Price - (entity.Collect + entity.Refund),
                    BankName = entity.BankName,
                    BankBranchName = entity.BankBranchName,
                    DocumentNumber = entity.DocumentNumber,
                    AccountNumber = entity.AccountNumber,
                    PrincipalDebtor = entity.PrincipalDebtor,
                    Endorser = entity.Endorser,

                    DocumentStatus =
                        ((ReceiptEditForm)OwnerForm).ReceiptType == ReceiptType.SendingToAnotherBranch ? DocumentStatus.WaitingConfirmation :
                        ((ReceiptEditForm)OwnerForm).ReceiptType == ReceiptType.ApproveIncomingDocument ? DocumentStatus.OnWallet :
                        ((ReceiptEditForm)OwnerForm).ReceiptType.ToName().GetEnum<DocumentStatus>(),

                    UserId = MainForm.UserId,
                    OldBranchId = MainForm.BranchId,

                    NewBranchId = ((ReceiptEditForm)OwnerForm).ReceiptType == ReceiptType.SendingToAnotherBranch ?
                        ((ReceiptEditForm)OwnerForm).txtAccount.Id : null,

                    Insert = true
                };

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colTransactionPrice;

            ShowHideColumns();
            RowCellAllowEdit();
            ButtonEnabledStatus(true);
        }

        protected override void ShowHideColumns()
        {
            if (table.DataRowCount == 0) return;
            var entity = table.GetRow<ReceiptActionsList>(false);
            if (entity == null) return;

            bndDocumentDetailInformations.Visible =
                entity.PaymentType == PaymentType.Cheque || entity.PaymentType == PaymentType.Indenture;

            colTrackNumber.Visible = entity.PaymentType == PaymentType.Pos;
            colBankName.Visible = entity.PaymentType == PaymentType.Epos || entity.PaymentType == PaymentType.Pos ||
                                  entity.PaymentType == PaymentType.Sps;

            colBankName.Visible = entity.PaymentType == PaymentType.Cheque;
            colBankBranchName.Visible = entity.PaymentType == PaymentType.Cheque;
            colAccountNumber.Visible = entity.PaymentType == PaymentType.Cheque;
            colDocumentNumber.Visible = entity.PaymentType == PaymentType.Cheque;
            colPrincipalDebtor.Visible = entity.PaymentType == PaymentType.Cheque || entity.PaymentType == PaymentType.Indenture;
            colEndorser.Visible = entity.PaymentType == PaymentType.Cheque || entity.PaymentType == PaymentType.Indenture;
        }

        protected override void RowCellAllowEdit()
        {
            if (table.DataRowCount == 0) return;
            var entity = table.GetRow<ReceiptActionsList>(false);
            if (entity == null) return;

            var receiptType = ((ReceiptEditForm)OwnerForm).ReceiptType;

            switch (receiptType)
            {
                case ReceiptType.CollectedViaLawyer:
                case ReceiptType.ChargedToVault:
                case ReceiptType.ChargedToBank:
                    colTransactionPrice.OptionsColumn.AllowEdit = entity.Id == 0 || entity.Id >= entity.LastActionId;
                    break;
            }
        }

        protected override void DeleteAction()
        {
            if (Messages.DeletionMessage("Makbuz Hareketi") != DialogResult.Yes) return;

            var entity = table.GetRow<ReceiptActionsList>();
            if (entity == null) return;

            if (entity.Id != 0 && entity.Id < entity.LastActionId)
            {
                Messages.PaymentDocumentCannotBeDeleted(true);
                return;
            }

            entity.Delete = true;
            table.RefreshDataSource();
            ButtonEnabledStatus(true);
        }

        protected internal bool MassDeleteAction()
        {
            if (Messages.DeletionMessage("Makbuz Kartı") != DialogResult.Yes) return false;

            if (((ReceiptEditForm)OwnerForm).BaseProcessType != ProcessType.EntityInsert)
            {
                var numberOfCannotBeDeleted = 0;

                var source = table.DataController.ListSource.Cast<ReceiptActionsList>();
                source.ForEach(p =>
                {
                    if (p.Id == 0 || p.Id >= p.LastActionId)
                    {
                        p.Delete = true;
                        ButtonEnabledStatus(true);
                    }
                    else numberOfCannotBeDeleted++;
                });

                table.RefreshDataSource();

                if (numberOfCannotBeDeleted > 0)
                {
                    Messages.ErrorMessage($"Makbuz İçerisinde Daha Sonra İşlem Görmüş {numberOfCannotBeDeleted} Adet Belge Bulunmaktadır." +
                                          $"\nMakbuz Tamamen İptal Edilemez.");
                    return false;
                }

                Save();
                return true;
            }

            return true;
        }

        protected internal override bool WrongData()
        {
            if (!TableValueChanged) return false;
            if (table.HasColumnErrors) table.ClearColumnErrors();
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<ReceiptActionsList>(i);

                if (entity.TransactionPrice <= 0)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colTransactionPrice;
                    table.SetColumnError(colTransactionPrice, "İşlem Tutarı, Sıfıra Eşit veya Sıfırdan Küçük Olamaz", ErrorType.Warning);
                }

                if (entity.TransactionPrice > entity.PriceBeforeTransaction)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colTransactionPrice;
                    table.SetColumnError(colTransactionPrice, "İşlem Tutarı, Kalan Bakiyeden Fazla Olamaz", ErrorType.Warning);
                }

                if (!table.HasColumnErrors) continue;
                Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void DocumentActions()
        {
            var entity = table.GetRow<ReceiptActionsList>();
            if (entity == null) return;
            ShowListForms<DocumentActionsListForm>
                .ShowDialogListForm(CardType.DocumentActions, null, entity.PaymentInformationsId);
        }

        protected override void Table_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Table_CellValueChanged(sender, e);

            var entity = table.GetRow<ReceiptActionsList>();
            if (entity == null) return;

            if (e.Column != colTransactionPrice) return;

            if ((decimal)e.Value < entity.PriceBeforeTransaction)
                entity.DocumentStatus = entity.DocumentStatus == DocumentStatus.CollectedViaLawyer
                    ? DocumentStatus.PartlyCollectedViaLawyer
                    : DocumentStatus.PartlyCollect;

            else entity.DocumentStatus = ((ReceiptEditForm)OwnerForm).ReceiptType.ToName().GetEnum<DocumentStatus>();
        }

        protected override void Table_RowCountChanged(object sender, EventArgs e)
        {
            ((ReceiptEditForm)OwnerForm).ReceiptTypeEnabled();
        }
    }
}