using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class AccrueInformationsTable : BaseTable
    {
        public AccrueInformationsTable()
        {
            InitializeComponent();

            Bll = new AccrueBll();
            Table = table;
            EventsLoad();

            InsUptNavigator.navigator.Buttons.Append.Visible = false;
            InsUptNavigator.navigator.Buttons.Remove.Visible = false;
            InsUptNavigator.navigator.Buttons.PrevPage.Visible = true;
            InsUptNavigator.navigator.Buttons.NextPage.Visible = true;

            HideItems = new BarItem[] { btnAddAction, btnDeleteActon };
            ShowItems = new BarItem[] { btnCardEdit};
        }

        protected internal override void List()
        {
            table.GridControl.DataSource = ((AccrueBll) Bll).StudentAccrueList(p => p.StudentId == OwnerForm.Id);
        }

        protected override void OpenEntity()
        {
            var entity = table.GetRow<StudentAccrueList>();
            if (entity == null) return;
            ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue, entity.AccrueId,
                entity.BranchId != MainForm.BranchId || entity.TermId != MainForm.BranchId);
            //ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue,entity.AccrueId,
            //    entity.BranchId==MainForm.BranchId);
        }
    }
}