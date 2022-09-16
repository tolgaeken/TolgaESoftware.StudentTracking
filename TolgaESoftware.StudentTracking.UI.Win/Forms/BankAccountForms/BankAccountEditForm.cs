using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BankAccountForms
{
    public partial class BankAccountEditForm : BaseEditForm
    {
        public BankAccountEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankAccountBll(myDataLayoutControl);
            txtBankAccountType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankAccountType>());
            BaseCardType = CardType.BankAccount;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new BankAccountSingle() : ((BankAccountBll)Bll).Single(FilterFunctions.Filter<BankAccount>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((BankAccountBll)Bll).GetNewCode(p => p.BranchId == MainForm.BranchId);
            txtBankAccountName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (BankAccountSingle)OldEntity;

            txtCode.Text = entity.Code;
            txtBankAccountName.Text = entity.BankAccountName;
            txtBankAccountType.SelectedItem = entity.BankAccountType.ToName();
            txtBankName.Id = entity.BankId;
            txtBankName.Text = entity.BankName;
            txtBankBranchName.Id = entity.BankBranchId;
            txtBankBranchName.Text = entity.BankBranchName;
            txtAccountOpeningDate.DateTime = entity.AccountOpeningDate;
            txtBankAccountNumber.Text = entity.AccountNumber;
            txtIbanNumber.Text = entity.IbanNumber;
            txtBlockedDay.Value = entity.BlockedDay;
            txtWorkplaceNumber.Text = entity.WorkplaceNumber;
            txtTerminalNumber.Text = entity.TerminalNumber;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new BankAccount
            {
                Id = Id,
                Code = txtCode.Text,
                BankAccountName = txtBankAccountName.Text,
                BankAccountType = txtBankAccountType.Text.GetEnum<BankAccountType>(),
                BankId = Convert.ToInt64(txtBankName.Id),
                BankBranchId = Convert.ToInt64(txtBankBranchName.Id),
                BlockedDay = (byte)txtBlockedDay.Value,
                WorkplaceNumber = txtWorkplaceNumber.Text,
                TerminalNumber = txtTerminalNumber.Text,
                AccountOpeningDate = txtAccountOpeningDate.DateTime.Date,
                AccountNumber = txtBankAccountNumber.Text,
                IbanNumber = txtIbanNumber.Text,
                SpecialCode1Id = txtSpecialCode1.Id,
                SpecialCode2Id = txtSpecialCode2.Id,
                BranchId = MainForm.BranchId,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtBankName) select.Select(txtBankName);
                else if (sender == txtBankBranchName) select.Select(txtBankBranchName, txtBankName);
                else if (sender == txtSpecialCode1) select.Select(txtSpecialCode1, CardType.BankAccount);
                else if (sender == txtSpecialCode2) select.Select(txtSpecialCode2, CardType.BankAccount);
        }

        protected override bool EntityInsert()
        {
            return ((BankAccountBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                            && p.BranchId == MainForm.BranchId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankAccountBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId);
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if(sender!=txtBankName) return;
            txtBankName.ControlEnabledChanged(txtBankBranchName);
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var accountType = edit.Text.GetEnum<BankAccountType>();

            if (accountType == BankAccountType.BlockedEposAccount
                || accountType == BankAccountType.BlockedSpsAccount
                || accountType == BankAccountType.BlockedPosAccount)
            {
                txtBlockedDay.Enabled = true;
                txtWorkplaceNumber.Enabled = true;
                txtTerminalNumber.Enabled = true;
            }

            else
            {
                txtBlockedDay.Enabled = false;
                txtWorkplaceNumber.Enabled = false;
                txtTerminalNumber.Enabled = false;
                txtBlockedDay.Value = 0;
                txtWorkplaceNumber.Text = null;
                txtTerminalNumber.Text = null;
            }
        }
    }
}