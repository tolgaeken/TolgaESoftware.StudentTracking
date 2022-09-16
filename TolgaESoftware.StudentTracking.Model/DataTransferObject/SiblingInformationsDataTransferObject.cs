using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class SiblingInformationsList :SiblingInformations,IBaseActionEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClassName { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
        public CancelStatus CancelStatus { get; set; }
        public string BranchName { get; set; }
        public long BranchId { get; set; }
        public long TermId { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}