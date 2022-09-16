using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class RoleAuthorization:BaseEntity
    {
        public CardType CardType { get; set; }
    }
}