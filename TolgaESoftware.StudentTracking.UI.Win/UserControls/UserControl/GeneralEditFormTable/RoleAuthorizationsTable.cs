using System;
using System.Linq;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.GeneralEditFormTable
{
    public partial class RoleAuthorizationsTable : BaseTable
    {
        public RoleAuthorizationsTable()
        {
            InitializeComponent();

            Bll = new RoleAuthorizationsBll();
            Table = table;
            ShowItems = new BarItem[] {btnSelectAll,btnDeselectAll};
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((RoleAuthorizationsBll) Bll).List(p => p.RoleId == OwnerForm.Id).ToBindingList<RoleAuthorizationsList>();
        }

        protected override void AddAction()
        {
            byte CheckBoxValue(CardType cardType)
            {
                if (cardType == CardType.MonthlyEnrollmentReport ||
                    cardType == CardType.OverdueReceivablesReport ||
                    cardType == CardType.IncomeDistributionReport ||
                    cardType == CardType.GeneralReport ||
                    cardType == CardType.TakenServiceReport ||
                    cardType == CardType.DiscountDistributionReport ||
                    cardType == CardType.VocationalGroupReport ||
                    cardType == CardType.NetPriceReport ||
                    cardType == CardType.PaymentDocumentsReport ||
                    cardType == CardType.ClassReports ||
                    cardType == CardType.CollectReport ||
                    cardType == CardType.PriceAveragesReport ||
                    cardType == CardType.PriceAndPaymentReport ||
                    cardType == CardType.BankPaymentPlanReport ||
                    cardType == CardType.DiscountPetitionReport ||
                    cardType == CardType.RegistrationContractReport ||
                    cardType == CardType.CreditCardPaymentOrderReport ||
                    cardType == CardType.UserDefinedReport ||
                    cardType == CardType.NationalEducationRegistrationContractReport ||
                    cardType == CardType.PaymentIndentureReport ||
                    cardType == CardType.StudentCardReport ||
                    cardType == CardType.DocumentSelection ||
                    cardType == CardType.ReportDesign ||
                    cardType == CardType.BillReport ||
                    cardType == CardType.BillStudentSummaryReport ||
                    cardType == CardType.BillTermSummaryReport ||
                    cardType == CardType.CollectReceiptReport ||
                    cardType == CardType.DeliveryReceiptReport ||
                    cardType == CardType.GeneralReceiptReport ||
                    cardType == CardType.RefundReceiptReport ||
                    cardType == CardType.DocumentActions) return 2;

                return 0;
            }

            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<RoleAuthorizationsList>().Where(p => !p.Delete)
                .Select(p => (long) p.CardType).ToList();

            var entities = ShowListForms<RoleAuthorizationCardsListForm>
                .ShowDialogListForm(UnlistedData,true).EntityListConvert<RoleAuthorization>();

            if (entities==null) return;

            foreach (var entity in entities)
            {
                var row = new RoleAuthorizationsList
                {
                    RoleId = OwnerForm.Id,
                    CardType = entity.CardType,
                    CanAdd = CheckBoxValue(entity.CardType),
                    CanChange = CheckBoxValue(entity.CardType),
                    CanDelete = CheckBoxValue(entity.CardType),
                    Insert = true
                };

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;

            ButtonEnabledStatus(true);
        }

        protected override void RowCellAllowEdit()
        {
            if(table.DataRowCount==0) return;

            var entity = table.GetRow<RoleAuthorizationsList>();
            
            if(entity == null) return;

            colCanAdd.OptionsColumn.AllowEdit = entity.CanAdd != 2;
            colCanChange.OptionsColumn.AllowEdit = entity.CanChange != 2;
            colCanDelete.OptionsColumn.AllowEdit = entity.CanDelete != 2;
        }

        protected override void SelectAll()
        {
            var source = table.DataController.ListSource.Cast<RoleAuthorizationsList>().ToList();

            for (int i = 0; i < source.Count; i++)
            {
                if (table.FocusedColumn == colCanRead && source[i].CanRead == 0) source[i].CanRead = 1;
                else if (table.FocusedColumn == colCanAdd && source[i].CanAdd == 0) source[i].CanAdd = 1;
                else if (table.FocusedColumn == colCanChange && source[i].CanChange == 0) source[i].CanChange = 1;
                else if (table.FocusedColumn == colCanDelete && source[i].CanDelete == 0) source[i].CanDelete = 1;

                else if (table.FocusedColumn == colCardType)
                {
                    if (source[i].CanRead == 0) source[i].CanRead = 1;
                    if (source[i].CanAdd == 0) source[i].CanAdd = 1;
                    if (source[i].CanChange == 0) source[i].CanChange = 1;
                    if (source[i].CanDelete == 0) source[i].CanDelete = 1;
                }

                if (!source[i].Insert) source[i].Update = true;

                table.RefreshRow(i);
            }

            ButtonEnabledStatus(true);
        }

        protected override void DeselectAll()
        {
            var source = table.DataController.ListSource.Cast<RoleAuthorizationsList>().ToList();

            for (int i = 0; i < source.Count; i++)
            {
                if (table.FocusedColumn == colCanRead && source[i].CanRead == 1) source[i].CanRead = 0;
                else if (table.FocusedColumn == colCanAdd && source[i].CanAdd == 1) source[i].CanAdd = 0;
                else if (table.FocusedColumn == colCanChange && source[i].CanChange == 1) source[i].CanChange = 0;
                else if (table.FocusedColumn == colCanDelete && source[i].CanDelete == 1) source[i].CanDelete = 0;

                else if (table.FocusedColumn == colCardType)
                {
                    if (source[i].CanRead == 1) source[i].CanRead = 0;
                    if (source[i].CanAdd == 1) source[i].CanAdd = 0;
                    if (source[i].CanChange == 1) source[i].CanChange = 0;
                    if (source[i].CanDelete == 1) source[i].CanDelete = 0;
                }

                if (!source[i].Insert) source[i].Update = true;

                table.RefreshRow(i);
            }

            ButtonEnabledStatus(true);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);
        }
    }
}
