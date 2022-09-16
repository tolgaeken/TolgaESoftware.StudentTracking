using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.StudentForms
{
    public partial class StudentListForm : BaseListForm
    {
        public StudentListForm()
        {
            InitializeComponent();
            Bll = new StudentBll();

            ShowItems = new BarItem[] {btnAccrue};
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Student;
            FormShow = new ShowEditForms<StudentEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((StudentBll)Bll).List(FilterFunctions.Filter<Student>(ShowActiveCards));
        }

        protected override void Accrue()
        {
            var entity = table.GetRow<StudentList>().EntityConvert<Student>();

            using (var bll= new AccrueBll())
            {
                var accrue = bll.SingleSummary(p => p.StudentId == entity.Id 
                                                    && p.BranchId == MainForm.BranchId 
                                                    && p.TermId == MainForm.TermId);

                if (accrue != null) ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue, accrue.Id, null);

                else ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue, -1, entity);

            }
        }
    }
}