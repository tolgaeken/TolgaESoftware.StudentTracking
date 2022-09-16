using System.ComponentModel;

namespace TolgaESoftware.StudentTracking.Common.Enums
{
    public enum BankAccountType:byte
    {
        [Description("Vadesiz Mevduat Hesabı")]
        DemandDepositAccount = 1,
        [Description("Vadeli Mevduat Hesabı")]
        TimeDepositAccount = 2,
        [Description("Kredi Hesabı")]
        CreditAccount = 3,
        [Description("Epos Bloke Hesabı")]
        BlockedEposAccount = 4,
        [Description("Ots Bloke Hesabı")]
        BlockedSpsAccount = 5,
        [Description("Pos Bloke Hesabı")]
        BlockedPosAccount = 6,
        [Description("Bloke Çözüm Hesabı")]
        BlockedSolutionAccount = 7
    }
}