using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Bll.General.FormReports;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.OverdueStatementsForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    public partial class OverdueReceivablesReport : BaseReport
    {
        public OverdueReceivablesReport()
        {
            InitializeComponent();
            ShowItems = new BarItem[] { btnDocumentActions, btnExpandAllDetails, btnCollapseAllDetails };
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
            txtFirstDate.DateTime = MainForm.TermParameters.TermStartDate;
            txtLastDate.DateTime = DateTime.Now.Date;
            ReportType = CardType.OverdueReceivablesReport;
        }

        protected override void List()
        {
            var branches = txtBranches.CheckedComboBoxList<long>();
            var payments = txtPayments.CheckedComboBoxList<PaymentType>();
            var enrollmentType = txtEnrollmentType.CheckedComboBoxList<EnrollmentType>();
            var enrollmentStatus = txtEnrollmentStatus.CheckedComboBoxList<EnrollmentStatus>();
            var cancelStatus = txtCancelStatus.CheckedComboBoxList<CancelStatus>();
            var documentStatuses = txtDocumentStatuses.CheckedComboBoxList<DocumentStatus>();

            using (var bll = new OverdueReceivablesReportBll())
            {
                table.GridControl.DataSource = bll.List(p =>
                    branches.Contains(p.Accrue.BranchId) &&
                    payments.Contains(p.PaymentType) &&
                    enrollmentType.Contains(p.Accrue.EnrollmentType) &&
                    enrollmentStatus.Contains(p.Accrue.EnrollmentStatus) &&
                    cancelStatus.Contains(p.Accrue.Status ? CancelStatus.Continues : CancelStatus.Cancelled) &&
                    p.PaymentTerm >= txtFirstDate.DateTime.Date &&
                    p.PaymentTerm <= txtLastDate.DateTime.Date &&
                    p.Accrue.TermId == MainForm.TermId, documentStatuses);


                base.List();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = table.GetRow<OverdueReceivablesReportList>();
            if (entity == null) return;
            ShowListForms<OverdueStatementsListForm>.ShowDialogListForm(CardType.Statement, null, entity.WalletNumber);
        }

        protected override void DocumentActions()
        {
            var entity = table.GetRow<OverdueReceivablesReportList>();
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

                if (entity == DocumentStatus.OnWallet ||
                    entity == DocumentStatus.PartlyCollectedViaLawyer ||
                    entity == DocumentStatus.PartlyCollect ||
                    entity == DocumentStatus.SendingToBank ||
                    entity == DocumentStatus.SendingToLawyer ||
                    entity == DocumentStatus.Profiting ||
                    entity == DocumentStatus.Blocking ||
                    entity == DocumentStatus.WaitingConfirmation ||
                    entity == DocumentStatus.RefundToWallet ||
                    entity == DocumentStatus.FreeRefundToWallet ||
                    entity == DocumentStatus.ImpossibleCollect) DocumentStatuses.Properties.Items.Add(item);
            }
        }

        protected override void Table_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        protected override void Table_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "subGrid";
        }

        protected override void Table_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var entity = table.GetRow<OverdueReceivablesReportList>(e.RowHandle);
            if(entity==null) return;

            using (var bll = new OverdueStatementsBll())
            {
                var list = bll.List(p => p.PaymentInformationsId == entity.WalletNumber)
                    .EntityListConvert<OverdueStatementsList>().ToList();

                if (list.Any())
                    e.ChildList = list;
            }

        }
    }
}