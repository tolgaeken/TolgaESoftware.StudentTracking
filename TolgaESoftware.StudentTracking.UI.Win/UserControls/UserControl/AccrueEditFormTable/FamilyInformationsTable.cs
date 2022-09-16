using System.Linq;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.FamilyInfoForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class FamilyInformationsTable : BaseTable
    {
        public FamilyInformationsTable()
        {
            InitializeComponent();

            Bll = new FamilyInformationsBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((FamilyInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<FamilyInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<FamilyInformationsList>().Where(p => !p.Delete)
                .Select(p => p.FamilyInfoId).ToList();

            var entities =
                ShowListForms<FamilyInfoListForm>.ShowDialogListForm(CardType.FamilyInfo, UnlistedData, true, false)
                    .EntityListConvert<FamilyInfo>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new FamilyInformationsList
                {
                    AccrueId = OwnerForm.Id,
                    FamilyInfoId = entity.Id,
                    InformationName = entity.FamilyInfoName,
                    Statement = null,
                    Insert = true
                };

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colInformationName;

            ButtonEnabledStatus(true);
        }
    }
}