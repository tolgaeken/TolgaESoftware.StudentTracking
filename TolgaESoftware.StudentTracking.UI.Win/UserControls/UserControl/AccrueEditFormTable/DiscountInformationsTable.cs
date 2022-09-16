using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.CancellationReasonForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    public partial class DiscountInformationsTable : BaseTable
    {
        public DiscountInformationsTable()
        {
            InitializeComponent();
            Bll = new DiscountInformationsBll();
            Table = table;
            EventsLoad();

            ShowItems = new BarItem[] { btnCancel, btnCancelUndo };
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((DiscountInformationsBll)Bll).List(p => p.AccrueId == OwnerForm.Id).ToBindingList<DiscountInformationsList>();
        }

        protected override void AddAction()
        {
            bool ServiceTaken(long serviceId)
            {
                var sumOfService = ((AccrueEditForm)OwnerForm)
                    .serviceInformationsTable.Table.DataController.ListSource.Cast<ServiceInformationsList>()
                    .Where(p => p.ServiceId == serviceId && !p.Cancelled && !p.Delete)
                    .Sum(p => p.GrossPrice);

                var sumOfDiscount = table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Where(p => p.ServiceId == serviceId && !p.ManuallyEnteredPrice && !p.Cancelled && !p.Delete)
                    .Sum(p => p.GrossDiscount);
                return sumOfService == 0 ? false : sumOfService - sumOfDiscount > 0;
            }

            bool ToSameServiceCardAppliedSameDiscount(DiscountApplyServicesList service)
            {
                return table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Any(p => p.ServiceId == service.ServiceId && p.DiscountId == service.DiscountId
                                                               && !p.ManuallyEnteredPrice && !p.Cancelled && !p.Delete);
            }

            var discountList =
                ShowListForms<DiscountListForm>.ShowDialogListForm(CardType.Discount, true)
                    .EntityListConvert<DiscountList>();

            if (discountList == null) return;

            using (var dasBll = new DiscountApplyServicesBll())
            {
                var source = table.DataController.ListSource;
                var enteredFixedPriceDiscount = false;
                var numberOfAddedAction = 0;

                foreach (var discount in discountList)
                {
                    var serviceList = dasBll.List(p => p.DiscountId == discount.Id
                                                       && p.BranchId == MainForm.BranchId
                                                       && p.TermId == MainForm.TermId).Cast<DiscountApplyServicesList>();

                    foreach (var service in serviceList)
                    {
                        if (!ServiceTaken(service.ServiceId)) continue;
                        if (ToSameServiceCardAppliedSameDiscount(service)) continue;

                        if (!enteredFixedPriceDiscount) enteredFixedPriceDiscount = service.DiscountPrice > 0;

                        var (grossDiscount, shortTermDeductedDiscount) = CalculateDiscount(service.DiscountId, service.ServiceId);

                        var row = new DiscountInformationsList
                        {
                            AccrueId = OwnerForm.Id,
                            DiscountId = discount.Id,
                            DiscountName = discount.DiscountName,
                            ServiceId = service.ServiceId,
                            ServiceName = service.ServiceName,
                            TransactionDate = DateTime.Now.Date,
                            GrossDiscount = grossDiscount,
                            ShortTermDeductedDiscount = shortTermDeductedDiscount,
                            NetDiscount = grossDiscount - shortTermDeductedDiscount,
                            PercentageDiscount = service.DiscountPercentage > 0,
                            ManuallyEnteredPrice = service.DiscountPercentage == 0 & service.DiscountPrice != 0,
                            Insert = true,
                        };

                        source.Add(row);
                        numberOfAddedAction++;

                        if (service.DiscountPercentage == 0 && service.DiscountPrice == 0) table.FocusedColumn = colGrossDiscount;
                    }
                }

                if (numberOfAddedAction == 0) return;
                if (enteredFixedPriceDiscount) CalculateMassDiscount();
            }
            table.Focus();
            table.RefreshDataSource();
            table.FocusedRowHandle = table.DataRowCount - 1;
            InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);

            ButtonEnabledStatus(true);
        }

        protected override void DeleteAction()
        {
            if (table.FocusedRowHandle < 0) return;      //if (table.DataRowCount == 0) return;  

            if (Messages.DeletionMessage("İndirim Bilgisi") != DialogResult.Yes) return;

            var entity = table.GetRow<DiscountInformationsList>();

            if (entity.Cancelled)
            {
                Messages.CancellationActionCannotBeDeleted();
                return;
            }

            entity.Delete = true;
            table.RefreshDataSource();
            CalculateMassDiscount();
            ButtonEnabledStatus(true);
        }

        protected internal void DeleteMassAction(long serviceId)
        {
            var source = table.DataController.ListSource.Cast<DiscountInformationsList>();

            if (source == null) return;

            var hasDeletedaction = false;

            source.ForEach(p =>
            {
                if (p.Cancelled || p.ServiceId != serviceId) return;
                p.Delete = true;
                hasDeletedaction = true;
            });

            if (!hasDeletedaction) return;

            table.RefreshDataSource();

            ButtonEnabledStatus(true);
        }

        protected override void Cancel()
        {
            var discountEntity = table.GetRow<DiscountInformationsList>();
            if (discountEntity == null || discountEntity.Cancelled || discountEntity.Insert) return;
            if (Messages.CancellationMessage("İndirim Bilgisi") != DialogResult.Yes) return;

            var serviceEntity = ((AccrueEditForm)OwnerForm).serviceInformationsTable.Table.DataController.ListSource
                .Cast<ServiceInformationsList>().FirstOrDefault(p => !p.Cancelled && p.ServiceId == discountEntity.ServiceId);

            if (serviceEntity == null) return;

            var dailyDiscount = discountEntity.GrossDiscount / serviceEntity.NumberOfEducationTermDateDays;
            var numberOfTakenServiceDays = (int)(DateTime.Now.Date - serviceEntity.StartDate).TotalDays + 1;
            var grossDiscount = dailyDiscount * numberOfTakenServiceDays;
            var shortTermDeductedDiscount = discountEntity.GrossDiscount - grossDiscount;
            shortTermDeductedDiscount = Math.Round(shortTermDeductedDiscount, MainForm.TermParameters.UseDiscountAccruePenny ? 2 : 0);

            var cancellationReason =
                (CancellationReason)ShowListForms<CancellationReasonListForm>.ShowDialogListForm(CardType.CancellationReason, -1);

            if (cancellationReason != null)
            {
                discountEntity.CancellationReasonId = cancellationReason.Id;
                discountEntity.CancellationReasonName = cancellationReason.CancellationReasonName;
            }

            discountEntity.DiscountName = $"{discountEntity.DiscountName} - ( ««« İptal Edildi »»» )";
            if (!discountEntity.ManuallyEnteredPrice)
                discountEntity.ShortTermDeductedDiscount =
                    shortTermDeductedDiscount > 0 ? shortTermDeductedDiscount : 0;

            discountEntity.NetDiscount = discountEntity.GrossDiscount - discountEntity.ShortTermDeductedDiscount;
            discountEntity.CancellationDate = DateTime.Now.Date;
            discountEntity.Cancelled = true;
            discountEntity.Update = true;

            CalculateMassDiscount();
            table.UpdateSummary();
            table.RowCellEnabled();
            table.FocusedColumn = colCancellationStatement;

            ButtonEnabledStatus(true);
        }

        protected override void CancelUndo()
        {
            bool ServiceTaken(long serviceId)
            {
                return ((AccrueEditForm)OwnerForm).serviceInformationsTable.Table.DataController.ListSource
                    .Cast<ServiceInformationsList>().Any(p => p.ServiceId == serviceId && !p.Cancelled);
            }

            bool TakenSameDiscount(long discountID, long serviceId)
            {
                return table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Any(p => p.DiscountId == discountID && p.ServiceId == serviceId && !p.Cancelled && !p.Delete);
            }

            var entity = table.GetRow<DiscountInformationsList>();
            if (entity == null || !entity.Cancelled) return;
            if (Messages.CancellationUndoMessage(entity.DiscountName) != DialogResult.Yes) return;

            if (entity.ServiceActionId == null && !ServiceTaken(entity.ServiceId))
            {
                Messages.ErrorMessage("İndirimin Uygulandığı Hizmet İptal Edilmiş." +
                                      "\nİptal Edilen Hizmet Kartı Geri Alınmadan veya Yeni Bir Hizmet Alınmadan İptal İşlemi Geri Alınamaz.");
                return;
            }

            if (entity.ServiceActionId != null)
            {
                Messages.ErrorMessage("İptal Edilen İndirim, Hizmet Hareketleri Tablosundan Geri Alınabilir.");
                return;
            }

            if (TakenSameDiscount(entity.DiscountId, entity.ServiceId))
            {
                Messages.ErrorMessage("İptal İşleminin Geri Alınması Durumunda Aynı İndirimden Birden Fazla Alım Durumu Oluşuyor");
                return;
            }

            entity.DiscountName = entity.DiscountName.Remove(entity.DiscountName.Length - 27, 27);
            entity.Cancelled = false;
            entity.CancellationDate = null;
            entity.CancellationReasonId = null;
            entity.CancellationReasonName = null;
            entity.CancellationStatement = null;
            entity.ServiceActionId = null;
            entity.Update = true;

            CalculateMassDiscount();
            table.RefreshDataSource();
            table.UpdateSummary();
            table.RowCellEnabled();
            ButtonEnabledStatus(true);
        }

        protected internal void MassCancel(ServiceInformationsList entity)
        {
            var source = table.DataController.ListSource.Cast<DiscountInformationsList>();

            if (source == null) return;

            source.ForEach(p =>
            {
                if (p.ServiceId != entity.ServiceId || p.Cancelled) return;

                var dailyDiscount = p.GrossDiscount / entity.NumberOfEducationTermDateDays;
                var grossDiscount = dailyDiscount * entity.NumberOfTakenServiceDays;
                var shortTermDeductedDiscount = p.GrossDiscount - grossDiscount;
                shortTermDeductedDiscount = Math.Round(shortTermDeductedDiscount, MainForm.TermParameters.UseDiscountAccruePenny ? 2 : 0);

                p.DiscountName = $"{p.DiscountName} - ( ««« İptal Edildi »»» )";
                if (!p.ManuallyEnteredPrice)
                    p.ShortTermDeductedDiscount = shortTermDeductedDiscount > 0 ? shortTermDeductedDiscount : 0;

                p.NetDiscount = p.GrossDiscount - p.ShortTermDeductedDiscount;
                p.CancellationDate = DateTime.Now.Date;
                p.Cancelled = true;
                p.ServiceActionId = entity.Id;
                p.CancellationReasonId = entity.CancellationReasonId;
                p.CancellationReasonName = entity.CancellationReasonName;

                if (!p.Insert) p.Update = true;
            });

            CalculateMassDiscount();
            table.UpdateSummary();
        }

        protected internal void MassCancelUndo(int serviceActionId)
        {
            var source = table.DataController.ListSource.Cast<DiscountInformationsList>()
                .Where(p => p.ServiceActionId == serviceActionId);

            source.ForEach(p =>
            {
                p.DiscountName = p.DiscountName.Remove(p.DiscountName.Length - 27, 27);
                p.Cancelled = false;
                p.CancellationDate = null;
                p.CancellationReasonId = null;
                p.CancellationReasonName = null;
                p.CancellationStatement = null;
                p.ServiceActionId = null;
                p.Update = true;
            });

            CalculateMassDiscount();
            table.RefreshDataSource();
            table.UpdateSummary();
        }

        private (decimal grossDiscount, decimal shortTermDeductedDiscount) CalculateDiscount(long discountId, long serviceId)
        {
            decimal GetSumOfService(bool cancelled)
            {
                var sumOfServices = ((AccrueEditForm)OwnerForm).serviceInformationsTable.Table.DataController.ListSource.Cast<ServiceInformationsList>()
                    .Where(p => p.ServiceId == serviceId && p.Cancelled == cancelled && !p.Delete).Sum(p => p.GrossPrice);

                var sumOfDiscount = table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .Where(p => p.ServiceId == serviceId && !p.ManuallyEnteredPrice && p.Cancelled == cancelled && !p.Delete)
                    .Sum(p => p.GrossDiscount);

                return sumOfServices == 0 ? 0 : sumOfServices - sumOfDiscount;
            }

            using (var Bll = new DiscountApplyServicesBll())
            {
                var serviceSource = Bll.List(p => p.DiscountId == discountId && p.ServiceId == serviceId)
                    .Cast<DiscountApplyServicesList>().FirstOrDefault();

                if (serviceSource == null) return (0, 0);
                var educationEndDate = MainForm.TermParameters.TermEndDate;

                var serviceEntity =
                    ((AccrueEditForm)OwnerForm).serviceInformationsTable.Table.DataController.ListSource.Cast<ServiceInformationsList>()
                    .First(p => p.ServiceId == serviceId && !p.Delete);

                var discountEntity = table.DataController.ListSource.Cast<DiscountInformationsList>()
                    .FirstOrDefault(p => p.DiscountId == discountId && p.ServiceId == serviceId && !p.Delete);

                var totalService = serviceEntity.Cancelled ? GetSumOfService(true) : GetSumOfService(false);

                var numberOfTotalDays = serviceEntity.NumberOfEducationTermDateDays;

                var numberOfServiceDays = discountEntity?.CancellationDate == null
                    ? (int)(educationEndDate - serviceEntity.StartDate).TotalDays + 1
                    : (int)(discountEntity.CancellationDate - serviceEntity.StartDate).Value.TotalDays + 1;

                var grossDiscount = serviceSource.DiscountPrice > 0 ? serviceSource.DiscountPrice : totalService * serviceSource.DiscountPercentage / 100;

                var dailyDiscount = grossDiscount / numberOfTotalDays;

                var shortTermDeductedDiscount = (numberOfTotalDays - numberOfServiceDays) * dailyDiscount;

                grossDiscount = Math.Round(grossDiscount, MainForm.TermParameters.UseDiscountAccruePenny ? 2 : 0);

                shortTermDeductedDiscount =
                    Math.Round(shortTermDeductedDiscount, MainForm.TermParameters.UseDiscountAccruePenny ? 2 : 0);

                return (grossDiscount, shortTermDeductedDiscount);
            }
        }

        protected internal void CalculateMassDiscount()
        {
            var source = table.DataController.ListSource.Cast<DiscountInformationsList>().ToList();

            source.ForEach(p =>
            {
                if (!p.PercentageDiscount || p.ManuallyEnteredPrice || p.Delete) return;
                p.GrossDiscount = 0;
                p.ShortTermDeductedDiscount = 0;

            });

            source.ForEach(p =>
            {
                if (p.ManuallyEnteredPrice || p.Delete) return;

                var (grossDiscount, shortTermDeductedDiscount) = CalculateDiscount(p.DiscountId, p.ServiceId);

                p.GrossDiscount = grossDiscount;
                p.ShortTermDeductedDiscount = shortTermDeductedDiscount;
                p.NetDiscount = grossDiscount - shortTermDeductedDiscount;

                if (!p.Insert) p.Update = true;
            });

            Table.UpdateSummary();
        }

        protected override void RowCellAllowEdit()
        {
            if (table.DataRowCount == 0) return;

            var entity = table.GetRow<DiscountInformationsList>();

            colCancellationDate.OptionsColumn.AllowEdit = entity.Cancelled & entity.ServiceActionId == null;
            colCancellationReasonName.OptionsColumn.AllowEdit = entity.Cancelled & entity.ServiceActionId == null;
            colCancellationStatement.OptionsColumn.AllowEdit = entity.Cancelled & entity.ServiceActionId == null;

            if (entity.Insert)
            {
                colGrossDiscount.OptionsColumn.AllowEdit = entity.ManuallyEnteredPrice && !entity.Cancelled;
                colShortTermDeductedDiscount.OptionsColumn.AllowEdit = entity.ManuallyEnteredPrice && entity.Cancelled;
            }
            else
            {
                colGrossDiscount.OptionsColumn.AllowEdit = false;
                colShortTermDeductedDiscount.OptionsColumn.AllowEdit = entity.ManuallyEnteredPrice;
            }
        }

        protected override void Table_MouseUp(object sender, MouseEventArgs e)
        {
            base.Table_MouseUp(sender, e);

            var entity = (DiscountInformationsList)table.GetRow(Table.FocusedRowHandle);

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

            else if (e.FocusedColumn == colCancellationDate)
            {
                var entity = table.GetRow<DiscountInformationsList>();

                if (entity.CancellationDate == null) return;

                repositoryItemCancellationDate.MinValue = MainForm.TermParameters.CancellationDateCanEnteredBeforeDayDate
                    ? entity.TransactionDate : DateTime.Now.Date;

                repositoryItemCancellationDate.MaxValue = MainForm.TermParameters.CancellationDateCanEnteredAfterDayDate
                    ? MainForm.TermParameters.TermEndDate.AddDays(-1) : DateTime.Now.Date;
            }
        }

        protected override void Table_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Table_CellValueChanged(sender, e);

            if (e.Column == colCancellationDate) CalculateMassDiscount();

            else if (e.Column == colGrossDiscount || e.Column == colShortTermDeductedDiscount)
            {
                var entity = table.GetRow<DiscountInformationsList>();

                entity.NetDiscount = entity.GrossDiscount - entity.ShortTermDeductedDiscount;
            }
        }
    }
}