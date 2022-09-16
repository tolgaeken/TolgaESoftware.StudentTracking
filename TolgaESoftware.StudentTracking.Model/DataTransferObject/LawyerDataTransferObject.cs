using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class LawyerSingle:Lawyer
    {
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
    }

    public class LawyerList:BaseEntity
    {
        public string NameLastname { get; set; }
        public string TrIdentityNumber { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string Statement { get; set; }
    }
}