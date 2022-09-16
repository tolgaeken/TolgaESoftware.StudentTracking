using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyLookUpEdit:LookUpEdit,IStatusBarShortcut
    {
        public MyLookUpEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.HeaderClickMode = HeaderClickMode.AutoSearch;
            Properties.ShowFooter = false;

        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarStatement { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 : ";
        public string StatusBarShortcutStatement { get; set; } = "Seçim Yap";
    }
}