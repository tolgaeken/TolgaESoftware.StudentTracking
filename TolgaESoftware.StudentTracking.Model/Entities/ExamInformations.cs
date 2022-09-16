using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class ExamInformations:BaseActionEntity
    {
        public long AccrueId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required,StringLength(30)]
        public string ExamName { get; set; }

        [Required,StringLength(20)]
        public string ScoreType { get; set; }

        public double Score { get; set; }

        public int Ranking { get; set; }

        public double RankingPercentage { get; set; }
    }
}