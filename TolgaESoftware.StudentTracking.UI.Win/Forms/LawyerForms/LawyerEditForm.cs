using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.LawyerForms
{
    public partial class LawyerEditForm : BaseEditForm
    {
        public LawyerEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new LawyerBll(myDataLayoutControl);
            BaseCardType = CardType.Lawyer;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new LawyerSingle() : ((LawyerBll) Bll).Single(FilterFunctions.Filter<Lawyer>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((LawyerBll) Bll).GetNewCode();
            txtNameLastname.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (LawyerSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtTrIdentityNumber.Text = entity.TrIdentityNumber;
            txtNameLastname.Text = entity.NameLastname;
            txtContractNumber.Text = entity.ContractNumber;
            txtContractStartDate.EditValue = entity.ContractStartDate;
            txtContractEndDate.EditValue = entity.ContractEndDate;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Lawyer
            {
                Id = Id,
                Code = txtCode.Text,
                TrIdentityNumber = txtTrIdentityNumber.Text,
                NameLastname = txtNameLastname.Text,
                ContractNumber = txtContractNumber.Text,
                ContractStartDate = (DateTime?) txtContractStartDate.EditValue,
                ContractEndDate = (DateTime?) txtContractEndDate.EditValue,
                SpecialCode1Id = txtSpecialCode1.Id,
                SpecialCode2Id = txtSpecialCode2.Id,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtSpecialCode1) select.Select(txtSpecialCode1,CardType.Lawyer);
                else if (sender == txtSpecialCode2) select.Select(txtSpecialCode2,CardType.Lawyer);
        }
    }
}