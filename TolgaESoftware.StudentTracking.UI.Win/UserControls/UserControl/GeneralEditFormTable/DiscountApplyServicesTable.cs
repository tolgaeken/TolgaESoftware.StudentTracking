using System.Linq;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.GeneralEditFormTable
{
    public partial class DiscountApplyServicesTable : BaseTable
    {
        public DiscountApplyServicesTable()
        {
            InitializeComponent();

            Bll = new DiscountApplyServicesBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((DiscountApplyServicesBll) Bll).List(p => p.DiscountId == OwnerForm.Id).ToBindingList<DiscountApplyServicesList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<DiscountApplyServicesList>().Where(p => !p.Delete)
                .Select(p => p.ServiceId).ToList();

            var entities = 
                ShowListForms<DiscountListForm>.ShowDialogListForm(CardType.Service,UnlistedData,true,false).EntityListConvert<ServiceList>();

            if (entities==null) return;

            foreach (var entity in entities)
            {
                var row = new DiscountApplyServicesList
                {
                    DiscountId = OwnerForm.Id,
                    ServiceId = entity.Id,
                    ServiceName = entity.ServiceName,
                    DiscountPrice = 0,
                    DiscountPercentage = 0,
                    BranchId = MainForm.BranchId,
                    TermId = MainForm.TermId,
                    Insert = true
                };

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colDiscountPrice;

            ButtonEnabledStatus(true);
        }

        protected internal override bool WrongData()
        {
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<DiscountApplyServicesList>(i);
                if (!(entity.DiscountPrice == 0 && entity.DiscountPercentage == 0)) continue;
                table.Focus();
                table.FocusedRowHandle = i;
                Messages.ErrorMessage("İndirim Tutarı veya İndirim Oranı Alanlarından En Az Birinin Değeri Sıfırdan Büyük Olmalıdır");
                return true;
            }
            if (!TableValueChanged) return false;
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<DiscountApplyServicesList>(i);
                if (entity.DiscountPrice == 0 || entity.DiscountPercentage == 0) continue;
                table.Focus();
                table.FocusedRowHandle = i;
                Messages.ErrorMessage("İndirim Tutarı veya İndirim Oranı Alanlarından Sadece Birinin Değeri Sıfırdan Büyük Olmalıdır");
                return true;
            }
            return false;
        }
    }
}