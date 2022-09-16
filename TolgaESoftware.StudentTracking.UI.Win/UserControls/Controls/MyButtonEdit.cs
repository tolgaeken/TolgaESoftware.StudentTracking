using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit : ButtonEdit, IStatusBarShortcut
    {
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public string StatusBarStatement { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 : ";
        public string StatusBarShortcutStatement { get; set; }

        #region Events
        private long? _id;
        [Browsable(false)]
        public long? Id
        {
            get => _id;
            set
            {
                var oldValue = _id;
                var newValue = value;


                if (newValue.HasValue && oldValue.HasValue && newValue == oldValue) return;
                _id = value;


                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
                //IdChanged?.Invoke(this, new IdChangedEventArgs(oldValue, newValue));
                EnabledChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };
        //public event EventHandler<IdChangedEventArgs> IdChanged; 
        public event EventHandler EnabledChanged = delegate { };
        #endregion


    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }
        public long? NewValue { get; }
    }
}