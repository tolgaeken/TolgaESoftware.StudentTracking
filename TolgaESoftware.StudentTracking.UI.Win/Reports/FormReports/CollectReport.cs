using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using TolgaESoftware.StudentTracking.Bll.General.FormReports;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    public partial class CollectReport : BaseReport
    {
        public CollectReport()
        {
            InitializeComponent();
            ShowItems = new BarItem[] { btnDocumentActions };
        }

        protected override void FillVariables()
        {
            DataLayoutControl = myDataLayoutControl;
            Table = table;
            Navigator = longNavigator.navigator;
            Branches = txtBranches;
            Payments = txtPayments;
            DocumentStatuses = txtDocumentStatuses;
            EnrollmentTypes = txtEnrollmentType;
            EnrollmentStatuses = txtEnrollmentStatus;
            CancelStatuses = txtCancelStatus;
            FirstDate = txtFirstDate;
            LastDate = txtLastDate;

            LoadBranchCards();
            LoadEnrollmentType();
            LoadEnrollmentStatuses();
            LoadCancelStatuses();
            LoadPaymentTypes();
            LoadDocumentStatus();
            txtFirstDate.DateTime = DateTime.Now.Date;
            txtLastDate.DateTime = DateTime.Now.Date;
            ReportType = CardType.CollectReport;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();
            var payments = txtPayments.CheckedComboBoxList<PaymentType>();
            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();
            var cancelStatus = txtCancelStatus.CheckedComboBoxList<CancelStatus>();
            var documentStatuses = txtDocumentStatuses.CheckedComboBoxList<DocumentStatus>();

            using (var bll = new CollectReportBll())
            {
                table.GridControl.DataSource = bll.List(p =>
                    branches.Contains(p.PaymentInformations.Accrue.BranchId) &&
                    payments.Contains(p.PaymentInformations.PaymentType) &&
                    enrollmentType.Contains(p.PaymentInformations.Accrue.EnrollmentType) &&
                    enrollmentStatus.Contains(p.PaymentInformations.Accrue.EnrollmentStatus) &&
                    cancelStatus.Contains(p.PaymentInformations.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled) &&
                    documentStatuses.Contains(p.DocumentStatus) &&
                    p.Receipt.Date >= txtFirstDate.DateTime.Date &&
                    p.Receipt.Date <= txtLastDate.DateTime.Date &&
                    p.PaymentInformations.Accrue.TermId == MainForm.TermId);


                base.List();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = table.GetRow<CollectReportList>();
            if (entity == null) return;
            ShowEditForms<ReceiptEditForm>.ShowDialogEditForm(CardType.Accrue, entity.ReceiptId,entity.ReceiptType,entity.ReceiptAccountType,
                entity.BranchId != MainForm.BranchId || entity.TermId != MainForm.BranchId);
        }

        protected override void DocumentActions()
        {
            var entity = table.GetRow<CollectReportList>();
            if (entity == null) return;
            ShowListForms<DocumentActionsListForm>
                .ShowDialogListForm(CardType.DocumentActions, null, entity.WalletNumber);
        }

        protected override void LoadDocumentStatus()
        {
            var enums = Enum.GetValues(typeof(DocumentStatus));

            foreach (DocumentStatus entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = entity.ToName(),
                    Value = entity
                };

                if (entity == DocumentStatus.CollectedViaLawyer ||
                    entity == DocumentStatus.PartlyCollectedViaLawyer ||
                    entity == DocumentStatus.Unblocking ||
                    entity == DocumentStatus.Offsetting ||
                    entity == DocumentStatus.MarkAsPaid ||
                    entity == DocumentStatus.ChargedToBank ||
                    entity == DocumentStatus.ChargedToVault ||
                    entity == DocumentStatus.CollectedViaBank ||
                    entity == DocumentStatus.PartlyCollect) DocumentStatuses.Properties.Items.Add(item);
            }
        }
    }
}