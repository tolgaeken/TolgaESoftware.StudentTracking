﻿namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    partial class PriceAndPaymentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceAndPaymentReport));
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
            this.colCancelStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.myDataLayoutControl = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStudentNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSchoolNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTrIdentityNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colClassName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGender = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPhone = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colForeignLanguageName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colComesFromSchool = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuideName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colQuotaType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIncentName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRegistrationDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEnrollmentType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEnrollmentStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGuardianshipName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuardianshipLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuardianshipVocation = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuardianshipKinship = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuardianshipWorkplaceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuardianshipJobName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGrossService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colShortTermDeductedService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGrossDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colShortTermDeductedDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
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
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode3 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode4 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode5 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
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
            // colCancelStatus
            // 
            this.colCancelStatus.Caption = "İptal Durumu";
            this.colCancelStatus.FieldName = "CancelStatus";
            this.colCancelStatus.Name = "colCancelStatus";
            this.colCancelStatus.OptionsColumn.AllowEdit = false;
            this.colCancelStatus.OptionsColumn.AllowShowHide = false;
            this.colCancelStatus.OptionsColumn.ShowInCustomizationForm = false;
            this.colCancelStatus.StatusBarShortcut = null;
            this.colCancelStatus.StatusBarShortcutStatement = null;
            this.colCancelStatus.StatusBarStatement = null;
            this.colCancelStatus.Width = 150;
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
            this.myDataLayoutControl.TabIndex = 5;
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
            this.repositoryItemDate});
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
            this.table.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.table.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.table.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.table.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.ViewCaption.Options.UseForeColor = true;
            this.table.BandPanelRowHeight = 40;
            this.table.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand3,
            this.gridBand9,
            this.gridBand8,
            this.gridBand4,
            this.gridBand7,
            this.gridBand2,
            this.gridBand6});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colStudentNumber,
            this.colSchoolNumber,
            this.colTrIdentityNumber,
            this.colName,
            this.colLastname,
            this.colGender,
            this.colRegistrationDate,
            this.colCancelStatus,
            this.colEnrollmentType,
            this.colEnrollmentStatus,
            this.colClassName,
            this.colComesFromSchool,
            this.colQuotaType,
            this.colForeignLanguageName,
            this.colGuideName,
            this.colIncentName,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colSpecialCode3,
            this.colSpecialCode4,
            this.colSpecialCode5,
            this.colPhone,
            this.colBranchName,
            this.colGuardianshipName,
            this.colGuardianshipLastname,
            this.colGuardianshipKinship,
            this.colGuardianshipVocation,
            this.colGuardianshipWorkplaceName,
            this.colGuardianshipJobName,
            this.colGrossService,
            this.colShortTermDeductedService,
            this.colNetService,
            this.colGrossDiscount,
            this.colShortTermDeductedDiscount,
            this.colNetDiscount,
            this.colNetPrice,
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
            gridFormatRule1.Column = this.colCancelStatus;
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
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetPrice", this.colNetPrice, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "DiscountPercentage", this.colDiscountPercentage, "{0:F}%"),
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
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetPayment", this.colNetPayment, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Remaining", this.colRemaining, "{0:c2}")});
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBranchName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.table.StatusBarShortcut = null;
            this.table.StatusBarShortcutStatement = null;
            this.table.StatusBarStatement = null;
            this.table.ViewCaption = "Ücret ve Ödeme Raporu";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colStudentNumber);
            this.gridBand1.Columns.Add(this.colSchoolNumber);
            this.gridBand1.Columns.Add(this.colTrIdentityNumber);
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Columns.Add(this.colLastname);
            this.gridBand1.Columns.Add(this.colClassName);
            this.gridBand1.Columns.Add(this.colGender);
            this.gridBand1.Columns.Add(this.colPhone);
            this.gridBand1.Columns.Add(this.colForeignLanguageName);
            this.gridBand1.Columns.Add(this.colComesFromSchool);
            this.gridBand1.Columns.Add(this.colGuideName);
            this.gridBand1.Columns.Add(this.colQuotaType);
            this.gridBand1.Columns.Add(this.colIncentName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1950;
            // 
            // colStudentNumber
            // 
            this.colStudentNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colStudentNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStudentNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colStudentNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStudentNumber.Caption = "Öğrenci No";
            this.colStudentNumber.FieldName = "StudentNumber";
            this.colStudentNumber.Name = "colStudentNumber";
            this.colStudentNumber.OptionsColumn.AllowEdit = false;
            this.colStudentNumber.StatusBarShortcut = null;
            this.colStudentNumber.StatusBarShortcutStatement = null;
            this.colStudentNumber.StatusBarStatement = null;
            this.colStudentNumber.Visible = true;
            this.colStudentNumber.Width = 150;
            // 
            // colSchoolNumber
            // 
            this.colSchoolNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colSchoolNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSchoolNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colSchoolNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSchoolNumber.Caption = "Okul No";
            this.colSchoolNumber.FieldName = "SchoolNumber";
            this.colSchoolNumber.Name = "colSchoolNumber";
            this.colSchoolNumber.OptionsColumn.AllowEdit = false;
            this.colSchoolNumber.StatusBarShortcut = null;
            this.colSchoolNumber.StatusBarShortcutStatement = null;
            this.colSchoolNumber.StatusBarStatement = null;
            this.colSchoolNumber.Visible = true;
            this.colSchoolNumber.Width = 150;
            // 
            // colTrIdentityNumber
            // 
            this.colTrIdentityNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colTrIdentityNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrIdentityNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrIdentityNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrIdentityNumber.Caption = "TC Kimlik No";
            this.colTrIdentityNumber.CustomizationCaption = "Öğrenci TC Kimlik No";
            this.colTrIdentityNumber.FieldName = "TrIdentityNumber";
            this.colTrIdentityNumber.Name = "colTrIdentityNumber";
            this.colTrIdentityNumber.OptionsColumn.AllowEdit = false;
            this.colTrIdentityNumber.StatusBarShortcut = null;
            this.colTrIdentityNumber.StatusBarShortcutStatement = null;
            this.colTrIdentityNumber.StatusBarStatement = null;
            this.colTrIdentityNumber.Visible = true;
            this.colTrIdentityNumber.Width = 150;
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.CustomizationCaption = "Öğrenci Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.StatusBarShortcut = null;
            this.colName.StatusBarShortcutStatement = null;
            this.colName.StatusBarStatement = null;
            this.colName.Visible = true;
            this.colName.Width = 150;
            // 
            // colLastname
            // 
            this.colLastname.Caption = "Soyadı";
            this.colLastname.CustomizationCaption = "Öğrenci Soyadı";
            this.colLastname.FieldName = "Lastname";
            this.colLastname.Name = "colLastname";
            this.colLastname.OptionsColumn.AllowEdit = false;
            this.colLastname.StatusBarShortcut = null;
            this.colLastname.StatusBarShortcutStatement = null;
            this.colLastname.StatusBarStatement = null;
            this.colLastname.Visible = true;
            this.colLastname.Width = 150;
            // 
            // colClassName
            // 
            this.colClassName.Caption = "Sınıf Adı";
            this.colClassName.FieldName = "ClassName";
            this.colClassName.Name = "colClassName";
            this.colClassName.OptionsColumn.AllowEdit = false;
            this.colClassName.StatusBarShortcut = null;
            this.colClassName.StatusBarShortcutStatement = null;
            this.colClassName.StatusBarStatement = null;
            this.colClassName.Visible = true;
            this.colClassName.Width = 150;
            // 
            // colGender
            // 
            this.colGender.Caption = "Cinsiyet";
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowEdit = false;
            this.colGender.StatusBarShortcut = null;
            this.colGender.StatusBarShortcutStatement = null;
            this.colGender.StatusBarStatement = null;
            this.colGender.Visible = true;
            this.colGender.Width = 150;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Telefon";
            this.colPhone.CustomizationCaption = "Öğrenci Telefon";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.StatusBarShortcut = null;
            this.colPhone.StatusBarShortcutStatement = null;
            this.colPhone.StatusBarStatement = null;
            this.colPhone.Visible = true;
            this.colPhone.Width = 150;
            // 
            // colForeignLanguageName
            // 
            this.colForeignLanguageName.Caption = "Yabancı Dil";
            this.colForeignLanguageName.FieldName = "ForeignLanguageName";
            this.colForeignLanguageName.Name = "colForeignLanguageName";
            this.colForeignLanguageName.OptionsColumn.AllowEdit = false;
            this.colForeignLanguageName.StatusBarShortcut = null;
            this.colForeignLanguageName.StatusBarShortcutStatement = null;
            this.colForeignLanguageName.StatusBarStatement = null;
            this.colForeignLanguageName.Visible = true;
            this.colForeignLanguageName.Width = 150;
            // 
            // colComesFromSchool
            // 
            this.colComesFromSchool.Caption = "Geldiği Okul";
            this.colComesFromSchool.FieldName = "ComesFromSchool";
            this.colComesFromSchool.Name = "colComesFromSchool";
            this.colComesFromSchool.OptionsColumn.AllowEdit = false;
            this.colComesFromSchool.StatusBarShortcut = null;
            this.colComesFromSchool.StatusBarShortcutStatement = null;
            this.colComesFromSchool.StatusBarStatement = null;
            this.colComesFromSchool.Visible = true;
            this.colComesFromSchool.Width = 150;
            // 
            // colGuideName
            // 
            this.colGuideName.Caption = "Rehber Öğretmen";
            this.colGuideName.FieldName = "GuideName";
            this.colGuideName.Name = "colGuideName";
            this.colGuideName.OptionsColumn.AllowEdit = false;
            this.colGuideName.StatusBarShortcut = null;
            this.colGuideName.StatusBarShortcutStatement = null;
            this.colGuideName.StatusBarStatement = null;
            this.colGuideName.Visible = true;
            this.colGuideName.Width = 150;
            // 
            // colQuotaType
            // 
            this.colQuotaType.Caption = "Kontenjan Türü";
            this.colQuotaType.FieldName = "QuotaType";
            this.colQuotaType.Name = "colQuotaType";
            this.colQuotaType.OptionsColumn.AllowEdit = false;
            this.colQuotaType.StatusBarShortcut = null;
            this.colQuotaType.StatusBarShortcutStatement = null;
            this.colQuotaType.StatusBarStatement = null;
            this.colQuotaType.Visible = true;
            this.colQuotaType.Width = 150;
            // 
            // colIncentName
            // 
            this.colIncentName.Caption = "Teşvik";
            this.colIncentName.FieldName = "IncentName";
            this.colIncentName.Name = "colIncentName";
            this.colIncentName.OptionsColumn.AllowEdit = false;
            this.colIncentName.StatusBarShortcut = null;
            this.colIncentName.StatusBarShortcutStatement = null;
            this.colIncentName.StatusBarStatement = null;
            this.colIncentName.Visible = true;
            this.colIncentName.Width = 150;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Kayıt Bilgileri";
            this.gridBand3.Columns.Add(this.colRegistrationDate);
            this.gridBand3.Columns.Add(this.colEnrollmentType);
            this.gridBand3.Columns.Add(this.colEnrollmentStatus);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 1;
            this.gridBand3.Width = 450;
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colRegistrationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegistrationDate.Caption = "Kayıt Tarihi";
            this.colRegistrationDate.ColumnEdit = this.repositoryItemDate;
            this.colRegistrationDate.CustomizationCaption = "Öğrenci Kayıt Tarihi";
            this.colRegistrationDate.FieldName = "RegistrationDate";
            this.colRegistrationDate.Name = "colRegistrationDate";
            this.colRegistrationDate.OptionsColumn.AllowEdit = false;
            this.colRegistrationDate.StatusBarShortcut = null;
            this.colRegistrationDate.StatusBarShortcutStatement = null;
            this.colRegistrationDate.StatusBarStatement = null;
            this.colRegistrationDate.Visible = true;
            this.colRegistrationDate.Width = 150;
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
            // colEnrollmentType
            // 
            this.colEnrollmentType.Caption = "Kayıt Şekli";
            this.colEnrollmentType.FieldName = "EnrollmentType";
            this.colEnrollmentType.Name = "colEnrollmentType";
            this.colEnrollmentType.OptionsColumn.AllowEdit = false;
            this.colEnrollmentType.StatusBarShortcut = null;
            this.colEnrollmentType.StatusBarShortcutStatement = null;
            this.colEnrollmentType.StatusBarStatement = null;
            this.colEnrollmentType.Visible = true;
            this.colEnrollmentType.Width = 150;
            // 
            // colEnrollmentStatus
            // 
            this.colEnrollmentStatus.Caption = "Kayıt Durumu";
            this.colEnrollmentStatus.FieldName = "EnrollmentStatus";
            this.colEnrollmentStatus.Name = "colEnrollmentStatus";
            this.colEnrollmentStatus.OptionsColumn.AllowEdit = false;
            this.colEnrollmentStatus.StatusBarShortcut = null;
            this.colEnrollmentStatus.StatusBarShortcutStatement = null;
            this.colEnrollmentStatus.StatusBarStatement = null;
            this.colEnrollmentStatus.Visible = true;
            this.colEnrollmentStatus.Width = 150;
            // 
            // gridBand9
            // 
            this.gridBand9.Caption = "Veli Bilgileri";
            this.gridBand9.Columns.Add(this.colGuardianshipName);
            this.gridBand9.Columns.Add(this.colGuardianshipLastname);
            this.gridBand9.Columns.Add(this.colGuardianshipVocation);
            this.gridBand9.Columns.Add(this.colGuardianshipKinship);
            this.gridBand9.Columns.Add(this.colGuardianshipWorkplaceName);
            this.gridBand9.Columns.Add(this.colGuardianshipJobName);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 2;
            this.gridBand9.Width = 900;
            // 
            // colGuardianshipName
            // 
            this.colGuardianshipName.Caption = "Adı";
            this.colGuardianshipName.CustomizationCaption = "Veli Adı";
            this.colGuardianshipName.FieldName = "GuardianshipName";
            this.colGuardianshipName.Name = "colGuardianshipName";
            this.colGuardianshipName.OptionsColumn.AllowEdit = false;
            this.colGuardianshipName.StatusBarShortcut = null;
            this.colGuardianshipName.StatusBarShortcutStatement = null;
            this.colGuardianshipName.StatusBarStatement = null;
            this.colGuardianshipName.Visible = true;
            this.colGuardianshipName.Width = 150;
            // 
            // colGuardianshipLastname
            // 
            this.colGuardianshipLastname.Caption = "Soyadı";
            this.colGuardianshipLastname.CustomizationCaption = "Veli Soyadı";
            this.colGuardianshipLastname.FieldName = "GuardianshipLastname";
            this.colGuardianshipLastname.Name = "colGuardianshipLastname";
            this.colGuardianshipLastname.OptionsColumn.AllowEdit = false;
            this.colGuardianshipLastname.StatusBarShortcut = null;
            this.colGuardianshipLastname.StatusBarShortcutStatement = null;
            this.colGuardianshipLastname.StatusBarStatement = null;
            this.colGuardianshipLastname.Visible = true;
            this.colGuardianshipLastname.Width = 150;
            // 
            // colGuardianshipVocation
            // 
            this.colGuardianshipVocation.Caption = "Meslek";
            this.colGuardianshipVocation.CustomizationCaption = "Veli Meslek";
            this.colGuardianshipVocation.FieldName = "GuardianshipVocationName";
            this.colGuardianshipVocation.Name = "colGuardianshipVocation";
            this.colGuardianshipVocation.OptionsColumn.AllowEdit = false;
            this.colGuardianshipVocation.StatusBarShortcut = null;
            this.colGuardianshipVocation.StatusBarShortcutStatement = null;
            this.colGuardianshipVocation.StatusBarStatement = null;
            this.colGuardianshipVocation.Visible = true;
            this.colGuardianshipVocation.Width = 150;
            // 
            // colGuardianshipKinship
            // 
            this.colGuardianshipKinship.Caption = "Yakınlık";
            this.colGuardianshipKinship.CustomizationCaption = "Veli Yakınlık";
            this.colGuardianshipKinship.FieldName = "GuardianshipKinshipName";
            this.colGuardianshipKinship.Name = "colGuardianshipKinship";
            this.colGuardianshipKinship.OptionsColumn.AllowEdit = false;
            this.colGuardianshipKinship.StatusBarShortcut = null;
            this.colGuardianshipKinship.StatusBarShortcutStatement = null;
            this.colGuardianshipKinship.StatusBarStatement = null;
            this.colGuardianshipKinship.Visible = true;
            this.colGuardianshipKinship.Width = 150;
            // 
            // colGuardianshipWorkplaceName
            // 
            this.colGuardianshipWorkplaceName.Caption = "İşyeri Adı";
            this.colGuardianshipWorkplaceName.CustomizationCaption = "Veli İşyeri Adı";
            this.colGuardianshipWorkplaceName.FieldName = "GuardianshipWorkplaceName";
            this.colGuardianshipWorkplaceName.Name = "colGuardianshipWorkplaceName";
            this.colGuardianshipWorkplaceName.OptionsColumn.AllowEdit = false;
            this.colGuardianshipWorkplaceName.StatusBarShortcut = null;
            this.colGuardianshipWorkplaceName.StatusBarShortcutStatement = null;
            this.colGuardianshipWorkplaceName.StatusBarStatement = null;
            this.colGuardianshipWorkplaceName.Visible = true;
            this.colGuardianshipWorkplaceName.Width = 150;
            // 
            // colGuardianshipJobName
            // 
            this.colGuardianshipJobName.Caption = "Görev Adı";
            this.colGuardianshipJobName.CustomizationCaption = "Veli Görev Adı";
            this.colGuardianshipJobName.FieldName = "GuardianshipJobName";
            this.colGuardianshipJobName.Name = "colGuardianshipJobName";
            this.colGuardianshipJobName.OptionsColumn.AllowEdit = false;
            this.colGuardianshipJobName.StatusBarShortcut = null;
            this.colGuardianshipJobName.StatusBarShortcutStatement = null;
            this.colGuardianshipJobName.StatusBarStatement = null;
            this.colGuardianshipJobName.Visible = true;
            this.colGuardianshipJobName.Width = 150;
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
            this.gridBand8.Columns.Add(this.colDiscountPercentage);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 3;
            this.gridBand8.Width = 1200;
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
            this.colNetPrice.FieldName = "NetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.OptionsColumn.AllowEdit = false;
            this.colNetPrice.StatusBarShortcut = null;
            this.colNetPrice.StatusBarShortcutStatement = null;
            this.colNetPrice.StatusBarStatement = null;
            this.colNetPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetPrice", "{0:c2}")});
            this.colNetPrice.Visible = true;
            this.colNetPrice.Width = 150;
            // 
            // colDiscountPercentage
            // 
            this.colDiscountPercentage.Caption = "İndirim Oranı";
            this.colDiscountPercentage.ColumnEdit = this.repositoryItemPercent;
            this.colDiscountPercentage.FieldName = "DiscountPercentage";
            this.colDiscountPercentage.Name = "colDiscountPercentage";
            this.colDiscountPercentage.OptionsColumn.AllowEdit = false;
            this.colDiscountPercentage.StatusBarShortcut = null;
            this.colDiscountPercentage.StatusBarShortcutStatement = null;
            this.colDiscountPercentage.StatusBarStatement = null;
            this.colDiscountPercentage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "DiscountPercentage", "{0:F}%")});
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
            this.gridBand4.VisibleIndex = 4;
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
            this.colNetPayment.FieldName = "NetPayment";
            this.colNetPayment.Name = "colNetPayment";
            this.colNetPayment.OptionsColumn.AllowEdit = false;
            this.colNetPayment.StatusBarShortcut = null;
            this.colNetPayment.StatusBarShortcutStatement = null;
            this.colNetPayment.StatusBarStatement = null;
            this.colNetPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetPayment", "{0:c2}")});
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
            this.gridBand7.VisibleIndex = 5;
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
            this.colRemaining.FieldName = "Remaining";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.OptionsColumn.AllowEdit = false;
            this.colRemaining.StatusBarShortcut = null;
            this.colRemaining.StatusBarShortcutStatement = null;
            this.colRemaining.StatusBarStatement = null;
            this.colRemaining.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Remaining", "{0:c2}")});
            this.colRemaining.Visible = true;
            this.colRemaining.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Diğer Bilgiler";
            this.gridBand2.Columns.Add(this.colBranchName);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 6;
            this.gridBand2.Width = 150;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "Şube Adı";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.OptionsColumn.AllowEdit = false;
            this.colBranchName.StatusBarShortcut = null;
            this.colBranchName.StatusBarShortcutStatement = null;
            this.colBranchName.StatusBarStatement = null;
            this.colBranchName.Visible = true;
            this.colBranchName.Width = 150;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Özel Kod";
            this.gridBand6.Columns.Add(this.colSpecialCode1);
            this.gridBand6.Columns.Add(this.colSpecialCode2);
            this.gridBand6.Columns.Add(this.colSpecialCode3);
            this.gridBand6.Columns.Add(this.colSpecialCode4);
            this.gridBand6.Columns.Add(this.colSpecialCode5);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Visible = false;
            this.gridBand6.VisibleIndex = -1;
            this.gridBand6.Width = 375;
            // 
            // colSpecialCode1
            // 
            this.colSpecialCode1.Caption = "Özel Kod - 1";
            this.colSpecialCode1.FieldName = "SpecialCode1";
            this.colSpecialCode1.Name = "colSpecialCode1";
            this.colSpecialCode1.OptionsColumn.AllowEdit = false;
            this.colSpecialCode1.StatusBarShortcut = null;
            this.colSpecialCode1.StatusBarShortcutStatement = null;
            this.colSpecialCode1.StatusBarStatement = null;
            this.colSpecialCode1.Visible = true;
            this.colSpecialCode1.Width = 150;
            // 
            // colSpecialCode2
            // 
            this.colSpecialCode2.Caption = "Özel Kod - 2";
            this.colSpecialCode2.FieldName = "SpecialCode2";
            this.colSpecialCode2.Name = "colSpecialCode2";
            this.colSpecialCode2.OptionsColumn.AllowEdit = false;
            this.colSpecialCode2.StatusBarShortcut = null;
            this.colSpecialCode2.StatusBarShortcutStatement = null;
            this.colSpecialCode2.StatusBarStatement = null;
            this.colSpecialCode2.Visible = true;
            this.colSpecialCode2.Width = 150;
            // 
            // colSpecialCode3
            // 
            this.colSpecialCode3.Caption = "Özel Kod - 3";
            this.colSpecialCode3.FieldName = "SpecialCode3";
            this.colSpecialCode3.Name = "colSpecialCode3";
            this.colSpecialCode3.OptionsColumn.AllowEdit = false;
            this.colSpecialCode3.StatusBarShortcut = null;
            this.colSpecialCode3.StatusBarShortcutStatement = null;
            this.colSpecialCode3.StatusBarStatement = null;
            this.colSpecialCode3.Visible = true;
            this.colSpecialCode3.Width = 150;
            // 
            // colSpecialCode4
            // 
            this.colSpecialCode4.Caption = "Özel Kod - 4";
            this.colSpecialCode4.FieldName = "SpecialCode4";
            this.colSpecialCode4.Name = "colSpecialCode4";
            this.colSpecialCode4.OptionsColumn.AllowEdit = false;
            this.colSpecialCode4.StatusBarShortcut = null;
            this.colSpecialCode4.StatusBarShortcutStatement = null;
            this.colSpecialCode4.StatusBarStatement = null;
            this.colSpecialCode4.Visible = true;
            this.colSpecialCode4.Width = 150;
            // 
            // colSpecialCode5
            // 
            this.colSpecialCode5.Caption = "Özel Kod - 5";
            this.colSpecialCode5.FieldName = "SpecialCode5";
            this.colSpecialCode5.Name = "colSpecialCode5";
            this.colSpecialCode5.OptionsColumn.AllowEdit = false;
            this.colSpecialCode5.StatusBarShortcut = null;
            this.colSpecialCode5.StatusBarShortcutStatement = null;
            this.colSpecialCode5.StatusBarStatement = null;
            this.colSpecialCode5.Visible = true;
            this.colSpecialCode5.Width = 150;
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
            // PriceAndPaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "PriceAndPaymentReport";
            this.Text = "Ücret ve Ödeme Raporu";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
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
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Grids.MyBandedGridColumn colStudentNumber;
        private UserControls.Grids.MyBandedGridColumn colSchoolNumber;
        private UserControls.Grids.MyBandedGridColumn colTrIdentityNumber;
        private UserControls.Grids.MyBandedGridColumn colName;
        private UserControls.Grids.MyBandedGridColumn colLastname;
        private UserControls.Grids.MyBandedGridColumn colClassName;
        private UserControls.Grids.MyBandedGridColumn colGender;
        private UserControls.Grids.MyBandedGridColumn colPhone;
        private UserControls.Grids.MyBandedGridColumn colForeignLanguageName;
        private UserControls.Grids.MyBandedGridColumn colComesFromSchool;
        private UserControls.Grids.MyBandedGridColumn colGuideName;
        private UserControls.Grids.MyBandedGridColumn colQuotaType;
        private UserControls.Grids.MyBandedGridColumn colIncentName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grids.MyBandedGridColumn colRegistrationDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private UserControls.Grids.MyBandedGridColumn colEnrollmentType;
        private UserControls.Grids.MyBandedGridColumn colEnrollmentStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipName;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipLastname;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipVocation;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipKinship;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipWorkplaceName;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipJobName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private UserControls.Grids.MyBandedGridColumn colGrossService;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private UserControls.Grids.MyBandedGridColumn colShortTermDeductedService;
        private UserControls.Grids.MyBandedGridColumn colNetService;
        private UserControls.Grids.MyBandedGridColumn colGrossDiscount;
        private UserControls.Grids.MyBandedGridColumn colShortTermDeductedDiscount;
        private UserControls.Grids.MyBandedGridColumn colNetDiscount;
        private UserControls.Grids.MyBandedGridColumn colNetPrice;
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
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn colBranchName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode3;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode4;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode5;
        private UserControls.Grids.MyBandedGridColumn colCancelStatus;
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
    }
}