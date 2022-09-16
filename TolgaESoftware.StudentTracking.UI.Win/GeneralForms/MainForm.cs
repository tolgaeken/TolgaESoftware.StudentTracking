using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraTabbedMdi;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankAccountForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolBusForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.CancellationReasonForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ClassForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ClassGroupForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ContactForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.CustomerForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountTypeForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DocumentForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.FamilyInfoForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ForeignLanguageForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.GuideForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.IncentForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.JobForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.KinshipForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.LawyerForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.PaymentMethodForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.PromotionForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ProvinceForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.QuotaForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceTypeForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.StudentForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.VaultForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.VocationForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.WorkplaceForms;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class MainForm : RibbonForm
    {
        public static string InstitutionName;
        public static long UserId;
        public static string UserName;
        public static long UserRoleId;
        public static string UserRoleName;

        public static long TermId;
        public static string TermName = "Dönem Bilgisi Bekleniyor...";

        public static long BranchId;
        public static string BranchName = "Şube Bilgisi Bekleniyor...";

        public static List<long> AuthorizedBranches;
        public static TermParameter TermParameters;
        public static UserParameterSingle UserParameters = new UserParameterSingle();
        public static IEnumerable<RoleAuthorizationsList> RoleAuthorizations;
        
        //public static long TermId = 1;
        //public static long BranchId = 1;
        //public static UserParameterSingle UserParameters = new UserParameterSingle();
        //public static DateTime EducationStartDate = new DateTime(2021, 09, 06);
        //public static DateTime TermStartDate = new DateTime(2021, 09, 01);
        //public static DateTime TermEndDate = new DateTime(2022, 06, 17);
        //public static bool ServiceStartDateCanEnteredBeforeDayDate = true;
        //public static bool ServiceStartDateCanEnteredAfterDayDate = true;
        //public static bool CancellationDateCanEnteredBeforeDayDate = true;
        //public static bool CancellationDateCanEnteredAfterDayDate = true;
        //public static bool ReceiptDateCanEnteredBeforeDayDate = true;
        //public static bool ReceiptDateCanEnteredAfterDayDate = true;
        //public static bool UseServiceAccruePenny;
        //public static bool UseDiscountAccruePenny;
        //public static bool UsePaymentPlanPenny;
        //public static bool UseBillAccruePenny;
        //public static bool HasRequiredSchoolToGoes = true;
        //public static DateTime MaxInstallmentDate = new DateTime(2022, 06, 17);
        //public static byte NumberOfMaximumInstallment = 12;
        //public static long? DefaultVaultAccountId;
        //public static string DefaultVaultAccountName;
        //public static long? DefaultBankAccountId;
        //public static string DefaultBankAccountName;
        //public static long? DefaultLawyerAccountId;
        //public static string DefaultLawyerAccountName;
        //public static long UserId = 1;
        //public static string UserName = "admin";
        //public static bool CloseReportsWithoutConfirmation = false;
        //public static List<long> AuthorizedBranches = new List<long> { 1, 2021101600122706491 };
        


        public MainForm()
        {
            InitializeComponent();
            EventsLoad();

            pictBackgroundImage.EditValue = UserParameters.BackgroundImage;
        }

        private void EventsLoad()
        {
            Load += MainForm_Load;
            FormClosing += MainForm_FormClosing;
            KeyDown += Control_KeyDown;

            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case SkinRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;

                    case SkinPaletteRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;

                    case BarButtonItem btn:
                        btn.ItemClick += Buttons_ItemClick;
                        break;
                }
            }

            foreach (Control control in Controls)
                control.KeyDown += Control_KeyDown;

            xtraTabbedMdiManager.PageAdded += XtraTabbedMdiManager_PageAdded;
            xtraTabbedMdiManager.PageRemoved += XtraTabbedMdiManager_PageRemoved;
        }

        private void BranchTermSelection(bool branchSelectionButtonClicked)
        {
            ShowEditForms<BranchTermSelectionEditForm>
                .ShowDialogEditForm(null, UserId, branchSelectionButtonClicked, BranchId, TermId);
            barTerm.Caption = TermName;
            btnBranch.Caption = BranchName;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            barUser.Caption = $"{UserName} ( {UserRoleName} )";
            barInstitution.Caption = InstitutionName;
            BranchTermSelection(false);

            if(TermParameters == null)
            {
                Messages.ErrorMessage("Dönem Parametreleri Girilmemiş\nLütfen Sistem Yöneticinize Başvurunuz");
                Application.ExitThread();
                return;
            }

            if(!TermParameters.AuthorizationControlWillBeInstantly)
                using (var bll = new RoleAuthorizationsBll())
                    RoleAuthorizations = bll.List(p => p.RoleId == UserRoleId).EntityListConvert<RoleAuthorizationsList>();


                
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.NoSelectedYesNo("Programdan Çıkış Yapmak İstediğinize Emin misiniz?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void Gallery_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var gallery = sender as InRibbonGallery;
            var key = "";

            if (gallery.OwnerItem.GetType() == typeof(SkinRibbonGalleryBarItem)) key = "Skin";
            if (gallery.OwnerItem.GetType() == typeof(SkinPaletteRibbonGalleryBarItem)) key = "Palette";

            Functions.GeneralFunctions.AppSettingsWrite(key, e.Item.Caption);
        }

        private void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnSchoolCards) ShowListForms<SchoolListForm>.ShowListForm(CardType.School);
            else if (e.Item == btnProvinceCards) ShowListForms<ProvinceListForm>.ShowListForm(CardType.Province);
            else if (e.Item == btnFamilyInfoCards) ShowListForms<FamilyInfoListForm>.ShowListForm(CardType.FamilyInfo);
            else if (e.Item == btnCancellationReasonCards) ShowListForms<CancellationReasonListForm>.ShowListForm(CardType.CancellationReason);
            else if (e.Item == btnForeignLanguageCards) ShowListForms<ForeignLanguageListForm>.ShowListForm(CardType.ForeignLanguage);
            else if (e.Item == btnIncentCards) ShowListForms<IncentListForm>.ShowListForm(CardType.Incent);
            else if (e.Item == btnQuotaCards) ShowListForms<QuotaListForm>.ShowListForm(CardType.Quota);
            else if (e.Item == btnGuideCards) ShowListForms<GuideListForm>.ShowListForm(CardType.Guide);
            else if (e.Item == btnClassGroupCards) ShowListForms<ClassGroupListForm>.ShowListForm(CardType.ClassGroup);
            else if (e.Item == btnVocationCards) ShowListForms<VocationListForm>.ShowListForm(CardType.Vocation);
            else if (e.Item == btnKinshipCards) ShowListForms<KinshipListForm>.ShowListForm(CardType.Kinship);
            else if (e.Item == btnWorkplaceCards) ShowListForms<WorkplaceListForm>.ShowListForm(CardType.Workplace);
            else if (e.Item == btnJobCards) ShowListForms<JobListForm>.ShowListForm(CardType.Job);
            else if (e.Item == btnDiscountTypeCards) ShowListForms<DiscountTypeListForm>.ShowListForm(CardType.DiscountType);
            else if (e.Item == btnDocumentCards) ShowListForms<DocumentListForm>.ShowListForm(CardType.Document);
            else if (e.Item == btnPromotionCards) ShowListForms<PromotionListForm>.ShowListForm(CardType.Promotion);
            else if (e.Item == btnSchoolBusCards) ShowListForms<SchoolBusListForm>.ShowListForm(CardType.SchoolBus);
            else if (e.Item == btnClassCards) ShowListForms<ClassListForm>.ShowListForm(CardType.Class);
            else if (e.Item == btnServiceTypeCards) ShowListForms<ServiceTypeListForm>.ShowListForm(CardType.ServiceType);
            else if (e.Item == btnServiceCards) ShowListForms<ServiceListForm>.ShowListForm(CardType.Service);
            else if (e.Item == btnVaultCards) ShowListForms<VaultListForm>.ShowListForm(CardType.Vault);
            else if (e.Item == btnBankCards) ShowListForms<BankListForm>.ShowListForm(CardType.Bank);
            else if (e.Item == btnLawyerCards) ShowListForms<LawyerListForm>.ShowListForm(CardType.Lawyer);
            else if (e.Item == btnCustomerCards) ShowListForms<CustomerListForm>.ShowListForm(CardType.Customer);
            else if (e.Item == btnPaymentMethodCards) ShowListForms<PaymentMethodListForm>.ShowListForm(CardType.PaymentMethod);
            else if (e.Item == btnBankAccountCards) ShowListForms<BankAccountListForm>.ShowListForm(CardType.BankAccount);
            else if (e.Item == btnContactCards) ShowListForms<ContactListForm>.ShowListForm(CardType.Contact);
            else if (e.Item == btnStudentCards) ShowListForms<StudentListForm>.ShowListForm(CardType.Student);
            else if (e.Item == btnDiscountCards) ShowListForms<DiscountListForm>.ShowListForm(CardType.Discount);
            else if (e.Item == btnAccrueCards) ShowListForms<AccrueListForm>.ShowListForm(CardType.Accrue);
            else if (e.Item == btnReceiptCards) ShowListForms<ReceiptListForm>.ShowListForm(CardType.Receipt);
            else if (e.Item == btnBillCards) ShowListForms<BillPlanListForm>.ShowListForm(CardType.Bill);
            else if (e.Item == btnBillAccrueCard) ShowEditForms<BillAccrueEditForm>.ShowDialogEditForm(CardType.Bill);

            else if (e.Item == btnGeneralReport) ShowReportForms<GeneralReport>.ShowReportForm(CardType.GeneralReport);
            else if (e.Item == btnClassReports) ShowReportForms<ClassReports>.ShowReportForm(CardType.ClassReports);
            else if (e.Item == btnTakenServiceReport) ShowReportForms<TakenServiceReport>.ShowReportForm(CardType.TakenServiceReport);
            else if (e.Item == btnNetPriceReport) ShowReportForms<NetPriceReport>.ShowReportForm(CardType.NetPriceReport);
            else if (e.Item == btnPriceAndPaymentReport) ShowReportForms<PriceAndPaymentReport>.ShowReportForm(CardType.PriceAndPaymentReport);
            else if (e.Item == btnDiscountDistributionReport) ShowReportForms<DiscountDistributionReport>.ShowReportForm(CardType.DiscountDistributionReport);
            else if (e.Item == btnVocationalGroupReport) ShowReportForms<VocationalGroupReport>.ShowReportForm(CardType.VocationalGroupReport);
            else if (e.Item == btnMonthlyEnrollmentReport) ShowReportForms<MonthlyEnrollmentReport>.ShowReportForm(CardType.MonthlyEnrollmentReport);
            else if (e.Item == btnIncomeDistributionReport) ShowReportForms<IncomeDistributionReport>.ShowReportForm(CardType.IncomeDistributionReport);
            else if (e.Item == btnPriceAveragesReport) ShowReportForms<PriceAveragesReport>.ShowReportForm(CardType.PriceAveragesReport);
            else if (e.Item == btnPaymentDocumentsReport) ShowReportForms<PaymentDocumentsReport>.ShowReportForm(CardType.PaymentDocumentsReport);
            else if (e.Item == btnPaymentDocumentsReport) ShowReportForms<PaymentDocumentsReport>.ShowReportForm(CardType.PaymentDocumentsReport);
            else if (e.Item == btnOverdueReceivablesReport) ShowReportForms<OverdueReceivablesReport>.ShowReportForm(CardType.OverdueReceivablesReport);

            else if (e.Item == btnUserParameters)
            {
                var entity = ShowEditForms<UserParameterEditForm>.ShowDialogEditForm<UserParameterSingle>(UserId);

                if (entity == null) return;

                UserParameters = entity;

                pictBackgroundImage.EditValue = entity.BackgroundImage;
            }

            else if (e.Item == btnCalculator)
            {
                try
                {
                    Process.Start("calc.exe");
                }
                catch 
                {
                    Messages.ErrorMessage("Hesap Makinesi Bulunamadı");
                }
            }

            else if (e.Item == btnBranch)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if(Application.OpenForms[i] is LoginForm || Application.OpenForms[i] is MainForm) continue;

                    Application.OpenForms[i].Close();
                    i--;
                }

                BranchTermSelection(true);
            }



            Cursor.Current = Cursors.Default;

        }

        private void XtraTabbedMdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            pictBackgroundImage.SendToBack();
        }

        private void XtraTabbedMdiManager_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
                pictBackgroundImage.BringToFront();
        }
    }
}