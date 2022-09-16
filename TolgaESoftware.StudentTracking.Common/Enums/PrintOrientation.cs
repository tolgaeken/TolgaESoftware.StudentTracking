using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum PrintOrientation:byte
    {
        [Description("Dikey")]
        Vertical =1,
        [Description("Yatay")]
        Horizontal=2,
        [Description("Otomatik")]
        Auto = 3
    }
}