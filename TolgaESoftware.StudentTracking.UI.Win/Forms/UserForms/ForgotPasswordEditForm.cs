using System.Windows.Forms;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms
{
    public partial class ForgotPasswordEditForm : BaseEditForm
    {
        #region Variables

        private readonly string _userName;

        #endregion

        public ForgotPasswordEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UserBll(myDataLayoutControl);
            BaseCardType = CardType.ForgotPassword;
            HideItems = new BarItem[] { btnNew, btnSave, btnUndo, btnDelete };
            ShowItems = new BarItem[] { btnResetPassword };
            EventsLoad();

            _userName = prm[0].ToString();
        }

        public override void Loads()
        {
            txtUserName.Text = _userName;
        }

        protected override void ResetPassword()
        {
            if (Messages.EmailSendConfirmation() != DialogResult.Yes) return;

            var entity = ((UserBll)Bll).SingleDetail(p => p.Code == txtUserName.Text).EntityConvert<UserSingle>();

            if (entity == null)
            {
                Messages.ErrorMessage("Veritabanında Kayıtlı Böyle Bir Kullanıcı Bulunmamaktadır");
                return;
            }

            if (txtName.Text == entity.Name
                && txtLastname.Text == entity.Lastname
                && txtEmail.Text == entity.Email
                && txtHint.Text.Md5Crypt() == entity.Hint)
            {
                var result = Functions.GeneralFunctions.CreatePassword();

                var currentEntity = new User
                {
                    Id = entity.Id,
                    Code = entity.Code,
                    Name = entity.Name,
                    Lastname = entity.Lastname,
                    Email = entity.Email,
                    RoleId = entity.RoleId,
                    Statement = entity.Statement,
                    Status = entity.Status,
                    Password = result.password,
                    Hint = result.hint
                };

                if (!((UserBll)Bll).Update(entity, currentEntity)) return;

                var result2 = txtUserName.Text.SendPasswordToEmail(entity.RoleName, entity.Email,
                    result.securePassword, result.secureHint);

                if (result2)
                {
                    Messages.InformationMessage("Parola Sıfırlama İşlemi Başarılı Bir Şekilde Gerçekleşmiştir");
                    Close();
                }

                else
                    Messages.ErrorMessage("Parola Sıfırlama İşlemi Başarılı Bir Şekilde Gerçekleşmiştir\nFakat E - Mail Gönderilemedi\nLütfen Tekrar Deneyiniz");
            }

            else
            {
                Messages.ErrorMessage("Girilen Bilgiler, Mevcut Bilgiler İle Uyuşmuyor\nLütfen Kontrol Edip Tekrar Deneyiniz");
            }
        }
    }
}