using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum EnrollmentStatus:byte
    {
        [Description("Ön Kayıt")]
        PreEnroll = 1,
        [Description("Kesin Kayıt")]
        CertainEnroll = 2,
        [Description("Kayıtsız")]
        UnEnroll = 3
    }
}