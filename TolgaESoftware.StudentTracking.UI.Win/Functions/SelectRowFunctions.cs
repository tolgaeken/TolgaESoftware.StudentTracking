using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public class SelectRowFunctions
    {
        #region Variables
        private GridView _table;
        private GridColumn _column;
        private RepositoryItemCheckEdit _checkEdit;
        private readonly IList<BaseEntity> _selectedRows;
        #endregion

        public SelectRowFunctions(GridView table)
        {
            _table = table;
            _selectedRows = new List<BaseEntity>();

            RemoveEvents();
            AddEvents(table);
            
        }

        private void Update()
        {
            _table.BeginUpdate();
            _table.EndUpdate();
        }

        private void SelectRow(int rowHandle, bool select)
        {
            if (IsRowSelected(rowHandle) == select) return;
            var row = _table.GetRow<BaseEntity>(rowHandle);

            if (select) _selectedRows.Add(row);
            else _selectedRows.Remove(row);
            Update();
        }

        public void RowSelection(int rowHandle)
        {
            if (!_table.IsDataRow(rowHandle)) return;

            SelectRow(rowHandle, !IsRowSelected(rowHandle));
        }

        private void AddEvents(GridView table)
        {
            if (table == null) return;

            _selectedRows.Clear();
            _table = table;

            _checkEdit = (RepositoryItemCheckEdit)_table.GridControl.RepositoryItems.Add("CheckEdit");
            _column = _table.Columns.Add();
            _column.OptionsColumn.AllowSort = DefaultBoolean.False;
            _column.Visible = true;
            _column.VisibleIndex = 0;
            _column.FieldName = "Selection";
            _column.OptionsColumn.ShowCaption = false;
            _column.OptionsColumn.AllowEdit = false;
            _column.OptionsColumn.AllowSize = false;
            _column.OptionsColumn.FixedWidth = true;
            _column.UnboundType = UnboundColumnType.Boolean;
            _column.Width = 35;
            _column.ColumnEdit = _checkEdit;
            _table.FocusedColumn = _column;

            if (_table is BandedGridView bView)
            {
                bView.Bands["bndSelection"].Visible = true;
                bView.Bands["bndSelection"].VisibleIndex = 0;
                bView.Bands["bndSelection"].Columns.Add((BandedGridColumn)_column);
            }

            _table.Click += Table_Click;
            _table.CustomDrawColumnHeader += Table_CustomDrawColumnHeader;
            _table.CustomUnboundColumnData += Table_CustomUnboundColumnData;
            _table.KeyDown += Table_KeyDown;
            _table.RowStyle += Table_RowStyle;
        }

        private void RemoveEvents()
        {
            if (_table == null) return;

            _column?.Dispose();

            if (_checkEdit != null)
            {
                _table.GridControl.RepositoryItems.Remove(_checkEdit);
                _checkEdit.Dispose();
            }

            _table.Click -= Table_Click;
            _table.CustomDrawColumnHeader -= Table_CustomDrawColumnHeader;
            _table.CustomUnboundColumnData -= Table_CustomUnboundColumnData;
            _table.KeyDown -= Table_KeyDown;
            _table.RowStyle -= Table_RowStyle;

            _table = null;

        }

        private void AddCheckBox(GraphicsCache cache, Rectangle rectangle, bool check)
        {
            var info = (CheckEditViewInfo)_checkEdit.CreateViewInfo();
            var painter = (CheckEditPainter)_checkEdit.CreatePainter();
            if (info == null) return;
            info.EditValue = check;
            info.Bounds = rectangle;
            info.CalcViewInfo(cache.Graphics);
            var argument = new ControlGraphicsInfoArgs(info, cache, rectangle);
            painter?.Draw(argument);
        }

        public int SelectedRowCount => _selectedRows.Count;

        public BaseEntity GetSelectedRow(int index)
        {
            return _selectedRows[index];
        }

        public IList<BaseEntity> GetSelectedRows()
        {
            return _selectedRows;
        }

        public int GetSelectedRowIndex(BaseEntity row)
        {
            return _selectedRows.IndexOf(row);
        }

        public bool IsRowSelected(int rowHandle)
        {
            var row = (BaseEntity) _table.GetRow(rowHandle);
            return GetSelectedRowIndex(row) > -1;
        }

        public void SelectAll()
        {
            _selectedRows.Clear();

            for (int i = 0; i < _table.DataRowCount; i++)
                _selectedRows.Add(_table.GetRow<BaseEntity>(i));

            Update();

        }

        public void ClearSelection()
        {
            _selectedRows.Clear();
            Update();
        }

        private void Table_Click(object sender, System.EventArgs e)
        {
            var point = _table.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = _table.CalcHitInfo(point);

            if (info.Column == _column)
            {
                if (info.InColumn)
                {
                    if (SelectedRowCount == _table.DataRowCount) ClearSelection();
                    else SelectAll();
                }
                else if (info.InRowCell)
                    RowSelection(info.RowHandle);
            }

            else if (info.InRow) RowSelection(info.RowHandle);
        }

        private void Table_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != _column) return;

            e.Info.InnerElements.Clear();
            e.Painter.DrawObject(e.Info);

            AddCheckBox(e.Cache, e.Bounds, SelectedRowCount == _table.DataRowCount);

            e.Handled = true;
        }

        private void Table_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column != _column) return;

            e.Value = IsRowSelected(_table.GetRowHandle(e.ListSourceRowIndex));
        }

        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;

            RowSelection(_table.FocusedRowHandle);
        }

        private void Table_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (!IsRowSelected(e.RowHandle)) return;

            e.Appearance.BackColor = SystemColors.Highlight;
            e.Appearance.ForeColor = SystemColors.HighlightText;
        }
    }
}