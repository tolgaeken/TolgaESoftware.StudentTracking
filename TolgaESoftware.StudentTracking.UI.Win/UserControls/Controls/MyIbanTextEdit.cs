using System.ComponentModel;
using DevExpress.XtraEditors.Mask;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyIbanTextEdit:MyTextEdit
    {
        public MyIbanTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            Properties.MaxLength = 32;
            StatusBarStatement = "IBAN No Giriniz";
        }
    }
}