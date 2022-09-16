namespace TolgaESoftware.StudentTracking.UI.Win.Forms.CustomerForms
{
    partial class CustomerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListForm));
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCode = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTrIdentityNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCustomerName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPhone1 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPhone2 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPhone3 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPhone4 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colFax = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWeb = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEMail = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTaxAdministration = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTaxNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAddress = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
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
            this.gridBand3});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colCode,
            this.colCustomerName,
            this.colTrIdentityNumber,
            this.colPhone1,
            this.colPhone2,
            this.colPhone3,
            this.colPhone4,
            this.colFax,
            this.colWeb,
            this.colEMail,
            this.colTaxAdministration,
            this.colTaxNumber,
            this.colAddress,
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
            this.table.ViewCaption = "Cari Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Cari Bilgileri";
            this.gridBand1.Columns.Add(this.colCode);
            this.gridBand1.Columns.Add(this.colTrIdentityNumber);
            this.gridBand1.Columns.Add(this.colCustomerName);
            this.gridBand1.Columns.Add(this.colPhone1);
            this.gridBand1.Columns.Add(this.colPhone2);
            this.gridBand1.Columns.Add(this.colPhone3);
            this.gridBand1.Columns.Add(this.colPhone4);
            this.gridBand1.Columns.Add(this.colFax);
            this.gridBand1.Columns.Add(this.colWeb);
            this.gridBand1.Columns.Add(this.colEMail);
            this.gridBand1.Columns.Add(this.colTaxAdministration);
            this.gridBand1.Columns.Add(this.colTaxNumber);
            this.gridBand1.Columns.Add(this.colAddress);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 550;
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
            this.colCode.Width = 100;
            // 
            // colTrIdentityNumber
            // 
            this.colTrIdentityNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colTrIdentityNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Cari Adı";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.StatusBarShortcut = null;
            this.colCustomerName.StatusBarShortcutStatement = null;
            this.colCustomerName.StatusBarStatement = null;
            this.colCustomerName.Visible = true;
            this.colCustomerName.Width = 150;
            // 
            // colPhone1
            // 
            this.colPhone1.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone1.Caption = "Telefon - 1";
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.OptionsColumn.AllowEdit = false;
            this.colPhone1.StatusBarShortcut = null;
            this.colPhone1.StatusBarShortcutStatement = null;
            this.colPhone1.StatusBarStatement = null;
            this.colPhone1.Visible = true;
            this.colPhone1.Width = 100;
            // 
            // colPhone2
            // 
            this.colPhone2.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone2.Caption = "Telefon - 2";
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.OptionsColumn.AllowEdit = false;
            this.colPhone2.StatusBarShortcut = null;
            this.colPhone2.StatusBarShortcutStatement = null;
            this.colPhone2.StatusBarStatement = null;
            this.colPhone2.Visible = true;
            this.colPhone2.Width = 100;
            // 
            // colPhone3
            // 
            this.colPhone3.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone3.Caption = "Telefon - 3";
            this.colPhone3.FieldName = "Phone3";
            this.colPhone3.Name = "colPhone3";
            this.colPhone3.OptionsColumn.AllowEdit = false;
            this.colPhone3.StatusBarShortcut = null;
            this.colPhone3.StatusBarShortcutStatement = null;
            this.colPhone3.StatusBarStatement = null;
            this.colPhone3.Width = 100;
            // 
            // colPhone4
            // 
            this.colPhone4.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone4.Caption = "Telefon - 4";
            this.colPhone4.FieldName = "Phone4";
            this.colPhone4.Name = "colPhone4";
            this.colPhone4.OptionsColumn.AllowEdit = false;
            this.colPhone4.StatusBarShortcut = null;
            this.colPhone4.StatusBarShortcutStatement = null;
            this.colPhone4.StatusBarStatement = null;
            this.colPhone4.Width = 100;
            // 
            // colFax
            // 
            this.colFax.AppearanceCell.Options.UseTextOptions = true;
            this.colFax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.StatusBarShortcut = null;
            this.colFax.StatusBarShortcutStatement = null;
            this.colFax.StatusBarStatement = null;
            this.colFax.Width = 100;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web Adresi";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarShortcut = null;
            this.colWeb.StatusBarShortcutStatement = null;
            this.colWeb.StatusBarStatement = null;
            this.colWeb.Width = 200;
            // 
            // colEMail
            // 
            this.colEMail.Caption = "E - Mail Adresi";
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.OptionsColumn.AllowEdit = false;
            this.colEMail.StatusBarShortcut = null;
            this.colEMail.StatusBarShortcutStatement = null;
            this.colEMail.StatusBarStatement = null;
            this.colEMail.Width = 200;
            // 
            // colTaxAdministration
            // 
            this.colTaxAdministration.Caption = "Vergi Dairesi";
            this.colTaxAdministration.FieldName = "TaxAdministration";
            this.colTaxAdministration.Name = "colTaxAdministration";
            this.colTaxAdministration.OptionsColumn.AllowEdit = false;
            this.colTaxAdministration.StatusBarShortcut = null;
            this.colTaxAdministration.StatusBarShortcutStatement = null;
            this.colTaxAdministration.StatusBarStatement = null;
            this.colTaxAdministration.Width = 150;
            // 
            // colTaxNumber
            // 
            this.colTaxNumber.Caption = "Vergi No";
            this.colTaxNumber.FieldName = "TaxNumber";
            this.colTaxNumber.Name = "colTaxNumber";
            this.colTaxNumber.OptionsColumn.AllowEdit = false;
            this.colTaxNumber.StatusBarShortcut = null;
            this.colTaxNumber.StatusBarShortcutStatement = null;
            this.colTaxNumber.StatusBarStatement = null;
            this.colTaxNumber.Width = 100;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Adresi";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.StatusBarShortcut = null;
            this.colAddress.StatusBarShortcutStatement = null;
            this.colAddress.StatusBarStatement = null;
            this.colAddress.Width = 250;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Özel Kod";
            this.gridBand2.Columns.Add(this.colSpecialCode1Name);
            this.gridBand2.Columns.Add(this.colSpecialCode2Name);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 200;
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
            this.colSpecialCode1Name.Width = 100;
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
            this.colSpecialCode2Name.Width = 100;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Ek Bilgiler";
            this.gridBand3.Columns.Add(this.colStatement);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 300;
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
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CustomerListForm";
            this.Text = "Cari Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView table;
        private UserControls.Grids.MyBandedGridColumn colId;
        private UserControls.Grids.MyBandedGridColumn colCode;
        private UserControls.Grids.MyBandedGridColumn colCustomerName;
        private UserControls.Grids.MyBandedGridColumn colTrIdentityNumber;
        private UserControls.Grids.MyBandedGridColumn colPhone1;
        private UserControls.Grids.MyBandedGridColumn colPhone2;
        private UserControls.Grids.MyBandedGridColumn colPhone3;
        private UserControls.Grids.MyBandedGridColumn colPhone4;
        private UserControls.Grids.MyBandedGridColumn colFax;
        private UserControls.Grids.MyBandedGridColumn colWeb;
        private UserControls.Grids.MyBandedGridColumn colEMail;
        private UserControls.Grids.MyBandedGridColumn colTaxAdministration;
        private UserControls.Grids.MyBandedGridColumn colTaxNumber;
        private UserControls.Grids.MyBandedGridColumn colAddress;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2Name;
        private UserControls.Grids.MyBandedGridColumn colStatement;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}