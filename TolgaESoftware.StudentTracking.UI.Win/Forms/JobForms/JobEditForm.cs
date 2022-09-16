using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.JobForms
{
    public partial class JobEditForm : BaseEditForm
    {
        public JobEditForm()
        {
            InitializeComponent();
       
            DataLayoutControl = myDataLayoutControl;
            Bll = new JobBll(myDataLayoutControl);
            BaseCardType = CardType.Job;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Job() : ((JobBll) Bll).Single(FilterFunctions.Filter<Job>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((JobBll) Bll).GetNewCode();
            txtJobName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Job) OldEntity;

            txtCode.Text = entity.Code;
            txtJobName.Text = entity.JobName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Job
            {
                Id = Id,
                Code = txtCode.Text,
                JobName = txtJobName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}