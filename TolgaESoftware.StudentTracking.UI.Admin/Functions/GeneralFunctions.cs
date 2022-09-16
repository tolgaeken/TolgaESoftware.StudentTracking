using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.UI.Admin.Forms.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Admin.Functions
{
    public class GeneralFunctions
    {
        protected internal static bool CreateDatabase<TContext>(string splashCaption, string splashDescription,
            string confirmMessage, string informationMessage) where TContext : DbContext, new()
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = Bll.Functions.GeneralFunctions.GetConnectionString();

                if (context.Database.Exists()) return true;

                if (Messages.YesSelectedYesNo(confirmMessage, "Onay") != DialogResult.Yes) return false;

                var splashForm = new SplashScreenManager(Form.ActiveForm, typeof(WaitingForm), true, true);

                StartSplash(splashForm);

                splashForm.SetWaitFormCaption(splashCaption);
                splashForm.SetWaitFormDescription(splashDescription);

                try
                {
                    if (context.Database.CreateIfNotExists())
                    {
                        StopSplash(splashForm);
                        Messages.InformationMessage(informationMessage);
                        return true;
                    }
                }
                catch (SqlException exception)
                {
                    StopSplash(splashForm);

                    switch (exception.Number)
                    {
                        case 5170:
                            Messages.ErrorMessage("Veritabanı Dosyalarının Yükleneceği Klasörde Aynı İsimde Dosya Mevcuttur.\nLütfen Kontrol Ediniz\n\n" + exception.Message);
                            break;
                        default:
                            Messages.ErrorMessage(exception.Message);
                            break;
                    }
                }

                return false;
            }
        }

        protected internal static bool DeleteDatabase<TContext>() where TContext : DbContext, new()
        {
            using (var context = new TContext())
            {
                context.Database.Connection.ConnectionString = Bll.Functions.GeneralFunctions.GetConnectionString();

                if (Messages.NoSelectedYesNo(
                    "Seçilen Kurum ve Kuruma Bağlı Yapılan İşlemlerin Tamamnını İçeren Kurum Veritabanı (Veritabanı Dosyaları Dahil) Silinecektir.\nOnaylıyor musunuz?",
                    "Onay") != DialogResult.Yes) return false;
                
                if (Messages.NoSelectedYesNo("Silme İşlemini Tekrar Onaylıyor musunuz?", "Onay") != DialogResult.Yes) return false;

                try
                {
                    if (context.Database.Delete())
                    {
                        Messages.InformationMessage("Kurum Silme İşlemi Başarılı Bir Şekilde Tamamlanmıştır.");
                        return true;
                    }
                }

                catch (SqlException exception)
                {
                    switch (exception.Number)
                    {
                        case 3702:
                            Messages.ErrorMessage(
                                "Veritabanı Kullanımda Olduğu İçin Silinemedi.\nLütfen Veritabanındaki Tüm Mevcut Bağlantıları Sonlandırdıktan Sonra Tekrar Deneyiniz");
                            break;
                        default:
                            Messages.ErrorMessage(exception.Message);
                            break;
                    }
                }


                return false;

            }
        }

        private static void StartSplash(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
                manager.ShowWaitForm();
            }

            else manager.ShowWaitForm();
          
        }

        private static void StopSplash(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible) manager.CloseWaitForm();


        }

    }
}