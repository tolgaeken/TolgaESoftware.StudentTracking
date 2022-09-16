using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum PaymentType:byte
    {
        [Description("Açık")]
        Open = 1,
        [Description("Çek")]
        Cheque = 2,
        [Description("Nakit")]
        Cash = 3,
        [Description("Epos")]
        Epos = 4,
        [Description("Ots")]
        Sps = 5,
        [Description("Pos")]
        Pos = 6,
        [Description("Senet")]
        Indenture = 7

    }
}