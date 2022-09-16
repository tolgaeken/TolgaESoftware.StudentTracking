namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class ServiceInformationsTable
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
            this.colServiceId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServiceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServiceTypeId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSchoolBusId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSchoolBusName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTransactionDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colStartDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGrossPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colShortTermDeductedPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCancelled = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNumberOfEducationTermDateDays = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNumberOfTakenServiceDays = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDailyPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCancellationDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCancellationDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colCancellationReasonId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCancellationReasonName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCancellationReason = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSchooltoGoesId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSchoolToGoesName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSchoolToGoes = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCancellationStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSchoolToGoes)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Size = new System.Drawing.Size(1089, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemCalc,
            this.repositoryItemCancellationReason,
            this.repositoryItemSchoolToGoes,
            this.repositoryItemCancellationDate});
            this.grid.Size = new System.Drawing.Size(1089, 340);
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
            this.colServiceId,
            this.colServiceName,
            this.colServiceTypeId,
            this.colSchoolBusId,
            this.colSchoolBusName,
            this.colTransactionDate,
            this.colStartDate,
            this.colGrossPrice,
            this.colShortTermDeductedPrice,
            this.colNetPrice,
            this.colCancelled,
            this.colNumberOfEducationTermDateDays,
            this.colNumberOfTakenServiceDays,
            this.colDailyPrice,
            this.colCancellationDate,
            this.colCancellationReasonId,
            this.colCancellationReasonName,
            this.colSchooltoGoesId,
            this.colSchoolToGoesName,
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
            this.table.StatusBarShortcut = "Shift + Insert";
            this.table.StatusBarShortcutStatement = "Seçim Yap";
            this.table.StatusBarStatement = "Öğrenciye Verilen Hizmetleri Seçiniz";
            this.table.ViewCaption = "Hizmet Bilgileri";
            // 
            // colServiceId
            // 
            this.colServiceId.Caption = "Hizmet Id";
            this.colServiceId.FieldName = "ServiceId";
            this.colServiceId.Name = "colServiceId";
            this.colServiceId.OptionsColumn.AllowEdit = false;
            this.colServiceId.OptionsColumn.ShowInCustomizationForm = false;
            this.colServiceId.StatusBarShortcut = null;
            this.colServiceId.StatusBarShortcutStatement = null;
            this.colServiceId.StatusBarStatement = null;
            // 
            // colServiceName
            // 
            this.colServiceName.Caption = "Hizmet Adı";
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.OptionsColumn.AllowEdit = false;
            this.colServiceName.OptionsColumn.AllowMove = false;
            this.colServiceName.OptionsColumn.AllowShowHide = false;
            this.colServiceName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServiceName.OptionsFilter.AllowAutoFilter = false;
            this.colServiceName.OptionsFilter.AllowFilter = false;
            this.colServiceName.StatusBarShortcut = null;
            this.colServiceName.StatusBarShortcutStatement = null;
            this.colServiceName.StatusBarStatement = null;
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 0;
            this.colServiceName.Width = 250;
            // 
            // colServiceTypeId
            // 
            this.colServiceTypeId.Caption = "Hizmet Türü Id";
            this.colServiceTypeId.FieldName = "ServiceTypeId";
            this.colServiceTypeId.Name = "colServiceTypeId";
            this.colServiceTypeId.OptionsColumn.AllowEdit = false;
            this.colServiceTypeId.OptionsColumn.ShowInCustomizationForm = false;
            this.colServiceTypeId.StatusBarShortcut = null;
            this.colServiceTypeId.StatusBarShortcutStatement = null;
            this.colServiceTypeId.StatusBarStatement = null;
            // 
            // colSchoolBusId
            // 
            this.colSchoolBusId.Caption = "Servis Id";
            this.colSchoolBusId.FieldName = "SchoolBusId";
            this.colSchoolBusId.Name = "colSchoolBusId";
            this.colSchoolBusId.OptionsColumn.AllowEdit = false;
            this.colSchoolBusId.OptionsColumn.ShowInCustomizationForm = false;
            this.colSchoolBusId.StatusBarShortcut = null;
            this.colSchoolBusId.StatusBarShortcutStatement = null;
            this.colSchoolBusId.StatusBarStatement = null;
            // 
            // colSchoolBusName
            // 
            this.colSchoolBusName.Caption = "Servis Yeri";
            this.colSchoolBusName.FieldName = "SchoolBusName";
            this.colSchoolBusName.Name = "colSchoolBusName";
            this.colSchoolBusName.OptionsColumn.AllowEdit = false;
            this.colSchoolBusName.OptionsColumn.AllowMove = false;
            this.colSchoolBusName.OptionsColumn.AllowShowHide = false;
            this.colSchoolBusName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSchoolBusName.OptionsFilter.AllowAutoFilter = false;
            this.colSchoolBusName.OptionsFilter.AllowFilter = false;
            this.colSchoolBusName.StatusBarShortcut = null;
            this.colSchoolBusName.StatusBarShortcutStatement = null;
            this.colSchoolBusName.StatusBarStatement = null;
            this.colSchoolBusName.Width = 100;
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
            this.colTransactionDate.OptionsColumn.AllowMove = false;
            this.colTransactionDate.OptionsColumn.AllowShowHide = false;
            this.colTransactionDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTransactionDate.OptionsFilter.AllowAutoFilter = false;
            this.colTransactionDate.OptionsFilter.AllowFilter = false;
            this.colTransactionDate.StatusBarShortcut = null;
            this.colTransactionDate.StatusBarShortcutStatement = null;
            this.colTransactionDate.StatusBarStatement = null;
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 5;
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
            // colStartDate
            // 
            this.colStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartDate.Caption = "Başlama Tarihi";
            this.colStartDate.ColumnEdit = this.repositoryItemDate;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.OptionsColumn.AllowEdit = false;
            this.colStartDate.OptionsColumn.AllowMove = false;
            this.colStartDate.OptionsColumn.AllowShowHide = false;
            this.colStartDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStartDate.OptionsFilter.AllowAutoFilter = false;
            this.colStartDate.OptionsFilter.AllowFilter = false;
            this.colStartDate.StatusBarShortcut = null;
            this.colStartDate.StatusBarShortcutStatement = null;
            this.colStartDate.StatusBarStatement = null;
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 1;
            this.colStartDate.Width = 100;
            // 
            // colGrossPrice
            // 
            this.colGrossPrice.Caption = "Brüt Ücret";
            this.colGrossPrice.ColumnEdit = this.repositoryItemCalc;
            this.colGrossPrice.FieldName = "GrossPrice";
            this.colGrossPrice.Name = "colGrossPrice";
            this.colGrossPrice.OptionsColumn.AllowEdit = false;
            this.colGrossPrice.OptionsColumn.AllowMove = false;
            this.colGrossPrice.OptionsColumn.AllowShowHide = false;
            this.colGrossPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGrossPrice.OptionsFilter.AllowAutoFilter = false;
            this.colGrossPrice.OptionsFilter.AllowFilter = false;
            this.colGrossPrice.StatusBarShortcut = null;
            this.colGrossPrice.StatusBarShortcutStatement = null;
            this.colGrossPrice.StatusBarStatement = null;
            this.colGrossPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossPrice", "{0:c2}")});
            this.colGrossPrice.Visible = true;
            this.colGrossPrice.VisibleIndex = 2;
            this.colGrossPrice.Width = 90;
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
            // colShortTermDeductedPrice
            // 
            this.colShortTermDeductedPrice.Caption = "Kıst Dönem Düşülen Ücret";
            this.colShortTermDeductedPrice.ColumnEdit = this.repositoryItemCalc;
            this.colShortTermDeductedPrice.FieldName = "ShortTermDeductedPrice";
            this.colShortTermDeductedPrice.Name = "colShortTermDeductedPrice";
            this.colShortTermDeductedPrice.OptionsColumn.AllowEdit = false;
            this.colShortTermDeductedPrice.OptionsColumn.AllowMove = false;
            this.colShortTermDeductedPrice.OptionsColumn.AllowShowHide = false;
            this.colShortTermDeductedPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colShortTermDeductedPrice.OptionsFilter.AllowAutoFilter = false;
            this.colShortTermDeductedPrice.OptionsFilter.AllowFilter = false;
            this.colShortTermDeductedPrice.StatusBarShortcut = null;
            this.colShortTermDeductedPrice.StatusBarShortcutStatement = null;
            this.colShortTermDeductedPrice.StatusBarStatement = null;
            this.colShortTermDeductedPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShortTermDeductedPrice", "{0:c2}")});
            this.colShortTermDeductedPrice.Visible = true;
            this.colShortTermDeductedPrice.VisibleIndex = 3;
            this.colShortTermDeductedPrice.Width = 90;
            // 
            // colNetPrice
            // 
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
            this.colNetPrice.VisibleIndex = 4;
            this.colNetPrice.Width = 90;
            // 
            // colCancelled
            // 
            this.colCancelled.Caption = "İptal Edildi";
            this.colCancelled.FieldName = "Cancelled";
            this.colCancelled.Name = "colCancelled";
            this.colCancelled.OptionsColumn.AllowEdit = false;
            this.colCancelled.OptionsColumn.ShowInCustomizationForm = false;
            this.colCancelled.StatusBarShortcut = null;
            this.colCancelled.StatusBarShortcutStatement = null;
            this.colCancelled.StatusBarStatement = null;
            this.colCancelled.Width = 90;
            // 
            // colNumberOfEducationTermDateDays
            // 
            this.colNumberOfEducationTermDateDays.AppearanceCell.Options.UseTextOptions = true;
            this.colNumberOfEducationTermDateDays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumberOfEducationTermDateDays.Caption = "Eğitim Dönemi Gün Sayısı";
            this.colNumberOfEducationTermDateDays.FieldName = "NumberOfEducationTermDateDays";
            this.colNumberOfEducationTermDateDays.Name = "colNumberOfEducationTermDateDays";
            this.colNumberOfEducationTermDateDays.OptionsColumn.AllowEdit = false;
            this.colNumberOfEducationTermDateDays.OptionsColumn.AllowMove = false;
            this.colNumberOfEducationTermDateDays.OptionsColumn.AllowShowHide = false;
            this.colNumberOfEducationTermDateDays.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNumberOfEducationTermDateDays.OptionsFilter.AllowAutoFilter = false;
            this.colNumberOfEducationTermDateDays.OptionsFilter.AllowFilter = false;
            this.colNumberOfEducationTermDateDays.StatusBarShortcut = null;
            this.colNumberOfEducationTermDateDays.StatusBarShortcutStatement = null;
            this.colNumberOfEducationTermDateDays.StatusBarStatement = null;
            this.colNumberOfEducationTermDateDays.Visible = true;
            this.colNumberOfEducationTermDateDays.VisibleIndex = 6;
            // 
            // colNumberOfTakenServiceDays
            // 
            this.colNumberOfTakenServiceDays.AppearanceCell.Options.UseTextOptions = true;
            this.colNumberOfTakenServiceDays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumberOfTakenServiceDays.Caption = "Alınan Hizmet Gün Sayısı";
            this.colNumberOfTakenServiceDays.FieldName = "NumberOfTakenServiceDays";
            this.colNumberOfTakenServiceDays.Name = "colNumberOfTakenServiceDays";
            this.colNumberOfTakenServiceDays.OptionsColumn.AllowEdit = false;
            this.colNumberOfTakenServiceDays.OptionsColumn.AllowMove = false;
            this.colNumberOfTakenServiceDays.OptionsColumn.AllowShowHide = false;
            this.colNumberOfTakenServiceDays.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNumberOfTakenServiceDays.OptionsFilter.AllowAutoFilter = false;
            this.colNumberOfTakenServiceDays.OptionsFilter.AllowFilter = false;
            this.colNumberOfTakenServiceDays.StatusBarShortcut = null;
            this.colNumberOfTakenServiceDays.StatusBarShortcutStatement = null;
            this.colNumberOfTakenServiceDays.StatusBarStatement = null;
            this.colNumberOfTakenServiceDays.Visible = true;
            this.colNumberOfTakenServiceDays.VisibleIndex = 7;
            // 
            // colDailyPrice
            // 
            this.colDailyPrice.Caption = "Günlük Ücret";
            this.colDailyPrice.ColumnEdit = this.repositoryItemCalc;
            this.colDailyPrice.FieldName = "DailyPrice";
            this.colDailyPrice.Name = "colDailyPrice";
            this.colDailyPrice.OptionsColumn.AllowEdit = false;
            this.colDailyPrice.OptionsColumn.AllowMove = false;
            this.colDailyPrice.OptionsColumn.AllowShowHide = false;
            this.colDailyPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDailyPrice.OptionsFilter.AllowAutoFilter = false;
            this.colDailyPrice.OptionsFilter.AllowFilter = false;
            this.colDailyPrice.StatusBarShortcut = null;
            this.colDailyPrice.StatusBarShortcutStatement = null;
            this.colDailyPrice.StatusBarStatement = null;
            this.colDailyPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DailyPrice", "{0:c2}")});
            this.colDailyPrice.Visible = true;
            this.colDailyPrice.VisibleIndex = 8;
            this.colDailyPrice.Width = 90;
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
            this.colCancellationDate.OptionsColumn.AllowMove = false;
            this.colCancellationDate.OptionsColumn.AllowShowHide = false;
            this.colCancellationDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCancellationDate.OptionsFilter.AllowAutoFilter = false;
            this.colCancellationDate.OptionsFilter.AllowFilter = false;
            this.colCancellationDate.StatusBarShortcut = "F4 :";
            this.colCancellationDate.StatusBarShortcutStatement = "Seçim Yap";
            this.colCancellationDate.StatusBarStatement = "Tarih Seçiniz";
            this.colCancellationDate.Visible = true;
            this.colCancellationDate.VisibleIndex = 9;
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
            // colCancellationReasonId
            // 
            this.colCancellationReasonId.Caption = "İptal Nedeni Id";
            this.colCancellationReasonId.FieldName = "CancellationReasonId";
            this.colCancellationReasonId.Name = "colCancellationReasonId";
            this.colCancellationReasonId.OptionsColumn.AllowEdit = false;
            this.colCancellationReasonId.OptionsColumn.ShowInCustomizationForm = false;
            this.colCancellationReasonId.StatusBarShortcut = null;
            this.colCancellationReasonId.StatusBarShortcutStatement = null;
            this.colCancellationReasonId.StatusBarStatement = null;
            // 
            // colCancellationReasonName
            // 
            this.colCancellationReasonName.Caption = "İptal Nedeni Adı";
            this.colCancellationReasonName.ColumnEdit = this.repositoryItemCancellationReason;
            this.colCancellationReasonName.FieldName = "CancellationReasonName";
            this.colCancellationReasonName.Name = "colCancellationReasonName";
            this.colCancellationReasonName.OptionsColumn.AllowEdit = false;
            this.colCancellationReasonName.OptionsColumn.AllowMove = false;
            this.colCancellationReasonName.OptionsColumn.AllowShowHide = false;
            this.colCancellationReasonName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCancellationReasonName.OptionsFilter.AllowAutoFilter = false;
            this.colCancellationReasonName.OptionsFilter.AllowFilter = false;
            this.colCancellationReasonName.StatusBarShortcut = "F4 :";
            this.colCancellationReasonName.StatusBarShortcutStatement = "Seçim Yap";
            this.colCancellationReasonName.StatusBarStatement = "İptal Nedeni Seçiniz";
            this.colCancellationReasonName.Visible = true;
            this.colCancellationReasonName.VisibleIndex = 10;
            this.colCancellationReasonName.Width = 120;
            // 
            // repositoryItemCancellationReason
            // 
            this.repositoryItemCancellationReason.AutoHeight = false;
            this.repositoryItemCancellationReason.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemCancellationReason.Name = "repositoryItemCancellationReason";
            this.repositoryItemCancellationReason.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colSchooltoGoesId
            // 
            this.colSchooltoGoesId.Caption = "Gittiği Okul Id";
            this.colSchooltoGoesId.FieldName = "SchoolToGoesId";
            this.colSchooltoGoesId.Name = "colSchooltoGoesId";
            this.colSchooltoGoesId.OptionsColumn.AllowEdit = false;
            this.colSchooltoGoesId.OptionsColumn.ShowInCustomizationForm = false;
            this.colSchooltoGoesId.StatusBarShortcut = null;
            this.colSchooltoGoesId.StatusBarShortcutStatement = null;
            this.colSchooltoGoesId.StatusBarStatement = null;
            // 
            // colSchoolToGoesName
            // 
            this.colSchoolToGoesName.Caption = "Gittiği Okul Adı";
            this.colSchoolToGoesName.ColumnEdit = this.repositoryItemSchoolToGoes;
            this.colSchoolToGoesName.FieldName = "SchoolToGoesName";
            this.colSchoolToGoesName.Name = "colSchoolToGoesName";
            this.colSchoolToGoesName.OptionsColumn.AllowEdit = false;
            this.colSchoolToGoesName.OptionsColumn.AllowMove = false;
            this.colSchoolToGoesName.OptionsColumn.AllowShowHide = false;
            this.colSchoolToGoesName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSchoolToGoesName.OptionsFilter.AllowAutoFilter = false;
            this.colSchoolToGoesName.OptionsFilter.AllowFilter = false;
            this.colSchoolToGoesName.StatusBarShortcut = "F4 :";
            this.colSchoolToGoesName.StatusBarShortcutStatement = "Seçim Yap";
            this.colSchoolToGoesName.StatusBarStatement = "Okul Seçiniz";
            this.colSchoolToGoesName.Visible = true;
            this.colSchoolToGoesName.VisibleIndex = 11;
            this.colSchoolToGoesName.Width = 120;
            // 
            // repositoryItemSchoolToGoes
            // 
            this.repositoryItemSchoolToGoes.AutoHeight = false;
            this.repositoryItemSchoolToGoes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSchoolToGoes.Name = "repositoryItemSchoolToGoes";
            this.repositoryItemSchoolToGoes.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colCancellationStatement
            // 
            this.colCancellationStatement.Caption = "İptal Açıklaması";
            this.colCancellationStatement.FieldName = "CancellationStatement";
            this.colCancellationStatement.Name = "colCancellationStatement";
            this.colCancellationStatement.OptionsColumn.AllowEdit = false;
            this.colCancellationStatement.OptionsColumn.AllowMove = false;
            this.colCancellationStatement.OptionsColumn.AllowShowHide = false;
            this.colCancellationStatement.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCancellationStatement.OptionsFilter.AllowAutoFilter = false;
            this.colCancellationStatement.OptionsFilter.AllowFilter = false;
            this.colCancellationStatement.StatusBarShortcut = null;
            this.colCancellationStatement.StatusBarShortcutStatement = null;
            this.colCancellationStatement.StatusBarStatement = "İptal Açıklaması Giriniz";
            this.colCancellationStatement.Visible = true;
            this.colCancellationStatement.VisibleIndex = 12;
            this.colCancellationStatement.Width = 200;
            // 
            // ServiceInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "ServiceInformationsTable";
            this.Size = new System.Drawing.Size(1089, 364);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCancellationReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSchoolToGoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colServiceId;
        private Grids.MyGridColumn colServiceName;
        private Grids.MyGridColumn colServiceTypeId;
        private Grids.MyGridColumn colSchoolBusId;
        private Grids.MyGridColumn colSchoolBusName;
        private Grids.MyGridColumn colTransactionDate;
        private Grids.MyGridColumn colStartDate;
        private Grids.MyGridColumn colGrossPrice;
        private Grids.MyGridColumn colShortTermDeductedPrice;
        private Grids.MyGridColumn colNetPrice;
        private Grids.MyGridColumn colCancelled;
        private Grids.MyGridColumn colNumberOfEducationTermDateDays;
        private Grids.MyGridColumn colNumberOfTakenServiceDays;
        private Grids.MyGridColumn colDailyPrice;
        private Grids.MyGridColumn colCancellationDate;
        private Grids.MyGridColumn colCancellationReasonId;
        private Grids.MyGridColumn colCancellationReasonName;
        private Grids.MyGridColumn colSchooltoGoesId;
        private Grids.MyGridColumn colSchoolToGoesName;
        private Grids.MyGridColumn colCancellationStatement;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemCancellationReason;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemSchoolToGoes;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemCancellationDate;
    }
}
