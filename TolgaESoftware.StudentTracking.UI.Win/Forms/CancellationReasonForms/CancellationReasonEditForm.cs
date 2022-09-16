using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.CancellationReasonForms
{
    public partial class CancellationReasonEditForm : BaseEditForm
    {
        public CancellationReasonEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new CancellationReasonBll(myDataLayoutControl);
            BaseCardType = CardType.CancellationReason;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? 
                new CancellationReason() : 
                ((CancellationReasonBll) Bll).Single(FilterFunctions.Filter<CancellationReason>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((CancellationReasonBll) Bll).GetNewCode();
            txtCancellationReasonName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (CancellationReason) OldEntity;

            txtCode.Text = entity.Code;
            txtCancellationReasonName.Text = entity.CancellationReasonName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new CancellationReason
            {
                Id = Id,
                Code = txtCode.Text,
                CancellationReasonName = txtCancellationReasonName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}