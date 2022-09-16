using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySimpleButton:SimpleButton,IStatusBarStatement
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarStatement { get; set; }
    }
}