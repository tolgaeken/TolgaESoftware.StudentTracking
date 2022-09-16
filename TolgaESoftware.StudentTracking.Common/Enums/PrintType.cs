using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum PrintType:byte
    {
        [Description("Tek Tek Yazdır")]
        OneByOnePrint = 1,
        [Description("Toplu Yazdır")]
        MassPrint = 2
    }
}