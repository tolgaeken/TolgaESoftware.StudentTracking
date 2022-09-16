using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using TolgaESoftware.StudentTracking.Common.Enums;

namespace TolgaESoftware.StudentTracking.UI.Win.Show
{
    public class ShowRibbonForms<TForm> where TForm : RibbonForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var form = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            if (dialog) using (form) form.ShowDialog();
            else form.Show();
        }

        public static long ShowDialogForm(CardType cardType, params object[] prm)
        {
            //Authentication Control

            var form = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            using (form)
            {
                form.ShowDialog();
                return form.DialogResult == DialogResult.OK ? (long) form.Tag : 0;
            }

        }
    }
}