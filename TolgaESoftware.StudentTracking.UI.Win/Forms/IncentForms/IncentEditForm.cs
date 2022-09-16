using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.IncentForms
{
    public partial class IncentEditForm : BaseEditForm
    {
        public IncentEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new IncentBll();
            BaseCardType = CardType.Incent;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? 
                new Incent() : 
                ((IncentBll) Bll).Single(FilterFunctions.Filter<Incent>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((IncentBll) Bll).GetNewCode();
            txtIncentName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Incent) OldEntity;

            txtCode.Text = entity.Code;
            txtIncentName.Text = entity.IncentName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Incent
            {
                Id = Id,
                Code = txtCode.Text,
                IncentName = txtIncentName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}