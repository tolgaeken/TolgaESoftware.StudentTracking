using DevExpress.XtraPrinting;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class ReportPreview : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ReportPreview(params object[] prm)
        {
            InitializeComponent();

            reportShower.PrintingSystem = (PrintingSystemBase) prm[0];
            Text = $"{Text} ( {prm[1].ToString()} )";
        }
    }
}