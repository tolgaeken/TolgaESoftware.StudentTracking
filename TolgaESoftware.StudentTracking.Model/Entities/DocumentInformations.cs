using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class DocumentInformations:BaseActionEntity
    {
        public long AccrueId { get; set; }

        public long DocumentId { get; set; }
        public Document Document { get; set; }
    }
}