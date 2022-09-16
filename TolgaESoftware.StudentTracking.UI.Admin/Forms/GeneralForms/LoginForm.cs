using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Admin.Forms.GeneralForms
{
    public partial class LoginForm : XtraForm
    {
        private Point _mouseLocation;

        public LoginForm()
        {
            InitializeComponent();
            txtAuthenticationType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AuthenticationType>());
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

                        case MyComboBoxEdit edit:
                            edit.SelectedValueChanged += Control_SelectedValueChanged;
                            break;

                    }
                }
            }

            //Form Events
            Shown += LoginForm_Shown;
        }

        private void Loads()
        {
            txtVersion.Text = $"Version : {Assembly.GetExecutingAssembly().GetName().Version}";


            var connectionStringArray = Bll.Functions.GeneralFunctions.GetConnectionString().Split(';');
            var dictionary = new Dictionary<string, string>();

            connectionStringArray.ForEach(p =>
            {
                var row = p.Split('=');
                dictionary.Add(row[0], row[1]);
            });

            txtServer.Text = dictionary.GetValueOrDefault("Data Source","");
            txtAuthenticationType.SelectedItem = dictionary.ContainsKey("Password")
                ? AuthenticationType.SqlServerAuthentication.ToName()
                : AuthenticationType.WindowsAuthentication.ToName();

            if (txtAuthenticationType.Text.GetEnum<AuthenticationType>() == AuthenticationType.SqlServerAuthentication)
                txtUserName.Focus();

            else btnLogin.Focus();
        }

        private void Login()
        {
            if (!Win.Functions.GeneralFunctions.ConnectionControl(txtServer.Text,
                txtUserName.Text.ConvertToSecureString(), txtPassword.Text.ConvertToSecureString(),
                txtAuthenticationType.Text.GetEnum<AuthenticationType>())) return;

            Win.Functions.GeneralFunctions.CreateConnectionString("TolgaESoftwareStudentTrackingAdmin", txtServer.Text,
                txtUserName.Text.ConvertToSecureString(), txtPassword.Text.ConvertToSecureString(),
                txtAuthenticationType.Text.GetEnum<AuthenticationType>());

            if (!Functions.GeneralFunctions.CreateDatabase<StudentTrackingAdminContext>("Lütfen Bekleyiniz...",
                "Program İlk Kurulum için Hazırlanıyor...", "Programın İlk Kurulum İşlemi Yapılacaktır.\nOnaylıyor musunuz?",
                "İlk Kurulum İşlemi Başarılı Bir Şekilde Tamamlandı...")) return;

            Hide();

            ShowRibbonForms<MainForm>.ShowForm(false, txtServer.Text, txtUserName.Text.ConvertToSecureString(),
                txtPassword.Text.ConvertToSecureString(), txtAuthenticationType.Text.GetEnum<AuthenticationType>());

            txtUserName.Text = "";
            txtPassword.Text = "";
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

            if (button == btnLogin) Login();
            else if (button == btnCancel) Close();
        }

        private void Control_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var authenticationType = edit.Text.GetEnum<AuthenticationType>();

            txtUserName.Enabled = authenticationType == AuthenticationType.SqlServerAuthentication;
            txtPassword.Enabled = authenticationType == AuthenticationType.SqlServerAuthentication;
            txtUserName.Focus();

            if (authenticationType != AuthenticationType.WindowsAuthentication) return;

            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void LoginForm_Shown(object sender, System.EventArgs e)
        {
            Loads();
        }

    }
}