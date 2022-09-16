using System;
using System.Linq;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using TolgaESoftware.StudentTracking.Bll.General.FormReports;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    public partial class MonthlyEnrollmentReport : BaseReport
    {
        public MonthlyEnrollmentReport()
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
            EnrollmentTypes = txtEnrollmentType;
            EnrollmentStatuses = txtEnrollmentStatus;
            CancelStatuses = txtCancelStatus;

            LoadBranchCards();
            LoadEnrollmentType();
            LoadEnrollmentStatuses();
            LoadCancelStatuses();
            ReportType = CardType.MonthlyEnrollmentReport;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();
            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();
            var cancelStatus = txtCancelStatus.CheckedComboBoxList<CancelStatus>();

            using (var bll = new MonthlyEnrollmentReportBll())
            {
                table.GridControl.DataSource = bll.List(p =>
                    branches.Contains(p.BranchId) &&
                    enrollmentType.Contains(p.EnrollmentType) &&
                    enrollmentStatus.Contains(p.EnrollmentStatus) &&
                    cancelStatus.Contains(p.Status ? CancelStatus.Continues : CancelStatus.Cancelled) &&
                    p.TermId == MainForm.TermId);


                base.List();
            }
        }

        protected override void Table_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;

            if (item.FieldName == "colDiscountPercentage")
            {
                if (e.IsGroupSummary)
                {
                    var sumOfServices = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["NetService"]));
                    var sumOfDiscounts = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["NetDiscount"]));

                    e.TotalValue = sumOfServices == 0 ? 0 : sumOfDiscounts / sumOfServices * 100;
                }

                else if (e.IsTotalSummary)
                {
                    var sumOfServices = Convert.ToDecimal(colNetService.SummaryItem.SummaryValue);
                    var sumOfDiscounts = Convert.ToDecimal(colNetDiscount.SummaryItem.SummaryValue);

                    e.TotalValue = sumOfServices == 0 ? 0 : sumOfDiscounts / sumOfServices * 100;

                }
            }

            if (item.FieldName != "colAverage") return;

            if (e.IsGroupSummary)
            {
                var sumOfEnrollment = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["SumOfEnrollment"]));
                var netPrice = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["NetPrice"]));

                e.TotalValue = sumOfEnrollment == 0 ? 0 : netPrice / sumOfEnrollment;
            }

            else if (e.IsTotalSummary)
            {
                var sumOfEnrollment = Convert.ToDecimal(colSumOfEnrollment.SummaryItem.SummaryValue);
                var netPrice = Convert.ToDecimal(colNetPrice.SummaryItem.SummaryValue);

                e.TotalValue = sumOfEnrollment == 0 ? 0 : netPrice / sumOfEnrollment;
            }
        }
    }
}