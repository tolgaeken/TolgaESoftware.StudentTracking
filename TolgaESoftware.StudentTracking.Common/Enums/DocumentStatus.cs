using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum DocumentStatus:byte
    {
        [Description("Portföyde")]
        OnWallet = 1,
        [Description("Tahsil Etme ( Kasa )")]
        ChargedToVault = 2,
        [Description("Tahsil Etme ( Banka )")]
        ChargedToBank = 3,
        [Description("Kısmi Tahsil Edildi")]
        PartlyCollect = 4,
        [Description("Bankaya Tahsile Gönderme")]
        SendingToBank = 5,
        [Description("Banka Yoluyla Tahsil Etme")]
        CollectedViaBank = 6,
        [Description("Portföye Geri İade")]
        RefundToWallet = 7,
        [Description("Portföye Karşılıksız İade")]
        FreeRefundToWallet = 8,
        [Description("Avukata Gönderme")]
        SendingToLawyer = 9,
        [Description("Avukat Yoluyla Tahsil Etme")]
        CollectedViaLawyer = 10,
        [Description("Kısmi Avukat Yoluyla Tahsil Etme")]
        PartlyCollectedViaLawyer = 11,
        [Description("Blokeye Alma")]
        Blocking = 12,
        [Description("Bloke Çözümü")]
        Unblocking = 13,
        [Description("Ciro Etme")]
        Profiting = 14,
        [Description("Müşteri Geri İade")]
        RefundToCustomer = 15,
        [Description("Mahsup Etme")]
        Offsetting = 16,
        [Description("Onay Bekliyor")]
        WaitingConfirmation = 17,
        [Description("Ödenmiş Olarak İşaretleme")]
        MarkAsPaid = 18,
        [Description("Karşılıksız Olarak İşaretleme")]
        MarkAsUnpaid = 19,
        [Description("Tahsili İmkansız Hale Gelme")]
        ImpossibleCollect = 20
    }
}