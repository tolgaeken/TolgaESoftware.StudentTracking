using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToggleSwitch:ToggleSwitch,IStatusBarStatement
    {
        public MyToggleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
            Font = new Font("Tahoma" , 8.25f , FontStyle.Bold);
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarStatement { get; set; } = "Durumu Seçiniz";
    }
}