using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum RefundAccountType:byte
    {
        [Description("Banka")]
        Bank = 1,
        [Description("Kasa")]
        Vault = 2
    }
}