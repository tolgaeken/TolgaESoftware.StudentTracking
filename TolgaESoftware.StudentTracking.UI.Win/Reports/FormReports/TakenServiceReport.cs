using System.Linq;
using TolgaESoftware.StudentTracking.Bll.General.FormReports;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    public partial class TakenServiceReport : BaseReport
    {
        public TakenServiceReport()
        {
            InitializeComponent();
        }
        protected override void FillVariables()
        {
            DataLayoutControl = myDataLayoutControl;
            Table = table;
            Navigator = longNavigator.navigator;
            Branches = txtBranches;
            Services = txtServices;
            TakenServiceType = txtTakenServiceType;
            EnrollmentTypes = txtEnrollmentType;
            EnrollmentStatuses = txtEnrollmentStatus;

            LoadBranchCards();
            LoadEnrollmentType();
            LoadEnrollmentStatuses();
            LoadServiceCards();
            txtTakenServiceType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TakenServiceStatus>());
            txtTakenServiceType.SelectedItem = TakenServiceStatus.TakenService.ToName();
            ReportType = CardType.TakenServiceReport;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();
            var services = txtServices.CheckedComboBoxList<long>();
            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();

            using (var bll = new TakenServiceReportBll())
            {
                table.GridControl.DataSource = bll.List(p =>
                    branches.Contains(p.BranchId) &&
                    enrollmentType.Contains(p.EnrollmentType) &&
                    enrollmentStatus.Contains(p.EnrollmentStatus) &&
                    p.TermId == MainForm.TermId, services, txtTakenServiceType.Text.GetEnum<TakenServiceStatus>());


                base.List();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = table.GetRow<TakenServiceReportList>();
            if (entity == null) return;
            ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue, entity.AccrueId,
                entity.BranchId != MainForm.BranchId || entity.TermId != MainForm.BranchId);
        }
    }
}