using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum ReceiptType : byte
    {
        [Description("Avukata Gönderme")]
        SendingToLawyer = 1,
        [Description("Avukat Yoluyla Tahsil Etme")]
        CollectedViaLawyer = 2,
        [Description("Bankaya Tahsile Gönderme")]
        SendingToBank = 3,
        [Description("Banka Yoluyla Tahsil Etme")]
        CollectedViaBank = 4,
        [Description("Başka Şubeye Gönderme")]
        SendingToAnotherBranch = 5,
        [Description("Blokeye Alma")]
        Blocking = 6,
        [Description("Bloke Çözümü")]
        Unblocking = 7,
        [Description("Ciro Etme")]
        Profiting = 8,
        [Description("Gelen Belgeyi Onaylama")]
        ApproveIncomingDocument = 9,
        [Description("Karşılıksız Olarak İşaretleme")]
        MarkAsUnpaid = 10,
        [Description("Mahsup Etme")]
        Offsetting = 11,
        [Description("Müşteri Geri İade")]
        RefundToCustomer = 12,
        [Description("Ödenmiş Olarak İşaretleme")]
        MarkAsPaid = 13,
        [Description("Portföye Geri İade")]
        RefundToWallet = 14,
        [Description("Portföye Karşılıksız İade")]
        FreeRefundToWallet = 15,
        [Description("Tahsil Etme ( Banka )")]
        ChargedToBank = 16,
        [Description("Tahsil Etme ( Kasa )")]
        ChargedToVault = 17,
        [Description("Tahsili İmkansız Hale Gelme")]
        ImpossibleCollect = 18,

    }
}