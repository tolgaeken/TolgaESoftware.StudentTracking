using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BankBranchForms
{
    public partial class BankBranchEditForm : BaseEditForm
    {

        #region Variables
        private readonly long _bankId;
        private readonly string _bankName; 
        #endregion
        public BankBranchEditForm(params object[] prm)
        {
            InitializeComponent();

            _bankId = (long) prm[0];
            _bankName = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankBranchBll(myDataLayoutControl);
            BaseCardType = CardType.BankBranch;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new BankBranch() : ((BankBranchBll) Bll).Single(FilterFunctions.Filter<BankBranch>(Id));
            LinkObjectToControls();
            Text = Text + $" - ( {_bankName} )"; 

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((BankBranchBll) Bll).GetNewCode(p=>p.BankId==_bankId);
            txtBankBranchName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (BankBranch) OldEntity;

            txtCode.Text = entity.Code;
            txtBankBranchName.Text = entity.BankBranchName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new BankBranch
            {
                Id = Id,
                Code = txtCode.Text,
                BankBranchName = txtBankBranchName.Text,
                BankId = _bankId,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((BankBranchBll) Bll).Insert(CurrentEntity, p => p.Code == CurrentEntity.Code && p.BankId == _bankId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankBranchBll) Bll).Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code && p.BankId == _bankId);
        }
    }
}