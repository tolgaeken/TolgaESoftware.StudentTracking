using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum ReportSectionType:byte
    {
        [Description("Genel Raporlar")]
        GeneralReports = 1,
        [Description("Tahakkuk Raporları")]
        AccrueReports = 2,
        [Description("Fatura Dönem Raporları")]
        BillTermReports = 3,
        [Description("Fatura Genel Raporlar")]
        BillGeneralReports = 4,
        [Description("Makbuz Raporları")]
        ReceiptReports = 5
    }
}