using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum TakenServiceStatus:byte
    {
        [Description("Hizmeti Alanlar")]
        TakenService = 1,
        [Description("Hizmeti Almayanlar")]
        NotTakenService = 2
    }
}