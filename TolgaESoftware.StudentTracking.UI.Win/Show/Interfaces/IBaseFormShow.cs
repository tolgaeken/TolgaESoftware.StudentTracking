using TolgaESoftware.StudentTracking.Common.Enums;

namespace TolgaESoftware.StudentTracking.UI.Win.Show.Interfaces
{
    public interface IBaseFormShow
    {
        long ShowDialogEditForm(CardType cardType, long id /*,params object[] prm*/);
    }
}
