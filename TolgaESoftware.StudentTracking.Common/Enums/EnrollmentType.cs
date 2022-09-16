using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum EnrollmentType:byte
    {
        [Description("Yeni Kayıt")]
        NewEnrollment = 1,
        [Description("Kayıt Yenileme")]
        RenewedEnrollment = 2,
        [Description("Nakil Kayıt")]
        TransferEnrollment = 3
    }
}