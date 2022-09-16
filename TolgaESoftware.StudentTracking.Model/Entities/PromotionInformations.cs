using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class PromotionInformations:BaseActionEntity
    {
        public long AccrueId { get; set; }

        public long PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}