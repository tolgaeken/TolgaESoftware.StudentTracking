namespace TolgaESoftware.StudentTracking.UI.Win.Forms.LawyerForms
{
    partial class LawyerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerListForm));
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCode = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTrIdentityNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNameLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colContractNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colContractStartDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colContractEndDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
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
            this.colTrIdentityNumber,
            this.colNameLastname,
            this.colContractNumber,
            this.colContractStartDate,
            this.colContractEndDate,
            this.colSpecialCode1,
            this.colSpecialCode2,
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
            this.table.ViewCaption = "Avukat Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Avukat Bilgileri";
            this.gridBand1.Columns.Add(this.colCode);
            this.gridBand1.Columns.Add(this.colTrIdentityNumber);
            this.gridBand1.Columns.Add(this.colNameLastname);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 380;
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
            this.colCode.Width = 130;
            // 
            // colTrIdentityNumber
            // 
            this.colTrIdentityNumber.Caption = "TC Kimlik No";
            this.colTrIdentityNumber.FieldName = "TrIdentityNumber";
            this.colTrIdentityNumber.Name = "colTrIdentityNumber";
            this.colTrIdentityNumber.OptionsColumn.AllowEdit = false;
            this.colTrIdentityNumber.StatusBarShortcut = null;
            this.colTrIdentityNumber.StatusBarShortcutStatement = null;
            this.colTrIdentityNumber.StatusBarStatement = null;
            this.colTrIdentityNumber.Visible = true;
            this.colTrIdentityNumber.Width = 100;
            // 
            // colNameLastname
            // 
            this.colNameLastname.Caption = "Adı Soyadı";
            this.colNameLastname.FieldName = "NameLastname";
            this.colNameLastname.Name = "colNameLastname";
            this.colNameLastname.OptionsColumn.AllowEdit = false;
            this.colNameLastname.StatusBarShortcut = null;
            this.colNameLastname.StatusBarShortcutStatement = null;
            this.colNameLastname.StatusBarStatement = null;
            this.colNameLastname.Visible = true;
            this.colNameLastname.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Sözleşme Bilgileri";
            this.gridBand2.Columns.Add(this.colContractNumber);
            this.gridBand2.Columns.Add(this.colContractStartDate);
            this.gridBand2.Columns.Add(this.colContractEndDate);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 300;
            // 
            // colContractNumber
            // 
            this.colContractNumber.Caption = "Sözleşme No";
            this.colContractNumber.FieldName = "ContractNumber";
            this.colContractNumber.Name = "colContractNumber";
            this.colContractNumber.OptionsColumn.AllowEdit = false;
            this.colContractNumber.StatusBarShortcut = null;
            this.colContractNumber.StatusBarShortcutStatement = null;
            this.colContractNumber.StatusBarStatement = null;
            this.colContractNumber.Visible = true;
            this.colContractNumber.Width = 100;
            // 
            // colContractStartDate
            // 
            this.colContractStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colContractStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractStartDate.Caption = "Başlangıç Tarihi";
            this.colContractStartDate.ColumnEdit = this.repositoryItemDate;
            this.colContractStartDate.CustomizationCaption = "Sözleşme Başlangıç Tarihi";
            this.colContractStartDate.FieldName = "ContractStartDate";
            this.colContractStartDate.Name = "colContractStartDate";
            this.colContractStartDate.OptionsColumn.AllowEdit = false;
            this.colContractStartDate.StatusBarShortcut = null;
            this.colContractStartDate.StatusBarShortcutStatement = null;
            this.colContractStartDate.StatusBarStatement = null;
            this.colContractStartDate.Visible = true;
            this.colContractStartDate.Width = 100;
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
            // colContractEndDate
            // 
            this.colContractEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colContractEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractEndDate.Caption = "Bitiş Tarihi";
            this.colContractEndDate.ColumnEdit = this.repositoryItemDate;
            this.colContractEndDate.CustomizationCaption = "Sözleşme Bitiş Tarihi";
            this.colContractEndDate.FieldName = "ContractEndDate";
            this.colContractEndDate.Name = "colContractEndDate";
            this.colContractEndDate.OptionsColumn.AllowEdit = false;
            this.colContractEndDate.StatusBarShortcut = null;
            this.colContractEndDate.StatusBarShortcutStatement = null;
            this.colContractEndDate.StatusBarStatement = null;
            this.colContractEndDate.Visible = true;
            this.colContractEndDate.Width = 100;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod";
            this.gridBand3.Columns.Add(this.colSpecialCode1);
            this.gridBand3.Columns.Add(this.colSpecialCode2);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 300;
            // 
            // colSpecialCode1
            // 
            this.colSpecialCode1.Caption = "Özel Kod - 1";
            this.colSpecialCode1.FieldName = "SpecialCode1Name";
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
            this.colSpecialCode2.FieldName = "SpecialCode2Name";
            this.colSpecialCode2.Name = "colSpecialCode2";
            this.colSpecialCode2.OptionsColumn.AllowEdit = false;
            this.colSpecialCode2.StatusBarShortcut = null;
            this.colSpecialCode2.StatusBarShortcutStatement = null;
            this.colSpecialCode2.StatusBarStatement = null;
            this.colSpecialCode2.Visible = true;
            this.colSpecialCode2.Width = 150;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colStatement);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 250;
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
            // LaywerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "LaywerListForm";
            this.Text = "Avukat Kartları";
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
        private UserControls.Grids.MyBandedGridColumn colNameLastname;
        private UserControls.Grids.MyBandedGridColumn colContractNumber;
        private UserControls.Grids.MyBandedGridColumn colContractStartDate;
        private UserControls.Grids.MyBandedGridColumn colContractEndDate;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private UserControls.Grids.MyBandedGridColumn colStatement;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private UserControls.Grids.MyBandedGridColumn colTrIdentityNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}