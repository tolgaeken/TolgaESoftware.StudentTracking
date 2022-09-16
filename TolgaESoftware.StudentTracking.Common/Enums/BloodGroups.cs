using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum BloodGroups:byte
    {
        [Description("Kan Grubu Seçilmedi")]
        Empty = 1,
        [Description("0 Rh -")]
        ON = 2,
        [Description("0 Rh +")]
        OP = 3,
        [Description("A Rh -")]
        AN = 4,
        [Description("A Rh +")]
        AP = 5,
        [Description("B Rh -")]
        BN = 6,
        [Description("B Rh +")]
        BP = 7,
        [Description("AB Rh -")]
        ABN = 8,
        [Description("AB Rh +")]
        ABP = 9
    }
}
