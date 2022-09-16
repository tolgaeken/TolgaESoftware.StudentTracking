using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Events;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class TermParameterEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _termId;
        #endregion

        public TermParameterEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new TermParameterBll();
            BaseCardType = CardType.TermParameter;
            HideItems = new BarItem[] { btnNew, btnDelete };
            CloseFormPostRegistration = false;
            EventsLoad();

            _termId = (long)prm[0];
        }

        protected override void LinkObjectToControls()
        {
            var parameter = (TermParameter)OldEntity;

            var entity = new TermParameter
            {
                Id = parameter.Id,
                Code = parameter.Code,
                BranchId = parameter.BranchId,
                TermId = parameter.TermId,
                TermStartDate = parameter.TermStartDate,
                TermEndDate = parameter.TermEndDate,
                EducationStartDate = parameter.EducationStartDate,
                EducationEndDate = parameter.EducationEndDate,
                ServiceStartDateCanEnteredBeforeDayDate = parameter.ServiceStartDateCanEnteredBeforeDayDate,
                ServiceStartDateCanEnteredAfterDayDate = parameter.ServiceStartDateCanEnteredAfterDayDate,
                CancellationDateCanEnteredBeforeDayDate = parameter.CancellationDateCanEnteredBeforeDayDate,
                CancellationDateCanEnteredAfterDayDate = parameter.CancellationDateCanEnteredAfterDayDate,
                ReceiptDateCanEnteredBeforeDayDate = parameter.ReceiptDateCanEnteredBeforeDayDate,
                ReceiptDateCanEnteredAfterDayDate = parameter.ReceiptDateCanEnteredAfterDayDate,
                UseServiceAccruePenny = parameter.UseServiceAccruePenny,
                UseDiscountAccruePenny = parameter.UseDiscountAccruePenny,
                UsePaymentPlanPenny = parameter.UsePaymentPlanPenny,
                UseBillAccruePenny = parameter.UseBillAccruePenny,
                MaxInstallmentDate = parameter.MaxInstallmentDate,
                NumberOfMaximumInstallment = parameter.NumberOfMaximumInstallment,
                HasRequiredSchoolToGoes = parameter.HasRequiredSchoolToGoes,
                AuthorizationControlWillBeInstantly = parameter.AuthorizationControlWillBeInstantly
            };

            Id = entity.Id;

            propertyGridControl.SelectedObject = entity;
        }

        protected override void CreateCurrentObject()
        {
            if (txtBranch.Id == null)
            {
                OldEntity = new TermParameter();
                CurrentEntity = new TermParameter();
                ButtonEnabledStatus();
                return;
            }

            CurrentEntity = new TermParameter
            {
                Id = Id,
                Code = Id.ToString(),
                BranchId = (long)txtBranch.Id,
                TermId = _termId,
                TermStartDate = (DateTime)TermStartDate.Value,
                TermEndDate = (DateTime)TermEndDate.Value,
                EducationStartDate = (DateTime)EducationStartDate.Value,
                EducationEndDate = (DateTime)EducationEndDate.Value,
                ServiceStartDateCanEnteredBeforeDayDate = (bool)ServiceStartDateCanEnteredBeforeDayDate.Properties.Value,
                ServiceStartDateCanEnteredAfterDayDate = (bool)ServiceStartDateCanEnteredAfterDayDate.Properties.Value,
                CancellationDateCanEnteredBeforeDayDate = (bool)CancellationDateCanEnteredBeforeDayDate.Properties.Value,
                CancellationDateCanEnteredAfterDayDate = (bool)CancellationDateCanEnteredAfterDayDate.Properties.Value,
                ReceiptDateCanEnteredBeforeDayDate = (bool)ReceiptDateCanEnteredBeforeDayDate.Properties.Value,
                ReceiptDateCanEnteredAfterDayDate = (bool)ReceiptDateCanEnteredAfterDayDate.Properties.Value,
                UseServiceAccruePenny = (bool)UseServiceAccruePenny.Properties.Value,
                UseDiscountAccruePenny = (bool)UseDiscountAccruePenny.Properties.Value,
                UsePaymentPlanPenny = (bool)UsePaymentPlanPenny.Properties.Value,
                UseBillAccruePenny = (bool)UseBillAccruePenny.Properties.Value,
                MaxInstallmentDate = (DateTime)MaxInstallmentDate.Properties.Value,
                NumberOfMaximumInstallment = (byte)NumberOfMaximumInstallment.Properties.Value,
                HasRequiredSchoolToGoes = (bool)HasRequiredSchoolToGoes.Properties.Value,
                AuthorizationControlWillBeInstantly = (bool)AuthorizationControlWillBeInstantly.Properties.Value,

            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtBranch) select.Select(txtBranch);
        }

        protected override void Control_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            CreateCurrentObject();
        }

        protected override void Control_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            StatusBarStatement.Caption = e.Row.Properties.Caption;
        }

        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!(sender is ButtonEdit)) return;

            if (txtBranch.Id == null) return;

            OldEntity = ((TermParameterBll) Bll).Single(p => p.BranchId == txtBranch.Id && p.TermId == _termId) ?? new TermParameter();
            BaseProcessType = OldEntity.Id == 0 ? ProcessType.EntityInsert : ProcessType.EntityUpdate;
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if(sender!=txtBranch) return;
            txtBranch.ControlEnabledChanged(propertyGridControl);
            CreateCurrentObject();
        }
    }
}