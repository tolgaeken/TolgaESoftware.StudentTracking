using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class RoleAuthorizations:BaseActionEntity
    {
        public CardType CardType { get; set; }
        public byte CanRead { get; set; }
        public byte CanAdd { get; set; }
        public byte CanChange { get; set; }
        public byte CanDelete { get; set; }

        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}
