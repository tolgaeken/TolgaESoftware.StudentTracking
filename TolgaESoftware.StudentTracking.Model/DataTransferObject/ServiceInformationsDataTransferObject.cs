using System;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class ServiceInformationsList:ServiceInformations,IBaseActionEntity
    {
        public string CancellationReasonName { get; set; }
        public string SchoolToGoesName { get; set; }
        public string ServiceName { get; set; }
        public ServiceTypeEnum ServiceTypeEnum { get; set; }
        public string SchoolBusName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class ServiceInformationsReport
    {
        public string ServiceName { get; set; }
        public string SchoolBusName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ProcessDate { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal ShortTermDeductedPrice { get; set; }
        public decimal NetPrice { get; set; }
        public int NumberOfEducationTermDateDays { get; set; }
        public int NumberOfTakenServiceDays { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime? CancellationDate { get; set; }
        public string CancellationReasonName { get; set; }
        public string CancellationReasonStatement { get; set; }
        public string SchoolToGoesName { get; set; }
    }
}
