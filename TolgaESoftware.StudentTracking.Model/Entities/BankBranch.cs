using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class BankBranch:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Banka Şube Adı","txtBankBranchName")]
        public string BankBranchName { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public long BankId { get; set; }
        public Bank Bank { get; set; }
    }
}