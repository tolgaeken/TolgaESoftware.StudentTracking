using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class UserUnitAuthorizations:BaseActionEntity
    {
        
        public CardType CardType { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public long? BranchId { get; set; }
        public Branch Branch { get; set; }

        public long? TermId { get; set; }
        public Term Term { get; set; }
    }
}