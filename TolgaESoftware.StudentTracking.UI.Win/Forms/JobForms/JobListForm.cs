using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.JobForms
{
    public partial class JobListForm : BaseListForm
    {
        public JobListForm()
        {
            InitializeComponent();
            Bll = new JobBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.Job;
            FormShow = new ShowEditForms<JobEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((JobBll) Bll).List(FilterFunctions.Filter<Job>(ShowActiveCards));
        }
    }
}