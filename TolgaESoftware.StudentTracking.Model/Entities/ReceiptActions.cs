using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class ReceiptActions : BaseActionEntity
    {
        [Column(TypeName = "money")]
        public decimal PriceBeforeTransaction { get; set; }

        [Column(TypeName = "money")]
        public decimal TransactionPrice { get; set; }

        public DocumentStatus DocumentStatus { get; set; }


        public long ReceiptId { get; set; }
        public Receipt Receipt { get; set; }

        public int PaymentInformationsId { get; set; }
        public PaymentInformations PaymentInformations { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public long OldBranchId { get; set; }
        public Branch OldBranch { get; set; }

        public long? NewBranchId { get; set; }
        public Branch NewBranch { get; set; }

    }
}