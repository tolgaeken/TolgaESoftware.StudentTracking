using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum AuthenticationType:byte
    {
        [Description("Sql Server Yetkilendirmesi")]
        SqlServerAuthentication = 1,
        [Description("Windows Yetkilendirmesi")]
        WindowsAuthentication = 2
    }
}
