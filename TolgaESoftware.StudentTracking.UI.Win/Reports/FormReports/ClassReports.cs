using System;
using System.Linq;
using DevExpress.Data;
using DevExpress.XtraGrid;
using TolgaESoftware.StudentTracking.Bll.General.FormReports;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    public partial class ClassReports : BaseReport
    {
        public ClassReports()
        {
            InitializeComponent();
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
            ReportType = CardType.ClassReports;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();

            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();
            var cancelStatus = txtCancelStatus.CheckedComboBoxList<CancelStatus>();

            using (var bll = new GeneralReportBll())
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

        protected override void ShowEditForm()
        {
            var entity = table.GetRow<GeneralReportList>();
            if (entity == null) return;
            ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue, entity.AccrueId,
                entity.BranchId != MainForm.BranchId || entity.TermId != MainForm.BranchId);
        }

        protected override void Table_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;

            if (item.FieldName != "DiscountPercentage") return;

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
    }
}