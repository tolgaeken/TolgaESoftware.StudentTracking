using System;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.Show
{
    public class ShowReportForms<TForm> where TForm : BaseReport
    {
        public static void ShowReportForm(CardType cardType)
        {
            //Authentication Control

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Loads();
            frm.Show();
        }
    }
}
