using System.Linq;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General.FormReports;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    public partial class PaymentDocumentsReport : BaseReport
    {
        public PaymentDocumentsReport()
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

            LoadBranchCards();
            LoadEnrollmentType();
            LoadEnrollmentStatuses();
            LoadCancelStatuses();
            LoadPaymentTypes();
            LoadDocumentStatus();

            ReportType = CardType.PaymentDocumentsReport;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();
            var payments = txtPayments.CheckedComboBoxList<PaymentType>();
            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();
            var cancelStatus = txtCancelStatus.CheckedComboBoxList<CancelStatus>();
            var documentStatuses = txtDocumentStatuses.CheckedComboBoxList<DocumentStatus>();

            using (var bll = new PaymentDocumentsReportBll())
            {
                table.GridControl.DataSource = bll.List(p =>
                    branches.Contains(p.Accrue.BranchId) &&
                    payments.Contains(p.PaymentType) &&
                    enrollmentType.Contains(p.Accrue.EnrollmentType) &&
                    enrollmentStatus.Contains(p.Accrue.EnrollmentStatus) &&
                    cancelStatus.Contains(p.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled) &&
                    p.Accrue.TermId == MainForm.TermId, documentStatuses);


                base.List();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = table.GetRow<PaymentDocumentsReportList>();
            if (entity == null) return;
            ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue, entity.AccrueId,
                entity.BranchId != MainForm.BranchId || entity.TermId != MainForm.BranchId);
        }

        protected override void DocumentActions()
        {
            var entity = table.GetRow<PaymentDocumentsReportList>();
            if (entity == null) return;
            ShowListForms<DocumentActionsListForm>
                .ShowDialogListForm(CardType.DocumentActions, null, entity.WalletNumber);
        }
    }
}