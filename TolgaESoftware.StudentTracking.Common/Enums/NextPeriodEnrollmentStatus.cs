using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum NextTermEnrollmentStatus:byte
    {
        [Description("Kayıt Yenileyecek")]
        WillBeRenewedEnrollment = 1,
        [Description("Şartlı Kayıt Yenileyecek")]
        WillBeRenewedEnrollmentWithConditions = 2,
        [Description("Kayıt Yenilemeyecek")]
        WillNotBeRenewedEnrollment = 3,
        [Description("Kurum Tarafından Kaydı Yenilenmeyecek")]
        WillNotBeRenewedEnrollmentFromInstitution = 4
    }
}