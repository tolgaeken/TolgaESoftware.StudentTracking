namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class DiscountInformationsTable
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
            this.colCancelled = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colDiscountName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServiceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTransactionDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colCancellationDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCancellationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colGrossDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colShortTermDeductedDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCancellationReasonId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCancellationReasonName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCancellationReason = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCancellationStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationReason)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 348);
            this.InsUptNavigator.Size = new System.Drawing.Size(722, 24);
            // 
            // colCancelled
            // 
            this.colCancelled.Caption = "İptal Edildi";
            this.colCancelled.FieldName = "Cancelled";
            this.colCancelled.Name = "colCancelled";
            this.colCancelled.OptionsColumn.AllowEdit = false;
            this.colCancelled.OptionsColumn.AllowFocus = false;
            this.colCancelled.OptionsColumn.ShowInCustomizationForm = false;
            this.colCancelled.StatusBarShortcut = null;
            this.colCancelled.StatusBarShortcutStatement = null;
            this.colCancelled.StatusBarStatement = null;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCancellationDate,
            this.repositoryItemCancellationReason,
            this.repositoryItemCalc,
            this.repositoryItemDate});
            this.grid.Size = new System.Drawing.Size(722, 348);
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
            this.colDiscountName,
            this.colServiceName,
            this.colTransactionDate,
            this.colCancellationDate,
            this.colCancelled,
            this.colGrossDiscount,
            this.colShortTermDeductedDiscount,
            this.colNetDiscount,
            this.colCancellationReasonId,
            this.colCancellationReasonName,
            this.colCancellationStatement});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colCancelled;
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
            this.table.StatusBarShortcut = "Shift + Insert";
            this.table.StatusBarShortcutStatement = "Seçim Yap";
            this.table.StatusBarStatement = "Öğrenciye Uygulanan İndirimleri Seçiniz";
            this.table.ViewCaption = "İndirim Bilgileri";
            // 
            // colDiscountName
            // 
            this.colDiscountName.Caption = "İndirim Adı";
            this.colDiscountName.FieldName = "DiscountName";
            this.colDiscountName.Name = "colDiscountName";
            this.colDiscountName.OptionsColumn.AllowEdit = false;
            this.colDiscountName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscountName.OptionsFilter.AllowAutoFilter = false;
            this.colDiscountName.OptionsFilter.AllowFilter = false;
            this.colDiscountName.StatusBarShortcut = null;
            this.colDiscountName.StatusBarShortcutStatement = null;
            this.colDiscountName.StatusBarStatement = null;
            this.colDiscountName.Visible = true;
            this.colDiscountName.VisibleIndex = 0;
            this.colDiscountName.Width = 150;
            // 
            // colServiceName
            // 
            this.colServiceName.Caption = "İndirimin Uygulanacağı Hizmet";
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.OptionsColumn.AllowEdit = false;
            this.colServiceName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServiceName.OptionsFilter.AllowAutoFilter = false;
            this.colServiceName.OptionsFilter.AllowFilter = false;
            this.colServiceName.StatusBarShortcut = null;
            this.colServiceName.StatusBarShortcutStatement = null;
            this.colServiceName.StatusBarStatement = null;
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 1;
            this.colServiceName.Width = 150;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.AppearanceCell.Options.UseTextOptions = true;
            this.colTransactionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTransactionDate.Caption = "İşlem Tarihi";
            this.colTransactionDate.ColumnEdit = this.repositoryItemDate;
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.OptionsColumn.AllowEdit = false;
            this.colTransactionDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTransactionDate.OptionsFilter.AllowAutoFilter = false;
            this.colTransactionDate.OptionsFilter.AllowFilter = false;
            this.colTransactionDate.StatusBarShortcut = null;
            this.colTransactionDate.StatusBarShortcutStatement = null;
            this.colTransactionDate.StatusBarStatement = null;
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 2;
            this.colTransactionDate.Width = 100;
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
            // colCancellationDate
            // 
            this.colCancellationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colCancellationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCancellationDate.Caption = "İptal Tarihi";
            this.colCancellationDate.ColumnEdit = this.repositoryItemCancellationDate;
            this.colCancellationDate.FieldName = "CancellationDate";
            this.colCancellationDate.Name = "colCancellationDate";
            this.colCancellationDate.OptionsColumn.AllowEdit = false;
            this.colCancellationDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCancellationDate.OptionsFilter.AllowAutoFilter = false;
            this.colCancellationDate.OptionsFilter.AllowFilter = false;
            this.colCancellationDate.StatusBarShortcut = "F4 : ";
            this.colCancellationDate.StatusBarShortcutStatement = "Seçim Yap";
            this.colCancellationDate.StatusBarStatement = "Tarih Seçiniz";
            this.colCancellationDate.Visible = true;
            this.colCancellationDate.VisibleIndex = 6;
            this.colCancellationDate.Width = 100;
            // 
            // repositoryItemCancellationDate
            // 
            this.repositoryItemCancellationDate.AutoHeight = false;
            this.repositoryItemCancellationDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCancellationDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCancellationDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemCancellationDate.Name = "repositoryItemCancellationDate";
            // 
            // colGrossDiscount
            // 
            this.colGrossDiscount.Caption = "Brüt İndirim";
            this.colGrossDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colGrossDiscount.FieldName = "GrossDiscount";
            this.colGrossDiscount.Name = "colGrossDiscount";
            this.colGrossDiscount.OptionsColumn.AllowEdit = false;
            this.colGrossDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGrossDiscount.OptionsFilter.AllowAutoFilter = false;
            this.colGrossDiscount.OptionsFilter.AllowFilter = false;
            this.colGrossDiscount.StatusBarShortcut = "F4 : ";
            this.colGrossDiscount.StatusBarShortcutStatement = "Hesap Makinesi";
            this.colGrossDiscount.StatusBarStatement = "Tutar Giriniz";
            this.colGrossDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossDiscount", "{0:c2}")});
            this.colGrossDiscount.Visible = true;
            this.colGrossDiscount.VisibleIndex = 3;
            this.colGrossDiscount.Width = 90;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalc.DisplayFormat.FormatString = " {0:c2}";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.EditFormat.FormatString = "{o:c2}";
            this.repositoryItemCalc.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Mask.EditMask = "c2";
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // colShortTermDeductedDiscount
            // 
            this.colShortTermDeductedDiscount.Caption = "Kıst Dönem Düşülen İndirim";
            this.colShortTermDeductedDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colShortTermDeductedDiscount.FieldName = "ShortTermDeductedDiscount";
            this.colShortTermDeductedDiscount.Name = "colShortTermDeductedDiscount";
            this.colShortTermDeductedDiscount.OptionsColumn.AllowEdit = false;
            this.colShortTermDeductedDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colShortTermDeductedDiscount.OptionsFilter.AllowAutoFilter = false;
            this.colShortTermDeductedDiscount.OptionsFilter.AllowFilter = false;
            this.colShortTermDeductedDiscount.StatusBarShortcut = "F4 :";
            this.colShortTermDeductedDiscount.StatusBarShortcutStatement = "Hesap Makinesi";
            this.colShortTermDeductedDiscount.StatusBarStatement = "Tutar Giriniz";
            this.colShortTermDeductedDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedDiscount", "{0:c2}")});
            this.colShortTermDeductedDiscount.Visible = true;
            this.colShortTermDeductedDiscount.VisibleIndex = 4;
            this.colShortTermDeductedDiscount.Width = 90;
            // 
            // colNetDiscount
            // 
            this.colNetDiscount.Caption = "Net İndirim";
            this.colNetDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colNetDiscount.FieldName = "NetDiscount";
            this.colNetDiscount.Name = "colNetDiscount";
            this.colNetDiscount.OptionsColumn.AllowEdit = false;
            this.colNetDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetDiscount.OptionsFilter.AllowAutoFilter = false;
            this.colNetDiscount.OptionsFilter.AllowFilter = false;
            this.colNetDiscount.StatusBarShortcut = null;
            this.colNetDiscount.StatusBarShortcutStatement = null;
            this.colNetDiscount.StatusBarStatement = null;
            this.colNetDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetDiscount", "{0:c2}")});
            this.colNetDiscount.Visible = true;
            this.colNetDiscount.VisibleIndex = 5;
            this.colNetDiscount.Width = 90;
            // 
            // colCancellationReasonId
            // 
            this.colCancellationReasonId.Caption = "İptal Nedeni Id";
            this.colCancellationReasonId.FieldName = "CancellationReasonId";
            this.colCancellationReasonId.Name = "colCancellationReasonId";
            this.colCancellationReasonId.OptionsColumn.AllowEdit = false;
            this.colCancellationReasonId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCancellationReasonId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCancellationReasonId.OptionsFilter.AllowAutoFilter = false;
            this.colCancellationReasonId.OptionsFilter.AllowFilter = false;
            this.colCancellationReasonId.StatusBarShortcut = null;
            this.colCancellationReasonId.StatusBarShortcutStatement = null;
            this.colCancellationReasonId.StatusBarStatement = null;
            // 
            // colCancellationReasonName
            // 
            this.colCancellationReasonName.Caption = "İptal Nedeni";
            this.colCancellationReasonName.ColumnEdit = this.repositoryItemCancellationReason;
            this.colCancellationReasonName.FieldName = "CancellationReasonName";
            this.colCancellationReasonName.Name = "colCancellationReasonName";
            this.colCancellationReasonName.OptionsColumn.AllowEdit = false;
            this.colCancellationReasonName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCancellationReasonName.OptionsFilter.AllowAutoFilter = false;
            this.colCancellationReasonName.OptionsFilter.AllowFilter = false;
            this.colCancellationReasonName.StatusBarShortcut = "F4 :";
            this.colCancellationReasonName.StatusBarShortcutStatement = "Seçim Yap";
            this.colCancellationReasonName.StatusBarStatement = "İptal Nedeni Seçiniz";
            this.colCancellationReasonName.Visible = true;
            this.colCancellationReasonName.VisibleIndex = 7;
            this.colCancellationReasonName.Width = 150;
            // 
            // repositoryItemCancellationReason
            // 
            this.repositoryItemCancellationReason.AutoHeight = false;
            this.repositoryItemCancellationReason.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemCancellationReason.Name = "repositoryItemCancellationReason";
            // 
            // colCancellationStatement
            // 
            this.colCancellationStatement.Caption = "İptal Açıklama";
            this.colCancellationStatement.FieldName = "CancellationStatement";
            this.colCancellationStatement.Name = "colCancellationStatement";
            this.colCancellationStatement.OptionsColumn.AllowEdit = false;
            this.colCancellationStatement.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCancellationStatement.OptionsFilter.AllowAutoFilter = false;
            this.colCancellationStatement.OptionsFilter.AllowFilter = false;
            this.colCancellationStatement.StatusBarShortcut = null;
            this.colCancellationStatement.StatusBarShortcutStatement = null;
            this.colCancellationStatement.StatusBarStatement = "İptal Açıklaması Giriniz";
            this.colCancellationStatement.Visible = true;
            this.colCancellationStatement.VisibleIndex = 8;
            this.colCancellationStatement.Width = 300;
            // 
            // DiscountInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "DiscountInformationsTable";
            this.Size = new System.Drawing.Size(722, 372);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationReason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colDiscountName;
        private Grids.MyGridColumn colServiceName;
        private Grids.MyGridColumn colTransactionDate;
        private Grids.MyGridColumn colCancellationDate;
        private Grids.MyGridColumn colGrossDiscount;
        private Grids.MyGridColumn colShortTermDeductedDiscount;
        private Grids.MyGridColumn colNetDiscount;
        private Grids.MyGridColumn colCancellationReasonId;
        private Grids.MyGridColumn colCancellationReasonName;
        private Grids.MyGridColumn colCancellationStatement;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemCancellationDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemCancellationReason;
        private Grids.MyGridColumn colCancelled;
    }
}
