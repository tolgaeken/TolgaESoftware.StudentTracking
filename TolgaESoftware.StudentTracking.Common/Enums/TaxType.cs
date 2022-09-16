using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum TaxType:byte
    {
        [Description("Dahil")]
        Included = 1,
        [Description("Hariç")]
        Excluded = 2
    }
}
