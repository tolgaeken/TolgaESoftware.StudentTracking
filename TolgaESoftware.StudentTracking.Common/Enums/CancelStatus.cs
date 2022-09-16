using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum CancelStatus
    {
        [Description("İptal Edildi")]
        Cancelled = 1,
        [Description("Devam Ediyor")]
        Continues = 2,
    }
}