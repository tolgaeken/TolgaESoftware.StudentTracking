namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    partial class MonthlyEnrollmentReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyEnrollmentReport));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colYear = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMonth = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRenewedEnrollment = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCenter = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colNewEnrollment = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTransferEnrollment = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSumOfEnrollment = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGrossService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colShortTermDeductedService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGrossDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colShortTermDeductedDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAverage = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colDiscountPercentage = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemPercent = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOpen = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCheque = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCash = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEpos = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPos = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSps = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIndenture = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSumOfPay = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colRefund = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPaymentBack = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetPayment = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCollected = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOnCollect = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colRemaining = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.btnCreateReport = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MySimpleButton();
            this.txtCancelStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyCheckedComboboxEdit();
            this.txtEnrollmentStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyCheckedComboboxEdit();
            this.txtEnrollmentType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyCheckedComboboxEdit();
            this.txtBranches = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyCheckedComboboxEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCancelStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnrollmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnrollmentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranches.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnSend
            // 
            this.btnSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.Image")));
            this.btnSend.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.LargeImage")));
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.grid);
            this.myDataLayoutControl.Controls.Add(this.longNavigator);
            this.myDataLayoutControl.Controls.Add(this.btnCreateReport);
            this.myDataLayoutControl.Controls.Add(this.txtCancelStatus);
            this.myDataLayoutControl.Controls.Add(this.txtEnrollmentStatus);
            this.myDataLayoutControl.Controls.Add(this.txtEnrollmentType);
            this.myDataLayoutControl.Controls.Add(this.txtBranches);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(1168, 663);
            this.myDataLayoutControl.TabIndex = 7;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(4, 52);
            this.grid.MainView = this.table;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDecimal,
            this.repositoryItemPercent,
            this.repositoryItemCenter});
            this.grid.Size = new System.Drawing.Size(1160, 579);
            this.grid.TabIndex = 10;
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
            this.table.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.table.Appearance.GroupFooter.Options.UseFont = true;
            this.table.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.table.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.table.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.table.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.table.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.table.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.ViewCaption.Options.UseForeColor = true;
            this.table.BandPanelRowHeight = 40;
            this.table.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand6,
            this.gridBand8,
            this.gridBand4,
            this.gridBand7});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colYear,
            this.colMonth,
            this.colRenewedEnrollment,
            this.colNewEnrollment,
            this.colTransferEnrollment,
            this.colSumOfEnrollment,
            this.colGrossService,
            this.colShortTermDeductedService,
            this.colNetService,
            this.colGrossDiscount,
            this.colShortTermDeductedDiscount,
            this.colNetDiscount,
            this.colNetPrice,
            this.colAverage,
            this.colDiscountPercentage,
            this.colOpen,
            this.colCheque,
            this.colCash,
            this.colEpos,
            this.colSps,
            this.colPos,
            this.colIndenture,
            this.colSumOfPay,
            this.colCollected,
            this.colOnCollect,
            this.colRefund,
            this.colPaymentBack,
            this.colNetPayment,
            this.colRemaining});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[CancelStatus]=1";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.table.FormatRules.Add(gridFormatRule1);
            this.table.GridControl = this.grid;
            this.table.GroupCount = 1;
            this.table.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossService", this.colGrossService, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedService", this.colShortTermDeductedService, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetService", this.colNetService, "{0:c2}", "NetService"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossDiscount", this.colGrossDiscount, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedDiscount", this.colShortTermDeductedDiscount, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetDiscount", this.colNetDiscount, "{0:c2}", "NetDiscount"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colNetPrice", this.colNetPrice, "{0:c2}", "NetPrice"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colAverage", this.colAverage, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colDiscountPercentage", this.colDiscountPercentage, "{0:F}%"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Open", this.colOpen, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cheque", this.colCheque, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cash", this.colCash, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Epos", this.colEpos, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sps", this.colSps, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pos", this.colPos, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Indenture", this.colIndenture, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumOfPay", this.colSumOfPay, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Collected", this.colCollected, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OnCollect", this.colOnCollect, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Refund", this.colRefund, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentBack", this.colPaymentBack, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colNetPayment", this.colNetPayment, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colRemaining", this.colRemaining, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RenewedEnrollment", this.colRenewedEnrollment, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NewEnrollment", this.colNewEnrollment, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferEnrollment", this.colTransferEnrollment, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumOfEnrollment", this.colSumOfEnrollment, "{0:n0}", "SumOfEnrollment")});
            this.table.Name = "table";
            this.table.OptionsMenu.EnableColumnMenu = false;
            this.table.OptionsMenu.EnableFooterMenu = false;
            this.table.OptionsMenu.EnableGroupPanelMenu = false;
            this.table.OptionsNavigation.EnterMoveNextColumn = true;
            this.table.OptionsPrint.AutoWidth = false;
            this.table.OptionsView.ColumnAutoWidth = false;
            this.table.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.table.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.table.OptionsView.RowAutoHeight = true;
            this.table.OptionsView.ShowAutoFilterRow = true;
            this.table.OptionsView.ShowFooter = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colYear, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.table.StatusBarShortcut = null;
            this.table.StatusBarShortcutStatement = null;
            this.table.StatusBarStatement = null;
            this.table.ViewCaption = "Aylık Kayıt Raporu";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Tarih Bilgileri";
            this.gridBand2.Columns.Add(this.colYear);
            this.gridBand2.Columns.Add(this.colMonth);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 300;
            // 
            // colYear
            // 
            this.colYear.AppearanceCell.Options.UseTextOptions = true;
            this.colYear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYear.Caption = "Yıl";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.OptionsColumn.AllowEdit = false;
            this.colYear.StatusBarShortcut = null;
            this.colYear.StatusBarShortcutStatement = null;
            this.colYear.StatusBarStatement = null;
            this.colYear.Visible = true;
            this.colYear.Width = 150;
            // 
            // colMonth
            // 
            this.colMonth.Caption = "Ay";
            this.colMonth.FieldName = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.OptionsColumn.AllowEdit = false;
            this.colMonth.StatusBarShortcut = null;
            this.colMonth.StatusBarShortcutStatement = null;
            this.colMonth.StatusBarStatement = null;
            this.colMonth.Visible = true;
            this.colMonth.Width = 150;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Öğrenci Sayısı";
            this.gridBand6.Columns.Add(this.colRenewedEnrollment);
            this.gridBand6.Columns.Add(this.colNewEnrollment);
            this.gridBand6.Columns.Add(this.colTransferEnrollment);
            this.gridBand6.Columns.Add(this.colSumOfEnrollment);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 1;
            this.gridBand6.Width = 600;
            // 
            // colRenewedEnrollment
            // 
            this.colRenewedEnrollment.AppearanceCell.Options.UseTextOptions = true;
            this.colRenewedEnrollment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRenewedEnrollment.Caption = "Kayıt Yenileme";
            this.colRenewedEnrollment.ColumnEdit = this.repositoryItemCenter;
            this.colRenewedEnrollment.FieldName = "RenewedEnrollment";
            this.colRenewedEnrollment.Name = "colRenewedEnrollment";
            this.colRenewedEnrollment.OptionsColumn.AllowEdit = false;
            this.colRenewedEnrollment.StatusBarShortcut = null;
            this.colRenewedEnrollment.StatusBarShortcutStatement = null;
            this.colRenewedEnrollment.StatusBarStatement = null;
            this.colRenewedEnrollment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RenewedEnrollment", "{0:n0}")});
            this.colRenewedEnrollment.Visible = true;
            this.colRenewedEnrollment.Width = 150;
            // 
            // repositoryItemCenter
            // 
            this.repositoryItemCenter.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCenter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCenter.AutoHeight = false;
            this.repositoryItemCenter.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCenter.DisplayFormat.FormatString = "{0:n0}";
            this.repositoryItemCenter.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCenter.EditFormat.FormatString = "{0:n0}";
            this.repositoryItemCenter.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCenter.Name = "repositoryItemCenter";
            // 
            // colNewEnrollment
            // 
            this.colNewEnrollment.AppearanceCell.Options.UseTextOptions = true;
            this.colNewEnrollment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewEnrollment.Caption = "Yeni Kayıt";
            this.colNewEnrollment.ColumnEdit = this.repositoryItemCenter;
            this.colNewEnrollment.FieldName = "NewEnrollment";
            this.colNewEnrollment.Name = "colNewEnrollment";
            this.colNewEnrollment.OptionsColumn.AllowEdit = false;
            this.colNewEnrollment.StatusBarShortcut = null;
            this.colNewEnrollment.StatusBarShortcutStatement = null;
            this.colNewEnrollment.StatusBarStatement = null;
            this.colNewEnrollment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NewEnrollment", "{0:n0}")});
            this.colNewEnrollment.Visible = true;
            this.colNewEnrollment.Width = 150;
            // 
            // colTransferEnrollment
            // 
            this.colTransferEnrollment.AppearanceCell.Options.UseTextOptions = true;
            this.colTransferEnrollment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTransferEnrollment.Caption = "Nakil Kayıt";
            this.colTransferEnrollment.ColumnEdit = this.repositoryItemCenter;
            this.colTransferEnrollment.FieldName = "TransferEnrollment";
            this.colTransferEnrollment.Name = "colTransferEnrollment";
            this.colTransferEnrollment.OptionsColumn.AllowEdit = false;
            this.colTransferEnrollment.StatusBarShortcut = null;
            this.colTransferEnrollment.StatusBarShortcutStatement = null;
            this.colTransferEnrollment.StatusBarStatement = null;
            this.colTransferEnrollment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferEnrollment", "{0:n0}")});
            this.colTransferEnrollment.Visible = true;
            this.colTransferEnrollment.Width = 150;
            // 
            // colSumOfEnrollment
            // 
            this.colSumOfEnrollment.AppearanceCell.Options.UseTextOptions = true;
            this.colSumOfEnrollment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumOfEnrollment.Caption = "Toplam Kayıt";
            this.colSumOfEnrollment.ColumnEdit = this.repositoryItemCenter;
            this.colSumOfEnrollment.FieldName = "SumOfEnrollment";
            this.colSumOfEnrollment.Name = "colSumOfEnrollment";
            this.colSumOfEnrollment.OptionsColumn.AllowEdit = false;
            this.colSumOfEnrollment.StatusBarShortcut = null;
            this.colSumOfEnrollment.StatusBarShortcutStatement = null;
            this.colSumOfEnrollment.StatusBarStatement = null;
            this.colSumOfEnrollment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumOfEnrollment", "{0:n0}")});
            this.colSumOfEnrollment.Visible = true;
            this.colSumOfEnrollment.Width = 150;
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "Ücret Bilgileri";
            this.gridBand8.Columns.Add(this.colGrossService);
            this.gridBand8.Columns.Add(this.colShortTermDeductedService);
            this.gridBand8.Columns.Add(this.colNetService);
            this.gridBand8.Columns.Add(this.colGrossDiscount);
            this.gridBand8.Columns.Add(this.colShortTermDeductedDiscount);
            this.gridBand8.Columns.Add(this.colNetDiscount);
            this.gridBand8.Columns.Add(this.colNetPrice);
            this.gridBand8.Columns.Add(this.colAverage);
            this.gridBand8.Columns.Add(this.colDiscountPercentage);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 2;
            this.gridBand8.Width = 1350;
            // 
            // colGrossService
            // 
            this.colGrossService.Caption = "Brüt Hizmet";
            this.colGrossService.ColumnEdit = this.repositoryItemDecimal;
            this.colGrossService.FieldName = "GrossService";
            this.colGrossService.Name = "colGrossService";
            this.colGrossService.OptionsColumn.AllowEdit = false;
            this.colGrossService.StatusBarShortcut = null;
            this.colGrossService.StatusBarShortcutStatement = null;
            this.colGrossService.StatusBarStatement = null;
            this.colGrossService.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossService", "{0:c2}")});
            this.colGrossService.Visible = true;
            this.colGrossService.Width = 150;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:c2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:c2}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colShortTermDeductedService
            // 
            this.colShortTermDeductedService.Caption = "Kıst Dönem Düşülen Hizmet";
            this.colShortTermDeductedService.ColumnEdit = this.repositoryItemDecimal;
            this.colShortTermDeductedService.FieldName = "ShortTermDeductedService";
            this.colShortTermDeductedService.Name = "colShortTermDeductedService";
            this.colShortTermDeductedService.OptionsColumn.AllowEdit = false;
            this.colShortTermDeductedService.StatusBarShortcut = null;
            this.colShortTermDeductedService.StatusBarShortcutStatement = null;
            this.colShortTermDeductedService.StatusBarStatement = null;
            this.colShortTermDeductedService.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedService", "{0:c2}")});
            this.colShortTermDeductedService.Visible = true;
            this.colShortTermDeductedService.Width = 150;
            // 
            // colNetService
            // 
            this.colNetService.Caption = "Net Hizmet";
            this.colNetService.ColumnEdit = this.repositoryItemDecimal;
            this.colNetService.FieldName = "NetService";
            this.colNetService.Name = "colNetService";
            this.colNetService.OptionsColumn.AllowEdit = false;
            this.colNetService.StatusBarShortcut = null;
            this.colNetService.StatusBarShortcutStatement = null;
            this.colNetService.StatusBarStatement = null;
            this.colNetService.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetService", "{0:c2}")});
            this.colNetService.Visible = true;
            this.colNetService.Width = 150;
            // 
            // colGrossDiscount
            // 
            this.colGrossDiscount.Caption = "Brüt İndirim";
            this.colGrossDiscount.ColumnEdit = this.repositoryItemDecimal;
            this.colGrossDiscount.FieldName = "GrossDiscount";
            this.colGrossDiscount.Name = "colGrossDiscount";
            this.colGrossDiscount.OptionsColumn.AllowEdit = false;
            this.colGrossDiscount.StatusBarShortcut = null;
            this.colGrossDiscount.StatusBarShortcutStatement = null;
            this.colGrossDiscount.StatusBarStatement = null;
            this.colGrossDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossDiscount", "{0:c2}")});
            this.colGrossDiscount.Visible = true;
            this.colGrossDiscount.Width = 150;
            // 
            // colShortTermDeductedDiscount
            // 
            this.colShortTermDeductedDiscount.Caption = "Kıst Dönem Düşülen İndirim";
            this.colShortTermDeductedDiscount.ColumnEdit = this.repositoryItemDecimal;
            this.colShortTermDeductedDiscount.FieldName = "ShortTermDeductedDiscount";
            this.colShortTermDeductedDiscount.Name = "colShortTermDeductedDiscount";
            this.colShortTermDeductedDiscount.OptionsColumn.AllowEdit = false;
            this.colShortTermDeductedDiscount.StatusBarShortcut = null;
            this.colShortTermDeductedDiscount.StatusBarShortcutStatement = null;
            this.colShortTermDeductedDiscount.StatusBarStatement = null;
            this.colShortTermDeductedDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedDiscount", "{0:c2}")});
            this.colShortTermDeductedDiscount.Visible = true;
            this.colShortTermDeductedDiscount.Width = 150;
            // 
            // colNetDiscount
            // 
            this.colNetDiscount.Caption = "Net İndirim";
            this.colNetDiscount.ColumnEdit = this.repositoryItemDecimal;
            this.colNetDiscount.FieldName = "NetDiscount";
            this.colNetDiscount.Name = "colNetDiscount";
            this.colNetDiscount.OptionsColumn.AllowEdit = false;
            this.colNetDiscount.StatusBarShortcut = null;
            this.colNetDiscount.StatusBarShortcutStatement = null;
            this.colNetDiscount.StatusBarStatement = null;
            this.colNetDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetDiscount", "{0:c2}")});
            this.colNetDiscount.Visible = true;
            this.colNetDiscount.Width = 150;
            // 
            // colNetPrice
            // 
            this.colNetPrice.AppearanceCell.BackColor = System.Drawing.Color.AntiqueWhite;
            this.colNetPrice.AppearanceCell.Options.HighPriority = true;
            this.colNetPrice.AppearanceCell.Options.UseBackColor = true;
            this.colNetPrice.Caption = "Net Ücret";
            this.colNetPrice.ColumnEdit = this.repositoryItemDecimal;
            this.colNetPrice.FieldName = "colNetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.OptionsColumn.AllowEdit = false;
            this.colNetPrice.StatusBarShortcut = null;
            this.colNetPrice.StatusBarShortcutStatement = null;
            this.colNetPrice.StatusBarStatement = null;
            this.colNetPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colNetPrice", "{0:c2}")});
            this.colNetPrice.UnboundExpression = "[NetService] - [NetDiscount]";
            this.colNetPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colNetPrice.Visible = true;
            this.colNetPrice.Width = 150;
            // 
            // colAverage
            // 
            this.colAverage.Caption = "Ortalama";
            this.colAverage.ColumnEdit = this.repositoryItemDecimal;
            this.colAverage.FieldName = "colAverage";
            this.colAverage.Name = "colAverage";
            this.colAverage.OptionsColumn.AllowEdit = false;
            this.colAverage.StatusBarShortcut = null;
            this.colAverage.StatusBarShortcutStatement = null;
            this.colAverage.StatusBarStatement = null;
            this.colAverage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colAverage", "{0:c2}")});
            this.colAverage.UnboundExpression = "Iif([SumOfEnrollment] > 0, ([NetService] - [NetDiscount]) / [SumOfEnrollment], 0)" +
    "";
            this.colAverage.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colAverage.Visible = true;
            this.colAverage.Width = 150;
            // 
            // colDiscountPercentage
            // 
            this.colDiscountPercentage.Caption = "İndirim Oranı";
            this.colDiscountPercentage.ColumnEdit = this.repositoryItemPercent;
            this.colDiscountPercentage.FieldName = "colDiscountPercentage";
            this.colDiscountPercentage.Name = "colDiscountPercentage";
            this.colDiscountPercentage.OptionsColumn.AllowEdit = false;
            this.colDiscountPercentage.StatusBarShortcut = null;
            this.colDiscountPercentage.StatusBarShortcutStatement = null;
            this.colDiscountPercentage.StatusBarStatement = null;
            this.colDiscountPercentage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colDiscountPercentage", "{0:F}%")});
            this.colDiscountPercentage.UnboundExpression = "Iif([NetService] = 0, 0, [NetDiscount] / [NetService] * 100)";
            this.colDiscountPercentage.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDiscountPercentage.Visible = true;
            this.colDiscountPercentage.Width = 150;
            // 
            // repositoryItemPercent
            // 
            this.repositoryItemPercent.Appearance.Options.UseTextOptions = true;
            this.repositoryItemPercent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemPercent.AutoHeight = false;
            this.repositoryItemPercent.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPercent.DisplayFormat.FormatString = "{0:F}%";
            this.repositoryItemPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPercent.EditFormat.FormatString = "{0:F}%";
            this.repositoryItemPercent.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPercent.Name = "repositoryItemPercent";
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ödeme Bilgileri";
            this.gridBand4.Columns.Add(this.colOpen);
            this.gridBand4.Columns.Add(this.colCheque);
            this.gridBand4.Columns.Add(this.colCash);
            this.gridBand4.Columns.Add(this.colEpos);
            this.gridBand4.Columns.Add(this.colPos);
            this.gridBand4.Columns.Add(this.colSps);
            this.gridBand4.Columns.Add(this.colIndenture);
            this.gridBand4.Columns.Add(this.colSumOfPay);
            this.gridBand4.Columns.Add(this.colRefund);
            this.gridBand4.Columns.Add(this.colPaymentBack);
            this.gridBand4.Columns.Add(this.colNetPayment);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 1650;
            // 
            // colOpen
            // 
            this.colOpen.Caption = "Açık";
            this.colOpen.ColumnEdit = this.repositoryItemDecimal;
            this.colOpen.FieldName = "Open";
            this.colOpen.Name = "colOpen";
            this.colOpen.OptionsColumn.AllowEdit = false;
            this.colOpen.StatusBarShortcut = null;
            this.colOpen.StatusBarShortcutStatement = null;
            this.colOpen.StatusBarStatement = null;
            this.colOpen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Open", "{0:c2}")});
            this.colOpen.Visible = true;
            this.colOpen.Width = 150;
            // 
            // colCheque
            // 
            this.colCheque.Caption = "Çek";
            this.colCheque.ColumnEdit = this.repositoryItemDecimal;
            this.colCheque.FieldName = "Cheque";
            this.colCheque.Name = "colCheque";
            this.colCheque.OptionsColumn.AllowEdit = false;
            this.colCheque.StatusBarShortcut = null;
            this.colCheque.StatusBarShortcutStatement = null;
            this.colCheque.StatusBarStatement = null;
            this.colCheque.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cheque", "{0:c2}")});
            this.colCheque.Visible = true;
            this.colCheque.Width = 150;
            // 
            // colCash
            // 
            this.colCash.Caption = "Nakit";
            this.colCash.ColumnEdit = this.repositoryItemDecimal;
            this.colCash.FieldName = "Cash";
            this.colCash.Name = "colCash";
            this.colCash.OptionsColumn.AllowEdit = false;
            this.colCash.StatusBarShortcut = null;
            this.colCash.StatusBarShortcutStatement = null;
            this.colCash.StatusBarStatement = null;
            this.colCash.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cash", "{0:c2}")});
            this.colCash.Visible = true;
            this.colCash.Width = 150;
            // 
            // colEpos
            // 
            this.colEpos.Caption = "Epos";
            this.colEpos.ColumnEdit = this.repositoryItemDecimal;
            this.colEpos.FieldName = "Epos";
            this.colEpos.Name = "colEpos";
            this.colEpos.OptionsColumn.AllowEdit = false;
            this.colEpos.StatusBarShortcut = null;
            this.colEpos.StatusBarShortcutStatement = null;
            this.colEpos.StatusBarStatement = null;
            this.colEpos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Epos", "{0:c2}")});
            this.colEpos.Visible = true;
            this.colEpos.Width = 150;
            // 
            // colPos
            // 
            this.colPos.Caption = "Pos";
            this.colPos.ColumnEdit = this.repositoryItemDecimal;
            this.colPos.FieldName = "Pos";
            this.colPos.Name = "colPos";
            this.colPos.OptionsColumn.AllowEdit = false;
            this.colPos.StatusBarShortcut = null;
            this.colPos.StatusBarShortcutStatement = null;
            this.colPos.StatusBarStatement = null;
            this.colPos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pos", "{0:c2}")});
            this.colPos.Visible = true;
            this.colPos.Width = 150;
            // 
            // colSps
            // 
            this.colSps.Caption = "Ots";
            this.colSps.ColumnEdit = this.repositoryItemDecimal;
            this.colSps.FieldName = "Sps";
            this.colSps.Name = "colSps";
            this.colSps.OptionsColumn.AllowEdit = false;
            this.colSps.StatusBarShortcut = null;
            this.colSps.StatusBarShortcutStatement = null;
            this.colSps.StatusBarStatement = null;
            this.colSps.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sps", "{0:c2}")});
            this.colSps.Visible = true;
            this.colSps.Width = 150;
            // 
            // colIndenture
            // 
            this.colIndenture.Caption = "Senet";
            this.colIndenture.ColumnEdit = this.repositoryItemDecimal;
            this.colIndenture.FieldName = "Indenture";
            this.colIndenture.Name = "colIndenture";
            this.colIndenture.OptionsColumn.AllowEdit = false;
            this.colIndenture.StatusBarShortcut = null;
            this.colIndenture.StatusBarShortcutStatement = null;
            this.colIndenture.StatusBarStatement = null;
            this.colIndenture.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Indenture", "{0:c2}")});
            this.colIndenture.Visible = true;
            this.colIndenture.Width = 150;
            // 
            // colSumOfPay
            // 
            this.colSumOfPay.AppearanceCell.BackColor = System.Drawing.Color.AntiqueWhite;
            this.colSumOfPay.AppearanceCell.Options.HighPriority = true;
            this.colSumOfPay.AppearanceCell.Options.UseBackColor = true;
            this.colSumOfPay.Caption = "Toplam Ödeme";
            this.colSumOfPay.ColumnEdit = this.repositoryItemDecimal;
            this.colSumOfPay.CustomizationCaption = "Toplam Ödeme Planı Toplamı";
            this.colSumOfPay.FieldName = "SumOfPay";
            this.colSumOfPay.Name = "colSumOfPay";
            this.colSumOfPay.OptionsColumn.AllowEdit = false;
            this.colSumOfPay.StatusBarShortcut = null;
            this.colSumOfPay.StatusBarShortcutStatement = null;
            this.colSumOfPay.StatusBarStatement = null;
            this.colSumOfPay.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumOfPay", "{0:c2}")});
            this.colSumOfPay.Visible = true;
            this.colSumOfPay.Width = 150;
            // 
            // colRefund
            // 
            this.colRefund.Caption = "Geri İade";
            this.colRefund.ColumnEdit = this.repositoryItemDecimal;
            this.colRefund.FieldName = "Refund";
            this.colRefund.Name = "colRefund";
            this.colRefund.OptionsColumn.AllowEdit = false;
            this.colRefund.StatusBarShortcut = null;
            this.colRefund.StatusBarShortcutStatement = null;
            this.colRefund.StatusBarStatement = null;
            this.colRefund.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Refund", "{0:c2}")});
            this.colRefund.Visible = true;
            this.colRefund.Width = 150;
            // 
            // colPaymentBack
            // 
            this.colPaymentBack.Caption = "Geri Ödeme";
            this.colPaymentBack.ColumnEdit = this.repositoryItemDecimal;
            this.colPaymentBack.FieldName = "PaymentBack";
            this.colPaymentBack.Name = "colPaymentBack";
            this.colPaymentBack.OptionsColumn.AllowEdit = false;
            this.colPaymentBack.StatusBarShortcut = null;
            this.colPaymentBack.StatusBarShortcutStatement = null;
            this.colPaymentBack.StatusBarStatement = null;
            this.colPaymentBack.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentBack", "{0:c2}")});
            this.colPaymentBack.Visible = true;
            this.colPaymentBack.Width = 150;
            // 
            // colNetPayment
            // 
            this.colNetPayment.AppearanceCell.BackColor = System.Drawing.Color.AntiqueWhite;
            this.colNetPayment.AppearanceCell.Options.HighPriority = true;
            this.colNetPayment.AppearanceCell.Options.UseBackColor = true;
            this.colNetPayment.Caption = "Net Ödeme";
            this.colNetPayment.ColumnEdit = this.repositoryItemDecimal;
            this.colNetPayment.FieldName = "colNetPayment";
            this.colNetPayment.Name = "colNetPayment";
            this.colNetPayment.OptionsColumn.AllowEdit = false;
            this.colNetPayment.StatusBarShortcut = null;
            this.colNetPayment.StatusBarShortcutStatement = null;
            this.colNetPayment.StatusBarStatement = null;
            this.colNetPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colNetPayment", "{0:c2}")});
            this.colNetPayment.UnboundExpression = "[SumOfPay] - [PaymentBack]";
            this.colNetPayment.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colNetPayment.Visible = true;
            this.colNetPayment.Width = 150;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "Tahsilat Bilgileri";
            this.gridBand7.Columns.Add(this.colCollected);
            this.gridBand7.Columns.Add(this.colOnCollect);
            this.gridBand7.Columns.Add(this.colRemaining);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 4;
            this.gridBand7.Width = 450;
            // 
            // colCollected
            // 
            this.colCollected.Caption = "Tahsil Edilen";
            this.colCollected.ColumnEdit = this.repositoryItemDecimal;
            this.colCollected.FieldName = "Collected";
            this.colCollected.Name = "colCollected";
            this.colCollected.OptionsColumn.AllowEdit = false;
            this.colCollected.StatusBarShortcut = null;
            this.colCollected.StatusBarShortcutStatement = null;
            this.colCollected.StatusBarStatement = null;
            this.colCollected.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Collected", "{0:c2}")});
            this.colCollected.Visible = true;
            this.colCollected.Width = 150;
            // 
            // colOnCollect
            // 
            this.colOnCollect.Caption = "Tahsilde";
            this.colOnCollect.ColumnEdit = this.repositoryItemDecimal;
            this.colOnCollect.FieldName = "OnCollect";
            this.colOnCollect.Name = "colOnCollect";
            this.colOnCollect.OptionsColumn.AllowEdit = false;
            this.colOnCollect.StatusBarShortcut = null;
            this.colOnCollect.StatusBarShortcutStatement = null;
            this.colOnCollect.StatusBarStatement = null;
            this.colOnCollect.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OnCollect", "{0:c2}")});
            this.colOnCollect.Visible = true;
            this.colOnCollect.Width = 150;
            // 
            // colRemaining
            // 
            this.colRemaining.AppearanceCell.BackColor = System.Drawing.Color.AntiqueWhite;
            this.colRemaining.AppearanceCell.Options.HighPriority = true;
            this.colRemaining.AppearanceCell.Options.UseBackColor = true;
            this.colRemaining.Caption = "Kalan";
            this.colRemaining.ColumnEdit = this.repositoryItemDecimal;
            this.colRemaining.FieldName = "colRemaining";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.OptionsColumn.AllowEdit = false;
            this.colRemaining.StatusBarShortcut = null;
            this.colRemaining.StatusBarShortcutStatement = null;
            this.colRemaining.StatusBarStatement = null;
            this.colRemaining.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colRemaining", "{0:c2}")});
            this.colRemaining.UnboundExpression = "[SumOfPay] - ([Collected] + [Refund])";
            this.colRemaining.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRemaining.Visible = true;
            this.colRemaining.Width = 150;
            // 
            // longNavigator
            // 
            this.longNavigator.Location = new System.Drawing.Point(4, 635);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1160, 24);
            this.longNavigator.TabIndex = 9;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCreateReport.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateReport.Appearance.Options.UseFont = true;
            this.btnCreateReport.Appearance.Options.UseForeColor = true;
            this.btnCreateReport.Location = new System.Drawing.Point(939, 28);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(96, 20);
            this.btnCreateReport.StatusBarStatement = null;
            this.btnCreateReport.StyleController = this.myDataLayoutControl;
            this.btnCreateReport.TabIndex = 8;
            this.btnCreateReport.Text = "Rapor Hazırla";
            // 
            // txtCancelStatus
            // 
            this.txtCancelStatus.EnterMoveNextControl = true;
            this.txtCancelStatus.Location = new System.Drawing.Point(714, 4);
            this.txtCancelStatus.MenuManager = this.ribbonControl;
            this.txtCancelStatus.Name = "txtCancelStatus";
            this.txtCancelStatus.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtCancelStatus.Properties.Appearance.Options.UseBackColor = true;
            this.txtCancelStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCancelStatus.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCancelStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCancelStatus.Size = new System.Drawing.Size(321, 20);
            this.txtCancelStatus.StatusBarShortcut = "F4 : ";
            this.txtCancelStatus.StatusBarShortcutStatement = null;
            this.txtCancelStatus.StatusBarStatement = null;
            this.txtCancelStatus.StyleController = this.myDataLayoutControl;
            this.txtCancelStatus.TabIndex = 7;
            // 
            // txtEnrollmentStatus
            // 
            this.txtEnrollmentStatus.EnterMoveNextControl = true;
            this.txtEnrollmentStatus.Location = new System.Drawing.Point(384, 28);
            this.txtEnrollmentStatus.MenuManager = this.ribbonControl;
            this.txtEnrollmentStatus.Name = "txtEnrollmentStatus";
            this.txtEnrollmentStatus.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtEnrollmentStatus.Properties.Appearance.Options.UseBackColor = true;
            this.txtEnrollmentStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEnrollmentStatus.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEnrollmentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEnrollmentStatus.Size = new System.Drawing.Size(216, 20);
            this.txtEnrollmentStatus.StatusBarShortcut = "F4 : ";
            this.txtEnrollmentStatus.StatusBarShortcutStatement = null;
            this.txtEnrollmentStatus.StatusBarStatement = null;
            this.txtEnrollmentStatus.StyleController = this.myDataLayoutControl;
            this.txtEnrollmentStatus.TabIndex = 6;
            // 
            // txtEnrollmentType
            // 
            this.txtEnrollmentType.EnterMoveNextControl = true;
            this.txtEnrollmentType.Location = new System.Drawing.Point(84, 28);
            this.txtEnrollmentType.MenuManager = this.ribbonControl;
            this.txtEnrollmentType.Name = "txtEnrollmentType";
            this.txtEnrollmentType.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtEnrollmentType.Properties.Appearance.Options.UseBackColor = true;
            this.txtEnrollmentType.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEnrollmentType.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEnrollmentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEnrollmentType.Size = new System.Drawing.Size(216, 20);
            this.txtEnrollmentType.StatusBarShortcut = "F4 : ";
            this.txtEnrollmentType.StatusBarShortcutStatement = null;
            this.txtEnrollmentType.StatusBarStatement = null;
            this.txtEnrollmentType.StyleController = this.myDataLayoutControl;
            this.txtEnrollmentType.TabIndex = 5;
            // 
            // txtBranches
            // 
            this.txtBranches.EnterMoveNextControl = true;
            this.txtBranches.Location = new System.Drawing.Point(84, 4);
            this.txtBranches.MenuManager = this.ribbonControl;
            this.txtBranches.Name = "txtBranches";
            this.txtBranches.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtBranches.Properties.Appearance.Options.UseBackColor = true;
            this.txtBranches.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBranches.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBranches.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBranches.Size = new System.Drawing.Size(516, 20);
            this.txtBranches.StatusBarShortcut = "F4 : ";
            this.txtBranches.StatusBarShortcutStatement = null;
            this.txtBranches.StatusBarStatement = null;
            this.txtBranches.StyleController = this.myDataLayoutControl;
            this.txtBranches.TabIndex = 4;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 300D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 300D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 30D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 275D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition5.Width = 30D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 100D;
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition7.Width = 100D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5,
            columnDefinition6,
            columnDefinition7});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition4.Height = 28D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup.Size = new System.Drawing.Size(1168, 663);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.Control = this.txtBranches;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(600, 24);
            this.layoutControlItem1.Text = "Şubeler";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.Control = this.txtEnrollmentType;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem2.Text = "Kayıt Şekli";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.Control = this.txtEnrollmentStatus;
            this.layoutControlItem3.Location = new System.Drawing.Point(300, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem3.Text = "Kayıt Durumu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.Control = this.txtCancelStatus;
            this.layoutControlItem4.Location = new System.Drawing.Point(630, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(405, 24);
            this.layoutControlItem4.Text = "İptal Durumu";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.Control = this.btnCreateReport;
            this.layoutControlItem5.Location = new System.Drawing.Point(935, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 5;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(100, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.Control = this.longNavigator;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 631);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(201, 28);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 7;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(1164, 28);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.Control = this.grid;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnSpan = 7;
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem7.Size = new System.Drawing.Size(1164, 583);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // MonthlyEnrollmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "MonthlyEnrollmentReport";
            this.Text = "Aylık Kayıt Raporu";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCancelStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnrollmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnrollmentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranches.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView table;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn colYear;
        private UserControls.Grids.MyBandedGridColumn colMonth;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private UserControls.Grids.MyBandedGridColumn colRenewedEnrollment;
        private UserControls.Grids.MyBandedGridColumn colNewEnrollment;
        private UserControls.Grids.MyBandedGridColumn colTransferEnrollment;
        private UserControls.Grids.MyBandedGridColumn colSumOfEnrollment;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private UserControls.Grids.MyBandedGridColumn colGrossService;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private UserControls.Grids.MyBandedGridColumn colShortTermDeductedService;
        private UserControls.Grids.MyBandedGridColumn colNetService;
        private UserControls.Grids.MyBandedGridColumn colGrossDiscount;
        private UserControls.Grids.MyBandedGridColumn colShortTermDeductedDiscount;
        private UserControls.Grids.MyBandedGridColumn colNetDiscount;
        private UserControls.Grids.MyBandedGridColumn colNetPrice;
        private UserControls.Grids.MyBandedGridColumn colAverage;
        private UserControls.Grids.MyBandedGridColumn colDiscountPercentage;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemPercent;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grids.MyBandedGridColumn colOpen;
        private UserControls.Grids.MyBandedGridColumn colCheque;
        private UserControls.Grids.MyBandedGridColumn colCash;
        private UserControls.Grids.MyBandedGridColumn colEpos;
        private UserControls.Grids.MyBandedGridColumn colPos;
        private UserControls.Grids.MyBandedGridColumn colSps;
        private UserControls.Grids.MyBandedGridColumn colIndenture;
        private UserControls.Grids.MyBandedGridColumn colSumOfPay;
        private UserControls.Grids.MyBandedGridColumn colRefund;
        private UserControls.Grids.MyBandedGridColumn colPaymentBack;
        private UserControls.Grids.MyBandedGridColumn colNetPayment;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private UserControls.Grids.MyBandedGridColumn colCollected;
        private UserControls.Grids.MyBandedGridColumn colOnCollect;
        private UserControls.Grids.MyBandedGridColumn colRemaining;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Controls.MySimpleButton btnCreateReport;
        private UserControls.Controls.MyCheckedComboboxEdit txtCancelStatus;
        private UserControls.Controls.MyCheckedComboboxEdit txtEnrollmentStatus;
        private UserControls.Controls.MyCheckedComboboxEdit txtEnrollmentType;
        private UserControls.Controls.MyCheckedComboboxEdit txtBranches;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCenter;
    }
}