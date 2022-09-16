using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum ServiceTypeEnum:byte
    {
        [Description("Eğitim")]
        Education = 1,
        [Description("Yemek")]
        Food = 2,
        [Description("Servis")]
        SchoolBus = 3,
        [Description("Yurt")]
        Dorm = 4,
        [Description("Diğer")]
        Other = 5
    }
}