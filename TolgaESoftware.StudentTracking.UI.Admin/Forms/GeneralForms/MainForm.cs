using System.Security;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BranchForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.TermForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Admin.Forms.GeneralForms
{
    public partial class MainForm : RibbonForm
    {
        #region Variables
        private readonly string _server;
        private readonly SecureString _userName;
        private readonly SecureString _password;
        private readonly AuthenticationType _authenticationType;
        private readonly InstitutionBll _bll; 
        #endregion

        public MainForm(params object[] prm)
        {
            InitializeComponent();

            longNavigator.navigator.NavigatableControl = table.GridControl;
            EventsLoad();
            ButtonEnabledStatus();

            _server = prm[0].ToString();
            _userName = (SecureString)prm[1];
            _password = (SecureString)prm[2];
            _authenticationType = (AuthenticationType)prm[3];
            _bll = new InstitutionBll();
        }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table Events
            table.DoubleClick += Table_DoubleClick;
            table.KeyDown += Table_KeyDown;
            table.MouseUp += Table_MouseUp;
            table.RowCountChanged += Table_RowCountChanged;

            //Form Events
            Closing += MainForm_Closing;
            Load += MainForm_Load;
        }

        private void ButtonEnabledStatus()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                if(!(button is BarButtonItem item)) continue;
                if (item != btnNew) item.Enabled = table.DataRowCount > 0;

            }
        }

        protected internal void List()
        {
            table.GridControl.DataSource = _bll.List(null);
        }

        protected virtual void ShowEditForm(long id)
        {
            GeneralFunctions.CreateConnectionString("TolgaESoftwareStudentTrackingAdmin", _server, _userName, _password, _authenticationType);

            var result = ShowEditForms<InstitutionEditForm>.ShowDialogEditForm(id, _server, _userName, _password,_authenticationType);

            if (result <= 0) return;
            List();
            table.RowFocus("Id", result);
        }

        private void EntityDelete(BaseEntity entity)
        {
            GeneralFunctions.CreateConnectionString(entity.Code, _server, _userName, _password, _authenticationType);

            if (!Functions.GeneralFunctions.DeleteDatabase<StudentTrackingAdminContext>()) return;

            GeneralFunctions.CreateConnectionString("TolgaESoftwareStudentTrackingAdmin", _server, _userName, _password, _authenticationType);

            _bll.Delete(entity);
            table.DeleteSelectedRows();
            table.RowFocus(table.FocusedRowHandle);
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnNew || e.Item == btnEdit)
            {
                if (e.Item == btnNew) ShowEditForm(-1);

                else if (e.Item == btnEdit) ShowEditForm(table.GetRowId());
            }

            else
            {
                var entity = table.GetRow<Institution>();
                if(entity==null) return;
                GeneralFunctions.CreateConnectionString(entity.Code, _server, _userName, _password, _authenticationType);

                if(e.Item == btnDelete) EntityDelete(entity);

                else if (e.Item == btnEMailParameters) ShowEditForms<EmailParameterEditForm>.ShowDialogEditForm();

                else if (e.Item == btnBranchCards) ShowListForms<BranchListForm>.ShowDialogListForm();
                
                else if (e.Item == btnTermCards) ShowListForms<TermListForm>.ShowDialogListForm();

                else if (e.Item == btnInstitutionInformations) ShowEditForms<InstitutionInformationsEditForm>.ShowDialogEditForm(null,entity.Code,entity.InstitutionName);
               
                else if (e.Item == btnRoleCards) ShowListForms<RoleListForm>.ShowDialogListForm();
               
                else if (e.Item == btnUserCards) ShowListForms<UserListForm>.ShowDialogListForm();
               
                else if (e.Item == btnUserUnitAuthorizations) ShowEditForms<UserUnitAuthorizationEditForm>.ShowDialogEditForm();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Table_DoubleClick(object sender, System.EventArgs e)
        {
            if(table.FocusedRowHandle<0) return;

            ShowEditForm(table.GetRowId());
        }

        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            if(table.FocusedRowHandle<0) return;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowEditForm(table.GetRowId());
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Table_MouseUp(object sender, MouseEventArgs e)
        {
            e.ShowRightClickMenu(rightClickMenu);
        }

        private void Table_RowCountChanged(object sender, System.EventArgs e)
        {
            ButtonEnabledStatus();
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Messages.NoSelectedYesNo("Programdan Çıkış Yapılacaktır.\nOnaylıyor musunuz?", "Çıkış Onay") ==
                DialogResult.Yes)
                Application.ExitThread();

            else e.Cancel = true;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            List();
            table.Focus();
        }
    }
}