using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class SchoolSingle:School
    {
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
    }

    public class SchoolList : BaseEntity
    {
        public string SchoolName { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
        public string Statement { get; set; }
    }
}