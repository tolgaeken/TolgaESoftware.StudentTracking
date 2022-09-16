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
    public partial class PriceAveragesReport : BaseReport
    {
        public PriceAveragesReport()
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
            ReportType = CardType.PriceAveragesReport;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();
            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();
            var cancelStatus = txtCancelStatus.CheckedComboBoxList<CancelStatus>();

            using (var bll = new PriceAveragesReportBll())
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

            switch (item.FieldName)
            {
                case "colPaidAverage":

                    if (e.IsGroupSummary)
                    {
                        var paidStudent = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["PaidStudent"]));
                        var netPrice = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["NetPrice"]));

                        e.TotalValue = paidStudent == 0 ? 0 : netPrice / paidStudent;
                    }

                    else if (e.IsTotalSummary)
                    {
                        var paidStudent = Convert.ToDecimal(colPaidStudent.SummaryItem.SummaryValue);
                        var netPrice = Convert.ToDecimal(colNetPrice.SummaryItem.SummaryValue);

                        e.TotalValue = paidStudent == 0 ? 0 : netPrice / paidStudent;
                    }
                    break;

                case "colIncludedUnpaidAverage":

                    if (e.IsGroupSummary)
                    {
                        var studentNumber = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["SumOfStudent"]));
                        var netPrice = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["NetPrice"]));

                        e.TotalValue = studentNumber == 0 ? 0 : netPrice / studentNumber;
                    }

                    else if (e.IsTotalSummary)
                    {
                        var studentNumber = Convert.ToDecimal(colSumOfStudent.SummaryItem.SummaryValue);
                        var netPrice = Convert.ToDecimal(colNetPrice.SummaryItem.SummaryValue);

                        e.TotalValue = studentNumber == 0 ? 0 : netPrice / studentNumber;
                    }
                    break;

                case "colClassAverage":

                    if (e.IsGroupSummary)
                    {
                        var studentNumber = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["SumOfStudent"]));
                        var numberOfClass = Convert.ToDecimal(Table.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Table.GroupSummary["NumberOfClass"]));

                        e.TotalValue = studentNumber == 0 ? 0 : studentNumber/ numberOfClass;
                    }

                    else if (e.IsTotalSummary)
                    {
                        var studentNumber = Convert.ToDecimal(colSumOfStudent.SummaryItem.SummaryValue);
                        var numberOfClass = Convert.ToDecimal(colNumberOfClass.SummaryItem.SummaryValue);

                        e.TotalValue = studentNumber == 0 ? 0 : studentNumber/ numberOfClass;
                    }
                    break;
            }
        }
    }
}