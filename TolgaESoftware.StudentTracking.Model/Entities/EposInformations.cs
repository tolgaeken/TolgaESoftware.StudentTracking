using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class EposInformations:BaseActionEntity
    {
        public long AccrueId { get; set; }

        [Required,StringLength(30)]
        public string Name { get; set; }

        [Required,StringLength(30)]
        public string Lastname { get; set; }

        [Required,StringLength(50)]
        public string CardNumber { get; set; }

        [Required,StringLength(50)]
        public string ExpirationDate { get; set; }

        [Required,StringLength(50)]
        public string SecurityCode { get; set; }

        public EposCardType CardType { get; set; } = EposCardType.Visa;

        public Bank Bank { get; set; }
        public long BankId { get; set; }
    }
}