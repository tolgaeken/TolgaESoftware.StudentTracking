using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum FitReportToPaperType:byte
    {
        [Description("Sütunları Daraltarak Sığdır")]
        ShrinkColumnsToFit=1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        ReduceTheFontSizeToFit =2,
        [Description("İşlem Yapma")]
        DoNotProcess =3
    }
}