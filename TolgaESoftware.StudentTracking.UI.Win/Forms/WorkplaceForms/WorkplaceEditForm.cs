using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.WorkplaceForms
{
    public partial class WorkplaceEditForm : BaseEditForm
    {
        public WorkplaceEditForm()
        {
            InitializeComponent();
        
            DataLayoutControl = myDataLayoutControl;
            Bll = new WorkplaceBll(myDataLayoutControl);
            BaseCardType = CardType.Workplace;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Workplace() : ((WorkplaceBll) Bll).Single(FilterFunctions.Filter<Workplace>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((WorkplaceBll) Bll).GetNewCode();
            txtWorkplaceName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Workplace) OldEntity;

            txtCode.Text = entity.Code;
            txtWorkplaceName.Text = entity.WorkplaceName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Workplace
            {
                Id = Id,
                Code = txtCode.Text,
                WorkplaceName = txtWorkplaceName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}