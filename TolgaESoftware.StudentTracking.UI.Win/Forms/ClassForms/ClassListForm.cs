using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DocumentForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ClassForms
{
    public partial class ClassListForm : BaseListForm
    {
        public ClassListForm()
        {
            InitializeComponent();

            Bll=new ClassBll();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Class;
            FormShow = new ShowEditForms<ClassEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((ClassBll) Bll).List(p => p.Status == ShowActiveCards
                                                                         && p.BranchId == MainForm.BranchId);
        }
    }
}