using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class BranchSingle:Branch
    {
        public string AddressProvinceName { get; set; }
        public string AddressDistrictName { get; set; }
    }

    public class BranchList : BaseEntity
    {
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string AddressProvinceName { get; set; }
        public string AddressDistrictName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string IbanNumber { get; set; }
        public string GroupName { get; set; }
        public int? RowNumber { get; set; }
        public string InstitutionName { get; set; }
    }
}
