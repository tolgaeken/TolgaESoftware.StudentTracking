using System;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms
{
    public partial class RoleEditForm : BaseEditForm
    {
        public RoleEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new RoleBll(myDataLayoutControl);
            BaseCardType = CardType.Role;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Role() : ((RoleBll) Bll).Single(FilterFunctions.Filter<Role>(Id));
            LinkObjectToControls();

            LoadTable();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((RoleBll) Bll).GetNewCode();
            txtRoleName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Role) OldEntity;

            txtCode.Text = entity.Code;
            txtRoleName.Text = entity.RoleName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Role
            {
                Id = Id,
                Code = txtCode.Text,
                RoleName = txtRoleName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void LoadTable()
        {
            roleAuthorizationsTable.OwnerForm = this;
            roleAuthorizationsTable.Loads();
        }

        protected internal override void ButtonEnabledStatus()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledStatus
                (btnNew, btnSave, btnUndo, btnDelete, OldEntity, CurrentEntity, roleAuthorizationsTable.TableValueChanged);
        }

        protected override bool EntityInsert()
        {

            return ((RoleBll)Bll)
                   .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code) && roleAuthorizationsTable.Save();
        }

        protected override bool EntityUpdate()
        {

            return ((RoleBll) Bll)
                   .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code) &&
                   roleAuthorizationsTable.Save();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (BaseProcessType == ProcessType.EntityUpdate)
                roleAuthorizationsTable.Table.Focus();
        }
    }
}