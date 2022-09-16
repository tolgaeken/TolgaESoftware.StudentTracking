using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum ReceiptAccountType:byte
    {
        [Description("Avukat")]
        Lawyer = 1,
        [Description("Banka")]
        Bank = 2,
        [Description("Cari")]
        Customer = 3,
        [Description("Epos")]
        Epos = 4,
        [Description("İade")]
        Refund = 5,
        [Description("Kasa")]
        Vault = 6,
        [Description("Mahsup")]
        Offset = 7,
        [Description("Ots")]
        Sps = 8,
        [Description("Pos")]
        Pos = 9,
        [Description("Şüpheli")]
        Dubious = 10,
        [Description("Transfer")]
        Transfer = 11
    }
}