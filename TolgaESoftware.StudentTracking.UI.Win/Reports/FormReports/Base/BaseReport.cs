using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.FilterForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReportForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base
{
    public partial class BaseReport : RibbonForm
    {
        private long _filterId;
        private long _reportTemplateId;
        private ReportSectionType _reportSectionType = ReportSectionType.GeneralReports;
        protected CardType ReportType;
        protected ControlNavigator Navigator;
        protected GridView Table;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected MyCheckedComboboxEdit Branches;
        protected MyCheckedComboboxEdit Services;
        protected MyCheckedComboboxEdit Discounts;
        protected MyCheckedComboboxEdit Payments;
        protected MyCheckedComboboxEdit DocumentStatuses;
        protected MyCheckedComboboxEdit EnrollmentTypes;
        protected MyCheckedComboboxEdit EnrollmentStatuses;
        protected MyCheckedComboboxEdit CancelStatuses;
        protected MyComboBoxEdit TakenServiceType;
        protected MyComboBoxEdit CalculationType;
        protected MyDataLayoutControl DataLayoutControl;
        protected DateEdit FirstDate , LastDate;

        public BaseReport()
        {
            InitializeComponent();
        }

        protected internal void Loads()
        {
            FillVariables();
            EventsLoad();


            Navigator.NavigatableControl = Table.GridControl;

            ShowItems?.ForEach(p => p.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(p => p.Visibility = BarItemVisibility.Never);
        }

        private void EventsLoad()
        {
            //ButtonEvents
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table Events
            Table.DoubleClick += Table_DoubleClick;
            Table.KeyDown += Control_KeyDown;
            Table.MouseUp += Table_MouseUp;
            Table.ColumnFilterChanged += Table_ColumnFilterChanged;
            Table.FilterEditorCreated += Table_FilterEditorCreated;
            Table.CustomDrawFooterCell += Table_CustomDrawFooterCell;
            Table.CustomDrawRowFooterCell += Table_CustomDrawRowFooterCell;
            Table.CustomSummaryCalculate += Table_CustomSummaryCalculate;
            Table.MasterRowGetRelationCount += Table_MasterRowGetRelationCount;
            Table.MasterRowGetRelationName += Table_MasterRowGetRelationName;
            Table.MasterRowGetChildList += Table_MasterRowGetChildList;

            //Form Events
            FormClosing += BaseReport_FormClosing;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;

                if (control is SimpleButton btn)
                    btn.Click += Control_Click;
            }

            foreach (Control ctrl in DataLayoutControl.Controls) ControlEvents(ctrl);
        }

        protected void LoadBranchCards()
        {
            using (var bll = new BranchBll())
            {
                var entities = bll.List(p => MainForm.AuthorizedBranches.Contains(p.Id));

                foreach (BranchList entity in entities)
                {
                    var item = new CheckedListBoxItem
                    {
                        CheckState = entity.Id == MainForm.BranchId ? CheckState.Checked : CheckState.Unchecked,
                        Description = entity.BranchName,
                        Value = entity.Id
                    };

                    Branches.Properties.Items.Add(item);
                }
            }
        }

        protected void LoadEnrollmentType()
        {
            var enums = Enum.GetValues(typeof(EnrollmentType));

            foreach (EnrollmentType entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = entity.ToName(),
                    Value = entity
                };

                EnrollmentTypes.Properties.Items.Add(item);
            }
        }

        protected void LoadEnrollmentStatuses()
        {
            var enums = Enum.GetValues(typeof(EnrollmentStatus));

            foreach (EnrollmentStatus entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = entity == EnrollmentStatus.CertainEnroll ? CheckState.Checked : CheckState.Unchecked,
                    Description = entity.ToName(),
                    Value = entity
                };

                EnrollmentStatuses.Properties.Items.Add(item);
            }
        }

        protected void LoadCancelStatuses()
        {
            var enums = Enum.GetValues(typeof(CancelStatus));

            foreach (CancelStatus entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = entity.ToName(),
                    Value = entity
                };

                CancelStatuses.Properties.Items.Add(item);
            }
        }

        protected void LoadServiceCards()
        {
            using (var bll = new ServiceBll())
            {
                var entities = bll.List(null);

                foreach (ServiceList entity in entities)
                {
                    var item = new CheckedListBoxItem
                    {
                        CheckState = CheckState.Checked,
                        Description = entity.ServiceName,
                        Value = entity.Id
                    };

                    Services.Properties.Items.Add(item);
                }
            }
        }

        protected void LoadDiscountCards()
        {
            using (var bll = new DiscountBll())
            {
                var entities = bll.List(null);

                foreach (DiscountList entity in entities)
                {
                    var item = new CheckedListBoxItem
                    {
                        CheckState = CheckState.Checked,
                        Description = entity.DiscountName,
                        Value = entity.Id
                    };

                    Discounts.Properties.Items.Add(item);
                }
            }
        }

        protected void LoadPaymentTypes()
        {
            var enums = Enum.GetValues(typeof(PaymentType));

            foreach (PaymentType entity in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = entity.ToName(),
                    Value = entity
                };

                Payments.Properties.Items.Add(item);
            }
        }
        
        protected virtual void LoadDocumentStatus()
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

                DocumentStatuses.Properties.Items.Add(item);
            }
        }

        protected virtual void FillVariables() { }

        private void SelectFilter()
        {
            var entity = (Filter)ShowListForms<FilterListForm>
                .ShowDialogListForm(CardType.Filter, _filterId, ReportType, Table.GridControl);
            if (entity == null) return;

            _filterId = entity.Id;
            Table.ActiveFilterString = entity.FilterText;
        }

        private void SelectReportTemplate()
        {
            var entity =
                ShowListForms<ReportListForm>
                    .ShowDialogListForm(CardType.Report, _reportTemplateId, ReportType, _reportSectionType, CreateTemplateFile());
            if (entity == null) return;

            _reportTemplateId = entity.Id;

            using (var bll = new ReportBll())
            {
                var stream = ((Report)bll.Single(p => p.Id == entity.Id)).File.ByteToStream();
                Table.RestoreLayoutFromStream(stream);
                Table.Focus();
            }
        }

        private byte[] CreateTemplateFile()
        {
            var stream = new MemoryStream();
            Table.SaveLayoutToStream(stream);
            return stream.GetBuffer();
        }

        protected virtual void List()
        {
            Table.ExpandAllGroups();
        }

        protected virtual void ShowEditForm() { }

        protected virtual void DocumentActions() { }

        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnSend)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }

            else if (e.Item == btnSendAsStandartExcel) Table.ExportTable(FileType.ExcelStandard, e.Item.Caption, Text);

            else if (e.Item == btnSendAsFormattedExcel) Table.ExportTable(FileType.FormattedExcel, e.Item.Caption, Text);

            else if (e.Item == btnSendAsUnformattedExcel) Table.ExportTable(FileType.UnformattedExcel, e.Item.Caption, Text);

            else if (e.Item == btnSendAsWord) Table.ExportTable(FileType.Word, e.Item.Caption);

            else if (e.Item == btnSendAsPdf) Table.ExportTable(FileType.Pdf, e.Item.Caption);

            else if (e.Item == btnSendAsTxt) Table.ExportTable(FileType.Txt, e.Item.Caption);

            else if (e.Item == btnFilter) SelectFilter();

            else if (e.Item == btnColumns)
            {
                if (Table.CustomizationForm == null)
                {
                    Table.ShowCustomization();
                }
                else
                {
                    Table.HideCustomization();
                }
            }

            else if (e.Item == btnReportTemplates) SelectReportTemplate();

            else if (e.Item == btnPrint)
            {
                switch (ReportType)
                {
                    case CardType.GeneralReport:
                    case CardType.ClassReports:
                    case CardType.PriceAndPaymentReport:
                    case CardType.VocationalGroupReport:
                    case CardType.MonthlyEnrollmentReport:
                    case CardType.PriceAveragesReport:
                    case CardType.PaymentDocumentsReport:
                        TablePrintingFunctions.Print(Table, Table.ViewCaption, Branches.Text, EnrollmentTypes.Text, EnrollmentStatuses.Text, CancelStatuses.Text);
                        break;

                    case CardType.TakenServiceReport:
                        TablePrintingFunctions.Print(Table, Table.ViewCaption, Branches.Text, EnrollmentTypes.Text, EnrollmentStatuses.Text, null, "Hizmet Türü", Services.Text, "Hizmet Alım Türü", TakenServiceType.Text);
                        break;

                    case CardType.NetPriceReport:
                        TablePrintingFunctions.Print(Table, Table.ViewCaption, Branches.Text, EnrollmentTypes.Text, EnrollmentStatuses.Text, CancelStatuses.Text, "Hizmet Türü", Services.Text);
                        break;
                    
                    case CardType.DiscountDistributionReport:
                        TablePrintingFunctions.Print(Table, Table.ViewCaption, Branches.Text, EnrollmentTypes.Text, EnrollmentStatuses.Text, CancelStatuses.Text, "İndirim Türü", Discounts.Text);
                        break;
                    
                    case CardType.IncomeDistributionReport:
                        TablePrintingFunctions.Print(Table, Table.ViewCaption, Branches.Text, EnrollmentTypes.Text, EnrollmentStatuses.Text, CancelStatuses.Text, "Hesaplama Türü", CalculationType.Text);
                        break;

                    case CardType.CollectReport:
                    case CardType.OverdueReceivablesReport:
                        TablePrintingFunctions.Print(Table, Table.ViewCaption, Branches.Text, EnrollmentTypes.Text, EnrollmentStatuses.Text, CancelStatuses.Text, "Vade Aralığı", $"{FirstDate.Text} - {LastDate.Text}");
                        break;
                }
            }

            else if (e.Item == btnOpenCard) ShowEditForm();

            else if (e.Item == btnGroupPanel) Table.OptionsView.ShowGroupPanel = !Table.OptionsView.ShowGroupPanel;

            else if (e.Item == btnExpandAllGroups) Table.ExpandAllGroups();

            else if (e.Item == btnCollapseAllGroups) Table.CollapseAllGroups();

            else if (e.Item == btnExpandAllDetails)
                for (int i = 0; i < Table.DataRowCount; i++) Table.SetMasterRowExpanded(i, true);

            else if (e.Item == btnCollapseAllDetails) Table.CollapseAllDetails();

            else if (e.Item == btnDocumentActions) DocumentActions();

            else if (e.Item == btnExit) Close();

            Cursor.Current = DefaultCursor;
        }

        private void Table_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ShowEditForm();
            Cursor.Current = DefaultCursor;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F7:
                    Branches.Focus();
                    break;
            }
        }

        private void Table_MouseUp(object sender, MouseEventArgs e)
        {
            btnOpenCard.Enabled = Table.DataRowCount > 0;
            btnExpandAllGroups.Enabled = Table.DataRowCount > 0;
            btnCollapseAllGroups.Enabled = Table.DataRowCount > 0;
            btnExpandAllDetails.Enabled = Table.DataRowCount > 0;
            btnCollapseAllDetails.Enabled = Table.DataRowCount > 0;
            btnDocumentActions.Enabled = Table.DataRowCount > 0;
            e.ShowRightClickMenu(rightClickMenu);
        }

        private void Table_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Table.ActiveFilterString)) _filterId = 0;
        }

        private void Table_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditForms<FilterEditForm>.ShowDialogEditForm(CardType.Filter, _filterId, ReportType,
                Table.GridControl);
        }

        private void Table_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Table.OptionsView.ShowFooter) return;
            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit != null)
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
        }

        private void Table_CustomDrawRowFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit != null)
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
        }

        protected virtual void Table_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) { }

        protected virtual void Table_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e) { }

        protected virtual void Table_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) { }

        protected virtual void Table_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e) { }

        private void BaseReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MainForm.UserParameters.CloseReportsWithoutConfirmation)
                if (Messages.CloseReport() != DialogResult.Yes) e.Cancel = true;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            List();
            Table.Focus();

            Cursor.Current = Cursors.Default;
        }
    }
}