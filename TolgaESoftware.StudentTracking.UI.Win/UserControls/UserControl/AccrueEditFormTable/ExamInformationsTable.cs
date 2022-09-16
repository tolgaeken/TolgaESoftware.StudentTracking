using System;
using System.CodeDom;
using DevExpress.XtraEditors.DXErrorProvider;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class ExamInformationsTable : BaseTable
    {
        public ExamInformationsTable()
        {
            InitializeComponent();

            Bll = new ExamInformationsBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((ExamInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<ExamInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;

            var row = new ExamInformationsList
            {
                AccrueId = OwnerForm.Id,
                Date = DateTime.Now.Date,
                Insert = true
            };

            source.Add(row);


            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colExamName;

            ButtonEnabledStatus(true);
        }

        protected internal override bool WrongData()
        {
            if (!TableValueChanged) return false;
            if(table.HasColumnErrors) table.ClearColumnErrors();
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<ExamInformationsList>(i);

                if (String.IsNullOrEmpty(entity.ExamName))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colExamName;
                    table.SetColumnError(colExamName,"Sınav Adı Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if (String.IsNullOrEmpty(entity.ScoreType))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colScoreType;
                    table.SetColumnError(colScoreType,"Puan Türü Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if(!table.HasColumnErrors) continue;

                Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }
    }
}