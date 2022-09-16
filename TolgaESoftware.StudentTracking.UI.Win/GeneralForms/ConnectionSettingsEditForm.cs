using System;
using System.Configuration;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class ConnectionSettingsEditForm : BaseEditForm
    {
        public ConnectionSettingsEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] {btnNew,btnDelete};
            BaseCardType = CardType.ConnectionSettings;
            txtAuthenticationType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AuthenticationType>());
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = new ConnectionSettings
            {
                Server = ConfigurationManager.AppSettings["Server"],
                AuthenticationType = ConfigurationManager.AppSettings["AuthenticationType"].GetEnum<AuthenticationType>(),
                UserName = ConfigurationManager.AppSettings["UserName"].ConvertToSecureString(),
                Password = ConfigurationManager.AppSettings["AuthenticationType"].GetEnum<AuthenticationType>() 
                           == AuthenticationType.SqlServerAuthentication 
                            ? "Burası Şifre Alanıdır".ConvertToSecureString()
                            :"".ConvertToSecureString()
            };

            LinkObjectToControls();
        }

        protected override void LinkObjectToControls()
        {
            txtServer.Text = ConfigurationManager.AppSettings["Server"];
            txtAuthenticationType.SelectedItem = ConfigurationManager.AppSettings["AuthenticationType"];
            txtUserName.Text = ConfigurationManager.AppSettings["UserName"];
            txtPassword.Text = ConfigurationManager.AppSettings["AuthenticationType"].GetEnum<AuthenticationType>()
                                == AuthenticationType.SqlServerAuthentication
                                 ? "Burası Şifre Alanıdır" : "";
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new ConnectionSettings
            {
                Server = txtServer.Text,
                AuthenticationType = txtAuthenticationType.Text.GetEnum<AuthenticationType>(),
                UserName = txtUserName.Text.ConvertToSecureString(),
                Password = txtPassword.Text.ConvertToSecureString()
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityUpdate()
        {
            var list = GeneralFunctions.GetChangingFields(OldEntity, CurrentEntity).ToList();

            list.ForEach(p =>
            {
                switch (p)
                {
                    case "Server":
                        Functions.GeneralFunctions.AppSettingsWrite(p,txtServer.Text);
                        break;

                    case "AuthenticationType":
                        Functions.GeneralFunctions.AppSettingsWrite(p,txtAuthenticationType.Text);
                        break;

                    case "UserName":
                        Functions.GeneralFunctions.AppSettingsWrite(p,txtUserName.Text);
                        break;

                    case "Password":
                        Functions.GeneralFunctions.AppSettingsWrite(p,txtPassword.Text);
                        break;
                }
            });

            return true;
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if(!(sender is ComboBoxEdit edit)) return;

            var authenticationType = edit.Text.GetEnum<AuthenticationType>();

            txtUserName.Enabled = authenticationType == AuthenticationType.SqlServerAuthentication;
            txtPassword.Enabled = authenticationType == AuthenticationType.SqlServerAuthentication;
            txtUserName.Focus();

            if(authenticationType!=AuthenticationType.WindowsAuthentication) return;

            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}