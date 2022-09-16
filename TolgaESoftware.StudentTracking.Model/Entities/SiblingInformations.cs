using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class SiblingInformations:BaseActionEntity
    {
        public long AccrueId { get; set; }

        public Accrue SiblingAccrue { get; set; }
        public long SiblingAccrueId { get; set; }
    }
}