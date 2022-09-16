using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Bank:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Banka Adı","txtBankName")]
        public string BankName { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public long? SpecialCode1Id { get; set; }
        public SpecialCode SpecialCode1 { get; set; }

        public long? SpecialCode2Id { get; set; }
        public SpecialCode SpecialCode2 { get; set; }

        [InverseProperty("Bank")]
        public ICollection<BankBranch> BankBranch { get; set; }
    }
}