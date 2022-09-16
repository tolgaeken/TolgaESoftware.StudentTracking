namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms
{
    partial class BillPlanListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillPlanListForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colClassName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGuardianshipName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuardianshipLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKinship = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colVocation = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRegistrationDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEnrollmentType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEnrollmentStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCancelStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGrossPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPlanPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanDiscount = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode3 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode4 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode5 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
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
            // btnNewReceipt
            // 
            this.btnNewReceipt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewReceipt.ImageOptions.Image")));
            this.btnNewReceipt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNewReceipt.ImageOptions.LargeImage")));
            // 
            // btnNewReport
            // 
            this.btnNewReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewReport.ImageOptions.Image")));
            this.btnNewReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNewReport.ImageOptions.LargeImage")));
            // 
            // colNetPrice
            // 
            this.colNetPrice.Caption = "Net Tutar";
            this.colNetPrice.ColumnEdit = this.repositoryItemCalc;
            this.colNetPrice.FieldName = "ServiceNetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.OptionsColumn.AllowEdit = false;
            this.colNetPrice.StatusBarShortcut = null;
            this.colNetPrice.StatusBarShortcutStatement = null;
            this.colNetPrice.StatusBarStatement = null;
            this.colNetPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ServiceNetPrice", "{0:c2}")});
            this.colNetPrice.Visible = true;
            this.colNetPrice.Width = 100;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalc.DisplayFormat.FormatString = "{0:c2}";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 748);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1168, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.table;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemCalc});
            this.grid.Size = new System.Drawing.Size(1168, 639);
            this.grid.TabIndex = 3;
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
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colNumber,
            this.colName,
            this.colLastname,
            this.colClassName,
            this.colRegistrationDate,
            this.colEnrollmentType,
            this.colEnrollmentStatus,
            this.colCancelStatus,
            this.colGuardianshipName,
            this.colGuardianshipLastname,
            this.colKinship,
            this.colVocation,
            this.colGrossPrice,
            this.colDiscount,
            this.colNetPrice,
            this.colPlanPrice,
            this.colPlanDiscount,
            this.colPlanNetPrice,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colSpecialCode3,
            this.colSpecialCode4,
            this.colSpecialCode5});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colNetPrice;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.DarkSalmon;
            formatConditionRuleExpression1.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[ServiceNetPrice]<>[PlanNetPrice]";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colNetPrice;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            formatConditionRuleExpression2.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[ServiceNetPrice]==0";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.table.FormatRules.Add(gridFormatRule1);
            this.table.FormatRules.Add(gridFormatRule2);
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
            this.table.OptionsView.ShowAutoFilterRow = true;
            this.table.OptionsView.ShowFooter = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = null;
            this.table.StatusBarShortcutStatement = null;
            this.table.StatusBarStatement = null;
            this.table.ViewCaption = "Fatura Planı Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colNumber);
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Columns.Add(this.colLastname);
            this.gridBand1.Columns.Add(this.colClassName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 415;
            // 
            // colNumber
            // 
            this.colNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumber.Caption = "Öğrenci No";
            this.colNumber.FieldName = "StudentNumber";
            this.colNumber.Name = "colNumber";
            this.colNumber.OptionsColumn.AllowEdit = false;
            this.colNumber.StatusBarShortcut = null;
            this.colNumber.StatusBarShortcutStatement = null;
            this.colNumber.StatusBarStatement = null;
            this.colNumber.Visible = true;
            this.colNumber.Width = 100;
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.StatusBarShortcut = null;
            this.colName.StatusBarShortcutStatement = null;
            this.colName.StatusBarStatement = null;
            this.colName.Visible = true;
            this.colName.Width = 120;
            // 
            // colLastname
            // 
            this.colLastname.Caption = "Soyadı";
            this.colLastname.FieldName = "Lastname";
            this.colLastname.Name = "colLastname";
            this.colLastname.OptionsColumn.AllowEdit = false;
            this.colLastname.StatusBarShortcut = null;
            this.colLastname.StatusBarShortcutStatement = null;
            this.colLastname.StatusBarStatement = null;
            this.colLastname.Visible = true;
            this.colLastname.Width = 120;
            // 
            // colClassName
            // 
            this.colClassName.Caption = "Sınıf";
            this.colClassName.FieldName = "ClassName";
            this.colClassName.Name = "colClassName";
            this.colClassName.OptionsColumn.AllowEdit = false;
            this.colClassName.StatusBarShortcut = null;
            this.colClassName.StatusBarShortcutStatement = null;
            this.colClassName.StatusBarStatement = null;
            this.colClassName.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Veli Bilgileri";
            this.gridBand2.Columns.Add(this.colGuardianshipName);
            this.gridBand2.Columns.Add(this.colGuardianshipLastname);
            this.gridBand2.Columns.Add(this.colKinship);
            this.gridBand2.Columns.Add(this.colVocation);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 390;
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
            this.colGuardianshipName.Width = 120;
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
            this.colGuardianshipLastname.Width = 120;
            // 
            // colKinship
            // 
            this.colKinship.Caption = "Yakınlık";
            this.colKinship.FieldName = "GuardianshipKinshipName";
            this.colKinship.Name = "colKinship";
            this.colKinship.OptionsColumn.AllowEdit = false;
            this.colKinship.StatusBarShortcut = null;
            this.colKinship.StatusBarShortcutStatement = null;
            this.colKinship.StatusBarStatement = null;
            this.colKinship.Visible = true;
            // 
            // colVocation
            // 
            this.colVocation.Caption = "Meslek";
            this.colVocation.FieldName = "GuardianshipVocationName";
            this.colVocation.Name = "colVocation";
            this.colVocation.OptionsColumn.AllowEdit = false;
            this.colVocation.StatusBarShortcut = null;
            this.colVocation.StatusBarShortcutStatement = null;
            this.colVocation.StatusBarStatement = null;
            this.colVocation.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Kayıt Bilgileri";
            this.gridBand3.Columns.Add(this.colRegistrationDate);
            this.gridBand3.Columns.Add(this.colEnrollmentType);
            this.gridBand3.Columns.Add(this.colEnrollmentStatus);
            this.gridBand3.Columns.Add(this.colCancelStatus);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 325;
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colRegistrationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegistrationDate.Caption = "Kayıt Tarihi";
            this.colRegistrationDate.ColumnEdit = this.repositoryItemDate;
            this.colRegistrationDate.FieldName = "RegistrationDate";
            this.colRegistrationDate.Name = "colRegistrationDate";
            this.colRegistrationDate.OptionsColumn.AllowEdit = false;
            this.colRegistrationDate.StatusBarShortcut = null;
            this.colRegistrationDate.StatusBarShortcutStatement = null;
            this.colRegistrationDate.StatusBarStatement = null;
            this.colRegistrationDate.Visible = true;
            this.colRegistrationDate.Width = 100;
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
            // 
            // colCancelStatus
            // 
            this.colCancelStatus.Caption = "İptal Durumu";
            this.colCancelStatus.FieldName = "CancelStatus";
            this.colCancelStatus.Name = "colCancelStatus";
            this.colCancelStatus.OptionsColumn.AllowEdit = false;
            this.colCancelStatus.StatusBarShortcut = null;
            this.colCancelStatus.StatusBarShortcutStatement = null;
            this.colCancelStatus.StatusBarStatement = null;
            this.colCancelStatus.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Hizmet Bilgileri";
            this.gridBand4.Columns.Add(this.colGrossPrice);
            this.gridBand4.Columns.Add(this.colDiscount);
            this.gridBand4.Columns.Add(this.colNetPrice);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 300;
            // 
            // colGrossPrice
            // 
            this.colGrossPrice.Caption = "Brüt Tutar";
            this.colGrossPrice.ColumnEdit = this.repositoryItemCalc;
            this.colGrossPrice.FieldName = "ServicePrice";
            this.colGrossPrice.Name = "colGrossPrice";
            this.colGrossPrice.OptionsColumn.AllowEdit = false;
            this.colGrossPrice.StatusBarShortcut = null;
            this.colGrossPrice.StatusBarShortcutStatement = null;
            this.colGrossPrice.StatusBarStatement = null;
            this.colGrossPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ServicePrice", "{0:c2}")});
            this.colGrossPrice.Visible = true;
            this.colGrossPrice.Width = 100;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "İndirim";
            this.colDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colDiscount.FieldName = "ServiceDiscount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowEdit = false;
            this.colDiscount.StatusBarShortcut = null;
            this.colDiscount.StatusBarShortcutStatement = null;
            this.colDiscount.StatusBarStatement = null;
            this.colDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ServiceDiscount", "{0:c2}")});
            this.colDiscount.Visible = true;
            this.colDiscount.Width = 100;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Fatura Planı";
            this.gridBand5.Columns.Add(this.colPlanPrice);
            this.gridBand5.Columns.Add(this.colPlanDiscount);
            this.gridBand5.Columns.Add(this.colPlanNetPrice);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 300;
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
            // colPlanDiscount
            // 
            this.colPlanDiscount.Caption = "İndirim";
            this.colPlanDiscount.ColumnEdit = this.repositoryItemCalc;
            this.colPlanDiscount.CustomizationCaption = "Plan İndirim";
            this.colPlanDiscount.FieldName = "PlanDiscount";
            this.colPlanDiscount.Name = "colPlanDiscount";
            this.colPlanDiscount.OptionsColumn.AllowEdit = false;
            this.colPlanDiscount.StatusBarShortcut = null;
            this.colPlanDiscount.StatusBarShortcutStatement = null;
            this.colPlanDiscount.StatusBarStatement = null;
            this.colPlanDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanDiscount", "{0:c2}")});
            this.colPlanDiscount.Visible = true;
            this.colPlanDiscount.Width = 100;
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
            // gridBand6
            // 
            this.gridBand6.Caption = "Özel Kod";
            this.gridBand6.Columns.Add(this.colSpecialCode1);
            this.gridBand6.Columns.Add(this.colSpecialCode2);
            this.gridBand6.Columns.Add(this.colSpecialCode3);
            this.gridBand6.Columns.Add(this.colSpecialCode4);
            this.gridBand6.Columns.Add(this.colSpecialCode5);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
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
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(228, 403);
            this.progressBarControl.MenuManager = this.ribbonControl;
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.ShowTitle = true;
            this.progressBarControl.Size = new System.Drawing.Size(695, 27);
            this.progressBarControl.TabIndex = 4;
            this.progressBarControl.Visible = false;
            // 
            // BillPlanListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.progressBarControl);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "BillPlanListForm";
            this.Text = "Fatura Planı Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.progressBarControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView table;
        private UserControls.Grids.MyBandedGridColumn colNumber;
        private UserControls.Grids.MyBandedGridColumn colName;
        private UserControls.Grids.MyBandedGridColumn colLastname;
        private UserControls.Grids.MyBandedGridColumn colClassName;
        private UserControls.Grids.MyBandedGridColumn colRegistrationDate;
        private UserControls.Grids.MyBandedGridColumn colEnrollmentType;
        private UserControls.Grids.MyBandedGridColumn colEnrollmentStatus;
        private UserControls.Grids.MyBandedGridColumn colCancelStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipName;
        private UserControls.Grids.MyBandedGridColumn colGuardianshipLastname;
        private UserControls.Grids.MyBandedGridColumn colKinship;
        private UserControls.Grids.MyBandedGridColumn colVocation;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grids.MyBandedGridColumn colGrossPrice;
        private UserControls.Grids.MyBandedGridColumn colDiscount;
        private UserControls.Grids.MyBandedGridColumn colNetPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private UserControls.Grids.MyBandedGridColumn colPlanPrice;
        private UserControls.Grids.MyBandedGridColumn colPlanDiscount;
        private UserControls.Grids.MyBandedGridColumn colPlanNetPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode3;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode4;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
    }
}