namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.GeneralEditFormTable
{
    partial class RoleAuthorizationsTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCardType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCanRead = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCanAdd = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCanChange = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCanDelete = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 467);
            this.InsUptNavigator.Size = new System.Drawing.Size(653, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheck});
            this.grid.Size = new System.Drawing.Size(653, 467);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.table});
            // 
            // table
            // 
            this.table.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.table.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.FooterPanel.Options.UseFont = true;
            this.table.Appearance.FooterPanel.Options.UseForeColor = true;
            this.table.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.table.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.table.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.table.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.ViewCaption.Options.UseForeColor = true;
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCardType,
            this.colCanRead,
            this.colCanAdd,
            this.colCanChange,
            this.colCanDelete});
            this.table.GridControl = this.grid;
            this.table.Name = "table";
            this.table.OptionsMenu.EnableColumnMenu = false;
            this.table.OptionsMenu.EnableFooterMenu = false;
            this.table.OptionsMenu.EnableGroupPanelMenu = false;
            this.table.OptionsNavigation.EnterMoveNextColumn = true;
            this.table.OptionsPrint.AutoWidth = false;
            this.table.OptionsPrint.PrintFooter = false;
            this.table.OptionsPrint.PrintGroupFooter = false;
            this.table.OptionsView.ColumnAutoWidth = false;
            this.table.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.table.OptionsView.RowAutoHeight = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = "Shift + Insert : ";
            this.table.StatusBarShortcutStatement = "Yetki Kartı Ekle";
            this.table.StatusBarStatement = "Rol Yetki Kartları";
            this.table.ViewCaption = "Rol Yetkileri";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarShortcut = null;
            this.colId.StatusBarShortcutStatement = null;
            this.colId.StatusBarStatement = null;
            // 
            // colCardType
            // 
            this.colCardType.Caption = "Kart Türü";
            this.colCardType.FieldName = "CardType";
            this.colCardType.Name = "colCardType";
            this.colCardType.OptionsColumn.AllowEdit = false;
            this.colCardType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCardType.OptionsFilter.AllowAutoFilter = false;
            this.colCardType.OptionsFilter.AllowFilter = false;
            this.colCardType.StatusBarShortcut = null;
            this.colCardType.StatusBarShortcutStatement = null;
            this.colCardType.StatusBarStatement = null;
            this.colCardType.Visible = true;
            this.colCardType.VisibleIndex = 0;
            this.colCardType.Width = 150;
            // 
            // colCanRead
            // 
            this.colCanRead.Caption = "Görebilir";
            this.colCanRead.ColumnEdit = this.repositoryItemCheck;
            this.colCanRead.FieldName = "CanRead";
            this.colCanRead.Name = "colCanRead";
            this.colCanRead.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCanRead.OptionsFilter.AllowAutoFilter = false;
            this.colCanRead.OptionsFilter.AllowFilter = false;
            this.colCanRead.StatusBarShortcut = null;
            this.colCanRead.StatusBarShortcutStatement = null;
            this.colCanRead.StatusBarStatement = null;
            this.colCanRead.Visible = true;
            this.colCanRead.VisibleIndex = 1;
            this.colCanRead.Width = 100;
            // 
            // repositoryItemCheck
            // 
            this.repositoryItemCheck.AutoHeight = false;
            this.repositoryItemCheck.Name = "repositoryItemCheck";
            this.repositoryItemCheck.ValueChecked = ((byte)(1));
            this.repositoryItemCheck.ValueGrayed = ((byte)(2));
            this.repositoryItemCheck.ValueUnchecked = ((byte)(0));
            // 
            // colCanAdd
            // 
            this.colCanAdd.Caption = "Ekleyebilir";
            this.colCanAdd.ColumnEdit = this.repositoryItemCheck;
            this.colCanAdd.FieldName = "CanAdd";
            this.colCanAdd.Name = "colCanAdd";
            this.colCanAdd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCanAdd.OptionsFilter.AllowAutoFilter = false;
            this.colCanAdd.OptionsFilter.AllowFilter = false;
            this.colCanAdd.StatusBarShortcut = null;
            this.colCanAdd.StatusBarShortcutStatement = null;
            this.colCanAdd.StatusBarStatement = null;
            this.colCanAdd.Visible = true;
            this.colCanAdd.VisibleIndex = 2;
            this.colCanAdd.Width = 100;
            // 
            // colCanChange
            // 
            this.colCanChange.Caption = "Değiştirebilir";
            this.colCanChange.ColumnEdit = this.repositoryItemCheck;
            this.colCanChange.FieldName = "CanChange";
            this.colCanChange.Name = "colCanChange";
            this.colCanChange.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCanChange.OptionsFilter.AllowAutoFilter = false;
            this.colCanChange.OptionsFilter.AllowFilter = false;
            this.colCanChange.StatusBarShortcut = null;
            this.colCanChange.StatusBarShortcutStatement = null;
            this.colCanChange.StatusBarStatement = null;
            this.colCanChange.Visible = true;
            this.colCanChange.VisibleIndex = 3;
            this.colCanChange.Width = 100;
            // 
            // colCanDelete
            // 
            this.colCanDelete.Caption = "Silebilir";
            this.colCanDelete.ColumnEdit = this.repositoryItemCheck;
            this.colCanDelete.FieldName = "CanDelete";
            this.colCanDelete.Name = "colCanDelete";
            this.colCanDelete.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCanDelete.OptionsFilter.AllowAutoFilter = false;
            this.colCanDelete.OptionsFilter.AllowFilter = false;
            this.colCanDelete.StatusBarShortcut = null;
            this.colCanDelete.StatusBarShortcutStatement = null;
            this.colCanDelete.StatusBarStatement = null;
            this.colCanDelete.Visible = true;
            this.colCanDelete.VisibleIndex = 4;
            this.colCanDelete.Width = 100;
            // 
            // RoleAuthorizationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "RoleAuthorizationsTable";
            this.Size = new System.Drawing.Size(653, 491);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colId;
        private Grids.MyGridColumn colCardType;
        private Grids.MyGridColumn colCanRead;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheck;
        private Grids.MyGridColumn colCanAdd;
        private Grids.MyGridColumn colCanChange;
        private Grids.MyGridColumn colCanDelete;
    }
}
