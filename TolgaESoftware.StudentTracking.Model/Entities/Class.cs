using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Class:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Sınıf Adı","txtClassName")]
        public string ClassName { get; set; }
        public int TargetNumberOfStudents { get; set; }

        [Column(TypeName = "money")]
        public decimal TargetProfit { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        [RequiredField("Grup Adı","txtClassGroup")]
        public long ClassGroupId { get; set; }
        public ClassGroup ClassGroup { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}