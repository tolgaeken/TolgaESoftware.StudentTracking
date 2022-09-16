using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class EmailParameterEditForm : BaseEditForm
    {
        public EmailParameterEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new EmailParameterBll(myDataLayoutControl);
            BaseCardType = CardType.EmailParameter;
            HideItems = new BarItem[] { btnNew, btnDelete };
            txtUseSSL.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YesNo>());
            EventsLoad();

            
        }

        public override void Loads()
        {
            OldEntity = ((EmailParameterBll)Bll).Single(null) ?? new EmailParameter();
            ((EmailParameter) OldEntity).Password = "Bu E - Mail Şifresidir".Encrypt(OldEntity.Id + OldEntity.Code);

            BaseProcessType = OldEntity.Id == 0 ? ProcessType.EntityInsert : ProcessType.EntityUpdate;
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = "Email";
            txtEmail.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (EmailParameter)OldEntity;

            Id = entity.Id;
            txtCode.Text = entity.Code;
            txtEmail.Text = entity.Email;
            txtPassword.Text = BaseProcessType == ProcessType.EntityInsert ? null : entity.Password.Decrypt(entity.Id + entity.Code);
            txtPortNumber.Value = entity.PortNumber;
            txtHost.Text = entity.Host;
            txtUseSSL.SelectedItem = entity.UseSSL.ToName();
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new EmailParameter
            {
                Id = Id,
                Code = txtCode.Text,
                Email = txtEmail.Text,
                Password = string.IsNullOrWhiteSpace(txtPassword.Text) ? null : txtPassword.Text.Encrypt(Id+txtCode.Text),
                PortNumber = (int) txtPortNumber.Value,
                Host = txtHost.Text,
                UseSSL = txtUseSSL.Text.GetEnum<YesNo>()
            };

            ButtonEnabledStatus();
        }
    }
}