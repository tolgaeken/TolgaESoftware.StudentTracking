using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceForms
{
    public partial class ServiceEditForm : BaseEditForm
    {
        public ServiceEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new ServiceBll(myDataLayoutControl);
            BaseCardType = CardType.Service;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new ServiceSingle() : ((ServiceBll)Bll).Single(FilterFunctions.Filter<Service>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((ServiceBll)Bll).
                GetNewCode(p => p.BranchId == MainForm.BranchId && p.TermId==MainForm.TermId);
            txtStartDate.DateTime = txtStartDate.Properties.MinValue;
            txtEndDate.DateTime = txtEndDate.Properties.MaxValue;
            txtServiceName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (ServiceSingle)OldEntity;

            txtCode.Text = entity.Code;
            txtServiceName.Text = entity.ServiceName;
            txtServiceType.Id = entity.ServiceTypeId;
            txtServiceType.Text = entity.ServiceTypeName;
            txtStartDate.DateTime = entity.StartDate;
            txtEndDate.DateTime = entity.EndDate;
            txtPrice.Value = entity.Price;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Service
            {
                Id = Id,
                Code = txtCode.Text,
                ServiceName = txtServiceName.Text,
                ServiceTypeId = Convert.ToInt64(txtServiceType.Id),
                StartDate = txtStartDate.DateTime.Date,
                EndDate = txtEndDate.DateTime.Date,
                Price = txtPrice.Value,
                Statement = txtStatement.Text,
                BranchId = MainForm.BranchId,
                TermId = MainForm.TermId,
                Status = tglStatus.IsOn

            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtServiceType) select.Select(txtServiceType);
        }

        protected override bool EntityInsert()
        {
            return ((ServiceBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                            && p.BranchId == MainForm.BranchId
                                            && p.TermId == MainForm.TermId);
        }

        protected override bool EntityUpdate()
        {
            return ((ServiceBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId
                                                       && p.TermId == MainForm.TermId);
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            base.Control_EditValueChanged(sender, e);

            txtStartDate.Properties.MinValue = MainForm.TermParameters.EducationStartDate;
            txtStartDate.Properties.MaxValue = MainForm.TermParameters.TermEndDate;
            txtEndDate.Properties.MinValue = txtStartDate.DateTime.Date;
            txtEndDate.Properties.MaxValue = MainForm.TermParameters.TermEndDate;
        }
    }
}