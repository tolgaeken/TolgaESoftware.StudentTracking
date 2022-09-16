using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.UserUnitAuthorizationsEditFormTable
{
    public partial class UserTable : BaseTable
    {
        public UserTable()
        {
            InitializeComponent();

            Bll = new UserBll();
            Table = table;
            EventsLoad();
            HideItems = new BarItem[] { btnAddAction, btnDeleteActon };
            InsUptNavigator.navigator.Buttons.Append.Visible = false;
            InsUptNavigator.navigator.Buttons.Remove.Visible = false;
            InsUptNavigator.navigator.Buttons.PrevPage.Visible = true;
            InsUptNavigator.navigator.Buttons.NextPage.Visible = true;
        }

        protected internal override void List()
        {
            table.GridControl.DataSource = ((UserBll)Bll).List(null);
        }

        protected override void DeleteAction() { }

        protected override void Table_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            var entity = table.GetRow<UserList>();

            if (entity == null) return;

            OwnerForm.Id = entity.Id;
            ((UserUnitAuthorizationEditForm)OwnerForm).Loads();
        }
    }
}
