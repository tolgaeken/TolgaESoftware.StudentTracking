﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Quota:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Kontenjan Adı","txtQuotaName")]
        public string QuotaName { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }
    }
}