using System.Security;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms
{
    public partial class UserEditForm : BaseEditForm
    {
        #region Variables

        private string _password;
        private string _hint;
        private SecureString _securePassword;
        private SecureString _secureHint;
        private bool _sendAgain;

        #endregion

        public UserEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UserBll(myDataLayoutControl);
            BaseCardType = CardType.User;
            ShowItems = new BarItem[] { btnResetPassword };
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new UserSingle() : ((UserBll)Bll).Single(FilterFunctions.Filter<User>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtUserName.Text = "Yeni Kullanıcı";
            btnResetPassword.Enabled = false;
        }

        protected override void LinkObjectToControls()
        {
            var entity = (UserSingle)OldEntity;


            txtUserName.Text = entity.Code;
            txtName.Text = entity.Name;
            txtLastname.Text = entity.Lastname;
            txtEmail.Text = entity.Email;
            txtRole.Id = entity.RoleId;
            txtRole.Text = entity.RoleName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new User
            {
                Id = Id,
                Code = txtUserName.Text,
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                Email = txtEmail.Text,
                Password = _password,
                Hint = _hint,
                RoleId = (long)txtRole.Id,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            CreatePassword();
            var result = base.EntityInsert();

            if (result)
                txtUserName.Text.SendPasswordToEmail(txtRole.Text, txtEmail.Text, _securePassword, _secureHint);

            return result;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();

            if (_sendAgain)
                txtUserName.Text.SendPasswordToEmail(txtRole.Text, txtEmail.Text, _securePassword, _secureHint);

            return result;
        }

        private void CreatePassword()
        {
            var result = GeneralFunctions.CreatePassword();

            _password = result.password;
            _hint = result.hint;
            _securePassword = result.securePassword;
            _secureHint = result.secureHint;

            CreateCurrentObject();
        }

        protected override void ResetPassword()
        {
            if(Messages.EmailSendConfirmation()!=DialogResult.Yes) return;
            _sendAgain = true;
            CreatePassword();
            btnSave.PerformClick();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
            {
                if (sender == txtRole) select.Select(txtRole);
            }
        }
    }
}