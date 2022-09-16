using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class ClassSingle:Class
    {
        public string GroupName { get; set; }
    }

    public class ClassList : BaseEntity
    {
        public string ClassName { get; set; }
        public string GroupName { get; set; }
        public int TargetNumberOfStudents { get; set; }
        public decimal TargetProfit { get; set; }
        public string Statement { get; set; }

    }

}