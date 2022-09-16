namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms
{
    partial class DocumentSelectionListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentSelectionListForm));
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.bndSelection = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStudentNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colClassName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colStudentBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colWalletNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colDocumentBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPaymentTypeName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankAccountName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTrackNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEntryDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPaymentTerm = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccountTransferDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colCollect = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colRefund = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colRemaining = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colDocumentStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastProcessDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastProcessPlace = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.bndDocumentDetailInformations = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBankName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colDocumentNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccountNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPrincipalDebtor = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEndorser = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(898, 109);
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 551);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(898, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemCalc});
            this.grid.Size = new System.Drawing.Size(898, 442);
            this.grid.TabIndex = 6;
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
            this.bndSelection,
            this.gridBand1,
            this.gridBand2,
            this.bndDocumentDetailInformations});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colStudentNumber,
            this.colName,
            this.colLastname,
            this.colClassName,
            this.colStudentBranchName,
            this.colDocumentBranchName,
            this.colPaymentTypeName,
            this.colBankAccountName,
            this.colTrackNumber,
            this.colWalletNumber,
            this.colEntryDate,
            this.colPaymentTerm,
            this.colAccountTransferDate,
            this.colPrice,
            this.colCollect,
            this.colRefund,
            this.colRemaining,
            this.colLastProcessDate,
            this.colLastProcessPlace,
            this.colBankName,
            this.colBankBranchName,
            this.colDocumentNumber,
            this.colAccountNumber,
            this.colPrincipalDebtor,
            this.colEndorser,
            this.colDocumentStatus,
            this.colStatement});
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
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = null;
            this.table.StatusBarShortcutStatement = null;
            this.table.StatusBarStatement = null;
            this.table.ViewCaption = "Belge Seçimi";
            // 
            // bndSelection
            // 
            this.bndSelection.Caption = "Seç";
            this.bndSelection.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.bndSelection.Name = "bndSelection";
            this.bndSelection.Visible = false;
            this.bndSelection.VisibleIndex = -1;
            this.bndSelection.Width = 35;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colStudentNumber);
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Columns.Add(this.colLastname);
            this.gridBand1.Columns.Add(this.colClassName);
            this.gridBand1.Columns.Add(this.colStudentBranchName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 500;
            // 
            // colStudentNumber
            // 
            this.colStudentNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colStudentNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStudentNumber.Caption = "Öğrenci No";
            this.colStudentNumber.FieldName = "StudentNumber";
            this.colStudentNumber.Name = "colStudentNumber";
            this.colStudentNumber.OptionsColumn.AllowEdit = false;
            this.colStudentNumber.StatusBarShortcut = null;
            this.colStudentNumber.StatusBarShortcutStatement = null;
            this.colStudentNumber.StatusBarStatement = null;
            this.colStudentNumber.Visible = true;
            this.colStudentNumber.Width = 100;
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
            this.colName.Width = 100;
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
            this.colLastname.Width = 100;
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
            this.colClassName.Width = 100;
            // 
            // colStudentBranchName
            // 
            this.colStudentBranchName.Caption = "Şube Adı";
            this.colStudentBranchName.FieldName = "StudentBranchName";
            this.colStudentBranchName.Name = "colStudentBranchName";
            this.colStudentBranchName.OptionsColumn.AllowEdit = false;
            this.colStudentBranchName.StatusBarShortcut = null;
            this.colStudentBranchName.StatusBarShortcutStatement = null;
            this.colStudentBranchName.StatusBarStatement = null;
            this.colStudentBranchName.Visible = true;
            this.colStudentBranchName.Width = 100;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Belge Genel Bilgiler";
            this.gridBand2.Columns.Add(this.colWalletNumber);
            this.gridBand2.Columns.Add(this.colDocumentBranchName);
            this.gridBand2.Columns.Add(this.colPaymentTypeName);
            this.gridBand2.Columns.Add(this.colBankAccountName);
            this.gridBand2.Columns.Add(this.colTrackNumber);
            this.gridBand2.Columns.Add(this.colEntryDate);
            this.gridBand2.Columns.Add(this.colPaymentTerm);
            this.gridBand2.Columns.Add(this.colAccountTransferDate);
            this.gridBand2.Columns.Add(this.colPrice);
            this.gridBand2.Columns.Add(this.colCollect);
            this.gridBand2.Columns.Add(this.colRefund);
            this.gridBand2.Columns.Add(this.colRemaining);
            this.gridBand2.Columns.Add(this.colDocumentStatus);
            this.gridBand2.Columns.Add(this.colStatement);
            this.gridBand2.Columns.Add(this.colLastProcessDate);
            this.gridBand2.Columns.Add(this.colLastProcessPlace);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 2110;
            // 
            // colWalletNumber
            // 
            this.colWalletNumber.Caption = "Portföy No";
            this.colWalletNumber.FieldName = "PaymentInformationsId";
            this.colWalletNumber.Name = "colWalletNumber";
            this.colWalletNumber.OptionsColumn.AllowEdit = false;
            this.colWalletNumber.StatusBarShortcut = null;
            this.colWalletNumber.StatusBarShortcutStatement = null;
            this.colWalletNumber.StatusBarStatement = null;
            this.colWalletNumber.Visible = true;
            this.colWalletNumber.Width = 100;
            // 
            // colDocumentBranchName
            // 
            this.colDocumentBranchName.Caption = "Belge Şube Adı";
            this.colDocumentBranchName.FieldName = "DocumentBranchName";
            this.colDocumentBranchName.Name = "colDocumentBranchName";
            this.colDocumentBranchName.OptionsColumn.AllowEdit = false;
            this.colDocumentBranchName.StatusBarShortcut = null;
            this.colDocumentBranchName.StatusBarShortcutStatement = null;
            this.colDocumentBranchName.StatusBarStatement = null;
            this.colDocumentBranchName.Visible = true;
            this.colDocumentBranchName.Width = 200;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.Caption = "Ödeme Türü";
            this.colPaymentTypeName.FieldName = "PaymentMethodName";
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.OptionsColumn.AllowEdit = false;
            this.colPaymentTypeName.StatusBarShortcut = null;
            this.colPaymentTypeName.StatusBarShortcutStatement = null;
            this.colPaymentTypeName.StatusBarStatement = null;
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.Width = 100;
            // 
            // colBankAccountName
            // 
            this.colBankAccountName.Caption = "Hesap Adı";
            this.colBankAccountName.CustomizationCaption = "Banka Hesap Adı";
            this.colBankAccountName.FieldName = "BankAccountName";
            this.colBankAccountName.Name = "colBankAccountName";
            this.colBankAccountName.OptionsColumn.AllowEdit = false;
            this.colBankAccountName.StatusBarShortcut = null;
            this.colBankAccountName.StatusBarShortcutStatement = null;
            this.colBankAccountName.StatusBarStatement = null;
            this.colBankAccountName.Visible = true;
            this.colBankAccountName.Width = 150;
            // 
            // colTrackNumber
            // 
            this.colTrackNumber.Caption = "Takip No";
            this.colTrackNumber.FieldName = "TrackNumber";
            this.colTrackNumber.Name = "colTrackNumber";
            this.colTrackNumber.OptionsColumn.AllowEdit = false;
            this.colTrackNumber.StatusBarShortcut = null;
            this.colTrackNumber.StatusBarShortcutStatement = null;
            this.colTrackNumber.StatusBarStatement = null;
            this.colTrackNumber.Visible = true;
            this.colTrackNumber.Width = 100;
            // 
            // colEntryDate
            // 
            this.colEntryDate.AppearanceCell.Options.UseTextOptions = true;
            this.colEntryDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEntryDate.Caption = "Giriş Tarihi";
            this.colEntryDate.ColumnEdit = this.repositoryItemDate;
            this.colEntryDate.FieldName = "EntryDate";
            this.colEntryDate.Name = "colEntryDate";
            this.colEntryDate.OptionsColumn.AllowEdit = false;
            this.colEntryDate.StatusBarShortcut = null;
            this.colEntryDate.StatusBarShortcutStatement = null;
            this.colEntryDate.StatusBarStatement = null;
            this.colEntryDate.Visible = true;
            this.colEntryDate.Width = 100;
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
            // colPaymentTerm
            // 
            this.colPaymentTerm.AppearanceCell.Options.UseTextOptions = true;
            this.colPaymentTerm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentTerm.Caption = "Vade";
            this.colPaymentTerm.ColumnEdit = this.repositoryItemDate;
            this.colPaymentTerm.FieldName = "PaymentTerm";
            this.colPaymentTerm.Name = "colPaymentTerm";
            this.colPaymentTerm.OptionsColumn.AllowEdit = false;
            this.colPaymentTerm.StatusBarShortcut = null;
            this.colPaymentTerm.StatusBarShortcutStatement = null;
            this.colPaymentTerm.StatusBarStatement = null;
            this.colPaymentTerm.Visible = true;
            this.colPaymentTerm.Width = 100;
            // 
            // colAccountTransferDate
            // 
            this.colAccountTransferDate.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountTransferDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountTransferDate.Caption = "Hesaba Geçiş Tarihi";
            this.colAccountTransferDate.ColumnEdit = this.repositoryItemDate;
            this.colAccountTransferDate.FieldName = "AccountTransferDate";
            this.colAccountTransferDate.Name = "colAccountTransferDate";
            this.colAccountTransferDate.OptionsColumn.AllowEdit = false;
            this.colAccountTransferDate.StatusBarShortcut = null;
            this.colAccountTransferDate.StatusBarShortcutStatement = null;
            this.colAccountTransferDate.StatusBarStatement = null;
            this.colAccountTransferDate.Visible = true;
            this.colAccountTransferDate.Width = 110;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Tutar";
            this.colPrice.ColumnEdit = this.repositoryItemCalc;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.StatusBarShortcut = null;
            this.colPrice.StatusBarShortcutStatement = null;
            this.colPrice.StatusBarStatement = null;
            this.colPrice.Visible = true;
            this.colPrice.Width = 100;
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
            // colCollect
            // 
            this.colCollect.Caption = "Tahsil";
            this.colCollect.ColumnEdit = this.repositoryItemCalc;
            this.colCollect.FieldName = "Collect";
            this.colCollect.Name = "colCollect";
            this.colCollect.OptionsColumn.AllowEdit = false;
            this.colCollect.StatusBarShortcut = null;
            this.colCollect.StatusBarShortcutStatement = null;
            this.colCollect.StatusBarStatement = null;
            this.colCollect.Visible = true;
            this.colCollect.Width = 100;
            // 
            // colRefund
            // 
            this.colRefund.Caption = "İade";
            this.colRefund.ColumnEdit = this.repositoryItemCalc;
            this.colRefund.FieldName = "Refund";
            this.colRefund.Name = "colRefund";
            this.colRefund.OptionsColumn.AllowEdit = false;
            this.colRefund.StatusBarShortcut = null;
            this.colRefund.StatusBarShortcutStatement = null;
            this.colRefund.StatusBarStatement = null;
            this.colRefund.Visible = true;
            this.colRefund.Width = 100;
            // 
            // colRemaining
            // 
            this.colRemaining.Caption = "Kalan";
            this.colRemaining.ColumnEdit = this.repositoryItemCalc;
            this.colRemaining.FieldName = "Remaining";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.OptionsColumn.AllowEdit = false;
            this.colRemaining.StatusBarShortcut = null;
            this.colRemaining.StatusBarShortcutStatement = null;
            this.colRemaining.StatusBarStatement = null;
            this.colRemaining.Visible = true;
            this.colRemaining.Width = 100;
            // 
            // colDocumentStatus
            // 
            this.colDocumentStatus.Caption = "Durum";
            this.colDocumentStatus.FieldName = "DocumentStatus";
            this.colDocumentStatus.Name = "colDocumentStatus";
            this.colDocumentStatus.OptionsColumn.AllowEdit = false;
            this.colDocumentStatus.StatusBarShortcut = null;
            this.colDocumentStatus.StatusBarShortcutStatement = null;
            this.colDocumentStatus.StatusBarStatement = null;
            this.colDocumentStatus.Visible = true;
            this.colDocumentStatus.Width = 200;
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
            this.colStatement.Width = 250;
            // 
            // colLastProcessDate
            // 
            this.colLastProcessDate.Caption = "Son İşlem Tarihi";
            this.colLastProcessDate.FieldName = "LasProcessDate";
            this.colLastProcessDate.Name = "colLastProcessDate";
            this.colLastProcessDate.OptionsColumn.AllowEdit = false;
            this.colLastProcessDate.StatusBarShortcut = null;
            this.colLastProcessDate.StatusBarShortcutStatement = null;
            this.colLastProcessDate.StatusBarStatement = null;
            this.colLastProcessDate.Visible = true;
            this.colLastProcessDate.Width = 100;
            // 
            // colLastProcessPlace
            // 
            this.colLastProcessPlace.Caption = "Son İşlem Yeri";
            this.colLastProcessPlace.FieldName = "LastProcessPlace";
            this.colLastProcessPlace.Name = "colLastProcessPlace";
            this.colLastProcessPlace.OptionsColumn.AllowEdit = false;
            this.colLastProcessPlace.StatusBarShortcut = null;
            this.colLastProcessPlace.StatusBarShortcutStatement = null;
            this.colLastProcessPlace.StatusBarStatement = null;
            this.colLastProcessPlace.Visible = true;
            this.colLastProcessPlace.Width = 200;
            // 
            // bndDocumentDetailInformations
            // 
            this.bndDocumentDetailInformations.Caption = "Belge Detay Bilgiler";
            this.bndDocumentDetailInformations.Columns.Add(this.colBankName);
            this.bndDocumentDetailInformations.Columns.Add(this.colBankBranchName);
            this.bndDocumentDetailInformations.Columns.Add(this.colDocumentNumber);
            this.bndDocumentDetailInformations.Columns.Add(this.colAccountNumber);
            this.bndDocumentDetailInformations.Columns.Add(this.colPrincipalDebtor);
            this.bndDocumentDetailInformations.Columns.Add(this.colEndorser);
            this.bndDocumentDetailInformations.Name = "bndDocumentDetailInformations";
            this.bndDocumentDetailInformations.VisibleIndex = 2;
            this.bndDocumentDetailInformations.Width = 1000;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Banka";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowEdit = false;
            this.colBankName.StatusBarShortcut = null;
            this.colBankName.StatusBarShortcutStatement = null;
            this.colBankName.StatusBarStatement = null;
            this.colBankName.Visible = true;
            this.colBankName.Width = 200;
            // 
            // colBankBranchName
            // 
            this.colBankBranchName.Caption = "Banka Şube";
            this.colBankBranchName.FieldName = "BankBranchName";
            this.colBankBranchName.Name = "colBankBranchName";
            this.colBankBranchName.OptionsColumn.AllowEdit = false;
            this.colBankBranchName.StatusBarShortcut = null;
            this.colBankBranchName.StatusBarShortcutStatement = null;
            this.colBankBranchName.StatusBarStatement = null;
            this.colBankBranchName.Visible = true;
            this.colBankBranchName.Width = 200;
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.Caption = "Belge No";
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.OptionsColumn.AllowEdit = false;
            this.colDocumentNumber.StatusBarShortcut = null;
            this.colDocumentNumber.StatusBarShortcutStatement = null;
            this.colDocumentNumber.StatusBarStatement = null;
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.Width = 100;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.Caption = "Hesap No";
            this.colAccountNumber.FieldName = "AccountNumber";
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.OptionsColumn.AllowEdit = false;
            this.colAccountNumber.StatusBarShortcut = null;
            this.colAccountNumber.StatusBarShortcutStatement = null;
            this.colAccountNumber.StatusBarStatement = null;
            this.colAccountNumber.Visible = true;
            this.colAccountNumber.Width = 100;
            // 
            // colPrincipalDebtor
            // 
            this.colPrincipalDebtor.Caption = "Asıl Borçlu";
            this.colPrincipalDebtor.FieldName = "PrincipalDebtor";
            this.colPrincipalDebtor.Name = "colPrincipalDebtor";
            this.colPrincipalDebtor.OptionsColumn.AllowEdit = false;
            this.colPrincipalDebtor.StatusBarShortcut = null;
            this.colPrincipalDebtor.StatusBarShortcutStatement = null;
            this.colPrincipalDebtor.StatusBarStatement = null;
            this.colPrincipalDebtor.Visible = true;
            this.colPrincipalDebtor.Width = 200;
            // 
            // colEndorser
            // 
            this.colEndorser.Caption = "Ciranta";
            this.colEndorser.FieldName = "Endorser";
            this.colEndorser.Name = "colEndorser";
            this.colEndorser.OptionsColumn.AllowEdit = false;
            this.colEndorser.StatusBarShortcut = null;
            this.colEndorser.StatusBarShortcutStatement = null;
            this.colEndorser.StatusBarStatement = null;
            this.colEndorser.Visible = true;
            this.colEndorser.Width = 200;
            // 
            // DocumentSelectionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 599);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "DocumentSelectionListForm";
            this.Text = "Belge Seçimi";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView table;
        private UserControls.Grids.MyBandedGridColumn colStudentNumber;
        private UserControls.Grids.MyBandedGridColumn colName;
        private UserControls.Grids.MyBandedGridColumn colLastname;
        private UserControls.Grids.MyBandedGridColumn colClassName;
        private UserControls.Grids.MyBandedGridColumn colStudentBranchName;
        private UserControls.Grids.MyBandedGridColumn colWalletNumber;
        private UserControls.Grids.MyBandedGridColumn colDocumentBranchName;
        private UserControls.Grids.MyBandedGridColumn colPaymentTypeName;
        private UserControls.Grids.MyBandedGridColumn colBankAccountName;
        private UserControls.Grids.MyBandedGridColumn colTrackNumber;
        private UserControls.Grids.MyBandedGridColumn colEntryDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private UserControls.Grids.MyBandedGridColumn colPaymentTerm;
        private UserControls.Grids.MyBandedGridColumn colAccountTransferDate;
        private UserControls.Grids.MyBandedGridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private UserControls.Grids.MyBandedGridColumn colCollect;
        private UserControls.Grids.MyBandedGridColumn colRefund;
        private UserControls.Grids.MyBandedGridColumn colDocumentStatus;
        private UserControls.Grids.MyBandedGridColumn colBankName;
        private UserControls.Grids.MyBandedGridColumn colBankBranchName;
        private UserControls.Grids.MyBandedGridColumn colDocumentNumber;
        private UserControls.Grids.MyBandedGridColumn colAccountNumber;
        private UserControls.Grids.MyBandedGridColumn colPrincipalDebtor;
        private UserControls.Grids.MyBandedGridColumn colEndorser;
        private UserControls.Grids.MyBandedGridColumn colRemaining;
        private UserControls.Grids.MyBandedGridColumn colStatement;
        private UserControls.Grids.MyBandedGridColumn colLastProcessDate;
        private UserControls.Grids.MyBandedGridColumn colLastProcessPlace;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSelection;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndDocumentDetailInformations;
    }
}