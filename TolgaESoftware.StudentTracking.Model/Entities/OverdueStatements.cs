using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class OverdueStatements : BaseEntity
    {
        [Index("IX_Code", IsUnique = false)]
        public override string Code { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }

        [Required, StringLength(1000), RequiredField("Açıklama", "txtStatement")]
        public string Statement { get; set; }

        public int PaymentInformationsId { get; set; }
        public PaymentInformations PaymentInformations { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }
    }
}