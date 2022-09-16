using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class DiscountSingle:Discount
    {
        public string DiscountTypeName { get; set; }
    }

    public class DiscountList : BaseEntity
    {
        public string DiscountName { get; set; }
        public long DiscountTypeId { get; set; }
        public string DiscountTypeName { get; set; } 
        public string Statement { get; set; }
    }
}