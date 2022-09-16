using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    public class ReportList:BaseEntity
    {
        public string ReportName { get; set; }
        public string Statement { get; set; }
    }
}