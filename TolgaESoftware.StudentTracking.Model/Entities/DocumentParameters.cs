using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class DocumentParameters:IBaseEntity
    {
        public string ReportHeader { get; set; }
        public YesNo AddHeader { get; set; }
        public FitReportToPaperType FitReportToPaper { get; set; }
        public PrintOrientation PrintOrientation { get; set; }
        public YesNo ShowHorizontalLines { get; set; }
        public YesNo ShowVerticalLines { get; set; }
        public YesNo ShowColumnHeaders { get; set; }
        public string PrinterName { get; set; }
        public int PrintQuantity { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}