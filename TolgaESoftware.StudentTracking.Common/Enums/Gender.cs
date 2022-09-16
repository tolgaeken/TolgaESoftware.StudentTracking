using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum Gender:byte
    {
        [Description("Erkek")]
        Boy = 1,
        [Description("Kız")]
        Girl = 2
    }
}