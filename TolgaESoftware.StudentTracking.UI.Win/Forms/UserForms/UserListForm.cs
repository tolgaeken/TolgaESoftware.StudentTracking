using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms
{
    public partial class UserListForm : BaseListForm
    {
        public UserListForm()
        {
            InitializeComponent();
            Bll = new UserBll();

            HideItems = new BarItem[] { btnSelect };
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.User;
            FormShow = new ShowEditForms<UserEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((UserBll) Bll).List(FilterFunctions.Filter<User>(ShowActiveCards));
        }
    }
}