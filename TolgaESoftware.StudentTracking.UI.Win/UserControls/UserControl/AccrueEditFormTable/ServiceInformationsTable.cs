using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolBusForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.CancellationReasonForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class ServiceInformationsTable : BaseTable
    {
        public ServiceInformationsTable()
        {
            InitializeComponent();
            Bll = new ServiceInformationsBll();
            Table = table;
            EventsLoad();

            ShowItems = new BarItem[] { btnCancel, btnCancelUndo };
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((ServiceInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<ServiceInformationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<ServiceInformationsList>().Where(p => !p.Cancelled && !p.Delete)
                .Select(p => p.ServiceId).ToList();

            var entities =
                ShowListForms<ServiceListForm>.ShowDialogListForm(CardType.Service, UnlistedData, true, true)
                    .EntityListConvert<ServiceList>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                SchoolBus SchoolBus = null;

                if (entity.ServiceTypeEnum == ServiceTypeEnum.SchoolBus)
                {
                    SchoolBus = (SchoolBus)ShowListForms<SchoolBusListForm>.ShowDialogListForm(CardType.SchoolBus, -1);
                    if (SchoolBus == null) continue;
                }

                var row = new ServiceInformationsList
                {
                    AccrueId = OwnerForm.Id,
                    ServiceId = entity.Id,
                    ServiceName = entity.ServiceName,
                    ServiceTypeId = entity.ServiceTypeId,
                    ServiceTypeEnum = entity.ServiceTypeEnum,
                    TransactionDate = DateTime.Now.Date,
                    StartDate = entity.StartDate,
                    GrossPrice = entity.Price,
                    ShortTermDeductedPrice = 0,
                    Cancelled = false,
                    Insert = true
                };

                if (SchoolBus != null)
                {
                    row.SchoolBusId = SchoolBus.Id;
                    row.SchoolBusName = SchoolBus.SchoolBusName;
                    row.GrossPrice = SchoolBus.Price;
                }

                CalculatePrice(row);

                source.Add(row);
            }

            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);
            table.FocusedColumn = colServiceName;

            ButtonEnabledStatus(true);
        }

        protected override void DeleteAction()
        {
            bool CanceledActionOfServiceCard(long serviceId)
            {
                var count = table.DataController.ListSource.Cast<ServiceInformationsList>()
                    .Count(p => p.ServiceId == serviceId);
                return count < 2 && ((AccrueEditForm)OwnerForm).discountInformationsTable.Table.DataController
                    .ListSource.Cast<DiscountInformationsList>().Any(p => p.ServiceId == serviceId && p.Cancelled);
            }

            if (table.DataRowCount == 0) return;
            if (Messages.DeletionMessage("Hizmet Bilgisi") != DialogResult.Yes) return;

            var entity = table.GetRow<ServiceInformationsList>();
            if (entity.Cancelled)
            {
                Messages.CancellationActionCannotBeDeleted();
                return;
            }

            if (CanceledActionOfServiceCard(entity.ServiceId))
            {
                Messages.WarningMessage("Bu Hizmet Kartına Ait İptal Edilmiş İndirim Hareketleri Bulunmaktadır.\nHizmet Kartı Silinemez.");
                return;
            }

            ((AccrueEditForm)OwnerForm).discountInformationsTable.DeleteMassAction(entity.ServiceId);
            entity.Delete = true;
            table.RefreshDataSource();
            ButtonEnabledStatus(true);
        }

        protected override void Cancel()
        {
            var entity = table.GetRow<ServiceInformationsList>();
            if (entity == null || entity.Cancelled || entity.Insert) return;
            if (Messages.CancellationMessage("Hizmet Bilgisi") != DialogResult.Yes) return;

            var cancellationReason =
               (CancellationReason)ShowListForms<CancellationReasonListForm>.ShowDialogListForm(CardType.CancellationReason, -1);
            if (cancellationReason != null)
            {
                entity.CancellationReasonId = cancellationReason.Id;
                entity.CancellationReasonName = cancellationReason.CancellationReasonName;
            }

            if (entity.ServiceTypeEnum == ServiceTypeEnum.Education)
            {
                var schoolToGoes =
                    (SchoolList)ShowListForms<SchoolListForm>.ShowDialogListForm(CardType.School, -1);

                if (schoolToGoes != null)
                {
                    entity.SchoolToGoesId = schoolToGoes.Id;
                    entity.SchoolToGoesName = schoolToGoes.SchoolName;
                }
            }

            entity.CancellationDate = DateTime.Now.Date;
            entity.ServiceName = $"{entity.ServiceName} - ( ««« İptal Edildi »»» )";
            entity.Cancelled = true;
            entity.Update = true;
            CalculatePrice(entity);

            ((AccrueEditForm)OwnerForm).discountInformationsTable.MassCancel(entity);
            table.UpdateSummary();
            table.RowCellEnabled();
            table.FocusedColumn = colCancellationStatement;
            ButtonEnabledStatus(true);
        }

        protected override void CancelUndo()
        {
            bool TakenSameService(long serviceId)
            {
                return table.DataController.ListSource.Cast<ServiceInformationsList>()
                    .Any(p => p.ServiceId == serviceId && !p.Cancelled && !p.Delete);
            }

            var entity = table.GetRow<ServiceInformationsList>();
            if (entity == null || !entity.Cancelled) return;

            if (Messages.CancellationUndoMessage(entity.ServiceName) != DialogResult.Yes) return;
            if (TakenSameService(entity.ServiceId))
            {
                Messages.ErrorMessage("İptal İşleminin Geri Alınması Durumunda Aynı Hizmetten Birden Fazla Alım Durumu Oluşuyor");
                return;
            }

            entity.ServiceName = entity.ServiceName.Remove(entity.ServiceName.Length - 27, 27);
            entity.Cancelled = false;
            entity.CancellationDate = null;
            entity.CancellationReasonId = null;
            entity.CancellationReasonName = null;
            entity.SchoolToGoesId = null;
            entity.SchoolToGoesName = null;
            entity.CancellationStatement = null;
            entity.Update = true;

            ((AccrueEditForm)OwnerForm).discountInformationsTable.MassCancelUndo(entity.Id);
            CalculatePrice(entity);
            table.UpdateSummary();
            table.RowCellEnabled();
            ButtonEnabledStatus(true);
        }

        private void CalculatePrice(ServiceInformationsList entity)
        {
            var educationStartDate = MainForm.TermParameters.EducationStartDate;
            var educationEndDate = MainForm.TermParameters.TermEndDate;

            var numberOfTotalDays = (int)(educationEndDate - educationStartDate).TotalDays + 1;
            var dailyPrice = entity.GrossPrice / numberOfTotalDays;

            var numberOfTakenServiceDays = entity.CancellationDate == null
                ? (int)((educationEndDate - entity.StartDate).TotalDays + 1)
                : (int)((entity.CancellationDate - entity.StartDate).Value.TotalDays + 1);

            var priceToPaid = numberOfTakenServiceDays > 0 ? dailyPrice * numberOfTakenServiceDays : 0;

            var shortTermDeductedPrice = entity.GrossPrice - priceToPaid;
            shortTermDeductedPrice = Math.Round(shortTermDeductedPrice, MainForm.TermParameters.UseServiceAccruePenny ? 2 : 0);

            if (entity.StartDate > educationStartDate || entity.Cancelled)
                entity.ShortTermDeductedPrice = shortTermDeductedPrice;
            else entity.ShortTermDeductedPrice = 0;

            entity.NetPrice = entity.GrossPrice - entity.ShortTermDeductedPrice;
            entity.NumberOfEducationTermDateDays = numberOfTotalDays;
            entity.NumberOfTakenServiceDays = numberOfTakenServiceDays;
            entity.DailyPrice = dailyPrice;
        }

        protected internal override bool WrongData()
        {
            bool SumOfDiscountIsBiggerThanSumOfService(long serviceId)
            {
                var sumOfService = table.DataController.ListSource.Cast<ServiceInformationsList>()
                    .Where(p => p.ServiceId == serviceId && !p.Delete)
                    .Sum(p => p.GrossPrice - p.ShortTermDeductedPrice);

                var sumOfDiscount = ((AccrueEditForm)OwnerForm).discountInformationsTable.Table.DataController
                    .ListSource.Cast<DiscountInformationsList>().Where(p => p.ServiceId == serviceId && !p.Delete)
                    .Sum(p => p.GrossDiscount - p.ShortTermDeductedDiscount);

                return sumOfDiscount > sumOfService;
            }

            if (!TableValueChanged) return false;
            if (table.HasColumnErrors) table.ClearColumnErrors();

            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<ServiceInformationsList>(i);

                if (entity.Cancelled && entity.ServiceTypeEnum == ServiceTypeEnum.Education && MainForm.TermParameters.HasRequiredSchoolToGoes && entity.SchoolToGoesId == null)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colSchoolToGoesName;
                    table.SetColumnError(colSchoolToGoesName, "Gittiği Okul Adı Alanına Geçerli Bir Değer Giriniz", ErrorType.Warning);
                }

                if (entity.Cancelled && entity.CancellationReasonId == null)
                {
                    table.FocusedRowHandle = i;
                    table.FocusedColumn = colCancellationReasonName;
                    table.SetColumnError(colCancellationReasonName, "İptal Nedeni Alanına Geçerli Bir Değer Giriniz", ErrorType.Warning);
                }

                if (table.HasColumnErrors)
                {
                    Messages.TableMissingInformationMessage($"{table.ViewCaption} Tablosu");
                    return true;
                }

                if (SumOfDiscountIsBiggerThanSumOfService(entity.ServiceId))
                {
                    table.FocusedRowHandle = i;
                    Messages.ErrorMessage($"{entity.ServiceId} Kartına Uygulanan İndirimlerin Toplamı {entity.ServiceId} Kartının Toplam Tutarından Fazla Olamaz");
                    return true;
                }

            }

            return false;
        }

        protected override void ShowHideColumns()
        {
            if (table.DataRowCount == 0) return;

            var entity = table.GetRow<ServiceInformationsList>();

            if (entity.ServiceTypeEnum == ServiceTypeEnum.SchoolBus)
            {
                colSchoolBusName.Visible = true;
                colSchoolBusName.VisibleIndex = 1;
            }

            else colSchoolBusName.Visible = false;
        }

        protected override void RowCellAllowEdit()
        {
            if (table.DataRowCount == 0) return;

            var entity = table.GetRow<ServiceInformationsList>();

            colCancellationDate.OptionsColumn.AllowEdit = entity.Cancelled;
            colCancellationReasonName.OptionsColumn.AllowEdit = entity.Cancelled;
            colSchoolToGoesName.OptionsColumn.AllowEdit = entity.Cancelled;
            colCancellationStatement.OptionsColumn.AllowEdit = entity.Cancelled;

            if (entity.ServiceTypeEnum != ServiceTypeEnum.Education)
                colSchoolToGoesName.OptionsColumn.AllowEdit = false;
        }

        protected override void Table_MouseUp(object sender, MouseEventArgs e)
        {
            base.Table_MouseUp(sender, e);

            var entity = (ServiceInformationsList)table.GetRow(Table.FocusedRowHandle);

            if (entity == null) return;

            btnDeleteActon.Enabled = !entity.Cancelled;
            btnCancel.Enabled = !entity.Cancelled && !entity.Insert;
            btnCancelUndo.Enabled = entity.Cancelled;
        }

        protected override void Table_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Table_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colCancellationReasonName)
                e.FocusedColumn.Select(table, InsUptNavigator.navigator, repositoryItemCancellationReason, colCancellationReasonId);
            else if (e.FocusedColumn == colSchoolToGoesName)
                e.FocusedColumn.Select(table, InsUptNavigator.navigator, repositoryItemSchoolToGoes, colSchooltoGoesId);
            else if (e.FocusedColumn == colCancellationDate)
            {
                var entity = table.GetRow<ServiceInformationsList>();

                if (entity.CancellationDate == null) return;

                repositoryItemCancellationDate.MinValue = MainForm.TermParameters.CancellationDateCanEnteredBeforeDayDate
                    ? entity.StartDate : DateTime.Now.Date;

                repositoryItemCancellationDate.MaxValue = MainForm.TermParameters.CancellationDateCanEnteredAfterDayDate
                    ? MainForm.TermParameters.TermEndDate.AddDays(-1) : DateTime.Now.Date;
            }
        }

        protected override void Table_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Table_CellValueChanged(sender, e);

            var entity = table.GetRow<ServiceInformationsList>();

            if (e.Column == colCancellationReasonName)
            {
                ((AccrueEditForm)OwnerForm).discountInformationsTable.Table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Where(p => p.Cancelled && p.ServiceActionId == entity.Id).ForEach(p => p.CancellationReasonId = entity.CancellationReasonId);

                ((AccrueEditForm)OwnerForm).discountInformationsTable.Table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Where(p => p.Cancelled && p.ServiceActionId == entity.Id).ForEach(p => p.CancellationReasonName = entity.CancellationReasonName);
            }

            else if (e.Column == colCancellationStatement)
                ((AccrueEditForm)OwnerForm).discountInformationsTable.Table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Where(p => p.Cancelled && p.ServiceActionId == entity.Id).ForEach(p => p.CancellationStatement = entity.CancellationStatement);


            else if (e.Column == colCancellationDate)
            {
                CalculatePrice(entity);
                ((AccrueEditForm)OwnerForm).discountInformationsTable.Table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Where(p => p.Cancelled && p.ServiceActionId == entity.Id).ForEach(p => p.CancellationDate = entity.CancellationDate);

                ((AccrueEditForm)OwnerForm).discountInformationsTable.CalculateMassDiscount();
            }
        }


    }
}