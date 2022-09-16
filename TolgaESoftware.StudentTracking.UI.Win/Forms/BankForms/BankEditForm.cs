using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BankForms
{
    public partial class BankEditForm : BaseEditForm
    {
        public BankEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankBll(myDataLayoutControl);
            BaseCardType = CardType.Bank;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new BankSingle() : ((BankBll) Bll).Single(FilterFunctions.Filter<Bank>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((BankBll) Bll).GetNewCode();
            txtBankName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (BankSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtBankName.Text = entity.BankName;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Bank
            {
                Id = Id,
                Code = txtCode.Text,
                BankName = txtBankName.Text,
                SpecialCode1Id = txtSpecialCode1.Id,
                SpecialCode2Id = txtSpecialCode2.Id,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtSpecialCode1) select.Select(txtSpecialCode1,CardType.Bank);
                else if (sender == txtSpecialCode2) select.Select(txtSpecialCode2,CardType.Bank);
        }

        protected override bool EntityInsert()
        {
            return ((BankBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code);
        }

        protected override bool EntityUpdate()
        {
            return ((BankBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code);
        }
    }
}