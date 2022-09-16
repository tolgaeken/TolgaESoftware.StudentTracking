using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum YesNo:byte
    {
        [Description("Evet")]
        Yes=1,
        [Description("Hayır")]
        No = 2
    }
}