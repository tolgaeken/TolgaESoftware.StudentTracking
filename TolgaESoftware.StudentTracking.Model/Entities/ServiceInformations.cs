using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class ServiceInformations:BaseActionEntity
    {
        [Column(TypeName = "date")]
        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "money")]
        public decimal GrossPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal ShortTermDeductedPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal NetPrice { get; set; }

        public bool Cancelled { get; set; }

        public int NumberOfEducationTermDateDays { get; set; }

        public int NumberOfTakenServiceDays { get; set; }

        [Column(TypeName = "money")]
        public decimal DailyPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CancellationDate { get; set; }

        [StringLength(1000)]
        public string CancellationStatement { get; set; }


        public long AccrueId { get; set; }
        public Accrue Accrue { get; set; }

        public long? CancellationReasonId { get; set; }
        public CancellationReason CancellationReason { get; set; }

        public long? SchoolToGoesId { get; set; }
        public School SchoolToGoes { get; set; }

        public long ServiceId { get; set; }
        public Service Service { get; set; }

        public long ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }

        public long? SchoolBusId { get; set; }
        public SchoolBus SchoolBus { get; set; }
    }
}