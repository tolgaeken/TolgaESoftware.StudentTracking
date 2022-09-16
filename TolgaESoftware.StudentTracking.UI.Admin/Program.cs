using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using TolgaESoftware.StudentTracking.UI.Admin.Forms.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Admin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");

            Application.Run(new LoginForm());
        }
    }
}
