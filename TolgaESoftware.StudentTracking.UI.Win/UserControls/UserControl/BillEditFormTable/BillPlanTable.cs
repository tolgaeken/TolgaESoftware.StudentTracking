using System;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.BillEditFormTable
{
    public partial class BillPlanTable : BaseTable
    {
        public BillPlanTable()
        {
            InitializeComponent();
            Bll = new BillBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((BillBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<BillPlanList>();
        }

        protected override void AddAction()
        {
            var takenServicesSource = 
                ((BillPlanEditForm)OwnerForm).table.DataController.ListSource.Cast<BillTakenServicesList>().ToList();

            var billPlanSource = table.DataController.ListSource;

            if (!ShowEditForms<MassBillPlanEditForm>.ShowDialogEditForm(CardType.Bill,takenServicesSource,billPlanSource)) return;

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colStatement;

            ButtonEnabledStatus(true);
        }

        protected override void DeleteAction()
        {
            var entity = table.GetRow<BillPlanList>();

            if(entity==null) return;

            if (!colPlanDate.OptionsColumn.AllowEdit)
            {
                Messages.ErrorMessage("Hareket Görmüş Fatura Planları Silinemez.");
                return;
            }

            base.DeleteAction();
        }

        protected override void RowCellAllowEdit()
        {
            if(table.DataRowCount==0) return;

            var entity = table.GetRow<BillPlanList>();

            if(entity==null) return;

            colStatement.OptionsColumn.AllowEdit = entity.AccrueDate == null;
            colPlanDate.OptionsColumn.AllowEdit = entity.AccrueDate == null;
            colPlanPrice.OptionsColumn.AllowEdit = entity.AccrueDate == null;
            colPlanDiscountPrice.OptionsColumn.AllowEdit = entity.AccrueDate == null;
        }

        protected override void Table_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var entity = table.GetRow<BillPlanList>();

            if(entity==null) return;

            if (e.Column == colPlanPrice || e.Column == colPlanDiscountPrice)
                entity.PlanNetPrice = entity.PlanPrice - entity.PlanDiscountPrice;

            entity.Update = true;
            ButtonEnabledStatus(true);
        }

        protected override void Table_RowCountChanged(object sender, EventArgs e)
        {
            OwnerForm.btnDelete.Enabled = 
                table.DataController.ListSource.Cast<BillPlanList>().Where(p => !p.Delete).ToList().Any();
        }
    }
}
