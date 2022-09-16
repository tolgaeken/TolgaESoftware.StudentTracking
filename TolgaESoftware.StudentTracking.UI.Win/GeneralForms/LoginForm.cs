using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class LoginForm : XtraForm
    {
        #region Variables

        private Point _mouseLocation;
        private List<Institution> _source;

        #endregion

        public LoginForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            //Control Events
            foreach (Control control in Controls)
            {
                if (!(control is MyDataLayoutControl)) continue;

                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control control1 in control.Controls)
                {
                    control1.KeyDown += Control_KeyDown;

                    switch (control1)
                    {
                        case MySimpleButton btn:
                            btn.Click += Control_Click;
                            break;

                        case MyHyperLinkLabelControl hyper:
                            hyper.Click += Control_Click;
                            break;

                    }
                }
            }

            //Form Events
            Shown += LoginForm_Shown;
            Load += LoginForm_Load;
        }

        private void Loads()
        {
            txtVersion.Text = $"Version : {Assembly.GetExecutingAssembly().GetName().Version}";


            var server = ConfigurationManager.AppSettings["Server"];
            var authenticationType = ConfigurationManager.AppSettings["AuthenticationType"].GetEnum<AuthenticationType>();
            var userName = ConfigurationManager.AppSettings["UserName"].ConvertToSecureString();
            var password = ConfigurationManager.AppSettings["Password"].ConvertToSecureString();

            if (!Functions.GeneralFunctions.ConnectionControl(server, userName, password, authenticationType, true))
            {
                txtInstitution.Properties.DataSource = null;
                if (ShowEditForms<ConnectionSettingsEditForm>.ShowDialogEditForm(ProcessType.EntityUpdate))
                    Loads();
                return;
            }

            Functions.GeneralFunctions.CreateConnectionString("TolgaESoftwareStudentTrackingAdmin", server, userName, password, authenticationType);

            using (var bll = new InstitutionBll())
            {
                _source = bll.List(null).Cast<Institution>().ToList();

                txtInstitution.Properties.DataSource = _source;
                txtInstitution.Properties.ValueMember = "Code";
                txtInstitution.Properties.DisplayMember = "InstitutionName";
                txtInstitution.ItemIndex = 0;
            }
        }

        private void CreateConnection()
        {
            if (txtInstitution.Text == "")
            {
                Messages.ErrorMessage("Kurum Seçimi Yapmalısınız");
                txtInstitution.Focus();
                return;
            }

            var institution = _source[txtInstitution.ItemIndex];
            var code = institution.Code;
            var server = institution.Server;
            var authenticationType = institution.AuthenticationType;
            var userName = institution.UserName.Decrypt(institution.Id+institution.Code).ConvertToSecureString();
            var password = institution.Password.Decrypt(institution.Id+institution.Code).ConvertToSecureString();

            if (!Functions.GeneralFunctions.ConnectionControl(server, userName, password, authenticationType)) return;

            Functions.GeneralFunctions.CreateConnectionString(code, server, userName, password, authenticationType);

        }

        private void Login()
        {
            CreateConnection();

            using (var userBll = new UserBll())
            {
                var user = (UserSingle) userBll.SingleDetail(p => p.Code == txtUserName.Text);

                if (user == null || txtPassword.Text.Md5Crypt() != user.Password)
                {
                    Messages.ErrorMessage("Kullanıcı Adı veya Parola Hatalıdır\nLütfen Kontrol Edip Tekrar Deneyiniz");
                    txtUserName.Focus();
                    return;
                }

                if (!user.Status)
                {
                    Messages.ErrorMessage("Kullanıcı Pasif Durumdadır\nGiriş Yapılamaz");
                    txtUserName.Focus();
                    return;
                }

                using (var userParameterBll = new UserParameterBll())
                {
                    var entity = (UserParameterSingle) userParameterBll.Single(p => p.UserId == user.Id);
                    MainForm.UserParameters = entity ?? new UserParameterSingle();

                    MainForm.InstitutionName = txtInstitution.Text;
                    MainForm.UserId = user.Id;
                    MainForm.UserName = user.Name;
                    MainForm.UserRoleId = user.RoleId;
                    MainForm.UserRoleName = user.RoleName;

                    Hide();

                    ShowRibbonForms<MainForm>.ShowForm(false);
                }
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var position = MousePosition;
            position.Offset(_mouseLocation.X, _mouseLocation.Y);
            Location = position;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            if (!(sender is MySimpleButton button)) return;

            if (button == btnForgotPassword)
            {
                CreateConnection();
                ShowEditForms<ForgotPasswordEditForm>.ShowDialogEditForm(ProcessType.EntityUpdate, txtUserName.Text);
            }
            else if (button == btnConnectionSettings)
            {
                if(ShowEditForms<ConnectionSettingsEditForm>.ShowDialogEditForm(ProcessType.EntityUpdate))
                    Loads();
            }
            else if (button == btnLogin)
            {
                Cursor.Current = Cursors.WaitCursor;
                Login();
                Cursor.Current = Cursors.Default;
            }
            else if (button == btnCancel) Close();
        }


        private void LoginForm_Shown(object sender, System.EventArgs e)
        {
            txtUserName.Focus();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            //splash
            Loads();
            //splash
        }
    }
}