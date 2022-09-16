using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum Months:byte
    {
        [Description("Ocak")]
        January = 1,
        [Description("Şubat")]
        Fabruary = 2,
        [Description("Mart")]
        March = 3,
        [Description("Nisan")]
        April = 4,
        [Description("Mayıs")]
        May = 5,
        [Description("Haziran")]
        June = 6,
        [Description("Temmuz")]
        July = 7,
        [Description("Ağustos")]
        August = 8,
        [Description("Eylül")]
        September = 9,
        [Description("Ekim")]
        October = 10,
        [Description("Kasım")]
        November = 11,
        [Description("Aralık")]
        December = 12
    }
}
