using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReportForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Reports.XtraReports.Accure;
using TolgaESoftware.StudentTracking.UI.Win.Reports.XtraReports.Bill;
using TolgaESoftware.StudentTracking.UI.Win.Reports.XtraReports.Receipt;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;
using BillReport = TolgaESoftware.StudentTracking.Model.DataTransferObject.BillReport;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class ReportSelection : BaseListForm
    {
        #region Variables

        private readonly StudentReport _studentInformations;
        private readonly IEnumerable<ContactInformationsReport> _contactInformations;
        private readonly IEnumerable<ServiceInformationsReport> _serviceInformations;
        private readonly IEnumerable<DiscountInformationsReport> _discountInformations;
        private readonly IEnumerable<PaymentInformationsReport> _paymentInformations;
        private readonly IEnumerable<RefundInformationsReport> _refundInformations;
        private readonly IEnumerable<EposInformationsReport> _eposInformations;
        private readonly IEnumerable<ReceiptActionsReport> _receiptInformations;
        private readonly IEnumerable<BillReport> _billInformations;
        private readonly ReportSectionType _reportSectionType;

        #endregion

        public ReportSelection(params object[] prm)
        {
            InitializeComponent();

            Bll = new ReportBll();

            ShowItems = new BarItem[] { btnNewReport, btnPreview };
            HideItems = new BarItem[] { btnNew, btnSelect, btnFilter, btnColumns, barEnter, barEnterStatement, barFilter, barFilterStatement, barColumns, barColumnsStatement };

            btnEdit.CreateDropDownMenu(new BarItem[] { btnChangeDesign });
            btnPrint.CreateDropDownMenu(new BarItem[] { btnPrintTable });

            txtPrinterName.Properties.Items.AddRange(GeneralFunctions.ListPrinters());
            txtPrinterName.EditValue = GeneralFunctions.DefaultPrinter();
            txtPrintType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PrintType>());
            txtPrintType.SelectedItem = PrintType.OneByOnePrint.ToName();
            _reportSectionType = (ReportSectionType)prm[0];


            if (_reportSectionType == ReportSectionType.AccrueReports)
            {
                _studentInformations = (StudentReport)prm[1];
                _contactInformations = (IEnumerable<ContactInformationsReport>)prm[2];
                _serviceInformations = (IEnumerable<ServiceInformationsReport>)prm[3];
                _discountInformations = (IEnumerable<DiscountInformationsReport>)prm[4];
                _paymentInformations = (IEnumerable<PaymentInformationsReport>)prm[5];
                _refundInformations = (IEnumerable<RefundInformationsReport>)prm[6];
                _eposInformations = (IEnumerable<EposInformationsReport>)prm[7];
            }

            else if (_reportSectionType == ReportSectionType.ReceiptReports)
                _receiptInformations = (List<ReceiptActionsReport>)prm[1];

            else if (_reportSectionType == ReportSectionType.BillTermReports || _reportSectionType == ReportSectionType.BillGeneralReports)
                _billInformations = (List<BillReport>)prm[1];

        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Report;
            Navigator = smallNavigator.navigator;

            if (_reportSectionType == ReportSectionType.BillTermReports ||
                _reportSectionType == ReportSectionType.BillGeneralReports ||
                _reportSectionType == ReportSectionType.ReceiptReports)
            {
                switch (_reportSectionType)
                {
                    case ReportSectionType.ReceiptReports:
                        {
                            var showItems = new BarItem[]
                            {
                                btnGeneralReceipt,
                                btnCollectReceipt,
                                btnDeliveryReceipt,
                                btnRefundReceipt
                            };
                            ShowItems = ShowItems.Concat(showItems).ToArray();
                        }
                        break;
                    
                    case ReportSectionType.BillTermReports:
                        {
                            var showItems = new BarItem[]
                            {
                                btnBill,
                                btnTermSummaryReport
                            };
                            ShowItems = ShowItems.Concat(showItems).ToArray();
                        }
                        break;
                    
                    case ReportSectionType.BillGeneralReports:
                        {
                            var showItems = new BarItem[]
                            {
                                btnStudentSummaryReport
                            };
                            ShowItems = ShowItems.Concat(showItems).ToArray();
                        }
                        break;
                }

                var hideItems = new BarItem[]
                {
                    btnEmptyReport,
                    btnStudentCard,
                    btnBankPaymentPlan,
                    btnDiscountRequestPetition,
                    btnNationalEducationRegistrationContract,
                    btnRegistrationContract,
                    btnCreditCardPaymentOrder,
                    btnPaymentIndenture
                };
                HideItems = HideItems.Concat(hideItems).ToArray();
            }
        }

        protected override void List()
        {
            RowSelect?.ClearSelection();
            Table.GridControl.DataSource = ((ReportBll)Bll).List(p => p.ReportSectionType == _reportSectionType && p.Status == ShowActiveCards);
        }

        protected override void Edit()
        {
            if (Messages.SendReportToDesign() != DialogResult.Yes) return;

            Cursor.Current = Cursors.WaitCursor;

            var row = table.GetRow<ReportList>();
            if (row == null) return;

            var entity = (Report)((ReportBll)Bll).Single(p => p.Id == row.Id);

            var result = ShowRibbonForms<ReportDesign>.ShowDialogForm(CardType.ReportDesign, entity);

            ShowEditFormDefault(result);

            Cursor.Current = DefaultCursor;
        }

        protected override void ShowEditForm(long id)
        {
            var row = table.GetRow<ReportList>();
            if (row == null) return;

            var entity = (Report)((ReportBll)Bll).Single(p => p.Id == row.Id);

            var result = ShowEditForms<ReportEditForm>
                .ShowDialogEditForm(CardType.Report, id, entity.ReportType, entity.ReportSectionType, entity.File);
            ShowEditFormDefault(result);
        }

        private IList<MyXtraReport> PrepareReport()
        {
            var reports = new List<MyXtraReport>();

            var massReport = new MyXtraReport();

            massReport.CreateDocument();

            massReport.Header = "Toplu Rapor";

            massReport.PrintingSystem.ContinuousPageNumbering = false;

            foreach (var row in RowSelect.GetSelectedRows())
            {
                var entity = (Report)((ReportBll)Bll).Single(p => p.Id == row.Id);
                var report = entity.File.ByteToStream().StreamToReport();
                ReportDataSource(report);
                report.CreateDocument();

                switch (txtPrintType.Text.GetEnum<PrintType>())
                {
                    case PrintType.OneByOnePrint:
                        reports.Add(report);
                        break;
                    case PrintType.MassPrint:
                        massReport.Pages.AddRange(report.Pages);
                        break;
                }
            }

            if (massReport.Pages.Count == 0) return reports;

            reports.Add(massReport);

            return reports;
        }

        private void ReportDataSource(IReport report)
        {
            switch (report)
            {
                case StudentCardReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    rprt.Contact_Informations.DataSource = _contactInformations;
                    rprt.Service_Informations.DataSource = _serviceInformations;
                    rprt.Discount_Informations.DataSource = _discountInformations
                        .GroupBy(p => new
                        {
                            p.DiscountName,
                            p.CancellationDate,
                            p.ProcessDate
                        })
                        .Select(p => new
                        {
                            p.Key.DiscountName,
                            p.Key.CancellationDate,
                            p.Key.ProcessDate,
                            GrossDiscount = p.Sum(c => c.GrossDiscount),
                            ShortTermDeductedDiscount = p.Sum(c => c.ShortTermDeductedDiscount),
                            NetDiscount = p.Sum(c => c.NetDiscount),
                        });
                    rprt.Payment_Informations.DataSource = _paymentInformations;
                    rprt.Refund_Informations.DataSource = _refundInformations;
                    break;

                case BankPaymentPlanReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    var selectedPayments = _paymentInformations.Where(p => p.PaymentType == PaymentType.Sps);
                    var sumOfPrice = selectedPayments.Sum(p => p.Price);
                    rprt.xrTableCell96.Text = sumOfPrice == 0 ? null : sumOfPrice.PriceAsText();

                    //rprt.xrTableCell58.Text = ((PaymentType)_paymentInformations.Select(p => p.PaymentType.ToName())).ToString();

                    //rprt.xrTableCell58.Text = _paymentInformations.Select(p => p.PaymentType).ToString();
                    //rprt.xrTableCell58.Text = EnumFunctions.GetEnumDescriptionList<PaymentType>().ToString();
                    //rprt.xrTableCell58.Text.GetEnum<PaymentType>().ToName();

                    rprt.Payment_Informations.DataSource = selectedPayments;
                    break;

                case NationalEducationRegistrationContractReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    break;

                case DiscountPetitionReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    rprt.Discount_Informations.DataSource = _discountInformations.GroupBy(p => p.DiscountName).Select(
                        p => new
                        {
                            DiscountName = p.Key,
                            GrossDiscount = p.Sum(c => c.GrossDiscount),
                            ShortTermDeductedDiscount = p.Sum(c => c.ShortTermDeductedDiscount),
                            NetDiscount = p.Sum(c => c.NetDiscount)
                        });
                    break;

                case RegistrationContractReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    break;

                case CreditCardPaymentOrderReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    rprt.Epos_Informations.DataSource = _eposInformations;
                    rprt.Payment_Informations.DataSource = _paymentInformations.Where(p => p.PaymentType == PaymentType.Epos).OrderBy(p => p.PaymentTerm);
                    break;

                case PaymentIndentureReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    rprt.Payment_Informations.DataSource = _paymentInformations.Where(p => p.PaymentType == PaymentType.Indenture).OrderBy(p => p.PaymentTerm);
                    break;

                case UserDefinedReport rprt:
                    rprt.Student_Informations.DataSource = _studentInformations;
                    rprt.Contact_Informations.DataSource = _contactInformations;
                    rprt.Service_Informations.DataSource = _serviceInformations;
                    rprt.Discount_Informations.DataSource = _discountInformations
                        .GroupBy(p => new
                        {
                            p.DiscountName,
                            p.CancellationDate,
                            p.ProcessDate
                        })
                        .Select(p => new
                        {
                            p.Key.DiscountName,
                            p.Key.CancellationDate,
                            p.Key.ProcessDate,
                            GrossDiscount = p.Sum(c => c.GrossDiscount),
                            ShortTermDeductedDiscount = p.Sum(c => c.ShortTermDeductedDiscount),
                            NetDiscount = p.Sum(c => c.NetDiscount),
                        });
                    rprt.Payment_Informations.DataSource = _paymentInformations;
                    rprt.Refund_Informations.DataSource = _refundInformations;
                    rprt.Epos_Informations.DataSource = _eposInformations;
                    break;

                case CollectReceiptReport rprt:
                    rprt.Receipt_Informations.DataSource = _receiptInformations;
                    break;

                case DeliveryReceiptReport rprt:
                    rprt.Receipt_Informations.DataSource = _receiptInformations;
                    break;

                case RefundReceiptReport rprt:
                    rprt.Receipt_Informations.DataSource = _receiptInformations;
                    break;

                case GeneralReceiptReport rprt:
                    rprt.Receipt_Informations.DataSource = _receiptInformations;
                    break;
                
                case Reports.XtraReports.Bill.BillReport rprt:
                    rprt.Bill_Informations.DataSource = _billInformations;
                    break;
                
                case BillTermSummaryReport rprt:
                    rprt.Bill_Informations.DataSource = _billInformations;
                    break;
                
                case BillStudentSummaryReport rprt:
                    rprt.Bill_Informations.DataSource = _billInformations;
                    break;
            }
        }

        protected override void Print()
        {
            if (Messages.YesSelectedYesNo("Rapor Yazdırılmak Üzere Seçilen Yazıcıya Gönderilecektir.\nOnaylıyor musunuz?", "Onay") != DialogResult.Yes) return;

            var reports = PrepareReport();

            for (int i = 0; i < txtPrintQuantity.Value; i++)
                reports.ForEach(p => p.Print(txtPrinterName.Text));
        }

        protected override void Preview()
        {
            var reports = PrepareReport();
            reports.ForEach(p => ShowRibbonForms<ReportPreview>.ShowForm(false, p.PrintingSystem, p.Header));
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);

            void CreateReport(CardType reportType, ReportSectionType reportSectionType, XtraReport report)
            {
                if (Messages.SendReportToDesign() != DialogResult.Yes) return;

                Cursor.Current = Cursors.WaitCursor;

                var entity = new Report
                {
                    Code = ((ReportBll)Bll).GetNewCode(p => p.ReportType == reportType),
                    ReportType = reportType,
                    ReportSectionType = reportSectionType,
                    ReportName = reportType.ToName(),
                    File = report.ReportToStream().GetBuffer(),
                    Status = true
                };

                var result = ShowRibbonForms<ReportDesign>.ShowDialogForm(CardType.ReportDesign, entity);
                ShowEditFormDefault(result);

                Cursor.Current = DefaultCursor;
            }

            if (e.Item == btnNewReport)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }

            else if (e.Item == btnStudentCard)
                CreateReport(CardType.StudentCardReport, ReportSectionType.AccrueReports, new StudentCardReport());

            else if (e.Item == btnBankPaymentPlan)
                CreateReport(CardType.BankPaymentPlanReport, ReportSectionType.AccrueReports, new BankPaymentPlanReport());

            else if (e.Item == btnNationalEducationRegistrationContract)
                CreateReport(CardType.NationalEducationRegistrationContractReport, ReportSectionType.AccrueReports, new NationalEducationRegistrationContractReport());

            else if (e.Item == btnDiscountRequestPetition)
                CreateReport(CardType.DiscountPetitionReport, ReportSectionType.AccrueReports, new DiscountPetitionReport());

            else if (e.Item == btnRegistrationContract)
                CreateReport(CardType.RegistrationContractReport, ReportSectionType.AccrueReports, new RegistrationContractReport());

            else if (e.Item == btnCreditCardPaymentOrder)
                CreateReport(CardType.CreditCardPaymentOrderReport, ReportSectionType.AccrueReports, new CreditCardPaymentOrderReport());

            else if (e.Item == btnPaymentIndenture)
                CreateReport(CardType.PaymentIndentureReport, ReportSectionType.AccrueReports, new PaymentIndentureReport());

            else if (e.Item == btnEmptyReport)
                CreateReport(CardType.UserDefinedReport, ReportSectionType.AccrueReports, new UserDefinedReport());

            else if (e.Item == btnCollectReceipt)
                CreateReport(CardType.CollectReceiptReport, ReportSectionType.ReceiptReports, new CollectReceiptReport());

            else if (e.Item == btnDeliveryReceipt)
                CreateReport(CardType.DeliveryReceiptReport, ReportSectionType.ReceiptReports, new DeliveryReceiptReport());

            else if (e.Item == btnRefundReceipt)
                CreateReport(CardType.RefundReceiptReport, ReportSectionType.ReceiptReports, new RefundReceiptReport());

            else if (e.Item == btnGeneralReceipt)
                CreateReport(CardType.GeneralReceiptReport, ReportSectionType.ReceiptReports, new GeneralReceiptReport());
            
            else if (e.Item == btnBill)
                CreateReport(CardType.BillReport, ReportSectionType.BillTermReports, new Reports.XtraReports.Bill.BillReport());

            else if (e.Item == btnTermSummaryReport)
                CreateReport(CardType.BillTermSummaryReport, ReportSectionType.BillTermReports, new BillTermSummaryReport());

            else if (e.Item == btnStudentSummaryReport)
                CreateReport(CardType.BillStudentSummaryReport, ReportSectionType.BillGeneralReports, new BillStudentSummaryReport());
        }
    }
}