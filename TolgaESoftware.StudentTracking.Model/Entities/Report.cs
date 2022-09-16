using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Report:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Rapor Adı","txtReportName")]
        public string ReportName { get; set; }

        public CardType ReportType { get; set; }

        public ReportSectionType ReportSectionType { get; set; }

        [Required]
        public byte[] File { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }
    }
}