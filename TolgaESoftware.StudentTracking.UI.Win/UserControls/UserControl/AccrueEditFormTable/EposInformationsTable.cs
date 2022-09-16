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
    public partial class EposInformationsTable : BaseTable
    {
        public EposInformationsTable()
        {
            InitializeComponent();

            Bll = new EposInformationsBll();
            Table = table;
            EventsLoad();
            repositoryItemCardType.Items.AddEnum<EposCardType>();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((EposInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<EposInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;

            var row = new EposInformationsList
            {
                AccrueId = OwnerForm.Id,
                Insert = true
            };

            source.Add(row);


            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colName;

            ButtonEnabledStatus(true);
        }

        protected internal override bool WrongData()
        {
            if (!TableValueChanged) return false;
            if(table.HasColumnErrors) table.ClearColumnErrors();
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<EposInformationsList>(i);

                if (String.IsNullOrWhiteSpace(entity.Name))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colName;
                    table.SetColumnError(colName,"Kart Sahibinin Adı Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if (String.IsNullOrWhiteSpace(entity.Lastname))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colLastname;
                    table.SetColumnError(colLastname,"Kart Sahibinin Soyadı Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if (String.IsNullOrEmpty(entity.BankName))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colBankName;
                    table.SetColumnError(colBankName,"Banka Adı Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if (String.IsNullOrWhiteSpace(entity.CardNumber))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colCardNumber;
                    table.SetColumnError(colCardNumber,"Kart Numarası Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if (String.IsNullOrWhiteSpace(entity.ExpirationDate))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colExpirationDate;
                    table.SetColumnError(colExpirationDate,"Son Kullanma Tarihi Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if (String.IsNullOrWhiteSpace(entity.SecurityCode))
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colSecurityCode;
                    table.SetColumnError(colSecurityCode,"Güvenlik Kodu Alanına Geçerli Bir Değer Giriniz",ErrorType.Warning);
                }

                if(!table.HasColumnErrors) continue;

                Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }

        protected override void Table_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Table_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankName) 
                e.FocusedColumn.Select(table,InsUptNavigator.navigator,repositoryItemBank,colBankId);
        }
    }
}