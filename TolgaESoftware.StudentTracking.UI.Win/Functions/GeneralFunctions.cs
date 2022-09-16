using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports.UI;
using DevExpress.XtraVerticalGrid;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Properties;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView table)
        {
            if (table.FocusedRowHandle > -1)
            {
                return (long)table.GetFocusedRowCellValue("Id");
            }
            Messages.NoCardSelectionMessage();
            return -1;
        }

        public static long GetRowCellId(this GridView table, GridColumn idColumn)
        {
            var value = table.GetRowCellValue(table.FocusedRowHandle, idColumn);
            return (long?)value ?? -1;
        }

        public static T GetRow<T>(this GridView table, bool getMessage = true)
        {
            if (table.FocusedRowHandle > -1) return (T)table.GetRow(table.FocusedRowHandle);
            if (getMessage) Messages.NoCardSelectionMessage();
            return default(T);
        }

        public static T GetRow<T>(this GridView table, int rowHandle)
        {
            if (table.FocusedRowHandle > -1) return (T)table.GetRow(rowHandle);
            Messages.NoCardSelectionMessage();
            return default(T);
        }

        private static DataChangeLocation GetDataChangeLocation<T>(T oldEntity, T currentEntity)
        {
            foreach (var property in currentEntity.GetType().GetProperties())
            {
                if (property.PropertyType.Namespace == "System.Collections.Generic") continue;

                var oldValue = property.GetValue(oldEntity) ?? string.Empty;
                var currentValue = property.GetValue(currentEntity) ?? string.Empty;

                if (property.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };

                    if (string.IsNullOrEmpty(currentValue.ToString()))
                        currentValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        return DataChangeLocation.Field;
                }

                if (property.PropertyType == typeof(SecureString))
                {
                    var oldString = ((SecureString) oldValue).ConvertToUnsecureString();
                    var currentString = ((SecureString) currentValue).ConvertToUnsecureString();

                    if (!oldString.Equals(currentString))
                        return DataChangeLocation.Field;
                }

                else if (!currentValue.Equals(oldValue))
                    return DataChangeLocation.Field;
            }

            return DataChangeLocation.NoChangingData;
        }

        public static void ButtonEnabledStatus<T>
            (BarButtonItem btnSave, BarButtonItem btnSaveAs, BarButtonItem btnDelete, ProcessType processType,
            T oldEntity, T currentEntity)
        {
            var dataChangeLocation = GetDataChangeLocation(oldEntity, currentEntity);
            var buttonEnabledStatus = dataChangeLocation == DataChangeLocation.Field;

            btnSave.Enabled = buttonEnabledStatus;
            btnSaveAs.Enabled = processType != ProcessType.EntityInsert;
            btnDelete.Enabled = !buttonEnabledStatus;
        }

        public static void ButtonEnabledStatus
        (BarButtonItem btnSave, BarButtonItem btnUndo, bool tableValueChanged)
        {
            var buttonEnabledStatus = tableValueChanged;

            btnSave.Enabled = buttonEnabledStatus;
            btnUndo.Enabled = buttonEnabledStatus;
        }

        public static void ButtonEnabledStatus<T>
        (BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnUndo, BarButtonItem btnDelete,
            T oldEntity, T currentEntity)
        {
            var dataChangeLocation = GetDataChangeLocation(oldEntity, currentEntity);
            var buttonEnabledStatus = dataChangeLocation == DataChangeLocation.Field;

            btnSave.Enabled = buttonEnabledStatus;
            btnUndo.Enabled = buttonEnabledStatus;
            btnNew.Enabled = !buttonEnabledStatus;
            btnDelete.Enabled = !buttonEnabledStatus;
        }

        public static void ButtonEnabledStatus
        (BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnUndo, BarButtonItem btnDelete)
        {
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
        }

        public static void ButtonEnabledStatus<T>
        (BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnUndo, BarButtonItem btnDelete,
            T oldEntity, T currentEntity, bool tableValueChanged)
        {
            var dataChangeLocation = tableValueChanged ? DataChangeLocation.Table : GetDataChangeLocation(oldEntity, currentEntity);
            var buttonEnabledStatus = dataChangeLocation == DataChangeLocation.Field || dataChangeLocation == DataChangeLocation.Table;

            btnSave.Enabled = buttonEnabledStatus;
            btnUndo.Enabled = buttonEnabledStatus;
            btnNew.Enabled = !buttonEnabledStatus;
            btnDelete.Enabled = !buttonEnabledStatus;
        }

        public static long CreateId(this ProcessType processType, BaseEntity selectedEntity)
        {
            string MakeTwoDigit(string value)
            {
                if (value.Length == 1) return "0" + value;
                return value;
            }

            string MakeThreeDigit(string value)
            {
                switch (value.Length)
                {
                    case 1:
                        return "00" + value;
                    case 2:
                        return "0" + value;
                }

                return value;
            }

            string MakeFourDigit(string value)
            {
                switch (value.Length)
                {
                    case 1:
                        return "000" + value;
                    case 2:
                        return "00" + value;
                    case 3:
                        return "0" + value;
                }

                return value;
            }

            string Id()
            {
                var year = MakeFourDigit(DateTime.Now.Date.Year.ToString());
                var month = MakeTwoDigit(DateTime.Now.Date.Month.ToString());
                var day = MakeTwoDigit(DateTime.Now.Date.Day.ToString());
                var hour = MakeTwoDigit(DateTime.Now.Hour.ToString());
                var minute = MakeTwoDigit(DateTime.Now.Minute.ToString());
                var second = MakeTwoDigit(DateTime.Now.Second.ToString());
                var milliSecond = MakeThreeDigit(DateTime.Now.Millisecond.ToString());
                var random = MakeTwoDigit(new Random().Next(0, 99).ToString());

                return year + month + day + hour + minute + second + milliSecond + random;
            }

            var id = Id();

            return processType == ProcessType.EntityUpdate ? selectedEntity.Id : long.Parse(Id());
        }

        public static void ControlEnabledChanged(this MyButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit edit:
                    edit.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
                    edit.Id = null;
                    edit.EditValue = null;
                    break;
                case PropertyGridControl propertyGrid:
                    propertyGrid.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
                    if (!propertyGrid.Enabled) propertyGrid.SelectedObject = null;
                    break;
            }
        }

        public static void AppSettingsWrite(string key, string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void RowFocus(this GridView table, string columnToSearch, object valueToSearch)
        {
            var rowHandle = 0;

            for (int i = 0; i < table.RowCount; i++)
            {
                var foundValue = table.GetRowCellValue(i, columnToSearch);
                if (valueToSearch.Equals(foundValue)) rowHandle = i;
            }

            table.Focus();
            table.FocusedRowHandle = rowHandle;
        }

        public static void RowFocus(this GridView table, int rowHandle)
        {
            if (rowHandle <= 0) return;
            if (rowHandle == table.RowCount - 1) table.FocusedRowHandle = rowHandle;
            else table.FocusedRowHandle = rowHandle - 1;
        }

        public static void ShowRightClickMenu(this MouseEventArgs e, PopupMenu rightClickMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            rightClickMenu.ShowPopup(Control.MousePosition);
        }

        public static List<string> ListPrinters()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }

        public static string DefaultPrinter()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static void ShowPopupMenu(this MouseEventArgs e, PopupMenu popupMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu.ShowPopup(Control.MousePosition);
        }

        public static byte[] UploadImage()
        {
            var dialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları (*.bmp,*.jpg,*.png,*.gif)|*.bmp; *.gif; *.jpg; *.png|Bmp Dosyaları|*.bmp|Gif Dosyaları|*.gif|Jpg Dosyaları|*.jpg|Png Dosyaları|*.png",
                InitialDirectory = @"C:\",
            };

            byte[] Picture()
            {
                using (var stream = new MemoryStream())
                {
                    Image.FromFile(dialog.FileName).Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            return dialog.ShowDialog() != DialogResult.OK ? null : Picture();
        }

        public static void RefreshDataSource(this GridView table)
        {
            var source = table.DataController.ListSource.Cast<IBaseActionEntity>().ToList();
            if (!source.Any(p => p.Delete)) return;
            var rowHandle = table.FocusedRowHandle;

            table.CustomRowFilter += Table_CustomRowFilter;
            table.RefreshData();
            table.CustomRowFilter -= Table_CustomRowFilter;
            table.RowFocus(rowHandle);

            void Table_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;

                if (!entity.Delete) return;

                e.Visible = false;
                e.Handled = true;
            }
        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseActionEntity> list)
        {
            return new BindingList<T>((IList<T>)list);
        }

        public static BaseTable AddTable(this BaseTable table, BaseEditForm form)
        {
            table.Dock = DockStyle.Fill;
            table.OwnerForm = form;
            return table;
        }

        public static void LayoutControlInsert(this LayoutGroup group, Control control, int columnIndex, int rowIndex, int columnSpan, int rowSpan)
        {
            var item = new LayoutControlItem
            {
                Control = control,
                Parent = group,
                OptionsTableLayoutItem =
                {
                    ColumnIndex = columnIndex,
                    RowIndex = rowIndex,
                    ColumnSpan = columnSpan,
                    RowSpan = rowSpan
                }
            };
        }

        public static void RowCellEnabled(this GridView table)
        {
            var rowHandle = table.FocusedRowHandle;

            table.FocusedRowHandle = 0;
            table.ClearSelection();

            table.FocusedRowHandle = rowHandle;
        }

        public static void CreateDropDownMenu(this BarButtonItem baseButton, BarItem[] buttonItems)
        {
            baseButton.ButtonStyle = BarButtonStyle.CheckDropDown;
            var popupMenu = new PopupMenu();
            buttonItems.ForEach(p => p.Visibility = BarItemVisibility.Always);
            popupMenu.ItemLinks.AddRange(buttonItems);
            baseButton.DropDownControl = popupMenu;
        }

        public static MyXtraReport StreamToReport(this MemoryStream stream)
        {
            return (MyXtraReport)XtraReport.FromStream(stream, true);

        }

        public static MemoryStream ByteToStream(this byte[] report)
        {
            return new MemoryStream(report);
        }

        public static MemoryStream ReportToStream(this XtraReport report)
        {
            var stream = new MemoryStream();
            report.SaveLayout(stream);
            return stream;
        }

        public static IEnumerable<T> CheckedComboBoxList<T>(this MyCheckedComboboxEdit comboBox)
        {
            return comboBox.Properties.Items.Where(p => p.CheckState == CheckState.Checked).Select(p => (T)p.Value);
        }

        public static void CreateConnectionString(string initialCatalog, string server, SecureString userName
            , SecureString password, AuthenticationType authenticationType)
        {
            SqlConnectionStringBuilder builder = null;

            switch (authenticationType)
            {
                case AuthenticationType.SqlServerAuthentication:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        UserID = userName.ConvertToUnsecureString(),
                        Password = password.ConvertToUnsecureString(),
                        InitialCatalog = initialCatalog,
                        MultipleActiveResultSets = true,
                    };
                    break;

                case AuthenticationType.WindowsAuthentication:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        InitialCatalog = initialCatalog,
                        IntegratedSecurity = true,
                        MultipleActiveResultSets = true,
                    };
                    break;

            }

            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configuration.ConnectionStrings.ConnectionStrings["StudentTrackingContext"].ConnectionString =
                builder?.ConnectionString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            Settings.Default.Reset();
            Settings.Default.Save();
        }

        public static bool ConnectionControl(string server, SecureString userName, SecureString password
            , AuthenticationType authenticationType, bool getGeneralMessage = false)
        {
            CreateConnectionString("", server, userName, password, authenticationType);

            using (var connection = new SqlConnection(Bll.Functions.GeneralFunctions.GetConnectionString()))
            {
                try
                {
                    if (connection.ConnectionString == "") return false;
                    connection.Open();
                    return true;
                }
                catch (SqlException exception)
                {
                    if (getGeneralMessage)
                    {
                        Messages.ErrorMessage("Server Bağlantı Ayarları Hatalıdır.\nLütfen Kontrol Ediniz.");
                        return false;
                    }

                    switch (exception.Number)
                    {
                        case 18456:
                            Messages.ErrorMessage("Server Kullanıcı Adı veya Şifresi Hatalıdır.");
                            break;
                        default:
                            Messages.ErrorMessage(exception.Message);
                            break;
                    }
                }

                return false;
            }
        }

        public static string Md5Crypt(this string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var byt = Encoding.UTF8.GetBytes(value);
            byt = md5.ComputeHash(byt);

            var md5Password = BitConverter.ToString(byt).Replace("-", "");

            return md5Password;
        }

        public static (SecureString securePassword, SecureString secureHint, string password, string hint) CreatePassword()
        {
            string createRandomValue(int minValue, int count)
            {
                var random = new Random();

                const string chatacterTable = "0123456789ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz_.";

                string result = null;

                for (int i = 0; i < count; i++)
                    result += chatacterTable[random.Next(minValue, chatacterTable.Length - 1)].ToString();

                return result;
            }

            var securePassword = createRandomValue(0, 8).ConvertToSecureString();
            var secureHint = createRandomValue(9, 10).ConvertToSecureString();
            var password = securePassword.ConvertToUnsecureString().Md5Crypt();
            var hint = secureHint.ConvertToUnsecureString().Md5Crypt();

            return (securePassword, secureHint, password, hint);
        }

        public static bool SendPasswordToEmail(this string userName, string role, string email,
            SecureString securePassword, SecureString secureHint)
        {
            using (var bll = new EmailParameterBll())
            {
                var entity = (EmailParameter)bll.Single(null);

                if (entity == null)
                {
                    Messages.ErrorMessage("E - Mail Gönderilemedi. Kurumun E - Mail Parametreleri Girilmedi\nLütfen Kontrol Edip Tekrar Deneyiniz");
                    return false;
                }

                var client = new SmtpClient
                {
                    Port = entity.PortNumber,
                    Host = entity.Host,
                    EnableSsl = entity.UseSSL == YesNo.Yes,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(entity.Email, entity.Password.Decrypt(entity.Id + entity.Code).ConvertToSecureString()),
                };

                var message = new MailMessage
                {
                    From = new MailAddress(entity.Email,"TolgaESoftwareStudentTracking"),
                    To = {email},
                    Subject = "TolgaESoftwareStudentTracking Programı Kullanıcı Bilgileri",
                    IsBodyHtml = true,
                    Body = "TolgaESoftwareStudentTracking Programına Giriş İçin Gereken Kullanıcı Adı , Şifre ve Gizli Kelime Bilgileri Aşağıdadır<br/>" 
                           + "Lütfen Programa Giriş Yaptıktan Sonra Bu Bilgileri Değiştiriniz<br/><br/><br/>"
                           + $"<b>Kullanıcı Adı :</b> {userName}<br/><br/>"
                           + $"<b>Yetki Türü :</b> {role}<br/><br/>"
                           + $"<b>Parola :</b> {securePassword.ConvertToUnsecureString()}<br/><br/>"
                           + $"<b>Gizli Kelime :</b> {secureHint.ConvertToUnsecureString()}"
                };

                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    client.Send(message);
                    Cursor.Current = Cursors.Default;
                    return true;
                }
                catch (Exception exception)
                {
                    Messages.ErrorMessage(exception.Message);
                    return false;
                }
            }
        }
    }
}