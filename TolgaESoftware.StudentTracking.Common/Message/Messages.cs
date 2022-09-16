using System.Windows.Forms;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;

namespace TolgaESoftware.StudentTracking.Common.Message
{
   public class Messages
    {
        public static void ErrorMessage(string errorMessage)
        {
            XtraMessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarningMessage(string warningMessage)
        {
            XtraMessageBox.Show(warningMessage, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void InformationMessage(string informationMessage)
        {
            XtraMessageBox.Show(informationMessage, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult YesSelectedYesNo(string message,string caption)
        { 
            return XtraMessageBox.Show(message,caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult NoSelectedYesNo(string message,string caption)
        {
            return XtraMessageBox.Show(message,caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
        
        public static DialogResult YesSelectedYesNoCancel(string message,string caption)
        { 
            return XtraMessageBox.Show(message,caption,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult DeletionMessage(string cardName)
        {
            return NoSelectedYesNo($"Seçtiğiniz {cardName} Silinecektir.Onaylıyor musunuz?", "Silme Onayı");
        }

        public static DialogResult ClosingMessage()
        {
            return YesSelectedYesNoCancel($"Yapılan Değişiklikler Kayıt Edilisin mi?", "Çıkış Onay");
        }

        public static DialogResult RegistrationMessage()
        {
            return YesSelectedYesNoCancel($"Yeni Kayıt Eklensin mi?", "Kayıt Onay");
        }

        public static DialogResult ClosingMessage(CardType cardType)
        {
            return YesSelectedYesNoCancel($"{cardType.ToName()} Bilgisinde Yapılan Değişiklikler Kayıt Edilisin mi?", "Çıkış Onay");
        }
        
        public static DialogResult ClosingMessage(string cardType)
        {
            return YesSelectedYesNoCancel($"{cardType} Bilgisinde Yapılan Değişiklikler Kayıt Edilisin mi?", "Çıkış Onay");
        }

        public static DialogResult RegistrationMessage(CardType cardType)
        {
            return YesSelectedYesNoCancel($"{cardType.ToName()} Bilgisinde Yapılan Yeni Kayıt Eklensin mi?", "Kayıt Onay");
        }

        public static void NoCardSelectionMessage()
        {
            WarningMessage("Lütfen Bir Kart Seçiniz.");
        }

        public static void DuplicateRecordErrorMessage(string fieldName)
        {
            ErrorMessage($"Girmiş Olduğunuz {fieldName} Daha Önce Kullanılmıştır.");
        }

        public static void WrongDataMessage(string fieldName)
        {
            ErrorMessage($"{fieldName} Alanına Geçerli Bir Değer Girmelisiniz.");
        }

        public static DialogResult TableExportMessage(string fileFormat)
        { 
            return YesSelectedYesNo($"İlgili Tablo {fileFormat} Dosyası Olarak Dışarı Aktarılacaktır.\nOnaylıyor musunuz?","Aktarım Onay");
        }

        public static DialogResult FilterClearMessage()
        {
            return YesSelectedYesNo($"Uygulanan Filtre Temizlenecektir.Onaylıyor musunuz?", "Filtre Temizle Onay");
        }

        public static void CardNotFoundMessage(string cardType)
        {
            WarningMessage($"İşlem Yapılabilecek {cardType} Bulunamadı");
        }

        public static void TableMissingInformationMessage(string tableName)
        {
            WarningMessage($"{tableName}nda Eksik Bilgi Girişi Mevcuttur.\nLütfen Kotntrol Ediniz");
        }

        public static void CancellationActionCannotBeDeleted()
        {
            ErrorMessage("İptal Edilen Hareketler Silinemez");
        }

        public static DialogResult CancellationMessage(string cardName)
        {
            return NoSelectedYesNo($"Seçtiğiniz {cardName} İptal Edilecektir.Onaylıyor musunuz?", "İptal Onayı");
        }

        public static DialogResult CancellationUndoMessage(string cardName)
        {
            return NoSelectedYesNo($"Seçtiğiniz {cardName} Kartına Uygulanan İptal İşlemi Geri Alınacaktır.Onaylıyor musunuz?", "İptal Geri Al Onayı");
        }

        public static void SelectionErrorMessage(string fieldName)
        {
            ErrorMessage($"{fieldName} Seçimi Yapmalısınız");
        }

        public static void PaymentDocumentCannotBeDeleted(bool after)
        {
            WarningMessage(after 
                ? "Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri Var.\nÖdeme Belgesi Silinemez"
                : "Ödeme Belgesinin İşlem Görmüş Hareketleri Var.\nÖdeme Belgesi Silinemez");
        }

        public static DialogResult SendReportToDesign()
        {
            return NoSelectedYesNo("Rapor Tasarım Görünümünde Açılacaktır\nOnaylıyor musunuz?", "Onay");
        }

        public static DialogResult CloseReport()
        {
            return NoSelectedYesNo("Rapor Kapatılacaktır\nOnaylıyor musunuz?", "Onay");
        }

        public static DialogResult EmailSendConfirmation()
        {
            return NoSelectedYesNo(
                "Kullanıcı Parolası Sıfırlanarak Kullanıcı Bilgilerini İçeren Yeni Bir E - Mail Gönderilecektir\nOnaylıyor musunuz?",
                "Onay");
        }
    }
}