using System.Linq;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DocumentForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class DocumentInformationsTable : BaseTable
    {
        public DocumentInformationsTable()
        {
            InitializeComponent();

            Bll = new DocumentInformationsBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((DocumentInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<DocumentInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<DocumentInformationsList>().Where(p => !p.Delete)
                .Select(p => p.DocumentId).ToList();

            var entities =
                ShowListForms<DocumentListForm>.ShowDialogListForm(CardType.Document, UnlistedData, true, false)
                    .EntityListConvert<Document>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new DocumentInformationsList
                {
                    AccrueId = OwnerForm.Id,
                    DocumentId = entity.Id,
                    Code = entity.Code,
                    DocumentName = entity.DocumentName,
                    Insert = true
                };

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colCode;

            ButtonEnabledStatus(true);
        }
    }
}