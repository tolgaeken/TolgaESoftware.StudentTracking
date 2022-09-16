using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids
{
   [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("MyGridView");

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var idColumn = new MyGridColumn
            {
                Caption = @"Id",
                FieldName = "Id",
                Name = "colId",
                OptionsColumn = { AllowEdit = false, ShowInCustomizationForm = false },
            };
            view.Columns.Add(idColumn);

            var codeColumn = new MyGridColumn
            {
                Caption = @"Kod",
                FieldName = "Code",
                Name = "colCode",
                OptionsColumn = { AllowEdit = false, ShowInCustomizationForm = false },
                AppearanceCell = { Options = { UseTextOptions = true }, TextOptions = { HAlignment = HorzAlignment.Center }},
                Visible = true,
                Width = 130,
            };
            view.Columns.Add(codeColumn);

            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);

            collection.Add(new MyGridInfoRegistrator());
        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";
            public override BaseView CreateView(GridControl grid) => new MyGridView(grid);
        }
    }

    public class MyGridView : GridView, IStatusBarShortcut
    {
        public MyGridView() { }
        public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }

        #region Properties
        public string StatusBarStatement { get; set; }
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutStatement { get; set; }
        #endregion

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit = false;
                column.OptionsColumn.AllowFocus = false; //Tolga
                return column;
            }
        }
    }

    public class MyGridColumn : GridColumn, IStatusBarShortcut
    {
        #region Properties
        public string StatusBarStatement { get; set; }
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutStatement { get; set; }
        #endregion
    }
}