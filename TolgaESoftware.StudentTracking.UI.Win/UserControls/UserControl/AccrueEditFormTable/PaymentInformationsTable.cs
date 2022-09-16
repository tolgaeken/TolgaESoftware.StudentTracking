using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class PaymentInformationsTable : BaseTable
    {
        public PaymentInformationsTable()
        {
            InitializeComponent();
            Bll = new PaymentInformationsBll();
            Table = table;
            EventsLoad();

            ShowItems = new BarItem[] { btnDocumentActions };
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((PaymentInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<PaymentInformationsList>();
        }

        protected override void AddAction()
        {
            decimal CalculateBalance()
            {
                var balance = ((AccrueEditForm) OwnerForm).txtDifference.Value;
                return balance <= 0 ? 0 : balance;
            }

            var source = table.DataController.ListSource;

            var numberOfBeforeEnteredInstallment = source.Cast<PaymentInformationsList>()
                .Count(p => !p.Delete && p.DocumentStatus != DocumentStatus.RefundToCustomer);

            if (!ShowEditForms<MassPaymentPlanEditForm>.ShowDialogEditForm(source, OwnerForm.Id, CalculateBalance(),
                ((AccrueEditForm)OwnerForm).txtRegistrationDate.DateTime.Date, numberOfBeforeEnteredInstallment)) return;

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);
            table.FocusedColumn = colPaymentMethodName;

            ButtonEnabledStatus(true);
        }

        protected override void ShowHideColumns()
        {
            if (table.DataRowCount == 0) return;
            var entity = table.GetRow<PaymentInformationsList>();
            if (entity == null) return;

            colBankAccountName.VisibleIndex = 11;
            colTrackNumber.VisibleIndex = 12;
            colBlockedDay.VisibleIndex = 13;
            colBankName.VisibleIndex = 14;
            colBankBranchName.VisibleIndex = 15;
            colAccountNumber.VisibleIndex = 16;
            colDocumentNumber.VisibleIndex = 17;
            colPrincipalDebtor.VisibleIndex = 18;
            colEndorser.VisibleIndex = 19;

            colBankAccountName.Visible = entity.PaymentType == PaymentType.Epos ||
                                         entity.PaymentType == PaymentType.Sps ||
                                         entity.PaymentType == PaymentType.Pos;

            colTrackNumber.Visible = entity.PaymentType == PaymentType.Pos;

            colBlockedDay.Visible = entity.PaymentType == PaymentType.Epos ||
                                    entity.PaymentType == PaymentType.Sps ||
                                    entity.PaymentType == PaymentType.Pos;

            colBankName.Visible = entity.PaymentType == PaymentType.Cheque;

            colBankBranchName.Visible = entity.PaymentType == PaymentType.Cheque;

            colAccountNumber.Visible = entity.PaymentType == PaymentType.Cheque;

            colDocumentNumber.Visible = entity.PaymentType == PaymentType.Cheque;

            colPrincipalDebtor.Visible = entity.PaymentType == PaymentType.Cheque ||
                                         entity.PaymentType == PaymentType.Indenture;

            colEndorser.Visible = entity.PaymentType == PaymentType.Cheque ||
                                  entity.PaymentType == PaymentType.Indenture;
        }

        protected override void RowCellAllowEdit()
        {
            if (table.DataRowCount == 0) return;
            var entity = table.GetRow<PaymentInformationsList>();
            if (entity == null) return;

            colBankAccountName.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colPaymentTerm.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colPrice.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colBankName.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colTrackNumber.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colBankName.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colBankBranchName.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colAccountNumber.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colDocumentNumber.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colPrincipalDebtor.OptionsColumn.AllowEdit = entity.LastActionId == null;
            colEndorser.OptionsColumn.AllowEdit = entity.LastActionId == null;
        }

        protected internal override bool WrongData()
        {
            if (!TableValueChanged) return false;
            if (table.HasColumnErrors) table.ClearColumnErrors();

            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<PaymentInformationsList>(i);


                if (entity.Price == 0)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colPrice;
                    table.SetColumnError(colPrice, "Belge Tutarı Sıfır ( 0 ) Olamaz", ErrorType.Warning);
                }

                switch (entity.PaymentType)
                {
                    case PaymentType.Cheque:
                        if (entity.BankId == null)
                        {
                            table.FocusedRowHandle = i;
                            table.FocusedColumn = colBankName;
                            table.SetColumnError(colBankName, "Banka Seçimi Yapılması Zounludur", ErrorType.Warning);
                        }

                        if (entity.BankBranchId == null)
                        {
                            table.FocusedRowHandle = i;
                            table.FocusedColumn = colBankBranchName;
                            table.SetColumnError(colBankBranchName, "Banka Şube Seçimi Yapılması Zounludur", ErrorType.Warning);
                        }

                        if (String.IsNullOrEmpty(entity.DocumentNumber))
                        {
                            table.FocusedRowHandle = i;
                            table.FocusedColumn = colDocumentNumber;
                            table.SetColumnError(colDocumentNumber, "Belge No Alanına Geçerli Bir Değer Giriniz", ErrorType.Warning);
                        }

                        if (String.IsNullOrEmpty(entity.PrincipalDebtor))
                        {
                            table.FocusedRowHandle = i;
                            table.FocusedColumn = colPrincipalDebtor;
                            table.SetColumnError(colPrincipalDebtor, "Asıl Borçlu Alanına Geçerli Bir Değer Giriniz", ErrorType.Warning);
                        }
                        break;

                    case PaymentType.Indenture:
                        if (String.IsNullOrEmpty(entity.PrincipalDebtor))
                        {
                            table.FocusedRowHandle = i;
                            table.FocusedColumn = colPrincipalDebtor;
                            table.SetColumnError(colPrincipalDebtor, "Asıl Borçlu Alanına Geçerli Bir Değer Giriniz", ErrorType.Warning);
                        }
                        break;

                    case PaymentType.Epos:
                    case PaymentType.Sps:
                    case PaymentType.Pos:
                        if (entity.BankAccountId == null)
                        {
                            table.FocusedRowHandle = i;
                            table.FocusedColumn = colBankAccountName;
                            table.SetColumnError(colBankAccountName, "Banka Hesap Seçimi Yapılması Zounludur", ErrorType.Warning);
                        }
                        break;
                }

                if (!table.HasColumnErrors) continue;

                Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void DeleteAction()
        {
            if (table.DataRowCount == 0) return;
            if (Messages.DeletionMessage("Ödeme Bilgisi") != DialogResult.Yes) return;

            var entity = table.GetRow<PaymentInformationsList>();
            if (entity.LastActionId != null)
            {
                Messages.PaymentDocumentCannotBeDeleted(false);
                return;
            }

            entity.Delete = true;
            table.RefreshDataSource();
            ButtonEnabledStatus(true);
        }

        protected override void DocumentActions()
        {
            var entity = table.GetRow<PaymentInformationsList>();
            if (entity == null) return;
            ShowListForms<DocumentActionsListForm>
                .ShowDialogListForm(CardType.DocumentActions, null, entity.Id);
        }

        protected override void Table_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Table_CellValueChanged(sender, e);

            var entity = table.GetRow<PaymentInformationsList>();

            if (e.Column == colPaymentTerm)
            {
                entity.PaymentTermAsTxt = ((DateTime)e.Value).PaymentTermAsTextDate();
                entity.AccountTransferDate = entity.PaymentTerm.AddDays(entity.BlockedDay);
            }

            else if (e.Column == colPrice) entity.PriceAsText = ((decimal)e.Value).PriceAsText();
            else if (e.Column == colBlockedDay) entity.AccountTransferDate = entity.PaymentTerm.AddDays(entity.BlockedDay);
            else if (e.Column == colBankId)
            {
                entity.BankBranchId = null;
                entity.BankBranchName = null;
                colBankBranchName.OptionsColumn.AllowEdit = entity.BankId != null;
            }
        }

        protected override void Table_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Table_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankAccountName)
                e.FocusedColumn.Select(table, InsUptNavigator.navigator, repositoryItemBankAccount, colBankAccountId);

            else if (e.FocusedColumn == colBankName)
                e.FocusedColumn.Select(table, InsUptNavigator.navigator, repositoryItemBank, colBankId);

            else if (e.FocusedColumn == colBankBranchName)
                e.FocusedColumn.Select(table, InsUptNavigator.navigator, repositoryItemBankBranch, colBankBranchId, colBankId, colBankName);

            else if (e.FocusedColumn == colPaymentTerm)
            {
                repositoryItemPaymentTerm.MinValue = ((AccrueEditForm) OwnerForm).txtRegistrationDate.DateTime.Date;
                repositoryItemPaymentTerm.MaxValue = MainForm.TermParameters.MaxInstallmentDate;
            }

        }


    }
}