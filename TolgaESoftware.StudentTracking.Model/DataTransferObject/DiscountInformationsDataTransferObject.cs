using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class DiscountInformationsList:DiscountInformations,IBaseActionEntity
    {
        public string DiscountName { get; set; }
        public string ServiceName { get; set; }
        public string CancellationReasonName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class DiscountInformationsReport
    {
        public string DiscountName { get; set; }
        public string ServiceName { get; set; }
        public decimal GrossDiscount { get; set; }
        public decimal ShortTermDeductedDiscount { get; set; }
        public decimal NetDiscount { get; set; }
        public DateTime ProcessDate { get; set; }
        public DateTime? CancellationDate { get; set; }
        public string CancellationReasonName { get; set; }
        public string CancellationReasonStatement { get; set; }

    }
}