using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class CustomerSingle:Customer
    {
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
    }

    public class CustomerList:BaseEntity
    {
        public string CustomerName { get; set; }
        public string TrIdentityNumber { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }
        public string Fax { get; set; }
        public string Web { get; set; }
        public string EMail { get; set; }
        public string TaxAdministration { get; set; }
        public string TaxNumber { get; set; }
        public string Address { get; set; }
        public string Statement { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
    }
}
