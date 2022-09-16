using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class RefundInformationsList:RefundInformations,IBaseActionEntity
    {
        public long? AccountId { get; set; }
        public string AccountName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class RefundInformationsReport
    {
        public DateTime Date { get; set; }
        public RefundAccountType AccountType { get; set; }
        public string AccountName { get; set; }
        public decimal Price { get; set; }
        public string Statement { get; set; }
    }
}