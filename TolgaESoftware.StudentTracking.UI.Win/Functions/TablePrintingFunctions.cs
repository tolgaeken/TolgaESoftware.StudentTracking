using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public class TablePrintingFunctions
    {
        private static GridView _table;
        private static string _branchName;
        private static string _enrollmentType;
        private static string _enrollmentStatus;
        private static string _cancelStatus;
        private static string _parameter1Header;
        private static string _parameter1Value;
        private static string _parameter2Header;
        private static string _parameter2Value;
        private static PrintableComponentLink _link;
        private static PrintingSystem _printingSystem;
        private static DocumentParameters _documentParameters;


        public static void Print(GridView table, string reportHeader, string branchName,
            string enrollmentType = null, string enrollmentStatus = null, string cancelStatus = null,
            string parameter1Header = null, string parameter1Value = null,
            string parameter2Header = null, string parameter2Value = null)
        {
            _link = new PrintableComponentLink();
            _printingSystem = new PrintingSystem();
            _table = table;
            _branchName = branchName;
            _enrollmentType = enrollmentType;
            _enrollmentStatus = enrollmentStatus;
            _cancelStatus = cancelStatus;
            _parameter1Header = parameter1Header;
            _parameter1Value = parameter1Value;
            _parameter2Header = parameter2Header;
            _parameter2Value = parameter2Value;
            _documentParameters =
                ShowEditForms<TableDocumentParameters>.ShowDialogEditForm<DocumentParameters>(reportHeader);

            ReportDocument();
        }

        private static void ReportDocument()
        {
            AddHeader();
            FitReportToPaper();

            _table.OptionsPrint.PrintHorzLines = _documentParameters.ShowHorizontalLines == YesNo.Yes;
            _table.OptionsPrint.PrintVertLines = _documentParameters.ShowVerticalLines == YesNo.Yes;
            _table.OptionsPrint.PrintHeader = _documentParameters.ShowColumnHeaders == YesNo.Yes;
            _table.OptionsView.ShowViewCaption = false;

            _link.Component = _table.GridControl;
            _link.PaperKind = PaperKind.Letter;
            _link.Margins = new Margins(59, 59, 115, 48);
            _link.CreateMarginalHeaderArea += Link_CreateMarginalHeaderArea;
            _link.CreateDocument(_printingSystem);

            switch (_documentParameters.DocumentType)
            {
                case DocumentType.TablePreview:
                    ShowRibbonForms<ReportPreview>.ShowForm(true, _printingSystem, _documentParameters.ReportHeader);
                    break;
                case DocumentType.PrintTable:
                    for (int i = 0; i < _documentParameters.PrintQuantity; i++) _link.Print(_documentParameters.PrinterName);
                    break;
            }

            _table.OptionsView.ShowViewCaption = true;
        }

        private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            if (_documentParameters.AddHeader == YesNo.No) return;

            var boldFont = new Font("Tahoma", 7, FontStyle.Bold);
            var regularFont = new Font("Tahoma", 7, FontStyle.Regular);

            var pageBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                PageInfo = PageInfo.NumberOfTotal,
                Format = "Sayfa : {0} / {1}",
                Alignment = BrickAlignment.Far,
                AutoWidth = true
            };
            _printingSystem.Graph.DrawBrick(pageBrick, new RectangleF(200, 25, 40, 15));

            var dateBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                PageInfo = PageInfo.DateTime,
                Format = "Tarih : {0:dd.MM.yyyy}",
                Alignment = BrickAlignment.Far,
                AutoWidth = true
            };
            _printingSystem.Graph.DrawBrick(dateBrick, new RectangleF(0, 40, 50, 15));

            var branchHeaderBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldFont,
                Text = "Şube",
            };
            _printingSystem.Graph.DrawBrick(branchHeaderBrick, new RectangleF(0, 25, 40, 15));

            var branchValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                Text = $": {_branchName}",
            };
            _printingSystem.Graph.DrawBrick(branchValueBrick, new RectangleF(55, 25, 500, 15));

            var TermHeaderBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldFont,
                Text = "Dönem",
            };
            _printingSystem.Graph.DrawBrick(TermHeaderBrick, new RectangleF(0, 40, 40, 15));

            var TermValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                Text = $": {MainForm.TermName}",
            };
            _printingSystem.Graph.DrawBrick(TermValueBrick, new RectangleF(55, 40, 200, 15));

            if (_enrollmentType != null)
            {
                var enrollmentTypeHeaderBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = boldFont,
                    Text = "Kayıt Şekli",
                };
                _printingSystem.Graph.DrawBrick(enrollmentTypeHeaderBrick, new RectangleF(0, 55, 55, 15));

                var enrollmentTypeValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = regularFont,
                    Text = $": {_enrollmentType}",
                };
                _printingSystem.Graph.DrawBrick(enrollmentTypeValueBrick, new RectangleF(55, 55, 250, 15));
            }

            if (_enrollmentStatus != null)
            {
                var enrollmentStatusHeaderBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = boldFont,
                    Text = "Kayıt Durumu",
                };
                _printingSystem.Graph.DrawBrick(enrollmentStatusHeaderBrick, new RectangleF(250, 40, 70, 15));

                var enrollmentStatusValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = regularFont,
                    Text = $": {_enrollmentStatus}",
                };
                _printingSystem.Graph.DrawBrick(enrollmentStatusValueBrick, new RectangleF(340, 40, 150, 15));
            }
            
            if (_cancelStatus != null)
            {
                var cancelStatusHeaderBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = boldFont,
                    Text = "İptal Durumu",
                };
                _printingSystem.Graph.DrawBrick(cancelStatusHeaderBrick, new RectangleF(250, 55, 70, 15));

                var cancelStatusValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = regularFont,
                    Text = $": {_cancelStatus}",
                };
                _printingSystem.Graph.DrawBrick(cancelStatusValueBrick, new RectangleF(340, 55, 150, 15));
            }
            
            if (_parameter1Header != null)
            {
                var parameter1HeaderBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = boldFont,
                    Text = _parameter1Header,
                };
                _printingSystem.Graph.DrawBrick(parameter1HeaderBrick, new RectangleF(500, 40, 70, 15));

                var parameter1ValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = regularFont,
                    Text = $"{_parameter1Value}",
                };
                _printingSystem.Graph.DrawBrick(parameter1ValueBrick, new RectangleF(570, 40, 300, 15));
            }
            
            if (_parameter2Header != null)
            {
                var parameter2HeaderBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = boldFont,
                    Text = _parameter2Header,
                };
                _printingSystem.Graph.DrawBrick(parameter2HeaderBrick, new RectangleF(250, 55, 90, 15));

                var parameter2ValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = regularFont,
                    Text = $"{_parameter2Value}",
                };
                _printingSystem.Graph.DrawBrick(parameter2ValueBrick, new RectangleF(340, 55, 300, 15));
            }

        }

        private static void FitReportToPaper()
        {
            AlignPrintOrientation();

            switch (_documentParameters.FitReportToPaper)
            {
                case FitReportToPaperType.ShrinkColumnsToFit:
                    _table.OptionsPrint.AutoWidth = true;
                    break;
                case FitReportToPaperType.ReduceTheFontSizeToFit:
                    _table.OptionsPrint.AutoWidth = false;
                    _printingSystem.Document.AutoFitToPagesWidth = 1;
                    break;
                default:
                    _table.OptionsPrint.AutoWidth = false;
                    _printingSystem.Document.ScaleFactor = 1.0f;
                    break;
            }
        }

        private static void AlignPrintOrientation()
        {
            switch (_documentParameters.PrintOrientation)
            {
                case PrintOrientation.Vertical:
                    _link.Landscape = false;
                    break;
                case PrintOrientation.Horizontal:
                    _link.Landscape = true;
                    break;
                case PrintOrientation.Auto:
                    _link.Landscape = AutoPrintOrientation();
                    break;
            }
        }

        private static bool AutoPrintOrientation()
        {
            //Letter Size
            const int pageWidht = 703;
            var tableColumnWidths = 0;

            for (int i = 0; i < _table.Columns.Count; i++)
                if (_table.Columns[i].Visible) tableColumnWidths += _table.Columns[i].Width;

            return tableColumnWidths > pageWidht;
        }

        private static void AddHeader()
        {
            if (_documentParameters.AddHeader == YesNo.No) return;

            var headerArea = new PageHeaderArea();
            headerArea.Content.AddRange(new[] { "", _documentParameters.ReportHeader, "" });
            headerArea.Font = new Font("Arial Narrow", 10f, FontStyle.Bold);
            headerArea.LineAlignment = BrickAlignment.Far;
            _link.PageHeaderFooter = new PageHeaderFooter(headerArea, null);
        }
    }
}