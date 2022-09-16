using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.VaultForms
{
    public partial class VaultEditForm : BaseEditForm
    {
        public VaultEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new VaultBll(myDataLayoutControl);
            BaseCardType = CardType.Vault;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new VaultSingle() : ((VaultBll) Bll).Single(FilterFunctions.Filter<Vault>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((VaultBll) Bll).GetNewCode(p=>p.BranchId==MainForm.BranchId && p.TermId==MainForm.TermId);
            txtVaultName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (VaultSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtVaultName.Text = entity.VaultName;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Vault
            {
                Id = Id,
                Code = txtCode.Text,
                VaultName = txtVaultName.Text,
                SpecialCode1Id = txtSpecialCode1.Id,
                SpecialCode2Id = txtSpecialCode2.Id,
                BranchId = MainForm.BranchId,
                TermId = MainForm.TermId,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtSpecialCode1) select.Select(txtSpecialCode1,CardType.Vault);
                else if (sender == txtSpecialCode2) select.Select(txtSpecialCode2,CardType.Vault);
        }

        protected override bool EntityInsert()
        {
            return ((VaultBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                            && p.BranchId == MainForm.BranchId
                                            && p.TermId == MainForm.TermId);
        }

        protected override bool EntityUpdate()
        {
            return ((VaultBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId
                                                       && p.TermId == MainForm.TermId);
        }
    }
}