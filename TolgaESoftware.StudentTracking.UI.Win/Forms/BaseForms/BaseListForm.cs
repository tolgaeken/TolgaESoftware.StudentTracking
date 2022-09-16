using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;
using TolgaESoftware.StudentTracking.UI.Win.Forms.FilterForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.Show.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : RibbonForm
    {
        #region Variables
        private long _filterId;
        private bool _formTemplateToSave;
        private bool _tableTemplateToSave;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected IBaseFormShow FormShow;
        protected CardType BaseCardType;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected bool ShowActiveCards = true;
        protected internal GridView Table;
        protected internal BaseEntity SelectedEntity;
        protected internal SelectRowFunctions RowSelect;
        protected internal IList<long> UnlistedData;
        protected internal IList<BaseEntity> SelectedEntities;
        protected internal long? SelectedIncomingId;
        protected internal bool ShowActivePassiveButton = false;
        protected internal bool MultiSelect;
        protected internal bool HasAddableEntity = false;
        #endregion

        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            //ButtonEvents
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table Events
            Table.DoubleClick += Table_DoubleClick;
            Table.KeyDown += Table_KeyDown;
            Table.MouseUp += Table_MouseUp;
            Table.ColumnWidthChanged += Table_ColumnWidthChanged;
            Table.ColumnPositionChanged += Table_ColumnPositionChanged;
            Table.EndSorting += Table_EndSorting;
            Table.FilterEditorCreated += Table_FilterEditorCreated;
            Table.ColumnFilterChanged += Table_ColumnFilterChanged;
            Table.CustomDrawFooterCell += Table_CustomDrawFooterCell;
            Table.FocusedRowObjectChanged += Table_FocusedRowObjectChanged;
            Table.RowDeleted += Table_RowDeleted;

            //Form Events
            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            Closing += BaseListForm_Closing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }

        private void SaveTemplate()
        {
            if (_formTemplateToSave) Name.SaveFormTemplate(Left, Top, Width, Height, WindowState);

            if (_tableTemplateToSave) Table.SaveTableTemplate(IsMdiChild ? Name + "_table" : Name + "_mdiTable");
        }
        private void LoadTemplate()
        {
            if (IsMdiChild) Table.LoadTableTemplate(Name + "_table");
            else
            {
                Name.LoadFormTemplate(this);
                Table.LoadTableTemplate(Name + "_mdiTable");
            }
        }
        private void SelectFilter()
        {
            var entity =
                (Filter)ShowListForms<FilterListForm>.ShowDialogListForm(CardType.Filter, _filterId, BaseCardType,
                    Table.GridControl);
            if (entity == null) return;

            _filterId = entity.Id;
            Table.ActiveFilterString = entity.FilterText;
        }
        private void SetFormCaption()
        {
            if (btnActivePassiveCards == null)
            {
                List();
                return;
            }

            if (ShowActiveCards)
            {
                btnActivePassiveCards.Caption = "Pasif Kartlar";
                Table.ViewCaption = Text;
            }
            else
            {
                btnActivePassiveCards.Caption = "Aktif Kartlar";
                Table.ViewCaption = Text + " - Pasif Kartlar";
            }

            List();
        }
        private void SelectProcessType()
        {
            if (!IsMdiChild)
                if (btnSelect.Visibility == BarItemVisibility.Never) btnEdit.PerformClick();
                else SelectEntity();

            else
                btnEdit.PerformClick();
        }
        private void ShowHideButtons()
        {
            btnSelect.Visibility = ShowActivePassiveButton ? BarItemVisibility.Never :
                IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            barEnterStatement.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            btnActivePassiveCards.Visibility =
                ShowActivePassiveButton ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            ShowItems?.ForEach(p => p.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(p => p.Visibility = BarItemVisibility.Never);
        }
        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            ShowActiveCards = true;
            SetFormCaption();
            Table.RowFocus("Id", id);
        }
        protected virtual void ShowHideColumns() { }
        protected virtual void SelectEntity()
        {
            if (MultiSelect)
            {
                SelectedEntities = new List<BaseEntity>();
                if (RowSelect.SelectedRowCount == 0)
                {
                    Messages.NoCardSelectionMessage();
                    return;
                }

                SelectedEntities = RowSelect.GetSelectedRows();
            }
            else
                SelectedEntity = Table.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }
        protected virtual void FillVariables() { }
        protected virtual void ShowEditForm(long id)
        {
            if (id < -1) return;
            var result = FormShow.ShowDialogEditForm(BaseCardType, id);
            ShowEditFormDefault(result);
        }
        protected virtual void EntityDelete()
        {
            var entity = Table.GetRow<BaseEntity>();
            if (entity == null) return;
            if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            Table.DeleteSelectedRows();
            Table.RowFocus(Table.FocusedRowHandle);
        }
        protected virtual void OpenLinkedCard() { }
        protected virtual void Print()
        {
            TablePrintingFunctions.Print(Table, Table.ViewCaption, MainForm.BranchName);
        }
        protected virtual void Preview() { }
        protected virtual void List() { }
        protected virtual void Accrue() { }
        protected virtual void DocumentActions() { }
        protected virtual void Edit() { }
        protected internal void Loads()
        {
            FillVariables();
            EventsLoad();

            Table.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Table.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            List();
            Cursor.Current = DefaultCursor;

            Table.Appearance.ViewCaption.ForeColor = Color.FromArgb(MainForm.UserParameters.TableViewCaptionForeColor);
            Table.Appearance.HeaderPanel.ForeColor = Color.FromArgb(MainForm.UserParameters.TableColumnHeaderForeColor);

            if (Table is MyBandedGridView bandedGrid)
                bandedGrid.Appearance.BandPanel.ForeColor = Color.FromArgb(MainForm.UserParameters.TableBandPanelForeColor);
        }

        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnSend)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }

            else if (e.Item == btnSendAsStandartExcel) Table.ExportTable(FileType.ExcelStandard, e.Item.Caption, Text);

            else if (e.Item == btnSendAsFormattedExcel) Table.ExportTable(FileType.FormattedExcel, e.Item.Caption, Text);

            else if (e.Item == btnSendAsUnformattedExcel) Table.ExportTable(FileType.UnformattedExcel, e.Item.Caption, Text);

            else if (e.Item == btnSendAsWord) Table.ExportTable(FileType.Word, e.Item.Caption);

            else if (e.Item == btnSendAsPdf) Table.ExportTable(FileType.Pdf, e.Item.Caption);

            else if (e.Item == btnSendAsTxt) Table.ExportTable(FileType.Txt, e.Item.Caption);

            else if (e.Item == btnNew) ShowEditForm(-1); //Authentication Control

            else if (e.Item == btnEdit) ShowEditForm(Table.GetRowId());

            else if (e.Item == btnDelete) EntityDelete(); //Authentication Control

            else if (e.Item == btnSelect) SelectEntity();

            else if (e.Item == btnRefresh) List();

            else if (e.Item == btnFilter) SelectFilter();

            else if (e.Item == btnColumns)
            {
                if (Table.CustomizationForm == null)
                {
                    Table.ShowCustomization();
                }
                else
                {
                    Table.HideCustomization();
                }
            }

            else if (e.Item == btnDocumentActions) DocumentActions();

            else if (e.Item == btnAccrue) Accrue();

            else if (e.Item == btnLinkedCards) OpenLinkedCard();

            else if (e.Item == btnParameters) OpenLinkedCard();

            else if (e.Item == btnPrint) Print();

            else if (e.Item == btnPrintTable) TablePrintingFunctions.Print(Table, Table.ViewCaption, MainForm.BranchName);

            else if (e.Item == btnPreview) Preview();

            else if (e.Item == btnChangeDesign) Edit();

            else if (e.Item == btnExit) Close();

            else if (e.Item == btnActivePassiveCards)
            {
                ShowActiveCards = !ShowActiveCards;
                SetFormCaption();
            }

            Cursor.Current = DefaultCursor;
        }
        private void Table_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SelectProcessType();
            Cursor.Current = DefaultCursor;
        }
        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectProcessType();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
        private void Table_MouseUp(object sender, MouseEventArgs e)
        {
            e.ShowRightClickMenu(rightClickMenu);
        }
        private void Table_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            _tableTemplateToSave = true;
        }
        private void Table_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tableTemplateToSave = true;
        }
        private void Table_EndSorting(object sender, EventArgs e)
        {
            _tableTemplateToSave = true;
        }
        private void Table_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditForms<FilterEditForm>.ShowDialogEditForm(CardType.Filter, _filterId, BaseCardType,
                Table.GridControl);
        }
        private void Table_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Table.ActiveFilterString)) _filterId = 0;
        }
        private void Table_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Table.OptionsView.ShowFooter) return;
            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit != null)
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
        }
        private void Table_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ShowHideColumns();
        }
        private void Table_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            ShowHideColumns();
        }
        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Table.Focus();
            ShowHideButtons();
            ShowHideColumns();

            if (IsMdiChild || SelectedIncomingId == null) return;
            Table.RowFocus("Id", SelectedIncomingId);
        }
        private void BaseListForm_Load(object sender, EventArgs e)
        {
            LoadTemplate();
        }
        private void BaseListForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveTemplate();
        }
        private void BaseListForm_LocationChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild) _formTemplateToSave = true;
        }
        private void BaseListForm_SizeChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild) _formTemplateToSave = true;
        }
    }
}