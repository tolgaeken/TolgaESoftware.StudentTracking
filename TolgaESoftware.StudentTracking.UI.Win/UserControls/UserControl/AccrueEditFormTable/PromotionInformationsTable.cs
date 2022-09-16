using System.Linq;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.PromotionForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class PromotionInformationsTable : BaseTable
    {
        public PromotionInformationsTable()
        {
            InitializeComponent();

            Bll = new PromotionInformationsBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((PromotionInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<PromotionInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<PromotionInformationsList>().Where(p => !p.Delete)
                .Select(p => p.PromotionId).ToList();

            var entities =
                ShowListForms<PromotionListForm>.ShowDialogListForm(CardType.Promotion, UnlistedData, true, false)
                    .EntityListConvert<Promotion>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new PromotionInformationsList
                {
                    AccrueId = OwnerForm.Id,
                    PromotionId = entity.Id,
                    Code = entity.Code,
                    PromotionName = entity.PromotionName,
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