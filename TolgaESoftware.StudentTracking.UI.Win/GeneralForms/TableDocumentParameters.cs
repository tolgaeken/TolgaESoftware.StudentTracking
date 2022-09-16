using System;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class TableDocumentParameters : BaseEditForm
    {
        #region Variables
        private DocumentType _documentType;
        private readonly string _reportHeader;
        #endregion

        public TableDocumentParameters(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl2;
            HideItems= new BarItem[]
            {
                btnNew,
                btnSave,
                btnUndo,
                btnDelete
            };
            ShowItems = new BarItem[]
            {
                btnPrint,
                btnPreview
            };
            EventsLoad();

            _reportHeader = prm[0].ToString();
        }

        public override void Loads()
        {
            txtReportHeader.Text = _reportHeader;
            txtAddHeader.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YesNo>());
            txtFitReportToPaper.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<FitReportToPaperType>());
            txtPrintOrientation.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PrintOrientation>());
            txtShowHorizontalLines.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YesNo>());
            txtShowVerticalLines.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YesNo>());
            txtShowColumnHeaders.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YesNo>());
            txtPrinterName.Properties.Items.AddRange(GeneralFunctions.ListPrinters());

            txtAddHeader.SelectedItem = YesNo.Yes.ToName();
            txtFitReportToPaper.SelectedItem = FitReportToPaperType.ReduceTheFontSizeToFit.ToName();
            txtPrintOrientation.SelectedItem = PrintOrientation.Auto.ToName();
            txtShowHorizontalLines.SelectedItem = YesNo.Yes.ToName();
            txtShowVerticalLines.SelectedItem = YesNo.Yes.ToName();
            txtShowColumnHeaders.SelectedItem = YesNo.Yes.ToName();
            txtPrinterName.EditValue = GeneralFunctions.DefaultPrinter();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DocumentParameters
            {
                ReportHeader = txtReportHeader.Text,
                AddHeader = txtAddHeader.Text.GetEnum<YesNo>(),
                FitReportToPaper = txtFitReportToPaper.Text.GetEnum<FitReportToPaperType>(),
                PrintOrientation = txtPrintOrientation.Text.GetEnum<PrintOrientation>(),
                ShowHorizontalLines = txtShowHorizontalLines.Text.GetEnum<YesNo>(),
                ShowVerticalLines = txtShowVerticalLines.Text.GetEnum<YesNo>(),
                ShowColumnHeaders = txtShowColumnHeaders.Text.GetEnum<YesNo>(),
                PrinterName = txtPrinterName.Text,
                PrintQuantity = (int) txtPrintQuantity.Value,
                DocumentType = _documentType
            };

            return entity;
        }

        protected override void Print()
        {
            _documentType = DocumentType.PrintTable;
            Close();
        }

        protected override void Preview()
        {
            _documentType = DocumentType.TablePreview;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender!=txtAddHeader) return;
            txtReportHeader.Enabled = txtAddHeader.Text.GetEnum<YesNo>() == YesNo.Yes;
        }
    }
}