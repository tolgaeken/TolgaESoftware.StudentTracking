using System;
using System.Linq;
using DevExpress.XtraEditors.DXErrorProvider;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class NoteInformationsTable : BaseTable
    {
        public NoteInformationsTable()
        {
            InitializeComponent();

            Bll = new NoteInformationsBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((NoteInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<NoteInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;

            var row = new NoteInformationsList
            {
                AccrueId = OwnerForm.Id,
                Date = DateTime.Now,
                Insert = true
            };

            source.Add(row);


            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colNote;

            ButtonEnabledStatus(true);
        }

        protected internal override bool WrongData()
        {
            if (!TableValueChanged) return false;
            if(table.HasColumnErrors) table.ClearColumnErrors();
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<NoteInformationsList>(i);

                if (String.IsNullOrWhiteSpace(entity.Note))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colNote;
                    table.SetColumnError(colNote,"Bilgi Notu Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if(!table.HasColumnErrors) continue;

                Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }
    }
}
