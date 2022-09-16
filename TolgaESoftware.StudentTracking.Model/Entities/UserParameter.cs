using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class UserParameter : BaseEntity
    {
        [Index("IX_Code", IsUnique = false)]
        public override string Code { get; set; }

        public bool CloseReportsWithoutConfirmation { get; set; }
        public int TableViewCaptionForeColor { get; set; } = Color.Maroon.ToArgb();
        public int TableColumnHeaderForeColor { get; set; } = Color.Maroon.ToArgb();
        public int TableBandPanelForeColor { get; set; } = Color.DarkBlue.ToArgb();

        [Column(TypeName = "image")]
        public byte[] BackgroundImage { get; set; }


        public long UserId { get; set; }
        public User User { get; set; }

        public long? DefaultLawyerAccountId { get; set; }
        public Lawyer DefaultLawyerAccount { get; set; }

        public long? DefaultBankAccountId { get; set; }
        public BankAccount DefaultBankAccount { get; set; }

        public long? DefaultVaultAccountId { get; set; }
        public Vault DefaultVaultAccount { get; set; }
    }
}
