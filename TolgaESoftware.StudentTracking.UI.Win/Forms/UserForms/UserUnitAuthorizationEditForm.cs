using System;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms
{
    public partial class UserUnitAuthorizationEditForm : BaseEditForm
    {
        public UserUnitAuthorizationEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
            HideItems = new BarItem[] { btnNew, btnDelete, btnSave, btnUndo };
            LoadTable();
        }

        public override void Loads()
        {
            branchTable.Loads();
            termTable.Loads();
        }

        protected internal override void ButtonEnabledStatus() { }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            userTable.Table.Focus();
        }

        protected override void LoadTable()
        {
            userTable.OwnerForm = this;
            branchTable.OwnerForm = this;
            termTable.OwnerForm = this;
            userTable.Loads();
        }
    }
}