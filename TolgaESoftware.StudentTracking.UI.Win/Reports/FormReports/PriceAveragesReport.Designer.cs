namespace TolgaESoftware.StudentTracking.UI.Win.Reports.FormReports
{
    partial class PriceAveragesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceAveragesReport));
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
            this.colBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colClassGroupName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colClassName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBranchGroupName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBranchRowNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPaidStudent = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemInt = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colUnpaidStudent = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSumOfStudent = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPaidAverage = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIncludedUnpaidAverage = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNumberOfClass = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colClassAverage = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCenter = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGrossService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colShortTermDeductedService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetService = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGrossDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colShortTermDeductedDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCenter)).BeginInit();
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
            this.myDataLayoutControl.TabIndex = 8;
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
            this.repositoryItemInt,
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
            this.gridBand4,
            this.gridBand8});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colBranchName,
            this.colClassGroupName,
            this.colClassName,
            this.colBranchGroupName,
            this.colBranchRowNumber,
            this.colPaidStudent,
            this.colUnpaidStudent,
            this.colSumOfStudent,
            this.colGrossService,
            this.colShortTermDeductedService,
            this.colNetService,
            this.colGrossDiscount,
            this.colShortTermDeductedDiscount,
            this.colNetDiscount,
            this.colNetPrice,
            this.colNumberOfClass,
            this.colPaidAverage,
            this.colIncludedUnpaidAverage,
            this.colClassAverage});
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
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnpaidStudent", this.colUnpaidStudent, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaidStudent", this.colPaidStudent, "{0:n0}", "PaidStudent"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colSumOfStudent", this.colSumOfStudent, "{0:n0}", "SumOfStudent"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossService", this.colGrossService, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedService", this.colShortTermDeductedService, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetService", this.colNetService, "{0:c2}", "NetService"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossDiscount", this.colGrossDiscount, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedDiscount", this.colShortTermDeductedDiscount, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetDiscount", this.colNetDiscount, "{0:c2}", "NetDiscount"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colNetPrice", this.colNetPrice, "{0:c2}", "NetPrice"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colPaidAverage", this.colPaidAverage, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colIncludedUnpaidAverage", this.colIncludedUnpaidAverage, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumberOfClass", this.colNumberOfClass, "{0:n0}", "NumberOfClass"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colClassAverage", this.colClassAverage, "{0:n2}")});
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
            this.table.ViewCaption = "Ücret Ortalamaları Raporu";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Genel Bilgiler";
            this.gridBand2.Columns.Add(this.colBranchName);
            this.gridBand2.Columns.Add(this.colClassGroupName);
            this.gridBand2.Columns.Add(this.colClassName);
            this.gridBand2.Columns.Add(this.colBranchGroupName);
            this.gridBand2.Columns.Add(this.colBranchRowNumber);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 750;
            // 
            // colBranchName
            // 
            this.colBranchName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBranchName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // colClassGroupName
            // 
            this.colClassGroupName.AppearanceHeader.Options.UseTextOptions = true;
            this.colClassGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClassGroupName.Caption = "Sınıf Grubu";
            this.colClassGroupName.FieldName = "ClassGroupName";
            this.colClassGroupName.Name = "colClassGroupName";
            this.colClassGroupName.OptionsColumn.AllowEdit = false;
            this.colClassGroupName.StatusBarShortcut = null;
            this.colClassGroupName.StatusBarShortcutStatement = null;
            this.colClassGroupName.StatusBarStatement = null;
            this.colClassGroupName.Visible = true;
            this.colClassGroupName.Width = 150;
            // 
            // colClassName
            // 
            this.colClassName.AppearanceHeader.Options.UseTextOptions = true;
            this.colClassName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClassName.Caption = "Sınıf";
            this.colClassName.FieldName = "ClassName";
            this.colClassName.Name = "colClassName";
            this.colClassName.OptionsColumn.AllowEdit = false;
            this.colClassName.StatusBarShortcut = null;
            this.colClassName.StatusBarShortcutStatement = null;
            this.colClassName.StatusBarStatement = null;
            this.colClassName.Visible = true;
            this.colClassName.Width = 150;
            // 
            // colBranchGroupName
            // 
            this.colBranchGroupName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBranchGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBranchGroupName.Caption = "Şube Grubu";
            this.colBranchGroupName.FieldName = "BranchGroupName";
            this.colBranchGroupName.Name = "colBranchGroupName";
            this.colBranchGroupName.OptionsColumn.AllowEdit = false;
            this.colBranchGroupName.StatusBarShortcut = null;
            this.colBranchGroupName.StatusBarShortcutStatement = null;
            this.colBranchGroupName.StatusBarStatement = null;
            this.colBranchGroupName.Visible = true;
            this.colBranchGroupName.Width = 150;
            // 
            // colBranchRowNumber
            // 
            this.colBranchRowNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colBranchRowNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBranchRowNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colBranchRowNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBranchRowNumber.Caption = "Şube Sıra No";
            this.colBranchRowNumber.FieldName = "BranchRowNumber";
            this.colBranchRowNumber.Name = "colBranchRowNumber";
            this.colBranchRowNumber.OptionsColumn.AllowEdit = false;
            this.colBranchRowNumber.StatusBarShortcut = null;
            this.colBranchRowNumber.StatusBarShortcutStatement = null;
            this.colBranchRowNumber.StatusBarStatement = null;
            this.colBranchRowNumber.Visible = true;
            this.colBranchRowNumber.Width = 150;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Öğrenci Sayıları";
            this.gridBand6.Columns.Add(this.colPaidStudent);
            this.gridBand6.Columns.Add(this.colUnpaidStudent);
            this.gridBand6.Columns.Add(this.colSumOfStudent);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 1;
            this.gridBand6.Width = 450;
            // 
            // colPaidStudent
            // 
            this.colPaidStudent.AppearanceCell.Options.UseTextOptions = true;
            this.colPaidStudent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaidStudent.Caption = "Ücretli";
            this.colPaidStudent.ColumnEdit = this.repositoryItemInt;
            this.colPaidStudent.CustomizationCaption = "Ücretli Öğrenci";
            this.colPaidStudent.FieldName = "PaidStudent";
            this.colPaidStudent.Name = "colPaidStudent";
            this.colPaidStudent.OptionsColumn.AllowEdit = false;
            this.colPaidStudent.StatusBarShortcut = null;
            this.colPaidStudent.StatusBarShortcutStatement = null;
            this.colPaidStudent.StatusBarStatement = null;
            this.colPaidStudent.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaidStudent", "{0:n0}")});
            this.colPaidStudent.Visible = true;
            this.colPaidStudent.Width = 150;
            // 
            // repositoryItemInt
            // 
            this.repositoryItemInt.Appearance.Options.UseTextOptions = true;
            this.repositoryItemInt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemInt.AutoHeight = false;
            this.repositoryItemInt.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemInt.DisplayFormat.FormatString = "{0:n0}";
            this.repositoryItemInt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemInt.EditFormat.FormatString = "{0:n0}";
            this.repositoryItemInt.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemInt.Name = "repositoryItemInt";
            // 
            // colUnpaidStudent
            // 
            this.colUnpaidStudent.AppearanceCell.Options.UseTextOptions = true;
            this.colUnpaidStudent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnpaidStudent.Caption = "Ücretsiz";
            this.colUnpaidStudent.ColumnEdit = this.repositoryItemInt;
            this.colUnpaidStudent.CustomizationCaption = "Ücretsiz Öğrenci";
            this.colUnpaidStudent.FieldName = "UnpaidStudent";
            this.colUnpaidStudent.Name = "colUnpaidStudent";
            this.colUnpaidStudent.OptionsColumn.AllowEdit = false;
            this.colUnpaidStudent.StatusBarShortcut = null;
            this.colUnpaidStudent.StatusBarShortcutStatement = null;
            this.colUnpaidStudent.StatusBarStatement = null;
            this.colUnpaidStudent.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnpaidStudent", "{0:n0}")});
            this.colUnpaidStudent.Visible = true;
            this.colUnpaidStudent.Width = 150;
            // 
            // colSumOfStudent
            // 
            this.colSumOfStudent.AppearanceCell.Options.UseTextOptions = true;
            this.colSumOfStudent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumOfStudent.Caption = "Toplam";
            this.colSumOfStudent.ColumnEdit = this.repositoryItemInt;
            this.colSumOfStudent.CustomizationCaption = "Toplam Öğrenci";
            this.colSumOfStudent.FieldName = "colSumOfStudent";
            this.colSumOfStudent.Name = "colSumOfStudent";
            this.colSumOfStudent.OptionsColumn.AllowEdit = false;
            this.colSumOfStudent.StatusBarShortcut = null;
            this.colSumOfStudent.StatusBarShortcutStatement = null;
            this.colSumOfStudent.StatusBarStatement = null;
            this.colSumOfStudent.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colSumOfStudent", "{0:n0}")});
            this.colSumOfStudent.UnboundExpression = "[PaidStudent] + [UnpaidStudent]";
            this.colSumOfStudent.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSumOfStudent.Visible = true;
            this.colSumOfStudent.Width = 150;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ortalamalar";
            this.gridBand4.Columns.Add(this.colPaidAverage);
            this.gridBand4.Columns.Add(this.colIncludedUnpaidAverage);
            this.gridBand4.Columns.Add(this.colNumberOfClass);
            this.gridBand4.Columns.Add(this.colClassAverage);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 2;
            this.gridBand4.Width = 600;
            // 
            // colPaidAverage
            // 
            this.colPaidAverage.AppearanceHeader.Options.UseTextOptions = true;
            this.colPaidAverage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaidAverage.Caption = "Ücretli Ortalama";
            this.colPaidAverage.ColumnEdit = this.repositoryItemDecimal;
            this.colPaidAverage.FieldName = "colPaidAverage";
            this.colPaidAverage.Name = "colPaidAverage";
            this.colPaidAverage.OptionsColumn.AllowEdit = false;
            this.colPaidAverage.StatusBarShortcut = null;
            this.colPaidAverage.StatusBarShortcutStatement = null;
            this.colPaidAverage.StatusBarStatement = null;
            this.colPaidAverage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colPaidAverage", "{0:c2}")});
            this.colPaidAverage.UnboundExpression = "Iif([PaidStudent] = 0, 0, [colNetPrice] / [PaidStudent])";
            this.colPaidAverage.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colPaidAverage.Visible = true;
            this.colPaidAverage.Width = 150;
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
            // colIncludedUnpaidAverage
            // 
            this.colIncludedUnpaidAverage.AppearanceHeader.Options.UseTextOptions = true;
            this.colIncludedUnpaidAverage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIncludedUnpaidAverage.Caption = "Ücretsiz Öğrenciler Dahil Ortalama";
            this.colIncludedUnpaidAverage.ColumnEdit = this.repositoryItemDecimal;
            this.colIncludedUnpaidAverage.FieldName = "colIncludedUnpaidAverage";
            this.colIncludedUnpaidAverage.Name = "colIncludedUnpaidAverage";
            this.colIncludedUnpaidAverage.OptionsColumn.AllowEdit = false;
            this.colIncludedUnpaidAverage.StatusBarShortcut = null;
            this.colIncludedUnpaidAverage.StatusBarShortcutStatement = null;
            this.colIncludedUnpaidAverage.StatusBarStatement = null;
            this.colIncludedUnpaidAverage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colIncludedUnpaidAverage", "{0:c2}")});
            this.colIncludedUnpaidAverage.UnboundExpression = "Iif([colSumOfStudent] = 0, 0, [colNetPrice] / [colSumOfStudent])";
            this.colIncludedUnpaidAverage.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIncludedUnpaidAverage.Visible = true;
            this.colIncludedUnpaidAverage.Width = 150;
            // 
            // colNumberOfClass
            // 
            this.colNumberOfClass.AppearanceCell.Options.UseTextOptions = true;
            this.colNumberOfClass.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumberOfClass.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumberOfClass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumberOfClass.Caption = "Sınıf Sayısı";
            this.colNumberOfClass.ColumnEdit = this.repositoryItemInt;
            this.colNumberOfClass.FieldName = "NumberOfClass";
            this.colNumberOfClass.Name = "colNumberOfClass";
            this.colNumberOfClass.OptionsColumn.AllowEdit = false;
            this.colNumberOfClass.StatusBarShortcut = null;
            this.colNumberOfClass.StatusBarShortcutStatement = null;
            this.colNumberOfClass.StatusBarStatement = null;
            this.colNumberOfClass.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumberOfClass", "{0:n0}")});
            this.colNumberOfClass.Visible = true;
            this.colNumberOfClass.Width = 150;
            // 
            // colClassAverage
            // 
            this.colClassAverage.AppearanceCell.Options.UseTextOptions = true;
            this.colClassAverage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClassAverage.AppearanceHeader.Options.UseTextOptions = true;
            this.colClassAverage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClassAverage.Caption = "Sınıf Ortalama";
            this.colClassAverage.ColumnEdit = this.repositoryItemCenter;
            this.colClassAverage.FieldName = "colClassAverage";
            this.colClassAverage.Name = "colClassAverage";
            this.colClassAverage.OptionsColumn.AllowEdit = false;
            this.colClassAverage.StatusBarShortcut = null;
            this.colClassAverage.StatusBarShortcutStatement = null;
            this.colClassAverage.StatusBarStatement = null;
            this.colClassAverage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "colClassAverage", "{0:n2}")});
            this.colClassAverage.UnboundExpression = "Iif([NumberOfClass] = 0, 0, [colSumOfStudent] / [NumberOfClass])";
            this.colClassAverage.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colClassAverage.Visible = true;
            this.colClassAverage.Width = 150;
            // 
            // repositoryItemCenter
            // 
            this.repositoryItemCenter.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCenter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCenter.AutoHeight = false;
            this.repositoryItemCenter.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCenter.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemCenter.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCenter.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemCenter.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCenter.Name = "repositoryItemCenter";
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "Özet";
            this.gridBand8.Columns.Add(this.colGrossService);
            this.gridBand8.Columns.Add(this.colShortTermDeductedService);
            this.gridBand8.Columns.Add(this.colNetService);
            this.gridBand8.Columns.Add(this.colGrossDiscount);
            this.gridBand8.Columns.Add(this.colShortTermDeductedDiscount);
            this.gridBand8.Columns.Add(this.colNetDiscount);
            this.gridBand8.Columns.Add(this.colNetPrice);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 3;
            this.gridBand8.Width = 1050;
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
            // PriceAveragesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "PriceAveragesReport";
            this.Text = "Ücret Ortalamaları Raporu";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCenter)).EndInit();
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
        private UserControls.Grids.MyBandedGridColumn colPaidStudent;
        private UserControls.Grids.MyBandedGridColumn colUnpaidStudent;
        private UserControls.Grids.MyBandedGridColumn colSumOfStudent;
        private UserControls.Grids.MyBandedGridColumn colGrossService;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private UserControls.Grids.MyBandedGridColumn colShortTermDeductedService;
        private UserControls.Grids.MyBandedGridColumn colNetService;
        private UserControls.Grids.MyBandedGridColumn colGrossDiscount;
        private UserControls.Grids.MyBandedGridColumn colShortTermDeductedDiscount;
        private UserControls.Grids.MyBandedGridColumn colNetDiscount;
        private UserControls.Grids.MyBandedGridColumn colNetPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemInt;
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
        private UserControls.Grids.MyBandedGridColumn colBranchName;
        private UserControls.Grids.MyBandedGridColumn colClassGroupName;
        private UserControls.Grids.MyBandedGridColumn colClassName;
        private UserControls.Grids.MyBandedGridColumn colBranchGroupName;
        private UserControls.Grids.MyBandedGridColumn colBranchRowNumber;
        private UserControls.Grids.MyBandedGridColumn colNumberOfClass;
        private UserControls.Grids.MyBandedGridColumn colPaidAverage;
        private UserControls.Grids.MyBandedGridColumn colIncludedUnpaidAverage;
        private UserControls.Grids.MyBandedGridColumn colClassAverage;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCenter;
    }
}