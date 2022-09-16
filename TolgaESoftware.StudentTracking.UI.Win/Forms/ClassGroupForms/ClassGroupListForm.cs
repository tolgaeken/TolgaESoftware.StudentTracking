using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ClassGroupForms
{
    public partial class ClassGroupListForm : BaseListForm
    {
        public ClassGroupListForm()
        {
            InitializeComponent();
            Bll = new ClassGroupBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.ClassGroup;
            FormShow = new ShowEditForms<ClassGroupEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((ClassGroupBll) Bll).List(FilterFunctions.Filter<ClassGroup>(ShowActiveCards));
        }
    }
}