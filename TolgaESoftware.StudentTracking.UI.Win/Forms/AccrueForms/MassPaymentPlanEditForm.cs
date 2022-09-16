using System;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms
{
    public partial class MassPaymentPlanEditForm : BaseEditForm
    {
        #region Variables
        private PaymentType _paymentType;
        private byte _blockedDay;

        private readonly IList _source;
        private readonly long _accrueId;
        private readonly decimal _balance;
        private readonly DateTime _registrationDate;
        private readonly int _numberOfBeforeEnteredInstallment;
        #endregion

        public MassPaymentPlanEditForm(IList source, long accrueId, decimal balance, DateTime registrationDate, int numberOfBeforeEnteredInstallment)
        {
            InitializeComponent();

            _source = source;
            _accrueId = accrueId;
            _balance = balance;
            _registrationDate = registrationDate;
            _numberOfBeforeEnteredInstallment = numberOfBeforeEnteredInstallment;

            DataLayoutControl = myDataLayoutControl;
            EventsLoad();

            ShowItems = new BarItem[] { btnCreateInstallment };
            HideItems = new BarItem[] { btnNew, btnSave, btnSaveAs, btnUndo, btnDelete, btnPrint, btnPreview };
        }

        public override void Loads()
        {
            ControlEnableChange(PaymentType.Open);
            txtFirstInstallmentDate.DateTime = _registrationDate;
            txtFirstInstallmentDate.Properties.MinValue = _registrationDate;
            txtFirstInstallmentDate.Properties.MaxValue = MainForm.TermParameters.MaxInstallmentDate;
            txtFixedInstallment.Value = 0;
            txtBalance.Value = _balance;
            txtNumberOfInstallment.Properties.MinValue = 1;
            txtNumberOfInstallment.Properties.MaxValue = MainForm.TermParameters.NumberOfMaximumInstallment - _numberOfBeforeEnteredInstallment;

            if (MainForm.TermParameters.NumberOfMaximumInstallment - _numberOfBeforeEnteredInstallment > 0) ShowDialog();
            else Messages.ErrorMessage("Maksimum Taksit Sayısı Aşılıyor");
        }

        private void ControlEnableChange(PaymentType paymentType)
        {
            txtBankAccount.Enabled = paymentType == PaymentType.Epos || paymentType == PaymentType.Sps || paymentType == PaymentType.Pos;
            txtPrincipalDebtor.Enabled = paymentType == PaymentType.Cheque || paymentType == PaymentType.Indenture;
            txtEndorser.Enabled = paymentType == PaymentType.Cheque || paymentType == PaymentType.Indenture;
            txtBankName.Enabled = paymentType == PaymentType.Cheque;
            txtBankBranchName.Enabled = paymentType == PaymentType.Cheque;
            txtAccountNumber.Enabled = paymentType == PaymentType.Cheque;
            txtFirstDocumentNumber.Enabled = paymentType == PaymentType.Cheque;
            txtBankName.ControlEnabledChanged(txtBankBranchName);
        }

        private bool WrongData()
        {
            if (txtFirstInstallmentDate.DateTime.Date.AddMonths((int)txtNumberOfInstallment.Value-1) >
                MainForm.TermParameters.MaxInstallmentDate)
            {
                Messages.ErrorMessage("Maksimum Taksit Tarihi Aşılıyor");
                return true;
            }

            if (txtPaymentMethod.Id == null)
            {
                Messages.ErrorMessage("Ödeme Türü Seçimi Yapmalısınız");
                txtPaymentMethod.Focus();
                return true;
            }

            if ((_paymentType == PaymentType.Epos || _paymentType == PaymentType.Sps ||
                 _paymentType == PaymentType.Pos) && txtPaymentMethod.Id == null)
            {
                Messages.SelectionErrorMessage("Banka Hesap");
                txtBankAccount.Focus();
                return true;
            }

            if ((txtFixedInstallment.Value == 0 && txtBalance.Value == 0) ||
                (txtFixedInstallment.Value > 0 && txtBalance.Value > 0))
            {
                Messages.ErrorMessage("Sabiti Taksit veya Bakiye Alanlarından Sadece Birinin Değeri Sıfıra Eşit veya Sıfırdan Büyük Olmalıdır");
                txtFixedInstallment.Focus();
                return true;
            }

            if ((_paymentType == PaymentType.Indenture || _paymentType == PaymentType.Cheque)
                && String.IsNullOrEmpty(txtPrincipalDebtor.Text))
            {
                Messages.WrongDataMessage("Asıl Borçlu");
                txtPrincipalDebtor.Focus();
                return true;
            }

            switch (_paymentType)
            {
                case PaymentType.Cheque when txtBankName.Id == null:
                    Messages.SelectionErrorMessage("Banka");
                    txtBankName.Focus();
                    return true;

                case PaymentType.Cheque when txtBankBranchName.Id == null:
                    Messages.SelectionErrorMessage("Banka Şube");
                    txtBankBranchName.Focus();
                    return true;

                case PaymentType.Cheque when txtFirstDocumentNumber.Value == 0:
                    Messages.WrongDataMessage("İlk Belge No");
                    txtFirstDocumentNumber.Focus();
                    return true;
            }

            return false;
        }

        protected override void CreateInstallment()
        {
            if (WrongData()) return;
            txtPaymentMethod.Focus();

            var price = txtFixedInstallment.Value != 0
                ? txtFixedInstallment.Value
                : Math.Round(txtBalance.Value / txtNumberOfInstallment.Value, MainForm.TermParameters.UsePaymentPlanPenny ? 2 : 0);

            decimal sumOfEnteredPrice = 0;

            for (int i = 0; i < txtNumberOfInstallment.Value; i++)
            {
                var installment = new PaymentInformationsList
                {
                    Id = 0,
                    AccrueId = _accrueId,
                    PaymentType = _paymentType,
                    PaymentMethodId = (long)txtPaymentMethod.Id,
                    PaymentMethodName = txtPaymentMethod.Text,
                    EntryDate = DateTime.Now.Date,
                    PaymentTerm = txtFirstInstallmentDate.DateTime.Date.AddMonths(i),
                    AccountTransferDate = txtFirstInstallmentDate.DateTime.Date.AddMonths(i),
                    Price = i == txtNumberOfInstallment.Value - 1 && txtFixedInstallment.Value == 0 ? txtBalance.Value - sumOfEnteredPrice : price,
                    DocumentStatus = DocumentStatus.OnWallet,
                    Insert = true
                };

                installment.PriceAsText = installment.Price.PriceAsText();
                installment.PaymentTermAsTxt = installment.PaymentTerm.PaymentTermAsTextDate();
                installment.Remaining = installment.Price;
                sumOfEnteredPrice += installment.Price;

                switch (_paymentType)
                {
                    case PaymentType.Epos:
                    case PaymentType.Sps:
                    case PaymentType.Pos:
                        installment.BankAccountId = txtBankAccount.Id;
                        installment.BankAccountName = txtBankAccount.Text;
                        installment.BlockedDay = _blockedDay;
                        installment.AccountTransferDate = installment.PaymentTerm.Date.AddDays(_blockedDay);
                        break;

                    case PaymentType.Indenture:
                        installment.PrincipalDebtor = txtPrincipalDebtor.Text;
                        installment.Endorser = txtEndorser.Text;
                        break;

                    case PaymentType.Cheque:
                        installment.PrincipalDebtor = txtPrincipalDebtor.Text;
                        installment.Endorser = txtEndorser.Text;
                        installment.BankId = txtBankName.Id;
                        installment.BankName = txtBankName.Text;
                        installment.BankBranchId = txtBankBranchName.Id;
                        installment.BankBranchName = txtBankBranchName.Text;
                        installment.AccountNumber = txtAccountNumber.Text;
                        installment.DocumentNumber = ((int)txtFirstDocumentNumber.Value + i).ToString();
                        break;
                }

                _source.Add(installment);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
            {
                if (sender == txtPaymentMethod) select.Select(txtPaymentMethod);
                else if(sender==txtBankAccount) select.Select(txtBankAccount,_paymentType);
                else if(sender==txtBankName) select.Select(txtBankName);
                else if(sender==txtBankBranchName) select.Select(txtBankBranchName,txtBankName);
            }
            
        }

        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (sender == txtPaymentMethod)
            {
                _paymentType = txtPaymentMethod.Id == null
                    ? PaymentType.Open
                    : txtPaymentMethod.Tag.ToString().GetEnum<PaymentType>();

                ControlEnableChange(_paymentType);
                txtBankAccount.Id = null;
                txtBankAccount.Text = null;
            }

            else if (sender == txtBankAccount) _blockedDay = Convert.ToByte(txtBankAccount.Tag);

            else if (sender == txtBankName)
            {
                txtBankBranchName.Id = null;
                txtBankBranchName.Text = null;
            }
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if(sender!=txtBankName) return;
            txtBankName.ControlEnabledChanged(txtBankBranchName);
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTemplate();
            if(DialogResult!=DialogResult.Cancel) return;

            if (Messages.NoSelectedYesNo("Taksit Oluşturma Paneli Kapatılacaktır.\nOnaylıyor musunuz?", "Uyarı") ==
                DialogResult.No) e.Cancel = true;
        }
    }
}