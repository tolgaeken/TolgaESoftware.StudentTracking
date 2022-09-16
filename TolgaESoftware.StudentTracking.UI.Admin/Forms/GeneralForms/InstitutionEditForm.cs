using System;
using System.Security;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Admin.Forms.GeneralForms
{
    public partial class InstitutionEditForm : BaseEditForm
    {
        #region Variables

        private readonly string _server;
        private readonly SecureString _userName;
        private readonly SecureString _password;
        private readonly AuthenticationType _authenticationType;

        #endregion

        public InstitutionEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new InstitutionBll(myDataLayoutControl);
            BaseCardType = CardType.Institution;
            txtAuthenticationType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AuthenticationType>());
            EventsLoad();

            _server = prm[0].ToString();
            _userName = (SecureString) prm[1];
            _password = (SecureString) prm[2];
            _authenticationType = (AuthenticationType) prm[3];
            txtAuthenticationType.SelectedItem = _authenticationType.ToName();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Institution() : ((InstitutionBll)Bll).Single(FilterFunctions.Filter<Institution>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = "Yeni_Kurum";
            txtCode.Enabled = true;
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Institution)OldEntity;

            txtCode.Text = entity.Code;
            txtInstitutionName.Text = entity.InstitutionName;
            txtServer.Text = BaseProcessType == ProcessType.EntityInsert ? _server : entity.Server;
            txtAuthenticationType.SelectedItem = txtAuthenticationType.Text.GetEnum<AuthenticationType>();

            txtUserName.Text = BaseProcessType == ProcessType.EntityInsert 
                ? _userName.ConvertToUnsecureString() : entity.UserName.Decrypt(entity.Id+entity.Code);

            txtPassword.Text = BaseProcessType == ProcessType.EntityInsert 
                ? _password.ConvertToUnsecureString() : entity.Password.Decrypt(entity.Id+entity.Code);
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Institution
            {
                Id = Id,
                Code = txtCode.Text,
                InstitutionName = txtInstitutionName.Text,
                Server = txtServer.Text,
                AuthenticationType = txtAuthenticationType.Text.GetEnum<AuthenticationType>(),
            };

            ((Institution) CurrentEntity).UserName = txtUserName.Text.Encrypt(CurrentEntity.Id + CurrentEntity.Code);
            ((Institution) CurrentEntity).Password = txtPassword.Text.Encrypt(CurrentEntity.Id + CurrentEntity.Code);

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            if (!Win.Functions.GeneralFunctions.ConnectionControl(txtServer.Text,
                txtUserName.Text.ConvertToSecureString(), txtPassword.Text.ConvertToSecureString(),
                txtAuthenticationType.Text.GetEnum<AuthenticationType>())) return false;

            Win.Functions.GeneralFunctions.CreateConnectionString(txtCode.Text, txtServer.Text,
                txtUserName.Text.ConvertToSecureString(), txtPassword.Text.ConvertToSecureString(),
                txtAuthenticationType.Text.GetEnum<AuthenticationType>());

            if (!Functions.GeneralFunctions.CreateDatabase<StudentTrackingContext>("Lütfen Bekleyiniz...",
                "Kurum Veritabanı Oluşturuluyor...", "Kurum Veritabanı Oluşturulacaktır.\nOnaylıyor musunuz?",
                "Kurum Veritabanı Başarılı Bir Şekilde Oluşturuldu")) return false;

            Win.Functions.GeneralFunctions.CreateConnectionString("TolgaESoftwareStudentTrackingAdmin",txtServer.Text,
                txtUserName.Text.ConvertToSecureString(), txtPassword.Text.ConvertToSecureString(),
                txtAuthenticationType.Text.GetEnum<AuthenticationType>());

            return base.EntityInsert();

        }

        protected override bool EntityUpdate()
        {
            if (!Win.Functions.GeneralFunctions.ConnectionControl(txtServer.Text,
                txtUserName.Text.ConvertToSecureString(), txtPassword.Text.ConvertToSecureString(),
                txtAuthenticationType.Text.GetEnum<AuthenticationType>())) return false;

            Win.Functions.GeneralFunctions.CreateConnectionString("TolgaESoftwareStudentTrackingAdmin",txtServer.Text,
                txtUserName.Text.ConvertToSecureString(), txtPassword.Text.ConvertToSecureString(),
                txtAuthenticationType.Text.GetEnum<AuthenticationType>());

            return base.EntityUpdate();
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