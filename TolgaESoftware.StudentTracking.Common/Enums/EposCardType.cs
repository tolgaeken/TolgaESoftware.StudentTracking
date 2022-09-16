using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum EposCardType:byte
    {
        [Description("Visa")]
        Visa = 1,
        [Description("MasterCard")]
        Master = 2,
        [Description("American Express")]
        AmericanExpress = 3
    }
}