using System;
using System.Linq;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using TolgaESoftware.StudentTracking.Bll.General.FormReports;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    public partial class IncomeDistributionReport : BaseReport
    {
        public IncomeDistributionReport()
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnOpenCard };
        }

        protected override void FillVariables()
        {
            DataLayoutControl = myDataLayoutControl;
            Table = table;
            Navigator = longNavigator.navigator;
            Branches = txtBranches;
            Payments = txtPayments;
            CalculationType = txtCalculationType;
            EnrollmentTypes = txtEnrollmentType;
            EnrollmentStatuses = txtEnrollmentStatus;
            CancelStatuses = txtCancelStatus;

            LoadBranchCards();
            LoadEnrollmentType();
            LoadEnrollmentStatuses();
            LoadCancelStatuses();
            LoadPaymentTypes();
            txtCalculationType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<GroupingType>());
            txtCalculationType.SelectedItem = GroupingType.ByPaymentTerm.ToName();

            ReportType = CardType.MonthlyEnrollmentReport;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();
            var payments = txtPayments.CheckedComboBoxList<PaymentType>();
            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();
            var cancelStatus = txtCancelStatus.CheckedComboBoxList<CancelStatus>();
            var calculationType = txtCalculationType.Text.GetEnum<GroupingType>();

            using (var bll = new IncomeDistributionReportBll())
            {
                table.GridControl.DataSource = bll.List(p =>
                    branches.Contains(p.Accrue.BranchId) &&
                    payments.Contains(p.PaymentType) &&
                    enrollmentType.Contains(p.Accrue.EnrollmentType) &&
                    enrollmentStatus.Contains(p.Accrue.EnrollmentStatus) &&
                    cancelStatus.Contains(p.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled) &&
                    p.Accrue.TermId == MainForm.TermId,calculationType);


                base.List();
            }
        }

        protected override void Table_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;

            if (item.FieldName != "colCollectPercentage") return;
            {
                if (e.IsGroupSummary)
                {
                    var sumOfPayments = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["NetPayment"]));
                    var sumOfCollects = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["Collected"]));

                    e.TotalValue = sumOfPayments == 0 ? 0 : sumOfCollects / sumOfPayments * 100;
                }

                else if (e.IsTotalSummary)
                {
                    var sumOfPayments = Convert.ToDecimal(colNetPayment.SummaryItem.SummaryValue);
                    var sumOfCollects = Convert.ToDecimal(colCollected.SummaryItem.SummaryValue);

                    e.TotalValue = sumOfPayments == 0 ? 0 : sumOfCollects / sumOfPayments * 100;

                }
            }
        }
    }
}