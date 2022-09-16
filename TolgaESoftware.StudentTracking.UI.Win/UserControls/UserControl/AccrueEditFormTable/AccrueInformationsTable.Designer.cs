namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class AccrueInformationsTable
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colBranch = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTerm = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGrossService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colShortTermDeductedService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGrossDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colShortTermDeductedDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 369);
            this.InsUptNavigator.Size = new System.Drawing.Size(638, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalc});
            this.grid.Size = new System.Drawing.Size(638, 369);
            this.grid.TabIndex = 6;
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
            this.colBranch,
            this.colTerm,
            this.colGrossService,
            this.colShortTermDeductedService,
            this.colNetService,
            this.colGrossDiscount,
            this.colShortTermDeductedDiscount,
            this.colNetDiscount,
            this.colNetPrice});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.MistyRose;
            formatConditionRuleValue1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.HighPriority = true;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = true;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.table.FormatRules.Add(gridFormatRule1);
            this.table.GridControl = this.grid;
            this.table.Name = "table";
            this.table.OptionsCustomization.AllowColumnMoving = false;
            this.table.OptionsCustomization.AllowFilter = false;
            this.table.OptionsCustomization.AllowSort = false;
            this.table.OptionsMenu.EnableColumnMenu = false;
            this.table.OptionsMenu.EnableFooterMenu = false;
            this.table.OptionsMenu.EnableGroupPanelMenu = false;
            this.table.OptionsNavigation.EnterMoveNextColumn = true;
            this.table.OptionsPrint.AutoWidth = false;
            this.table.OptionsPrint.PrintFooter = false;
            this.table.OptionsPrint.PrintGroupFooter = false;
            this.table.OptionsView.ColumnAutoWidth = false;
            this.table.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.table.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.table.OptionsView.RowAutoHeight = true;
            this.table.OptionsView.ShowFooter = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = "";
            this.table.StatusBarShortcutStatement = "";
            this.table.StatusBarStatement = "Öğrenciye Verilen Ücret Tahakkukları";
            this.table.ViewCaption = "Tahakkuklar";
            // 
            // colBranch
            // 
            this.colBranch.Caption = "Şube";
            this.colBranch.FieldName = "BranchName";
            this.colBranch.Name = "colBranch";
            this.colBranch.OptionsColumn.AllowEdit = false;
            this.colBranch.OptionsColumn.AllowMove = false;
            this.colBranch.OptionsColumn.AllowShowHide = false;
            this.colBranch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBranch.OptionsFilter.AllowAutoFilter = false;
            this.colBranch.OptionsFilter.AllowFilter = false;
            this.colBranch.StatusBarShortcut = null;
            this.colBranch.StatusBarShortcutStatement = null;
            this.colBranch.StatusBarStatement = null;
            this.colBranch.Visible = true;
            this.colBranch.VisibleIndex = 0;
            this.colBranch.Width = 120;
            // 
            // colTerm
            // 
            this.colTerm.AppearanceCell.Options.UseTextOptions = true;
            this.colTerm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTerm.Caption = "Dönem";
            this.colTerm.FieldName = "TermName";
            this.colTerm.Name = "colTerm";
            this.colTerm.OptionsColumn.AllowEdit = false;
            this.colTerm.OptionsColumn.AllowMove = false;
            this.colTerm.OptionsColumn.AllowShowHide = false;
            this.colTerm.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTerm.OptionsFilter.AllowAutoFilter = false;
            this.colTerm.OptionsFilter.AllowFilter = false;
            this.colTerm.StatusBarShortcut = null;
            this.colTerm.StatusBarShortcutStatement = null;
            this.colTerm.StatusBarStatement = null;
            this.colTerm.Visible = true;
            this.colTerm.VisibleIndex = 1;
            this.colTerm.Width = 120;
            // 
            // colGrossService
            // 
            this.colGrossService.AppearanceCell.Options.UseTextOptions = true;
            this.colGrossService.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGrossService.Caption = "Brüt Hizmet";
            this.colGrossService.ColumnEdit = this.repositoryItemCalc;
            this.colGrossService.FieldName = "GrossService";
            this.colGrossService.Name = "colGrossService";
            this.colGrossService.OptionsColumn.AllowEdit = false;
            this.colGrossService.OptionsColumn.AllowMove = false;
            this.colGrossService.OptionsColumn.AllowShowHide = false;
            this.colGrossService.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGrossService.OptionsFilter.AllowAutoFilter = false;
            this.colGrossService.OptionsFilter.AllowFilter = false;
            this.colGrossService.StatusBarShortcut = null;
            this.colGrossService.StatusBarShortcutStatement = null;
            this.colGrossService.StatusBarStatement = null;
            this.colGrossService.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossService", "{0:c2}")});
            this.colGrossService.Visible = true;
            this.colGrossService.VisibleIndex = 2;
            this.colGrossService.Width = 90;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalc.DisplayFormat.FormatString = "{0:c2}";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.EditFormat.FormatString = "{0:c2}";
            this.repositoryItemCalc.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Mask.EditMask = "c2";
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // colShortTermDeductedService
            // 
            this.colShortTermDeductedService.AppearanceCell.Options.UseTextOptions = true;
            this.colShortTermDeductedService.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colShortTermDeductedService.Caption = "Kıst Dönem Düşülen Hizmet";
            this.colShortTermDeductedService.ColumnEdit = this.repositoryItemCalc;
            this.colShortTermDeductedService.FieldName = "ShortTermDeductedService";
            this.colShortTermDeductedService.Name = "colShortTermDeductedService";
            this.colShortTermDeductedService.OptionsColumn.AllowEdit = false;
            this.colShortTermDeductedService.OptionsColumn.AllowMove = false;
            this.colShortTermDeductedService.OptionsColumn.AllowShowHide = false;
            this.colShortTermDeductedService.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colShortTermDeductedService.OptionsFilter.AllowAutoFilter = false;
            this.colShortTermDeductedService.OptionsFilter.AllowFilter = false;
            this.colShortTermDeductedService.StatusBarShortcut = null;
            this.colShortTermDeductedService.StatusBarShortcutStatement = null;
            this.colShortTermDeductedService.StatusBarStatement = null;
            this.colShortTermDeductedService.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedService", "{0:c2}")});
            this.colShortTermDeductedService.Visible = true;
            this.colShortTermDeductedService.VisibleIndex = 3;
            this.colShortTermDeductedService.Width = 90;
            // 
            // colNetService
            // 
            this.colNetService.AppearanceCell.Options.UseTextOptions = true;
            this.colNetService.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNetService.Caption = "Net Hizmet";
            this.colNetService.ColumnEdit = this.repositoryItemCalc;
            this.colNetService.FieldName = "NetService";
            this.colNetService.Name = "colNetService";
            this.colNetService.OptionsColumn.AllowEdit = false;
            this.colNetService.OptionsColumn.AllowMove = false;
            this.colNetService.OptionsColumn.AllowShowHide = false;
            this.colNetService.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetService.OptionsFilter.AllowAutoFilter = false;
            this.colNetService.OptionsFilter.AllowFilter = false;
            this.colNetService.StatusBarShortcut = null;
            this.colNetService.StatusBarShortcutStatement = null;
            this.colNetService.StatusBarStatement = null;
            this.colNetService.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetService", "{0:c2}")});
            this.colNetService.Visible = true;
            this.colNetService.VisibleIndex = 4;
            this.colNetService.Width = 90;
            // 
            // colGrossDiscount
            // 
            this.colGrossDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.colGrossDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGrossDiscount.Caption = "Brüt İndirim";
            this.colGrossDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colGrossDiscount.FieldName = "GrossDiscount";
            this.colGrossDiscount.Name = "colGrossDiscount";
            this.colGrossDiscount.OptionsColumn.AllowEdit = false;
            this.colGrossDiscount.OptionsColumn.AllowMove = false;
            this.colGrossDiscount.OptionsColumn.AllowShowHide = false;
            this.colGrossDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGrossDiscount.OptionsFilter.AllowAutoFilter = false;
            this.colGrossDiscount.OptionsFilter.AllowFilter = false;
            this.colGrossDiscount.StatusBarShortcut = null;
            this.colGrossDiscount.StatusBarShortcutStatement = null;
            this.colGrossDiscount.StatusBarStatement = null;
            this.colGrossDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossDiscount", "{0:c2}")});
            this.colGrossDiscount.Visible = true;
            this.colGrossDiscount.VisibleIndex = 5;
            this.colGrossDiscount.Width = 90;
            // 
            // colShortTermDeductedDiscount
            // 
            this.colShortTermDeductedDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.colShortTermDeductedDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colShortTermDeductedDiscount.Caption = "Kıst Dönem Düşülen İndirim";
            this.colShortTermDeductedDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colShortTermDeductedDiscount.FieldName = "ShortTermDeductedDiscount";
            this.colShortTermDeductedDiscount.Name = "colShortTermDeductedDiscount";
            this.colShortTermDeductedDiscount.OptionsColumn.AllowEdit = false;
            this.colShortTermDeductedDiscount.OptionsColumn.AllowMove = false;
            this.colShortTermDeductedDiscount.OptionsColumn.AllowShowHide = false;
            this.colShortTermDeductedDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colShortTermDeductedDiscount.OptionsFilter.AllowAutoFilter = false;
            this.colShortTermDeductedDiscount.OptionsFilter.AllowFilter = false;
            this.colShortTermDeductedDiscount.StatusBarShortcut = null;
            this.colShortTermDeductedDiscount.StatusBarShortcutStatement = null;
            this.colShortTermDeductedDiscount.StatusBarStatement = null;
            this.colShortTermDeductedDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedDiscount", "{0:c2}")});
            this.colShortTermDeductedDiscount.Visible = true;
            this.colShortTermDeductedDiscount.VisibleIndex = 6;
            this.colShortTermDeductedDiscount.Width = 90;
            // 
            // colNetDiscount
            // 
            this.colNetDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.colNetDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNetDiscount.Caption = "Net İndirim";
            this.colNetDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colNetDiscount.FieldName = "NetDiscount";
            this.colNetDiscount.Name = "colNetDiscount";
            this.colNetDiscount.OptionsColumn.AllowEdit = false;
            this.colNetDiscount.OptionsColumn.AllowMove = false;
            this.colNetDiscount.OptionsColumn.AllowShowHide = false;
            this.colNetDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetDiscount.OptionsFilter.AllowAutoFilter = false;
            this.colNetDiscount.OptionsFilter.AllowFilter = false;
            this.colNetDiscount.StatusBarShortcut = null;
            this.colNetDiscount.StatusBarShortcutStatement = null;
            this.colNetDiscount.StatusBarStatement = null;
            this.colNetDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetDiscount", "{0:c2}")});
            this.colNetDiscount.Visible = true;
            this.colNetDiscount.VisibleIndex = 7;
            this.colNetDiscount.Width = 90;
            // 
            // colNetPrice
            // 
            this.colNetPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colNetPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNetPrice.Caption = "Net Ücret";
            this.colNetPrice.ColumnEdit = this.repositoryItemCalc;
            this.colNetPrice.FieldName = "NetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.OptionsColumn.AllowEdit = false;
            this.colNetPrice.OptionsColumn.AllowMove = false;
            this.colNetPrice.OptionsColumn.AllowShowHide = false;
            this.colNetPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetPrice.OptionsFilter.AllowAutoFilter = false;
            this.colNetPrice.OptionsFilter.AllowFilter = false;
            this.colNetPrice.StatusBarShortcut = null;
            this.colNetPrice.StatusBarShortcutStatement = null;
            this.colNetPrice.StatusBarStatement = null;
            this.colNetPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetPrice", "{0:c2}")});
            this.colNetPrice.Visible = true;
            this.colNetPrice.VisibleIndex = 8;
            this.colNetPrice.Width = 90;
            // 
            // AccrueInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "AccrueInformationsTable";
            this.Size = new System.Drawing.Size(638, 393);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colBranch;
        private Grids.MyGridColumn colGrossDiscount;
        private Grids.MyGridColumn colTerm;
        private Grids.MyGridColumn colGrossService;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private Grids.MyGridColumn colShortTermDeductedService;
        private Grids.MyGridColumn colNetService;
        private Grids.MyGridColumn colShortTermDeductedDiscount;
        private Grids.MyGridColumn colNetDiscount;
        private Grids.MyGridColumn colNetPrice;
    }
}
