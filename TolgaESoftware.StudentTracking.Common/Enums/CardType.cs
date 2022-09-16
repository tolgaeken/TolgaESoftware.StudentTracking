using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum CardType : byte
    {
        [Description("Okul Kartı")]
        School = 1,
        [Description("İl Kartı")]
        Province = 2,
        [Description("İlçe Kartı")]
        District = 3,
        [Description("Filtre Kartı")]
        Filter = 4,
        [Description("Aile Bilgi Kartı")]
        FamilyInfo = 5,
        [Description("İptal Nedeni Kartı")]
        CancellationReason = 6,
        [Description("Yabancı Dil Kartı")]
        ForeignLanguage = 7,
        [Description("Teşvik Kartı")]
        Incent = 8,
        [Description("Kontenjan Kartı")]
        Quota = 9,
        [Description("Rehber Kartı")]
        Guide = 10,
        [Description("Sınıf Grup Kartı")]
        ClassGroup = 11,
        [Description("Meslek Kartı")]
        Vocation = 12,
        [Description("Yakınlık Kartı")]
        Kinship = 13,
        [Description("İşyeri Kartı")]
        Workplace = 14,
        [Description("Görev Kartı")]
        Job = 15,
        [Description("İndirim Türü Kartı")]
        DiscountType = 16,
        [Description("Evrak Kartı")]
        Document = 17,
        [Description("Promosyon Kartı")]
        Promotion = 18,
        [Description("Servis Yeri Kartı")]
        SchoolBus = 19,
        [Description("Sınıf Kartı")]
        Class = 20,
        [Description("Hizmet Türü Kartı")]
        ServiceType = 21,
        [Description("Hizmet Kartı")]
        Service = 22,
        [Description("Özel Kod Kartı")]
        SpecialCode = 23,
        [Description("Kasa Kartı")]
        Vault = 24,
        [Description("Banka Kartı")]
        Bank = 25,
        [Description("Banka Şube Kartı")]
        BankBranch = 26,
        [Description("Avukat Kartı")]
        Lawyer = 27,
        [Description("Cari Kartı")]
        Customer = 28,
        [Description("Ödeme Türü Kartı")]
        PaymentMethod = 29,
        [Description("Banka Hesap Kartı")]
        BankAccount = 30,
        [Description("İletişim Kartı")]
        Contact = 31,
        [Description("Öğrenci Kartı")]
        Student = 32,
        [Description("İndirim Kartı")]
        Discount = 33,
        [Description("Tahakkuk Kartı")]
        Accrue = 34,
        [Description("Makbuz Kartı")]
        Receipt = 35,
        [Description("Belge Seçim Kartı")]
        DocumentSelection = 36,
        [Description("Belge Hareketleri Kartı")]
        DocumentActions = 37,
        [Description("Rapor Kartı")]
        Report = 38,
        [Description("Rapor Tasarım")]
        ReportDesign = 39,
        [Description("Öğrenci Kartı Raporu")]
        StudentCardReport = 40,
        [Description("Banka Ödeme Planı Raporu")]
        BankPaymentPlanReport = 41,
        [Description("MEB Kayıt Sözleşmesi Raporu")]
        NationalEducationRegistrationContractReport = 42,
        [Description("İndirim Dilekçesi Raporu")]
        DiscountPetitionReport = 43,
        [Description("Kayıt Sözleşmesi Raporu")]
        RegistrationContractReport = 44,
        [Description("Kredi Kartlı Ödeme Talimatı Raporu")]
        CreditCardPaymentOrderReport = 45,
        [Description("Ödeme Senedi Raporu")]
        PaymentIndentureReport = 46,
        [Description("Kullanıcı Tanımlı Rapor")]
        UserDefinedReport = 47,
        [Description("Tahsilat Makbuzu Raporu")]
        CollectReceiptReport = 48,
        [Description("Teslimat Makbuzu Raporu")]
        DeliveryReceiptReport = 49,
        [Description("Geri İade Makbuzu Raporu")]
        RefundReceiptReport = 50,
        [Description("Genel Makbuz Raporu")]
        GeneralReceiptReport = 51,
        [Description("Şube Kartı")]
        Branch = 52,
        [Description("Fatura Kartı")]
        Bill = 53,
        [Description("Fatura Raporu")]
        BillReport = 54,
        [Description("Fatura Dönem İcmal Raporu")]
        BillTermSummaryReport = 55,
        [Description("Fatura Öğrenci İcmal Raporu")]
        BillStudentSummaryReport = 56,
        [Description("Genel Amaçlı Rapor")]
        GeneralReport = 57,
        [Description("Sınıf Raporları")]
        ClassReports = 58,
        [Description("Hizmet Alım Raporu")]
        TakenServiceReport = 59,
        [Description("Net Ücret Raporu")]
        NetPriceReport = 60,
        [Description("Ücret ve Ödeme Raporu")]
        PriceAndPaymentReport = 61,
        [Description("İndirim Dağılım Raporu")]
        DiscountDistributionReport = 62,
        [Description("Mesleklere Göre Kayıt Raporu")]
        VocationalGroupReport = 63,
        [Description("Aylık Kayıt Raporu")]
        MonthlyEnrollmentReport = 64,
        [Description("Gelir Dağılım Raporu")]
        IncomeDistributionReport = 65,
        [Description("Ücret Ortalamaları Raporu")]
        PriceAveragesReport = 66,
        [Description("Ödeme Belgeleri Raporu")]
        PaymentDocumentsReport = 67,
        [Description("Tahsilat Raporu")]
        CollectReport = 68,
        [Description("Ödemesi Geciken Alacaklar Raporu")]
        OverdueReceivablesReport = 69,
        [Description("Açıklama Kartı")]
        Statement = 70,
        [Description("Kullanıcı Parametre Kartı")]
        UserParameter = 71,
        [Description("Kurum Kartı")]
        Institution = 72,
        [Description("E - Mail Parametre Kartı")]
        EmailParameter = 73,
        [Description("Dönem Kartı")]
        Term = 74,
        [Description("Dönem Parametre Kartı")]
        TermParameter = 75,
        [Description("Kurum Bilgi Kartı")]
        InstitutionInformations = 76,
        [Description("Rol Kartı")]
        Role = 77,
        [Description("Yetki Kartı")]
        Authorization = 78,
        [Description("Kullanıcı Kartı")]
        User = 79,
        [Description("Bağlantı Ayarları")]
        ConnectionSettings = 80,
        [Description("Şifremi Unuttum")]
        ForgotPassword = 81
    }
}