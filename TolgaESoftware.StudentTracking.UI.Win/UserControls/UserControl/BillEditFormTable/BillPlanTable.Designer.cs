namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.BillEditFormTable
{
    partial class BillPlanTable
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
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPlanPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPlanDiscountPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBillNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccrueDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccruePrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccrueDiscountPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccrueNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 369);
            this.InsUptNavigator.Size = new System.Drawing.Size(785, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemCalc});
            this.grid.Size = new System.Drawing.Size(785, 369);
            this.grid.TabIndex = 1;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.table});
            // 
            // table
            // 
            this.table.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.table.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.table.Appearance.BandPanel.Options.UseFont = true;
            this.table.Appearance.BandPanel.Options.UseForeColor = true;
            this.table.Appearance.BandPanel.Options.UseTextOptions = true;
            this.table.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.table.BandPanelRowHeight = 25;
            this.table.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colStatement,
            this.colPlanDate,
            this.colPlanPrice,
            this.colPlanDiscountPrice,
            this.colPlanNetPrice,
            this.colBillNumber,
            this.colAccrueDate,
            this.colAccruePrice,
            this.colAccrueDiscountPrice,
            this.colAccrueNetPrice});
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
            this.table.OptionsView.ShowFooter = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = "Shift + Insert : ";
            this.table.StatusBarShortcutStatement = "Fatura Planı Ekle";
            this.table.StatusBarStatement = "Öğrenciye Kesilen - Kesilecek Fatura Bilgileri";
            this.table.ViewCaption = "Fatura Planı";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Fatura Plan Bilgileri";
            this.gridBand1.Columns.Add(this.colStatement);
            this.gridBand1.Columns.Add(this.colPlanDate);
            this.gridBand1.Columns.Add(this.colPlanPrice);
            this.gridBand1.Columns.Add(this.colPlanDiscountPrice);
            this.gridBand1.Columns.Add(this.colPlanNetPrice);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 700;
            // 
            // colStatement
            // 
            this.colStatement.Caption = "Açıklama";
            this.colStatement.FieldName = "Statement";
            this.colStatement.Name = "colStatement";
            this.colStatement.OptionsColumn.AllowEdit = false;
            this.colStatement.StatusBarShortcut = null;
            this.colStatement.StatusBarShortcutStatement = null;
            this.colStatement.StatusBarStatement = null;
            this.colStatement.Visible = true;
            this.colStatement.Width = 300;
            // 
            // colPlanDate
            // 
            this.colPlanDate.AppearanceCell.Options.UseTextOptions = true;
            this.colPlanDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanDate.Caption = "Tarih";
            this.colPlanDate.ColumnEdit = this.repositoryItemDate;
            this.colPlanDate.CustomizationCaption = "Plan Tarih";
            this.colPlanDate.FieldName = "PlanDate";
            this.colPlanDate.Name = "colPlanDate";
            this.colPlanDate.OptionsColumn.AllowEdit = false;
            this.colPlanDate.StatusBarShortcut = null;
            this.colPlanDate.StatusBarShortcutStatement = null;
            this.colPlanDate.StatusBarStatement = null;
            this.colPlanDate.Visible = true;
            this.colPlanDate.Width = 100;
            // 
            // repositoryItemDate
            // 
            this.repositoryItemDate.AutoHeight = false;
            this.repositoryItemDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDate.Name = "repositoryItemDate";
            // 
            // colPlanPrice
            // 
            this.colPlanPrice.Caption = "Tutar";
            this.colPlanPrice.ColumnEdit = this.repositoryItemCalc;
            this.colPlanPrice.CustomizationCaption = "Plan Tutar";
            this.colPlanPrice.FieldName = "PlanPrice";
            this.colPlanPrice.Name = "colPlanPrice";
            this.colPlanPrice.OptionsColumn.AllowEdit = false;
            this.colPlanPrice.StatusBarShortcut = null;
            this.colPlanPrice.StatusBarShortcutStatement = null;
            this.colPlanPrice.StatusBarStatement = null;
            this.colPlanPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanPrice", "{0:c2}")});
            this.colPlanPrice.Visible = true;
            this.colPlanPrice.Width = 100;
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
            // colPlanDiscountPrice
            // 
            this.colPlanDiscountPrice.Caption = "İndirim";
            this.colPlanDiscountPrice.ColumnEdit = this.repositoryItemCalc;
            this.colPlanDiscountPrice.CustomizationCaption = "Plan İndirim";
            this.colPlanDiscountPrice.FieldName = "PlanDiscountPrice";
            this.colPlanDiscountPrice.Name = "colPlanDiscountPrice";
            this.colPlanDiscountPrice.OptionsColumn.AllowEdit = false;
            this.colPlanDiscountPrice.StatusBarShortcut = null;
            this.colPlanDiscountPrice.StatusBarShortcutStatement = null;
            this.colPlanDiscountPrice.StatusBarStatement = null;
            this.colPlanDiscountPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanDiscountPrice", "{0:c2}")});
            this.colPlanDiscountPrice.Visible = true;
            this.colPlanDiscountPrice.Width = 100;
            // 
            // colPlanNetPrice
            // 
            this.colPlanNetPrice.Caption = "Net Tutar";
            this.colPlanNetPrice.ColumnEdit = this.repositoryItemCalc;
            this.colPlanNetPrice.CustomizationCaption = "Plan Net Tutar";
            this.colPlanNetPrice.FieldName = "PlanNetPrice";
            this.colPlanNetPrice.Name = "colPlanNetPrice";
            this.colPlanNetPrice.OptionsColumn.AllowEdit = false;
            this.colPlanNetPrice.StatusBarShortcut = null;
            this.colPlanNetPrice.StatusBarShortcutStatement = null;
            this.colPlanNetPrice.StatusBarStatement = null;
            this.colPlanNetPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanNetPrice", "{0:c2}")});
            this.colPlanNetPrice.Visible = true;
            this.colPlanNetPrice.Width = 100;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Fatura Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colBillNumber);
            this.gridBand2.Columns.Add(this.colAccrueDate);
            this.gridBand2.Columns.Add(this.colAccruePrice);
            this.gridBand2.Columns.Add(this.colAccrueDiscountPrice);
            this.gridBand2.Columns.Add(this.colAccrueNetPrice);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 500;
            // 
            // colBillNumber
            // 
            this.colBillNumber.Caption = "Fatura No";
            this.colBillNumber.FieldName = "BillNumber";
            this.colBillNumber.Name = "colBillNumber";
            this.colBillNumber.OptionsColumn.AllowEdit = false;
            this.colBillNumber.StatusBarShortcut = null;
            this.colBillNumber.StatusBarShortcutStatement = null;
            this.colBillNumber.StatusBarStatement = null;
            this.colBillNumber.Visible = true;
            this.colBillNumber.Width = 100;
            // 
            // colAccrueDate
            // 
            this.colAccrueDate.AppearanceCell.Options.UseTextOptions = true;
            this.colAccrueDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccrueDate.Caption = "Tarih";
            this.colAccrueDate.ColumnEdit = this.repositoryItemDate;
            this.colAccrueDate.CustomizationCaption = "Tahakkuk Tarih";
            this.colAccrueDate.FieldName = "AccrueDate";
            this.colAccrueDate.Name = "colAccrueDate";
            this.colAccrueDate.OptionsColumn.AllowEdit = false;
            this.colAccrueDate.StatusBarShortcut = null;
            this.colAccrueDate.StatusBarShortcutStatement = null;
            this.colAccrueDate.StatusBarStatement = null;
            this.colAccrueDate.Visible = true;
            this.colAccrueDate.Width = 100;
            // 
            // colAccruePrice
            // 
            this.colAccruePrice.Caption = "Tutar";
            this.colAccruePrice.ColumnEdit = this.repositoryItemCalc;
            this.colAccruePrice.CustomizationCaption = "Tahakkuk Tutar";
            this.colAccruePrice.FieldName = "AccruePrice";
            this.colAccruePrice.Name = "colAccruePrice";
            this.colAccruePrice.OptionsColumn.AllowEdit = false;
            this.colAccruePrice.StatusBarShortcut = null;
            this.colAccruePrice.StatusBarShortcutStatement = null;
            this.colAccruePrice.StatusBarStatement = null;
            this.colAccruePrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccruePrice", "{0:c2}")});
            this.colAccruePrice.Visible = true;
            this.colAccruePrice.Width = 100;
            // 
            // colAccrueDiscountPrice
            // 
            this.colAccrueDiscountPrice.Caption = "İndirim";
            this.colAccrueDiscountPrice.ColumnEdit = this.repositoryItemCalc;
            this.colAccrueDiscountPrice.CustomizationCaption = "Tahakkuk İndirim";
            this.colAccrueDiscountPrice.FieldName = "AccrueDiscountPrice";
            this.colAccrueDiscountPrice.Name = "colAccrueDiscountPrice";
            this.colAccrueDiscountPrice.OptionsColumn.AllowEdit = false;
            this.colAccrueDiscountPrice.StatusBarShortcut = null;
            this.colAccrueDiscountPrice.StatusBarShortcutStatement = null;
            this.colAccrueDiscountPrice.StatusBarStatement = null;
            this.colAccrueDiscountPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccrueDiscountPrice", "{0:c2}")});
            this.colAccrueDiscountPrice.Visible = true;
            this.colAccrueDiscountPrice.Width = 100;
            // 
            // colAccrueNetPrice
            // 
            this.colAccrueNetPrice.Caption = "Net Tutar";
            this.colAccrueNetPrice.ColumnEdit = this.repositoryItemCalc;
            this.colAccrueNetPrice.CustomizationCaption = "Tahakkuk Net Tutar";
            this.colAccrueNetPrice.FieldName = "AccrueNetPrice";
            this.colAccrueNetPrice.Name = "colAccrueNetPrice";
            this.colAccrueNetPrice.OptionsColumn.AllowEdit = false;
            this.colAccrueNetPrice.StatusBarShortcut = null;
            this.colAccrueNetPrice.StatusBarShortcutStatement = null;
            this.colAccrueNetPrice.StatusBarStatement = null;
            this.colAccrueNetPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccrueNetPrice", "{0:c2}")});
            this.colAccrueNetPrice.Visible = true;
            this.colAccrueNetPrice.Width = 100;
            // 
            // BillPlanTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "BillPlanTable";
            this.Size = new System.Drawing.Size(785, 393);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Grids.MyBandedGridControl grid;
        private Grids.MyBandedGridView table;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private Grids.MyBandedGridColumn colStatement;
        private Grids.MyBandedGridColumn colPlanDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private Grids.MyBandedGridColumn colPlanPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private Grids.MyBandedGridColumn colPlanDiscountPrice;
        private Grids.MyBandedGridColumn colPlanNetPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private Grids.MyBandedGridColumn colBillNumber;
        private Grids.MyBandedGridColumn colAccrueDate;
        private Grids.MyBandedGridColumn colAccruePrice;
        private Grids.MyBandedGridColumn colAccrueDiscountPrice;
        private Grids.MyBandedGridColumn colAccrueNetPrice;
    }
}
