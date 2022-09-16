using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum AddressType:byte
    {
        [Description("Ev Adresi")]
        HomeAddress = 1,
        [Description("İş Adresi")]
        WorkAddress = 2
    }
}