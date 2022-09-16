﻿namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BankAccountForms
{
    partial class BankAccountListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountListForm));
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCode = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankAccountName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccountType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAccountOpeningDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBlockedDay = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAccountNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIbanNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplaceNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTerminaNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
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
            this.repositoryItemDate});
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
            this.gridBand4});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colCode,
            this.colBankAccountName,
            this.colAccountType,
            this.colBankName,
            this.colBankBranchName,
            this.colAccountOpeningDate,
            this.colBlockedDay,
            this.colAccountNumber,
            this.colIbanNumber,
            this.colWorkplaceNumber,
            this.colTerminaNumber,
            this.colSpecialCode1Name,
            this.colSpecialCode2Name,
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
            this.table.ViewCaption = "Banka Hesap Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Hesap Bilgileri";
            this.gridBand1.Columns.Add(this.colCode);
            this.gridBand1.Columns.Add(this.colBankAccountName);
            this.gridBand1.Columns.Add(this.colAccountType);
            this.gridBand1.Columns.Add(this.colBankName);
            this.gridBand1.Columns.Add(this.colBankBranchName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 690;
            // 
            // colCode
            // 
            this.colCode.AppearanceCell.Options.UseTextOptions = true;
            this.colCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.StatusBarShortcut = null;
            this.colCode.StatusBarShortcutStatement = null;
            this.colCode.StatusBarStatement = null;
            this.colCode.Visible = true;
            this.colCode.Width = 120;
            // 
            // colBankAccountName
            // 
            this.colBankAccountName.Caption = "Banka Hesap Adı";
            this.colBankAccountName.FieldName = "BankAccountName";
            this.colBankAccountName.Name = "colBankAccountName";
            this.colBankAccountName.OptionsColumn.AllowEdit = false;
            this.colBankAccountName.StatusBarShortcut = null;
            this.colBankAccountName.StatusBarShortcutStatement = null;
            this.colBankAccountName.StatusBarStatement = null;
            this.colBankAccountName.Visible = true;
            this.colBankAccountName.Width = 150;
            // 
            // colAccountType
            // 
            this.colAccountType.Caption = "Hesap Türü";
            this.colAccountType.FieldName = "BankAccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.OptionsColumn.AllowEdit = false;
            this.colAccountType.StatusBarShortcut = null;
            this.colAccountType.StatusBarShortcutStatement = null;
            this.colAccountType.StatusBarStatement = null;
            this.colAccountType.Visible = true;
            this.colAccountType.Width = 130;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Banka Adı";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowEdit = false;
            this.colBankName.StatusBarShortcut = null;
            this.colBankName.StatusBarShortcutStatement = null;
            this.colBankName.StatusBarStatement = null;
            this.colBankName.Visible = true;
            this.colBankName.Width = 150;
            // 
            // colBankBranchName
            // 
            this.colBankBranchName.Caption = "Banka Şube Adı";
            this.colBankBranchName.FieldName = "BankBranchName";
            this.colBankBranchName.Name = "colBankBranchName";
            this.colBankBranchName.OptionsColumn.AllowEdit = false;
            this.colBankBranchName.StatusBarShortcut = null;
            this.colBankBranchName.StatusBarShortcutStatement = null;
            this.colBankBranchName.StatusBarStatement = null;
            this.colBankBranchName.Visible = true;
            this.colBankBranchName.Width = 140;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Hesap Detay Bilgileri";
            this.gridBand2.Columns.Add(this.colAccountOpeningDate);
            this.gridBand2.Columns.Add(this.colBlockedDay);
            this.gridBand2.Columns.Add(this.colAccountNumber);
            this.gridBand2.Columns.Add(this.colIbanNumber);
            this.gridBand2.Columns.Add(this.colWorkplaceNumber);
            this.gridBand2.Columns.Add(this.colTerminaNumber);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 640;
            // 
            // colAccountOpeningDate
            // 
            this.colAccountOpeningDate.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountOpeningDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountOpeningDate.Caption = "Açılış Tarihi";
            this.colAccountOpeningDate.ColumnEdit = this.repositoryItemDate;
            this.colAccountOpeningDate.CustomizationCaption = "Hesap Açılış Tarihi";
            this.colAccountOpeningDate.FieldName = "AccountOpeningDate";
            this.colAccountOpeningDate.Name = "colAccountOpeningDate";
            this.colAccountOpeningDate.OptionsColumn.AllowEdit = false;
            this.colAccountOpeningDate.StatusBarShortcut = null;
            this.colAccountOpeningDate.StatusBarShortcutStatement = null;
            this.colAccountOpeningDate.StatusBarStatement = null;
            this.colAccountOpeningDate.Visible = true;
            this.colAccountOpeningDate.Width = 100;
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
            // colBlockedDay
            // 
            this.colBlockedDay.Caption = "Bloke Gün Sayısı";
            this.colBlockedDay.FieldName = "BlockedDay";
            this.colBlockedDay.Name = "colBlockedDay";
            this.colBlockedDay.OptionsColumn.AllowEdit = false;
            this.colBlockedDay.StatusBarShortcut = null;
            this.colBlockedDay.StatusBarShortcutStatement = null;
            this.colBlockedDay.StatusBarStatement = null;
            this.colBlockedDay.Visible = true;
            this.colBlockedDay.Width = 90;
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
            this.colAccountNumber.Width = 70;
            // 
            // colIbanNumber
            // 
            this.colIbanNumber.Caption = "IBAN No";
            this.colIbanNumber.FieldName = "IbanNumber";
            this.colIbanNumber.MinWidth = 200;
            this.colIbanNumber.Name = "colIbanNumber";
            this.colIbanNumber.OptionsColumn.AllowEdit = false;
            this.colIbanNumber.StatusBarShortcut = null;
            this.colIbanNumber.StatusBarShortcutStatement = null;
            this.colIbanNumber.StatusBarStatement = null;
            this.colIbanNumber.Visible = true;
            this.colIbanNumber.Width = 200;
            // 
            // colWorkplaceNumber
            // 
            this.colWorkplaceNumber.Caption = "İşyeri No";
            this.colWorkplaceNumber.FieldName = "WorkplaceNumber";
            this.colWorkplaceNumber.Name = "colWorkplaceNumber";
            this.colWorkplaceNumber.OptionsColumn.AllowEdit = false;
            this.colWorkplaceNumber.StatusBarShortcut = null;
            this.colWorkplaceNumber.StatusBarShortcutStatement = null;
            this.colWorkplaceNumber.StatusBarStatement = null;
            this.colWorkplaceNumber.Visible = true;
            this.colWorkplaceNumber.Width = 90;
            // 
            // colTerminaNumber
            // 
            this.colTerminaNumber.Caption = "Terminal No";
            this.colTerminaNumber.FieldName = "TerminalNumber";
            this.colTerminaNumber.Name = "colTerminaNumber";
            this.colTerminaNumber.OptionsColumn.AllowEdit = false;
            this.colTerminaNumber.StatusBarShortcut = null;
            this.colTerminaNumber.StatusBarShortcutStatement = null;
            this.colTerminaNumber.StatusBarStatement = null;
            this.colTerminaNumber.Visible = true;
            this.colTerminaNumber.Width = 90;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod";
            this.gridBand3.Columns.Add(this.colSpecialCode1Name);
            this.gridBand3.Columns.Add(this.colSpecialCode2Name);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 260;
            // 
            // colSpecialCode1Name
            // 
            this.colSpecialCode1Name.Caption = "Özel Kod - 1";
            this.colSpecialCode1Name.FieldName = "SpecialCode1Name";
            this.colSpecialCode1Name.Name = "colSpecialCode1Name";
            this.colSpecialCode1Name.OptionsColumn.AllowEdit = false;
            this.colSpecialCode1Name.StatusBarShortcut = null;
            this.colSpecialCode1Name.StatusBarShortcutStatement = null;
            this.colSpecialCode1Name.StatusBarStatement = null;
            this.colSpecialCode1Name.Visible = true;
            this.colSpecialCode1Name.Width = 130;
            // 
            // colSpecialCode2Name
            // 
            this.colSpecialCode2Name.Caption = "Özel Kod - 2";
            this.colSpecialCode2Name.FieldName = "SpecialCode2Name";
            this.colSpecialCode2Name.Name = "colSpecialCode2Name";
            this.colSpecialCode2Name.OptionsColumn.AllowEdit = false;
            this.colSpecialCode2Name.StatusBarShortcut = null;
            this.colSpecialCode2Name.StatusBarShortcutStatement = null;
            this.colSpecialCode2Name.StatusBarStatement = null;
            this.colSpecialCode2Name.Visible = true;
            this.colSpecialCode2Name.Width = 130;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colStatement);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 300;
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
            // BankAccountListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "BankAccountListForm";
            this.Text = "Banka Hesap Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView table;
        private UserControls.Grids.MyBandedGridColumn colId;
        private UserControls.Grids.MyBandedGridColumn colCode;
        private UserControls.Grids.MyBandedGridColumn colBankAccountName;
        private UserControls.Grids.MyBandedGridColumn colAccountType;
        private UserControls.Grids.MyBandedGridColumn colBankName;
        private UserControls.Grids.MyBandedGridColumn colBankBranchName;
        private UserControls.Grids.MyBandedGridColumn colAccountOpeningDate;
        private UserControls.Grids.MyBandedGridColumn colBlockedDay;
        private UserControls.Grids.MyBandedGridColumn colAccountNumber;
        private UserControls.Grids.MyBandedGridColumn colIbanNumber;
        private UserControls.Grids.MyBandedGridColumn colWorkplaceNumber;
        private UserControls.Grids.MyBandedGridColumn colTerminaNumber;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2Name;
        private UserControls.Grids.MyBandedGridColumn colStatement;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}