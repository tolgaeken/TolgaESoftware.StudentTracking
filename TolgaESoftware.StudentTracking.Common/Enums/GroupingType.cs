using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum GroupingType:byte
    {
        [Description("Giriş Tarihine Göre")]
        ByEntryDate = 1,
        [Description("Vadeye Göre")]
        ByPaymentTerm = 2,
        [Description("Hesaba Geçiş Tarihine Göre")]
        ByAccountTransferDate = 3
    }
}