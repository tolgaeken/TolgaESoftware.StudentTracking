using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities.Base;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTable : XtraUserControl
    {
        private bool _isLoaded;
        private bool _tableTemplateToSave;
        protected internal GridView Table;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;
        protected IList<long> UnlistedData;
        protected internal bool TableValueChanged;
        protected internal BaseEditForm OwnerForm;


        public BaseTable()
        {
            InitializeComponent();
        }

        private void ShowHideButton()
        {
            ShowItems?.ForEach(p => p.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(p => p.Visibility = BarItemVisibility.Never);
        }

        private void LoadTemplate()
        {
            Table.LoadTableTemplate(Table.ViewCaption);
        }

        private void SaveTemplate()
        {
            if (_tableTemplateToSave) Table.SaveTableTemplate(Table.ViewCaption);
        }

        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;

            foreach (GridColumn column in Table.Columns)
            {
                if (column.ColumnEdit == null) continue;

                var type = column.ColumnEdit.GetType();

                if (type == typeof(RepositoryItemImageComboBox))
                    ((RepositoryItemImageComboBox)column.ColumnEdit).SelectedValueChanged += ImageComboBox_SelectedValueChanged;

                if (type == typeof(RepositoryItemCheckEdit))
                    ((RepositoryItemCheckEdit)column.ColumnEdit).CheckedChanged += CheckEdit_CheckedChanged;


            }

            //Navigator Events
            InsUptNavigator.navigator.ButtonClick += Navigator_ButtonClick;

            //Table Events
            Table.CellValueChanged += Table_CellValueChanged;
            Table.MouseUp += Table_MouseUp;
            Table.GotFocus += Table_GotFocus;
            Table.LostFocus += Table_LostFocus;
            Table.KeyDown += Table_KeyDown;
            Table.FocusedColumnChanged += Table_FocusedColumnChanged;
            Table.ColumnPositionChanged += Table_TemplateChanged;
            Table.ColumnWidthChanged += Table_TemplateChanged;
            Table.EndSorting += Table_TemplateChanged;
            Table.DoubleClick += Table_DoubleClick;
            Table.FocusedRowObjectChanged += Table_FocusedRowObjectChanged;
            Table.RowCountChanged += Table_RowCountChanged;
        }

        protected void ButtonEnabledStatus(bool status)
        {
            TableValueChanged = status;
            OwnerForm.ButtonEnabledStatus();
        }

        protected virtual void OpenEntity() { }

        protected virtual void ShowHideColumns() { }

        protected virtual void RowCellAllowEdit() { }

        protected virtual void Cancel() { }

        protected virtual void CancelUndo() { }

        protected virtual void SelectAll() { }

        protected virtual void DeselectAll() { }

        //protected virtual void DeleteMassAction() { }

        protected virtual void AddAction() { }

        protected virtual void DeleteAction()
        {
            if (Table.DataRowCount == 0) return;

            if (Messages.DeletionMessage("İşlem Satırı") != DialogResult.Yes) return;

            Table.GetRow<IBaseActionEntity>().Delete = true;
            Table.RefreshDataSource();
            ButtonEnabledStatus(true);

        }

        protected virtual void DocumentActions() { }

        protected internal bool Save()
        {
            InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);

            var source = Table.DataController.ListSource;

            // Insert and Update are same methods
            var insert = source.Cast<BaseActionEntity>().Where(p => ((IBaseActionEntity)p).Insert && !((IBaseActionEntity)p).Delete).ToList();
            var update = source.Cast<IBaseActionEntity>().Where(p => p.Update && !p.Delete).Cast<BaseActionEntity>().ToList();
            var delete = source.Cast<IBaseActionEntity>().Where(p => p.Delete && !p.Insert).Cast<BaseActionEntity>().ToList();

            if (insert.Any())
                if (!((IBaseActionGeneralBll)Bll).Insert(insert))
                {
                    Messages.ErrorMessage($"{Table.ViewCaption} Tablosundaki Hareketler Eklenemedi");
                    return false;
                }
            if (update.Any())
                if (!((IBaseActionGeneralBll)Bll).Update(update))
                {
                    Messages.ErrorMessage($"{Table.ViewCaption} Tablosundaki Hareketler Güncellenemedi");
                    return false;
                }
            if (delete.Any())
                if (!((IBaseActionGeneralBll)Bll).Delete(delete))
                {
                    Messages.ErrorMessage($"{Table.ViewCaption} Tablosundaki Hareketler Silinemedi");
                    return false;
                }

            ButtonEnabledStatus(false);
            return true;
        }

        protected internal void Loads()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButtonEnabledStatus();
            InsUptNavigator.navigator.NavigatableControl = Table.GridControl;
            LoadTemplate();
            List();
            ShowHideButton();
            Table_LostFocus(Table, EventArgs.Empty);
        }

        protected internal virtual void List() { }

        protected internal virtual bool WrongData() { return false; }


        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnAddAction) AddAction();
            else if (e.Item == btnDeleteActon) DeleteAction();
            else if (e.Item == btnCardEdit) OpenEntity();
            else if (e.Item == btnCancel) Cancel();
            else if (e.Item == btnCancelUndo) CancelUndo();
            else if (e.Item == btnDocumentActions) DocumentActions();
            else if (e.Item == btnSelectAll) SelectAll();
            else if (e.Item == btnDeselectAll) DeselectAll();

            Cursor.Current = DefaultCursor;

        }

        protected virtual void ImageComboBox_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void CheckEdit_CheckedChanged(object sender, EventArgs e) { }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == InsUptNavigator.navigator.Buttons.Append) AddAction();
            else if (e.Button == InsUptNavigator.navigator.Buttons.Remove) DeleteAction();

            if (e.Button == InsUptNavigator.navigator.Buttons.Append ||
                e.Button == InsUptNavigator.navigator.Buttons.Remove)
                e.Handled = true;
        }

        protected virtual void Table_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Table.GetRow<IBaseActionEntity>();

            if (!entity.Insert) entity.Update = true;

            ButtonEnabledStatus(true);
        }

        protected virtual void Table_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;
            if (e.Button != MouseButtons.Right) return;

            btnDeleteActon.Enabled = Table.RowCount > 0;
            btnCardEdit.Enabled = Table.RowCount > 0;
            btnCancel.Enabled = Table.RowCount > 0;
            btnCancelUndo.Enabled = Table.RowCount > 0;

            e.ShowRightClickMenu(popupMenu);
        }

        private void Table_GotFocus(object sender, EventArgs e)
        {
            OwnerForm.StatusBarShortcut.Visibility = BarItemVisibility.Always;
            OwnerForm.StatusBarShortcutStatement.Visibility = BarItemVisibility.Always;

            OwnerForm.StatusBarStatement.Caption = ((IStatusBarStatement)sender).StatusBarStatement;
            OwnerForm.StatusBarShortcut.Caption = ((IStatusBarShortcut)sender).StatusBarShortcut;
            OwnerForm.StatusBarShortcutStatement.Caption = ((IStatusBarShortcut)sender).StatusBarShortcutStatement;
        }

        private void Table_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.StatusBarShortcut.Visibility = BarItemVisibility.Never;
            OwnerForm.StatusBarShortcutStatement.Visibility = BarItemVisibility.Never;
        }

        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Table.IsEditorFocused)
                        InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.CancelEdit);
                    else
                        OwnerForm.Close();
                    break;

                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    InsUptNavigator.navigator.Buttons.DoClick(InsUptNavigator.navigator.Buttons.EndEdit);
                    break;

                case Keys.Insert when e.Shift:
                    AddAction();
                    break;

                case Keys.Delete when e.Modifiers == Keys.Shift:
                    DeleteAction();
                    break;

                case Keys.F3:
                    OpenEntity();
                    break;

                case Keys.F6:
                    DocumentActions();
                    break;

                case Keys.T when e.Control:
                    Cancel();
                    break;

                case Keys.R when e.Control:
                    CancelUndo();
                    break;
            }
        }

        protected virtual void Table_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (OwnerForm == null) return;

            OwnerForm.StatusBarShortcut.Visibility = BarItemVisibility.Never;
            OwnerForm.StatusBarShortcutStatement.Visibility = BarItemVisibility.Never;

            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Table_GotFocus(sender, null); //Table_GotFocus(Table,EventArgs.Empty);

            else if (((IStatusBarShortcut)e.FocusedColumn).StatusBarShortcut != null)
            {
                OwnerForm.StatusBarShortcut.Visibility = BarItemVisibility.Always;
                OwnerForm.StatusBarShortcutStatement.Visibility = BarItemVisibility.Always;

                OwnerForm.StatusBarStatement.Caption = ((IStatusBarStatement)e.FocusedColumn).StatusBarStatement;
                OwnerForm.StatusBarShortcut.Caption = ((IStatusBarShortcut)e.FocusedColumn).StatusBarShortcut;
                OwnerForm.StatusBarShortcutStatement.Caption = ((IStatusBarShortcut)e.FocusedColumn).StatusBarShortcutStatement;
            }

            else if (((IStatusBarShortcut)e.FocusedColumn).StatusBarStatement != null)
                OwnerForm.StatusBarStatement.Caption = ((IStatusBarShortcut)e.FocusedColumn).StatusBarStatement;
        }

        private void Table_TemplateChanged(object sender, EventArgs e)
        {
            _tableTemplateToSave = true;
            SaveTemplate();
        }

        private void Table_DoubleClick(object sender, EventArgs e)
        {
            OpenEntity();
        }

        protected virtual void Table_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            ShowHideColumns();
            RowCellAllowEdit();
        }

        protected virtual void Table_RowCountChanged(object sender, EventArgs e) { }
    }
}
