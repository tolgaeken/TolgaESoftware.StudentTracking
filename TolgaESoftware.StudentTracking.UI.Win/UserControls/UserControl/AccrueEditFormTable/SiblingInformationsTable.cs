using System.Linq;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.Functions;
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
    public partial class SiblingInformationsTable : BaseTable
    {
        public SiblingInformationsTable()
        {
            InitializeComponent();

            Bll = new SiblingInformationsBll();
            Table = table;
            EventsLoad();
            ShowItems = new BarItem[] { btnCardEdit };
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((SiblingInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<SiblingInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<SiblingInformationsList>().Where(p => !p.Delete)
                .Select(p => p.SiblingAccrueId).ToList();
            UnlistedData.Add(OwnerForm.Id);

            var entities =
                ShowListForms<AccrueListForm>.ShowDialogListForm(CardType.Accrue, UnlistedData, true, false)
                    .EntityListConvert<AccrueList>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new SiblingInformationsList
                {
                    AccrueId = OwnerForm.Id,
                    SiblingAccrueId = entity.Id,
                    Name = entity.Name,
                    Lastname = entity.Lastname,
                    ClassName = entity.ClassName,
                    EnrollmentType = entity.EnrollmentType,
                    EnrollmentStatus = entity.EnrollmentStatus,
                    CancelStatus = entity.Status ? CancelStatus.Continues : CancelStatus.Cancelled,
                    BranchName = entity.BranchName,
                    Insert = true
                };

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colName;

            ButtonEnabledStatus(true);
        }

        protected override void OpenEntity()
        {
            var entity = table.GetRow<SiblingInformationsList>();
            if (entity == null) return;
            ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue, entity.SiblingAccrueId,
                entity.BranchId != MainForm.BranchId || entity.TermId != MainForm.TermId);
            //ShowEditForms<AccrueEditForm>.ShowDialogEditForm(CardType.Accrue,entity.SiblingAccrueId,
            //    entity.BranchId==MainForm.BranchId);
        }
    }
}