using System;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ContactForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.KinshipForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class ContactInformationsTable : BaseTable
    {
        public ContactInformationsTable()
        {
            InitializeComponent();

            Bll = new ContactInformationsBll();
            Table = table;
            EventsLoad();

            ShowItems = new BarItem[] { btnCardEdit };
            repositoryItemAddress.Items.AddEnum<AddressType>();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((ContactInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<ContactInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<ContactInformationsList>().Where(p => !p.Delete)
                .Select(p => p.ContactId).ToList();

            var entities =
                ShowListForms<ContactListForm>.ShowDialogListForm(CardType.Contact, UnlistedData, true, false)
                    .EntityListConvert<ContactList>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new ContactInformationsList
                {
                    AccrueId = OwnerForm.Id,
                    ContactId = entity.Id,
                    TrIdentityNumber = entity.TrIdentityNumber,
                    Name = entity.Name,
                    Lastname = entity.Lastname,
                    HomePhone = entity.HomePhone,
                    WorkplacePhone1 = entity.WorkplacePhone1,
                    InternalPhone1 = entity.InternalPhone1,
                    WorkplacePhone2 = entity.WorkplacePhone2,
                    InternalPhone2 = entity.InternalPhone2,
                    MobilePhone1 = entity.MobilePhone1,
                    MobilePhone2 = entity.MobilePhone2,
                    HomeAddress = entity.HomeAddress,
                    HomeAddressProvinceName = entity.HomeAddressProvinceName,
                    HomeAddressDistrictName = entity.HomeAddressDistrictName,
                    WorkplaceAddress = entity.WorkplaceAddress,
                    WorkplaceAddressProvinceName = entity.WorkplaceAddressProvinceName,
                    WorkplaceAddressDistrictName = entity.WorkplaceAddressDistrictName,
                    VocationName = entity.VocationName,
                    WorkplaceName = entity.WorkplaceName,
                    JobName = entity.JobName,
                    Insert = true
                };

                if (source.Count == 0)
                {
                    row.Guardianship = true;
                    row.BillingAddress = AddressType.HomeAddress;
                }

                var kinship = (Kinship)ShowListForms<KinshipListForm>.ShowDialogListForm(CardType.Kinship, -1);
                if (kinship == null) return;
                row.KinshipId = kinship.Id;
                row.KinshipName = kinship.KinshipName;

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            table.FocusedColumn = colGuardianship;

            ButtonEnabledStatus(true);
        }

        protected internal override bool WrongData()
        {
            if (!TableValueChanged) return false;
            if (table.HasColumnErrors) table.ClearColumnErrors();
            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<ContactInformationsList>(i);

                if (entity.KinshipName == null)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colKinshipName;
                    table.SetColumnError(colKinshipName, "Yakınlık Adı Alanına Geçerli Bir Değer Giriniz", ErrorType.Warning);
                }

                if (!table.HasColumnErrors) continue;

                Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }

        protected override void OpenEntity()
        {
            var entity = table.GetRow<ContactInformationsList>();
            if (entity == null) return;
            ShowEditForms<ContactEditForm>.ShowDialogEditForm(CardType.Accrue, entity.ContactId, null);
        }

        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var source = table.DataController.ListSource.Cast<ContactInformationsList>().ToList();
            if (source.Count == 0) return;

            var rowHandle = table.FocusedRowHandle;

            for (int i = 0; i < table.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (source[i].BillingAddress == null) continue;
                source[i].BillingAddress = null;

                if (!source[i].Insert) source[i].Update = true;

                InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);
            }
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = table.DataController.ListSource.Cast<ContactInformationsList>().ToList();
            if (source.Count == 0) return;

            var rowHandle = table.FocusedRowHandle;

            for (int i = 0; i < table.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (!source[i].Guardianship) continue;
                source[i].Guardianship = false;

                if (!source[i].Insert) source[i].Update = true;

                InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);
            }
        }

        protected override void Table_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Table_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colKinshipName) 
                e.FocusedColumn.Select(table,InsUptNavigator.navigator,repositoryItemKinship,colKinshipId);
        }
    }
}