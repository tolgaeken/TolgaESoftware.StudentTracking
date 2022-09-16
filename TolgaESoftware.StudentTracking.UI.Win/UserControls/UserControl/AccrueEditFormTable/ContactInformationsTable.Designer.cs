namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class ContactInformationsTable
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
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGuardianship = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemGuardianship = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBillingAddress = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemAddress = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colKinshipName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemKinship = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTrIdentityNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colHomePhone = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplacePhone1 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colInternalPhone1 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplacePhone2 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colInternalPhone2 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMobilePhone1 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMobilePhone2 = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colHomeAddress = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colHomeAddressProvinceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colHomeAddressDistrictName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colWorkplaceAddress = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplaceAddressProvinceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplaceAddressDistrictName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colVocationName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplaceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colJobName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKinshipId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGuardianship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemKinship)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 368);
            this.InsUptNavigator.Size = new System.Drawing.Size(913, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemKinship,
            this.repositoryItemAddress,
            this.repositoryItemGuardianship});
            this.grid.Size = new System.Drawing.Size(913, 368);
            this.grid.TabIndex = 5;
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
            this.table.BandPanelRowHeight = 20;
            this.table.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colGuardianship,
            this.colBillingAddress,
            this.colKinshipId,
            this.colKinshipName,
            this.colTrIdentityNumber,
            this.colName,
            this.colLastname,
            this.colHomePhone,
            this.colWorkplacePhone1,
            this.colInternalPhone1,
            this.colWorkplacePhone2,
            this.colInternalPhone2,
            this.colMobilePhone1,
            this.colMobilePhone2,
            this.colHomeAddress,
            this.colHomeAddressProvinceName,
            this.colHomeAddressDistrictName,
            this.colWorkplaceAddress,
            this.colWorkplaceAddressProvinceName,
            this.colWorkplaceAddressDistrictName,
            this.colVocationName,
            this.colWorkplaceName,
            this.colJobName});
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
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = "Shift + Insert :";
            this.table.StatusBarShortcutStatement = "Seçim Yap";
            this.table.StatusBarStatement = "İletişim Bilgileri Seçiniz";
            this.table.ViewCaption = "İletişim Bilgileri";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colGuardianship);
            this.gridBand1.Columns.Add(this.colBillingAddress);
            this.gridBand1.Columns.Add(this.colKinshipName);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 300;
            // 
            // colGuardianship
            // 
            this.colGuardianship.Caption = "Veli";
            this.colGuardianship.ColumnEdit = this.repositoryItemGuardianship;
            this.colGuardianship.FieldName = "Guardianship";
            this.colGuardianship.Name = "colGuardianship";
            this.colGuardianship.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGuardianship.OptionsFilter.AllowAutoFilter = false;
            this.colGuardianship.OptionsFilter.AllowFilter = false;
            this.colGuardianship.StatusBarShortcut = "Space :";
            this.colGuardianship.StatusBarShortcutStatement = "İşaretle";
            this.colGuardianship.StatusBarStatement = "Kişi Öğrenci Velisi İse İşaretleyiniz";
            this.colGuardianship.Visible = true;
            this.colGuardianship.Width = 100;
            // 
            // repositoryItemGuardianship
            // 
            this.repositoryItemGuardianship.AutoHeight = false;
            this.repositoryItemGuardianship.Name = "repositoryItemGuardianship";
            // 
            // colBillingAddress
            // 
            this.colBillingAddress.Caption = "Fatura Adresi";
            this.colBillingAddress.ColumnEdit = this.repositoryItemAddress;
            this.colBillingAddress.FieldName = "BillingAddress";
            this.colBillingAddress.Name = "colBillingAddress";
            this.colBillingAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBillingAddress.OptionsFilter.AllowAutoFilter = false;
            this.colBillingAddress.OptionsFilter.AllowFilter = false;
            this.colBillingAddress.StatusBarShortcut = "F4 :";
            this.colBillingAddress.StatusBarShortcutStatement = "Seçim Yap";
            this.colBillingAddress.StatusBarStatement = "Adres Türü Seçiniz";
            this.colBillingAddress.Visible = true;
            this.colBillingAddress.Width = 100;
            // 
            // repositoryItemAddress
            // 
            this.repositoryItemAddress.AutoHeight = false;
            this.repositoryItemAddress.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemAddress.Name = "repositoryItemAddress";
            // 
            // colKinshipName
            // 
            this.colKinshipName.Caption = "Yakınlık";
            this.colKinshipName.ColumnEdit = this.repositoryItemKinship;
            this.colKinshipName.FieldName = "KinshipName";
            this.colKinshipName.Name = "colKinshipName";
            this.colKinshipName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKinshipName.OptionsFilter.AllowAutoFilter = false;
            this.colKinshipName.OptionsFilter.AllowFilter = false;
            this.colKinshipName.StatusBarShortcut = "F4 :";
            this.colKinshipName.StatusBarShortcutStatement = "Seçim Yap";
            this.colKinshipName.StatusBarStatement = "Yakınlık Türü Seçiniz";
            this.colKinshipName.Visible = true;
            this.colKinshipName.Width = 100;
            // 
            // repositoryItemKinship
            // 
            this.repositoryItemKinship.AutoHeight = false;
            this.repositoryItemKinship.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemKinship.Name = "repositoryItemKinship";
            this.repositoryItemKinship.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Kimlik Bilgileri";
            this.gridBand2.Columns.Add(this.colTrIdentityNumber);
            this.gridBand2.Columns.Add(this.colName);
            this.gridBand2.Columns.Add(this.colLastname);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 250;
            // 
            // colTrIdentityNumber
            // 
            this.colTrIdentityNumber.Caption = "TC Kimlik No";
            this.colTrIdentityNumber.FieldName = "TrIdentityNumber";
            this.colTrIdentityNumber.Name = "colTrIdentityNumber";
            this.colTrIdentityNumber.OptionsColumn.AllowEdit = false;
            this.colTrIdentityNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTrIdentityNumber.OptionsFilter.AllowAutoFilter = false;
            this.colTrIdentityNumber.OptionsFilter.AllowFilter = false;
            this.colTrIdentityNumber.StatusBarShortcut = null;
            this.colTrIdentityNumber.StatusBarShortcutStatement = null;
            this.colTrIdentityNumber.StatusBarStatement = null;
            this.colTrIdentityNumber.Visible = true;
            this.colTrIdentityNumber.Width = 100;
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsFilter.AllowAutoFilter = false;
            this.colName.OptionsFilter.AllowFilter = false;
            this.colName.StatusBarShortcut = null;
            this.colName.StatusBarShortcutStatement = null;
            this.colName.StatusBarStatement = null;
            this.colName.Visible = true;
            // 
            // colLastname
            // 
            this.colLastname.Caption = "Soyadı";
            this.colLastname.FieldName = "Lastname";
            this.colLastname.Name = "colLastname";
            this.colLastname.OptionsColumn.AllowEdit = false;
            this.colLastname.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLastname.OptionsFilter.AllowAutoFilter = false;
            this.colLastname.OptionsFilter.AllowFilter = false;
            this.colLastname.StatusBarShortcut = null;
            this.colLastname.StatusBarShortcutStatement = null;
            this.colLastname.StatusBarStatement = null;
            this.colLastname.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Telefon Bilgileri";
            this.gridBand3.Columns.Add(this.colHomePhone);
            this.gridBand3.Columns.Add(this.colWorkplacePhone1);
            this.gridBand3.Columns.Add(this.colInternalPhone1);
            this.gridBand3.Columns.Add(this.colWorkplacePhone2);
            this.gridBand3.Columns.Add(this.colInternalPhone2);
            this.gridBand3.Columns.Add(this.colMobilePhone1);
            this.gridBand3.Columns.Add(this.colMobilePhone2);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 550;
            // 
            // colHomePhone
            // 
            this.colHomePhone.Caption = "Ev Telefonu";
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.OptionsColumn.AllowEdit = false;
            this.colHomePhone.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHomePhone.OptionsFilter.AllowAutoFilter = false;
            this.colHomePhone.OptionsFilter.AllowFilter = false;
            this.colHomePhone.StatusBarShortcut = null;
            this.colHomePhone.StatusBarShortcutStatement = null;
            this.colHomePhone.StatusBarStatement = null;
            this.colHomePhone.Visible = true;
            this.colHomePhone.Width = 90;
            // 
            // colWorkplacePhone1
            // 
            this.colWorkplacePhone1.Caption = "İş Telefonu - 1";
            this.colWorkplacePhone1.FieldName = "WorkplacePhone1";
            this.colWorkplacePhone1.Name = "colWorkplacePhone1";
            this.colWorkplacePhone1.OptionsColumn.AllowEdit = false;
            this.colWorkplacePhone1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWorkplacePhone1.OptionsFilter.AllowAutoFilter = false;
            this.colWorkplacePhone1.OptionsFilter.AllowFilter = false;
            this.colWorkplacePhone1.StatusBarShortcut = null;
            this.colWorkplacePhone1.StatusBarShortcutStatement = null;
            this.colWorkplacePhone1.StatusBarStatement = null;
            this.colWorkplacePhone1.Visible = true;
            this.colWorkplacePhone1.Width = 90;
            // 
            // colInternalPhone1
            // 
            this.colInternalPhone1.Caption = "Dahili - 1";
            this.colInternalPhone1.FieldName = "InternalPhone1";
            this.colInternalPhone1.Name = "colInternalPhone1";
            this.colInternalPhone1.OptionsColumn.AllowEdit = false;
            this.colInternalPhone1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colInternalPhone1.OptionsFilter.AllowAutoFilter = false;
            this.colInternalPhone1.OptionsFilter.AllowFilter = false;
            this.colInternalPhone1.StatusBarShortcut = null;
            this.colInternalPhone1.StatusBarShortcutStatement = null;
            this.colInternalPhone1.StatusBarStatement = null;
            this.colInternalPhone1.Visible = true;
            this.colInternalPhone1.Width = 50;
            // 
            // colWorkplacePhone2
            // 
            this.colWorkplacePhone2.Caption = "İş Telefonu - 2";
            this.colWorkplacePhone2.FieldName = "WorkplacePhone2";
            this.colWorkplacePhone2.Name = "colWorkplacePhone2";
            this.colWorkplacePhone2.OptionsColumn.AllowEdit = false;
            this.colWorkplacePhone2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWorkplacePhone2.OptionsFilter.AllowAutoFilter = false;
            this.colWorkplacePhone2.OptionsFilter.AllowFilter = false;
            this.colWorkplacePhone2.StatusBarShortcut = null;
            this.colWorkplacePhone2.StatusBarShortcutStatement = null;
            this.colWorkplacePhone2.StatusBarStatement = null;
            this.colWorkplacePhone2.Visible = true;
            this.colWorkplacePhone2.Width = 90;
            // 
            // colInternalPhone2
            // 
            this.colInternalPhone2.Caption = "Dahili - 2";
            this.colInternalPhone2.FieldName = "InternalPhone2";
            this.colInternalPhone2.Name = "colInternalPhone2";
            this.colInternalPhone2.OptionsColumn.AllowEdit = false;
            this.colInternalPhone2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colInternalPhone2.OptionsFilter.AllowAutoFilter = false;
            this.colInternalPhone2.OptionsFilter.AllowFilter = false;
            this.colInternalPhone2.StatusBarShortcut = null;
            this.colInternalPhone2.StatusBarShortcutStatement = null;
            this.colInternalPhone2.StatusBarStatement = null;
            this.colInternalPhone2.Visible = true;
            this.colInternalPhone2.Width = 50;
            // 
            // colMobilePhone1
            // 
            this.colMobilePhone1.Caption = "Cep Telefonu - 1";
            this.colMobilePhone1.FieldName = "MobilePhone1";
            this.colMobilePhone1.Name = "colMobilePhone1";
            this.colMobilePhone1.OptionsColumn.AllowEdit = false;
            this.colMobilePhone1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMobilePhone1.OptionsFilter.AllowAutoFilter = false;
            this.colMobilePhone1.OptionsFilter.AllowFilter = false;
            this.colMobilePhone1.StatusBarShortcut = null;
            this.colMobilePhone1.StatusBarShortcutStatement = null;
            this.colMobilePhone1.StatusBarStatement = null;
            this.colMobilePhone1.Visible = true;
            this.colMobilePhone1.Width = 90;
            // 
            // colMobilePhone2
            // 
            this.colMobilePhone2.Caption = "Cep Telefonu - 2";
            this.colMobilePhone2.FieldName = "MobilePhone2";
            this.colMobilePhone2.Name = "colMobilePhone2";
            this.colMobilePhone2.OptionsColumn.AllowEdit = false;
            this.colMobilePhone2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMobilePhone2.OptionsFilter.AllowAutoFilter = false;
            this.colMobilePhone2.OptionsFilter.AllowFilter = false;
            this.colMobilePhone2.StatusBarShortcut = null;
            this.colMobilePhone2.StatusBarShortcutStatement = null;
            this.colMobilePhone2.StatusBarStatement = null;
            this.colMobilePhone2.Visible = true;
            this.colMobilePhone2.Width = 90;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ev Adresi";
            this.gridBand4.Columns.Add(this.colHomeAddress);
            this.gridBand4.Columns.Add(this.colHomeAddressProvinceName);
            this.gridBand4.Columns.Add(this.colHomeAddressDistrictName);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 270;
            // 
            // colHomeAddress
            // 
            this.colHomeAddress.Caption = "Ev Adresi";
            this.colHomeAddress.FieldName = "HomeAddress";
            this.colHomeAddress.Name = "colHomeAddress";
            this.colHomeAddress.OptionsColumn.AllowEdit = false;
            this.colHomeAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHomeAddress.OptionsFilter.AllowAutoFilter = false;
            this.colHomeAddress.OptionsFilter.AllowFilter = false;
            this.colHomeAddress.StatusBarShortcut = null;
            this.colHomeAddress.StatusBarShortcutStatement = null;
            this.colHomeAddress.StatusBarStatement = null;
            this.colHomeAddress.Visible = true;
            this.colHomeAddress.Width = 120;
            // 
            // colHomeAddressProvinceName
            // 
            this.colHomeAddressProvinceName.Caption = "İl Adı";
            this.colHomeAddressProvinceName.CustomizationCaption = "Ev Adresine Bağlı İl Adı";
            this.colHomeAddressProvinceName.FieldName = "HomeAddressProvinceName";
            this.colHomeAddressProvinceName.Name = "colHomeAddressProvinceName";
            this.colHomeAddressProvinceName.OptionsColumn.AllowEdit = false;
            this.colHomeAddressProvinceName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHomeAddressProvinceName.OptionsFilter.AllowAutoFilter = false;
            this.colHomeAddressProvinceName.OptionsFilter.AllowFilter = false;
            this.colHomeAddressProvinceName.StatusBarShortcut = null;
            this.colHomeAddressProvinceName.StatusBarShortcutStatement = null;
            this.colHomeAddressProvinceName.StatusBarStatement = null;
            this.colHomeAddressProvinceName.Visible = true;
            // 
            // colHomeAddressDistrictName
            // 
            this.colHomeAddressDistrictName.Caption = "İlçe Adı";
            this.colHomeAddressDistrictName.CustomizationCaption = "Ev Adresine Bağlı İlçe Adı";
            this.colHomeAddressDistrictName.FieldName = "HomeAddressDistrictName";
            this.colHomeAddressDistrictName.Name = "colHomeAddressDistrictName";
            this.colHomeAddressDistrictName.OptionsColumn.AllowEdit = false;
            this.colHomeAddressDistrictName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHomeAddressDistrictName.OptionsFilter.AllowAutoFilter = false;
            this.colHomeAddressDistrictName.OptionsFilter.AllowFilter = false;
            this.colHomeAddressDistrictName.StatusBarShortcut = null;
            this.colHomeAddressDistrictName.StatusBarShortcutStatement = null;
            this.colHomeAddressDistrictName.StatusBarStatement = null;
            this.colHomeAddressDistrictName.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "İş Adresi";
            this.gridBand5.Columns.Add(this.colWorkplaceAddress);
            this.gridBand5.Columns.Add(this.colWorkplaceAddressProvinceName);
            this.gridBand5.Columns.Add(this.colWorkplaceAddressDistrictName);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 270;
            // 
            // colWorkplaceAddress
            // 
            this.colWorkplaceAddress.Caption = "İş Adresi";
            this.colWorkplaceAddress.FieldName = "WorkplaceAddress";
            this.colWorkplaceAddress.Name = "colWorkplaceAddress";
            this.colWorkplaceAddress.OptionsColumn.AllowEdit = false;
            this.colWorkplaceAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWorkplaceAddress.OptionsFilter.AllowAutoFilter = false;
            this.colWorkplaceAddress.OptionsFilter.AllowFilter = false;
            this.colWorkplaceAddress.StatusBarShortcut = null;
            this.colWorkplaceAddress.StatusBarShortcutStatement = null;
            this.colWorkplaceAddress.StatusBarStatement = null;
            this.colWorkplaceAddress.Visible = true;
            this.colWorkplaceAddress.Width = 120;
            // 
            // colWorkplaceAddressProvinceName
            // 
            this.colWorkplaceAddressProvinceName.Caption = "İl Adı";
            this.colWorkplaceAddressProvinceName.CustomizationCaption = "İş Adresine Bağlı İl Adı";
            this.colWorkplaceAddressProvinceName.FieldName = "WorkplaceAddressProvinceName";
            this.colWorkplaceAddressProvinceName.Name = "colWorkplaceAddressProvinceName";
            this.colWorkplaceAddressProvinceName.OptionsColumn.AllowEdit = false;
            this.colWorkplaceAddressProvinceName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWorkplaceAddressProvinceName.OptionsFilter.AllowAutoFilter = false;
            this.colWorkplaceAddressProvinceName.OptionsFilter.AllowFilter = false;
            this.colWorkplaceAddressProvinceName.StatusBarShortcut = null;
            this.colWorkplaceAddressProvinceName.StatusBarShortcutStatement = null;
            this.colWorkplaceAddressProvinceName.StatusBarStatement = null;
            this.colWorkplaceAddressProvinceName.Visible = true;
            // 
            // colWorkplaceAddressDistrictName
            // 
            this.colWorkplaceAddressDistrictName.Caption = "İlçe Adı";
            this.colWorkplaceAddressDistrictName.CustomizationCaption = "İş Adresine Bağlı İlçe Adı";
            this.colWorkplaceAddressDistrictName.FieldName = "WorkplaceAddressDistrictName";
            this.colWorkplaceAddressDistrictName.Name = "colWorkplaceAddressDistrictName";
            this.colWorkplaceAddressDistrictName.OptionsColumn.AllowEdit = false;
            this.colWorkplaceAddressDistrictName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWorkplaceAddressDistrictName.OptionsFilter.AllowAutoFilter = false;
            this.colWorkplaceAddressDistrictName.OptionsFilter.AllowFilter = false;
            this.colWorkplaceAddressDistrictName.StatusBarShortcut = null;
            this.colWorkplaceAddressDistrictName.StatusBarShortcutStatement = null;
            this.colWorkplaceAddressDistrictName.StatusBarStatement = null;
            this.colWorkplaceAddressDistrictName.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "İşyeri Bilgileri";
            this.gridBand6.Columns.Add(this.colVocationName);
            this.gridBand6.Columns.Add(this.colWorkplaceName);
            this.gridBand6.Columns.Add(this.colJobName);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 270;
            // 
            // colVocationName
            // 
            this.colVocationName.Caption = "Meslek Adı";
            this.colVocationName.FieldName = "VocationName";
            this.colVocationName.Name = "colVocationName";
            this.colVocationName.OptionsColumn.AllowEdit = false;
            this.colVocationName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVocationName.OptionsFilter.AllowAutoFilter = false;
            this.colVocationName.OptionsFilter.AllowFilter = false;
            this.colVocationName.StatusBarShortcut = null;
            this.colVocationName.StatusBarShortcutStatement = null;
            this.colVocationName.StatusBarStatement = null;
            this.colVocationName.Visible = true;
            // 
            // colWorkplaceName
            // 
            this.colWorkplaceName.Caption = "İşyeri Adı";
            this.colWorkplaceName.FieldName = "WorkplaceName";
            this.colWorkplaceName.Name = "colWorkplaceName";
            this.colWorkplaceName.OptionsColumn.AllowEdit = false;
            this.colWorkplaceName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWorkplaceName.OptionsFilter.AllowAutoFilter = false;
            this.colWorkplaceName.OptionsFilter.AllowFilter = false;
            this.colWorkplaceName.StatusBarShortcut = null;
            this.colWorkplaceName.StatusBarShortcutStatement = null;
            this.colWorkplaceName.StatusBarStatement = null;
            this.colWorkplaceName.Visible = true;
            this.colWorkplaceName.Width = 120;
            // 
            // colJobName
            // 
            this.colJobName.Caption = "Görev Adı";
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.OptionsColumn.AllowEdit = false;
            this.colJobName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colJobName.OptionsFilter.AllowAutoFilter = false;
            this.colJobName.OptionsFilter.AllowFilter = false;
            this.colJobName.StatusBarShortcut = null;
            this.colJobName.StatusBarShortcutStatement = null;
            this.colJobName.StatusBarStatement = null;
            this.colJobName.Visible = true;
            // 
            // colKinshipId
            // 
            this.colKinshipId.Caption = "Yakınlık Id";
            this.colKinshipId.FieldName = "KinshipId";
            this.colKinshipId.Name = "colKinshipId";
            this.colKinshipId.OptionsColumn.AllowEdit = false;
            this.colKinshipId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKinshipId.OptionsColumn.ShowInCustomizationForm = false;
            this.colKinshipId.OptionsFilter.AllowAutoFilter = false;
            this.colKinshipId.OptionsFilter.AllowFilter = false;
            this.colKinshipId.StatusBarShortcut = null;
            this.colKinshipId.StatusBarShortcutStatement = null;
            this.colKinshipId.StatusBarStatement = null;
            // 
            // ContactInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "ContactInformationsTable";
            this.Size = new System.Drawing.Size(913, 392);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGuardianship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemKinship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyBandedGridControl grid;
        private Grids.MyBandedGridView table;
        private Grids.MyBandedGridColumn colGuardianship;
        private Grids.MyBandedGridColumn colBillingAddress;
        private Grids.MyBandedGridColumn colKinshipId;
        private Grids.MyBandedGridColumn colKinshipName;
        private Grids.MyBandedGridColumn colTrIdentityNumber;
        private Grids.MyBandedGridColumn colName;
        private Grids.MyBandedGridColumn colLastname;
        private Grids.MyBandedGridColumn colHomePhone;
        private Grids.MyBandedGridColumn colWorkplacePhone1;
        private Grids.MyBandedGridColumn colInternalPhone1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemGuardianship;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemKinship;
        private Grids.MyBandedGridColumn colWorkplacePhone2;
        private Grids.MyBandedGridColumn colInternalPhone2;
        private Grids.MyBandedGridColumn colMobilePhone1;
        private Grids.MyBandedGridColumn colMobilePhone2;
        private Grids.MyBandedGridColumn colHomeAddress;
        private Grids.MyBandedGridColumn colHomeAddressProvinceName;
        private Grids.MyBandedGridColumn colHomeAddressDistrictName;
        private Grids.MyBandedGridColumn colWorkplaceAddress;
        private Grids.MyBandedGridColumn colWorkplaceAddressProvinceName;
        private Grids.MyBandedGridColumn colWorkplaceAddressDistrictName;
        private Grids.MyBandedGridColumn colVocationName;
        private Grids.MyBandedGridColumn colWorkplaceName;
        private Grids.MyBandedGridColumn colJobName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}