using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.QuotaForms
{
    public partial class QuotaEditForm : BaseEditForm
    {
        public QuotaEditForm()
        {
            InitializeComponent();
        
            DataLayoutControl = myDataLayoutControl;
            Bll = new QuotaBll(myDataLayoutControl);
            BaseCardType = CardType.Quota;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Quota() : ((QuotaBll) Bll).Single(FilterFunctions.Filter<Quota>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((QuotaBll) Bll).GetNewCode();
            txtQuotaName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Quota) OldEntity;

            txtCode.Text = entity.Code;
            txtQuotaName.Text = entity.QuotaName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Quota
            {
                Id = Id,
                Code = txtCode.Text,
                QuotaName = txtQuotaName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}