using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyHyperLinkLabelControl:HyperlinkLabelControl,IStatusBarStatement
    {
        public MyHyperLinkLabelControl()
        {
            Cursor = Cursors.Hand;
            LinkBehavior = LinkBehavior.NeverUnderline;
        }

        public string StatusBarStatement { get; set; }
    }
}