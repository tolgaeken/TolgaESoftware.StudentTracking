using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCodeTextEdit:MyTextEdit
    {
        public MyCodeTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            StatusBarStatement = "Kod Giriniz";
            Name = "txtCode";
        }
    }
}