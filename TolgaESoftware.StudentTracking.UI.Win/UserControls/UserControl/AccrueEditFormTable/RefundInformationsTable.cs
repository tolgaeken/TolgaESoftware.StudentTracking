using System;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class RefundInformationsTable : BaseTable
    {
        public RefundInformationsTable()
        {
            InitializeComponent();

            Bll = new RefundInformationsBll();
            Table = table;
            EventsLoad();
            repositoryItemAccountType.Items.AddEnum<RefundAccountType>();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((RefundInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<RefundInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;

            var row = new RefundInformationsList
            {
                AccrueId = OwnerForm.Id,
                Date = DateTime.Now.Date,
                AccountType = RefundAccountType.Vault,
                Price = 0,
                Insert = true
            };

            source.Add(row);


            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colAccountName;

            ButtonEnabledStatus(true);
        }

        protected internal override bool WrongData()
        {
            if (!TableValueChanged) return false;
            if (table.HasColumnErrors) table.ClearColumnErrors();
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<RefundInformationsList>(i);

                if (entity.AccountId == null)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colAccountName;
                    table.SetColumnError(colAccountName, "Hesap Seçimi Yapılması Zorunludur", ErrorType.Warning);
                }

                if (entity.Price <= 0)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colPrice;
                    table.SetColumnError(colPrice, "Tutar, 0'dan Büyük Olmalıdır", ErrorType.Warning);
                }

                if (!table.HasColumnErrors) continue;

                Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }

        protected override void Table_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Table_CellValueChanged(sender, e);

            if (e.Column != colAccountId) return;

            var entity = table.GetRow<RefundInformationsList>();
            entity.BankAccountId = entity.AccountType == RefundAccountType.Bank ? entity.AccountId : null;
            entity.VaultId = entity.AccountType == RefundAccountType.Vault ? entity.AccountId : null;

        }

        protected override void Table_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Table_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colAccountName)
                e.FocusedColumn.Select(table, InsUptNavigator.navigator, repositoryItemAccount, colAccountId);
        }

        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var entity = table.GetRow<RefundInformationsList>();
            entity.AccountId = null;
            entity.AccountName = null;
            table.FocusedColumn = colAccountName;
        }
    }
}