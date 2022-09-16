using System;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class UserParameterEditForm : BaseEditForm
    {
        private readonly long _userId;

        public UserParameterEditForm(params object[] prm)
        {
            InitializeComponent();

            _userId = (long)prm[0];

            DataLayoutControl = myDataLayoutControl;
            Bll = new UserParameterBll();
            BaseCardType = CardType.UserParameter;
            HideItems = new BarItem[] { btnNew, btnDelete };

            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = ((UserParameterBll)Bll).Single(p => p.UserId == _userId) ?? new UserParameterSingle();
            BaseProcessType = OldEntity.Id == 0 ? ProcessType.EntityInsert : ProcessType.EntityUpdate;
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
        }

        protected override void LinkObjectToControls()
        {
            var entity = (UserParameterSingle)OldEntity;

            Id = entity.Id;
            txtDefaultLawyerAccount.Id = entity.DefaultLawyerAccountId;
            txtDefaultLawyerAccount.Text = entity.DefaultLawyerAccountName;
            txtDefaultBankAccount.Id = entity.DefaultBankAccountId;
            txtDefaultBankAccount.Text = entity.DefaultBankAccountName;
            txtDefaultVaultAccount.Id = entity.DefaultVaultAccountId;
            txtDefaultVaultAccount.Text = entity.DefaultVaultAccountName;
            chkCloseReportsWithoutConfirmation.Checked = entity.CloseReportsWithoutConfirmation;
            txtTableViewCaptionForeColor.Color = Color.FromArgb(entity.TableViewCaptionForeColor);
            txtTableColumnHeaderForeColor.Color = Color.FromArgb(entity.TableColumnHeaderForeColor);
            txtTableBandPanelForeColor.Color = Color.FromArgb(entity.TableBandPanelForeColor);
            pictBackgroundImage.EditValue = entity.BackgroundImage;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new UserParameter
            {
                Id = Id,
                Code = "Param-001",
                UserId = MainForm.UserId,
                DefaultLawyerAccountId = txtDefaultLawyerAccount.Id,
                DefaultBankAccountId = txtDefaultBankAccount.Id,
                DefaultVaultAccountId = txtDefaultVaultAccount.Id,
                CloseReportsWithoutConfirmation = chkCloseReportsWithoutConfirmation.Checked,
                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtTableBandPanelForeColor.Color.ToArgb(),
                BackgroundImage = (byte[]) pictBackgroundImage.EditValue,
            };

            ButtonEnabledStatus();
        }

        

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new UserParameterSingle
            {
                DefaultLawyerAccountId = txtDefaultLawyerAccount.Id,
                DefaultLawyerAccountName = txtDefaultLawyerAccount.Text,
                DefaultBankAccountId = txtDefaultBankAccount.Id,
                DefaultBankAccountName = txtDefaultBankAccount.Text,
                DefaultVaultAccountId = txtDefaultVaultAccount.Id,
                DefaultVaultAccountName = txtDefaultVaultAccount.Text,
                CloseReportsWithoutConfirmation = chkCloseReportsWithoutConfirmation.Checked,
                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtTableBandPanelForeColor.Color.ToArgb(),
                BackgroundImage = (byte[]) pictBackgroundImage.EditValue
            };

            return entity;
        }

        protected override bool EntityInsert()
        {
            var result =  base.EntityInsert();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        protected override bool EntityUpdate()
        {
           var result =  base.EntityUpdate();
           if (!result) return false;

           ReturnEntity();
           return true;
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit image)) return;
            image.Select(imageMenu);
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtDefaultLawyerAccount) select.Select(txtDefaultLawyerAccount);
                else if (sender == txtDefaultBankAccount) select.Select(txtDefaultBankAccount);
                else if (sender == txtDefaultVaultAccount) select.Select(txtDefaultVaultAccount);
        }
    }
}