using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit:SpinEdit,IStatusBarStatement
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarStatement { get; set; }
    }
}