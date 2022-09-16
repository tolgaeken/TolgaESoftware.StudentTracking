using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms
{
    public partial class ReceiptEditForm : BaseEditForm
    {
        #region Variables

        private readonly ReceiptAccountType _accountType;
        protected internal readonly ReceiptType ReceiptType;

        #endregion

        public ReceiptEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ReceiptBll(myDataLayoutControl);
            BaseCardType = CardType.Receipt;
            EventsLoad();

            HideItems = new BarItem[] { btnNew };
            ShowItems = new BarItem[] { btnPrint };

            CloseFormPostRegistration = false;

            ReceiptType = (ReceiptType)prm[0];
            _accountType = (ReceiptAccountType)prm[1];
            AnotherBranchProcess = prm.Length > 2 && (bool) prm[2];
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new ReceiptSingle() : ((ReceiptBll)Bll).Single(FilterFunctions.Filter<Receipt>(Id));
            FieldProcesses();
            LinkObjectToControls();
            LoadTable();
            ReceiptTypeEnabled();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtReceiptNumber.Text = ((ReceiptBll)Bll).GetNewCode(p => p.TermId == MainForm.TermId && p.BranchId == MainForm.BranchId);
            txtDate.DateTime = DateTime.Now;
        }

        protected override void LinkObjectToControls()
        {
            var entity = (ReceiptSingle)OldEntity;

            txtReceiptNumber.Text = entity.Code;
            txtDate.DateTime = entity.Date;
            txtAccountType.SelectedItem = _accountType.ToName();

            if (BaseProcessType == ProcessType.EntityInsert)
            {
                switch (_accountType)
                {
                    case ReceiptAccountType.Vault when MainForm.UserParameters.DefaultVaultAccountId != null:
                        txtAccount.Id = MainForm.UserParameters.DefaultVaultAccountId;
                        txtAccount.Text = MainForm.UserParameters.DefaultVaultAccountName;
                        break;

                    case ReceiptAccountType.Bank when MainForm.UserParameters.DefaultBankAccountId != null:
                        txtAccount.Id = MainForm.UserParameters.DefaultBankAccountId;
                        txtAccount.Text = MainForm.UserParameters.DefaultBankAccountName;
                        break;

                    case ReceiptAccountType.Lawyer when MainForm.UserParameters.DefaultLawyerAccountId != null:
                        txtAccount.Id = MainForm.UserParameters.DefaultLawyerAccountId;
                        txtAccount.Text = MainForm.UserParameters.DefaultLawyerAccountName;
                        break;

                    case ReceiptAccountType.Transfer when ReceiptType == ReceiptType.ApproveIncomingDocument:
                        txtAccount.Id = MainForm.BranchId;
                        txtAccount.Text = MainForm.BranchName;
                        break;
                }
            }
            else
            {
                txtAccount.Id = entity.LawyerAccountId ?? entity.BankAccountId ??
                    entity.CustomerAccountId ?? entity.VaultAccountId ?? entity.BranchAccountId;
                txtAccount.Text = entity.AccountName;
            }
        }

        protected override void CreateCurrentObject()
        {
            var accountType = txtAccountType.Text.GetEnum<ReceiptAccountType>();

            CurrentEntity = new Receipt
            {
                Id = Id,
                Code = txtReceiptNumber.Text,
                Date = txtDate.DateTime.Date,
                ReceiptType = ReceiptType,
                AccountType = _accountType,
                LawyerAccountId = accountType == ReceiptAccountType.Lawyer ? txtAccount.Id : null,

                BankAccountId = accountType == ReceiptAccountType.Bank
                                || accountType == ReceiptAccountType.Epos
                                || accountType == ReceiptAccountType.Sps
                                || accountType == ReceiptAccountType.Pos ? txtAccount.Id : null,

                CustomerAccountId = accountType == ReceiptAccountType.Customer
                                    || accountType == ReceiptAccountType.Offset ? txtAccount.Id : null,

                VaultAccountId = accountType == ReceiptAccountType.Vault ? txtAccount.Id : null,
                BranchAccountId = accountType == ReceiptAccountType.Transfer ? txtAccount.Id : null,
                NumberOfAction = receiptActionsTable.Table.DataRowCount,

                SumOfReceipt = decimal.Parse(receiptActionsTable.colTransactionPrice.SummaryItem.SummaryValue.ToString()),
                //SumOfReceipt = decimal.Parse(receiptActionsTable.colTransactionPrice.SummaryText.Remove(0,1)),

                TermId = MainForm.TermId,
                BranchId = MainForm.BranchId
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
            {
                switch (txtAccountType.Text.GetEnum<ReceiptAccountType>())
                {
                    case ReceiptAccountType.Lawyer:
                        select.Select(txtAccount, CardType.Lawyer);
                        break;

                    case ReceiptAccountType.Bank:
                        select.Select(txtAccount, CardType.BankAccount, BankAccountType.DemandDepositAccount);
                        break;

                    case ReceiptAccountType.Customer:
                    case ReceiptAccountType.Offset:
                        select.Select(txtAccount, CardType.Customer);
                        break;

                    case ReceiptAccountType.Epos:
                        select.Select(txtAccount, CardType.BankAccount, BankAccountType.BlockedEposAccount);
                        break;

                    case ReceiptAccountType.Sps:
                        select.Select(txtAccount, CardType.BankAccount, BankAccountType.BlockedSpsAccount);
                        break;

                    case ReceiptAccountType.Pos:
                        select.Select(txtAccount, CardType.BankAccount, BankAccountType.BlockedPosAccount);
                        break;

                    case ReceiptAccountType.Vault:
                        select.Select(txtAccount, CardType.Vault);
                        break;

                        //case ReceiptAccountType.Transfer:
                        //    select.Select(txtAccount, CardType.Branch);
                        //    break;
                }
            }
        }

        protected override void Print()
        {
            var source = new List<ReceiptActionsReport>();
            for (int i = 0; i < receiptActionsTable.Table.DataRowCount; i++)
            {
                var entity = receiptActionsTable.Table.GetRow<ReceiptActionsList>(i);
                if (entity== null)return;

                var row = new ReceiptActionsReport
                {
                    StudentNumber = entity.StudentNumber,
                    Name = entity.Name,
                    Lastname = entity.Lastname,
                    ClassName = entity.ClassName,
                    BranchName = entity.StudentBranchName,
                    WalletNumber = entity.PaymentInformationsId,
                    PaymentMethodName = entity.PaymentMethodName,
                    PaymentTerm = entity.PaymentTerm,
                    PrincipalDebtor = entity.PrincipalDebtor,
                    Endorser = entity.Endorser,
                    BankAndBranchName = entity.BankName + " / " + entity.BankBranchName,
                    DocumentNumber = entity.DocumentNumber,
                    AccountNumber = entity.AccountNumber,
                    Price = entity.Price,
                    PriceBeforeTransaction = entity.PriceBeforeTransaction,
                    TransactionPrice = entity.TransactionPrice,
                    Date = txtDate.DateTime.Date,
                    ReceiptNumber = txtReceiptNumber.Text,
                    ReceiptType = ReceiptType.ToName(),
                    AccountType = _accountType.ToName(),
                    AccountName = txtAccount.Text,
                    DocumentStatus = entity.DocumentStatus.ToName()
                };

                source.Add(row);
            }

            ShowListForms<ReportSelection>.ShowDialogListForm(CardType.Report, false ,ReportSectionType.ReceiptReports, source);
        }

        protected override bool EntityInsert()
        {
            CreateCurrentObject();
            if (WrongData()) return false;

            if (receiptActionsTable.WrongData()) return false;

            var result = ((ReceiptBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                            && p.BranchId == MainForm.BranchId
                                            && p.TermId == MainForm.TermId) && receiptActionsTable.Save();

            if (result && !CloseFormPostRegistration) receiptActionsTable.Loads();
            return result;
        }

        protected override bool EntityUpdate()
        {
            CreateCurrentObject();
            if (WrongData()) return false;

            if (receiptActionsTable.WrongData()) return false;

            var result = ((ReceiptBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId
                                                       && p.TermId == MainForm.TermId) && receiptActionsTable.Save();

            if (result && !CloseFormPostRegistration) receiptActionsTable.Loads();
            return result;
        }

        protected override void EntityDelete()
        {
            if (!receiptActionsTable.MassDeleteAction()) return;

            //if (!((ReceiptBll) Bll).Delete(OldEntity)) return;
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;

            UpdateToDo = true;
            Close();
        }

        protected internal override void ButtonEnabledStatus()
        {
            if (!IsLoaded) return;

            if (AnotherBranchProcess) GeneralFunctions.ButtonEnabledStatus(btnNew, btnSave, btnUndo, btnDelete);
            else GeneralFunctions.ButtonEnabledStatus(btnNew, btnSave, btnUndo, btnDelete, OldEntity, CurrentEntity, receiptActionsTable.TableValueChanged);
        }

        protected internal bool WrongData()
        {
            if (!txtAccount.Visible || txtAccount.Id != null) return false;

            Messages.SelectionErrorMessage("Hesap");
            txtAccount.Focus();
            return true;
        }

        private void FieldProcesses()
        {
            Text = $"{Text} - {ReceiptType.ToName()}";

            txtDate.Properties.MinValue = MainForm.TermParameters.ReceiptDateCanEnteredBeforeDayDate
                ? MainForm.TermParameters.TermStartDate
                : DateTime.Now.Date;

            txtDate.Properties.MaxValue = MainForm.TermParameters.ReceiptDateCanEnteredAfterDayDate
                ? MainForm.TermParameters.TermStartDate
                : DateTime.Now.Date;

            switch (ReceiptType)
            {
                case ReceiptType.Blocking:
                case ReceiptType.Unblocking:
                    txtAccountType.Properties.Items.AddRange(Enum.GetValues(typeof(ReceiptAccountType)).Cast<ReceiptAccountType>()
                        .Where(p => p == ReceiptAccountType.Epos || p == ReceiptAccountType.Sps || p == ReceiptAccountType.Pos)
                        .Select(p => p.ToName()).ToList());
                    break;

                case ReceiptType.RefundToWallet:
                case ReceiptType.FreeRefundToWallet:
                    txtAccountType.Properties.Items.AddRange(Enum.GetValues(typeof(ReceiptAccountType)).Cast<ReceiptAccountType>()
                        .Where(p => p == ReceiptAccountType.Lawyer || p == ReceiptAccountType.Bank || p == ReceiptAccountType.Customer)
                        .Select(p => p.ToName()).ToList());
                    break;

                case ReceiptType.MarkAsPaid:
                case ReceiptType.MarkAsUnpaid:
                case ReceiptType.RefundToCustomer:
                case ReceiptType.ImpossibleCollect:
                    txtAccountType.Properties.Items.Add(_accountType.ToName());
                    layoutAccountName.Visibility = LayoutVisibility.Never;
                    break;

                default:
                    txtAccountType.Properties.Items.Add(_accountType.ToName());
                    break;
            }
        }

        protected internal void ReceiptTypeEnabled()
        {
            switch (ReceiptType)
            {
                case ReceiptType.Blocking:
                case ReceiptType.Unblocking:
                case ReceiptType.RefundToWallet:
                case ReceiptType.FreeRefundToWallet:
                case ReceiptType.SendingToLawyer:
                case ReceiptType.CollectedViaLawyer:
                case ReceiptType.SendingToBank:
                case ReceiptType.CollectedViaBank:
                case ReceiptType.Profiting:
                case ReceiptType.SendingToAnotherBranch:
                    txtAccount.Enabled = receiptActionsTable.Table.DataRowCount == 0;
                    txtAccountType.Enabled = receiptActionsTable.Table.DataRowCount == 0;
                    break;

                case ReceiptType.ApproveIncomingDocument:
                    txtAccountType.Enabled = false;
                    txtAccount.Enabled = false;
                    break;

            }
        }

        protected override void LoadTable()
        {
            receiptActionsTable.OwnerForm = this;
            receiptActionsTable.Loads();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtAccountType) return;

            txtAccount.Id = null;
            txtAccount.Text = null;
            txtAccount.Focus();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (layoutAccountName.Visible && txtAccount.Id == null) txtAccount.Focus();

            else receiptActionsTable.Table.GridControl.Focus();
        }
    }
}