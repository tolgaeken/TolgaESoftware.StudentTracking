using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class NoteInformations:BaseActionEntity
    {
        public long AccrueId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required,StringLength(1000)]
        public string Note { get; set; }
    }
}