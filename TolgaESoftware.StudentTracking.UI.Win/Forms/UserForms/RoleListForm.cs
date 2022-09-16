using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms
{
    public partial class RoleListForm : BaseListForm
    {
       
        public RoleListForm()
        {
            InitializeComponent();
            Bll = new RoleBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Role;
            FormShow = new ShowEditForms<RoleEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((RoleBll) Bll).List(FilterFunctions.Filter<Role>(ShowActiveCards));
        }
    }
}