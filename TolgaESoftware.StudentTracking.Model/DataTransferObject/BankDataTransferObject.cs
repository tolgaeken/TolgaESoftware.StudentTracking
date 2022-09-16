using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class BankSingle:Bank
    {
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
    }

    public class BankList : BaseEntity
    {
        public string BankName { get; set; }
        public string SpecialCode1Name { get; set; }
        public string SpecialCode2Name { get; set; }
        public string Statement { get; set; }
    }
}