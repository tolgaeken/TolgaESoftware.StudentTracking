namespace TolgaESoftware.StudentTracking.UI.Win.Forms.StudentForms
{
    partial class StudentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentListForm));
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCode = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTrIdentityNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGender = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPhone = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBirthPlace = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBirthDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colFatherName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMotherName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBloodGroups = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode3Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode4Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode5Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIdentitySerialNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityRowNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityProvinceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityDistrictName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityNeighborhood = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityBindingNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityFamilyRowNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityPersonRowNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityGivenPlace = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityGivenReason = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityRegisterNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityGivenDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
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
            this.colName,
            this.colLastname,
            this.colGender,
            this.colPhone,
            this.colFatherName,
            this.colMotherName,
            this.colBirthPlace,
            this.colBirthDate,
            this.colBloodGroups,
            this.colIdentitySerialNumber,
            this.colIdentityRowNumber,
            this.colIdentityProvinceName,
            this.colIdentityDistrictName,
            this.colIdentityNeighborhood,
            this.colIdentityBindingNumber,
            this.colIdentityFamilyRowNumber,
            this.colIdentityPersonRowNumber,
            this.colIdentityGivenPlace,
            this.colIdentityGivenReason,
            this.colIdentityRegisterNumber,
            this.colIdentityGivenDate,
            this.colSpecialCode1Name,
            this.colSpecialCode2Name,
            this.colSpecialCode3Name,
            this.colSpecialCode4Name,
            this.colSpecialCode5Name,
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
            this.table.ViewCaption = "Öğrenci Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colCode);
            this.gridBand1.Columns.Add(this.colTrIdentityNumber);
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Columns.Add(this.colLastname);
            this.gridBand1.Columns.Add(this.colGender);
            this.gridBand1.Columns.Add(this.colPhone);
            this.gridBand1.Columns.Add(this.colBirthPlace);
            this.gridBand1.Columns.Add(this.colBirthDate);
            this.gridBand1.Columns.Add(this.colFatherName);
            this.gridBand1.Columns.Add(this.colMotherName);
            this.gridBand1.Columns.Add(this.colBloodGroups);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 795;
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
            // colGender
            // 
            this.colGender.AppearanceCell.Options.UseTextOptions = true;
            this.colGender.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGender.Caption = "Cinsiyeti";
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowEdit = false;
            this.colGender.StatusBarShortcut = null;
            this.colGender.StatusBarShortcutStatement = null;
            this.colGender.StatusBarStatement = null;
            this.colGender.Visible = true;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone.Caption = "Telefon";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.StatusBarShortcut = null;
            this.colPhone.StatusBarShortcutStatement = null;
            this.colPhone.StatusBarStatement = null;
            this.colPhone.Visible = true;
            this.colPhone.Width = 100;
            // 
            // colBirthPlace
            // 
            this.colBirthPlace.Caption = "Doğum Yeri";
            this.colBirthPlace.FieldName = "BirthPlace";
            this.colBirthPlace.Name = "colBirthPlace";
            this.colBirthPlace.OptionsColumn.AllowEdit = false;
            this.colBirthPlace.StatusBarShortcut = null;
            this.colBirthPlace.StatusBarShortcutStatement = null;
            this.colBirthPlace.StatusBarStatement = null;
            this.colBirthPlace.Visible = true;
            // 
            // colBirthDate
            // 
            this.colBirthDate.AppearanceCell.Options.UseTextOptions = true;
            this.colBirthDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirthDate.Caption = "Doğum Tarihi";
            this.colBirthDate.ColumnEdit = this.repositoryItemDate;
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.OptionsColumn.AllowEdit = false;
            this.colBirthDate.StatusBarShortcut = null;
            this.colBirthDate.StatusBarShortcutStatement = null;
            this.colBirthDate.StatusBarStatement = null;
            this.colBirthDate.Visible = true;
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
            // colFatherName
            // 
            this.colFatherName.Caption = "Baba Adı";
            this.colFatherName.FieldName = "FatherName";
            this.colFatherName.Name = "colFatherName";
            this.colFatherName.OptionsColumn.AllowEdit = false;
            this.colFatherName.StatusBarShortcut = null;
            this.colFatherName.StatusBarShortcutStatement = null;
            this.colFatherName.StatusBarStatement = null;
            // 
            // colMotherName
            // 
            this.colMotherName.Caption = "Anne Adı";
            this.colMotherName.FieldName = "MotherName";
            this.colMotherName.Name = "colMotherName";
            this.colMotherName.OptionsColumn.AllowEdit = false;
            this.colMotherName.StatusBarShortcut = null;
            this.colMotherName.StatusBarShortcutStatement = null;
            this.colMotherName.StatusBarStatement = null;
            // 
            // colBloodGroups
            // 
            this.colBloodGroups.Caption = "Kan Grubu";
            this.colBloodGroups.FieldName = "BloodGroups";
            this.colBloodGroups.Name = "colBloodGroups";
            this.colBloodGroups.OptionsColumn.AllowEdit = false;
            this.colBloodGroups.StatusBarShortcut = null;
            this.colBloodGroups.StatusBarShortcutStatement = null;
            this.colBloodGroups.StatusBarStatement = null;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Özel Kod";
            this.gridBand2.Columns.Add(this.colSpecialCode1Name);
            this.gridBand2.Columns.Add(this.colSpecialCode2Name);
            this.gridBand2.Columns.Add(this.colSpecialCode3Name);
            this.gridBand2.Columns.Add(this.colSpecialCode4Name);
            this.gridBand2.Columns.Add(this.colSpecialCode5Name);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 600;
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
            this.colSpecialCode1Name.Width = 120;
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
            this.colSpecialCode2Name.Width = 120;
            // 
            // colSpecialCode3Name
            // 
            this.colSpecialCode3Name.Caption = "Özel Kod - 3";
            this.colSpecialCode3Name.FieldName = "SpecialCode3Name";
            this.colSpecialCode3Name.Name = "colSpecialCode3Name";
            this.colSpecialCode3Name.OptionsColumn.AllowEdit = false;
            this.colSpecialCode3Name.StatusBarShortcut = null;
            this.colSpecialCode3Name.StatusBarShortcutStatement = null;
            this.colSpecialCode3Name.StatusBarStatement = null;
            this.colSpecialCode3Name.Visible = true;
            this.colSpecialCode3Name.Width = 120;
            // 
            // colSpecialCode4Name
            // 
            this.colSpecialCode4Name.Caption = "Özel Kod - 4";
            this.colSpecialCode4Name.FieldName = "SpecialCode4Name";
            this.colSpecialCode4Name.Name = "colSpecialCode4Name";
            this.colSpecialCode4Name.OptionsColumn.AllowEdit = false;
            this.colSpecialCode4Name.StatusBarShortcut = null;
            this.colSpecialCode4Name.StatusBarShortcutStatement = null;
            this.colSpecialCode4Name.StatusBarStatement = null;
            this.colSpecialCode4Name.Visible = true;
            this.colSpecialCode4Name.Width = 120;
            // 
            // colSpecialCode5Name
            // 
            this.colSpecialCode5Name.Caption = "Özel Kod - 5";
            this.colSpecialCode5Name.FieldName = "SpecialCode5Name";
            this.colSpecialCode5Name.Name = "colSpecialCode5Name";
            this.colSpecialCode5Name.OptionsColumn.AllowEdit = false;
            this.colSpecialCode5Name.StatusBarShortcut = null;
            this.colSpecialCode5Name.StatusBarShortcutStatement = null;
            this.colSpecialCode5Name.StatusBarStatement = null;
            this.colSpecialCode5Name.Visible = true;
            this.colSpecialCode5Name.Width = 120;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Kimlik Bilgileri";
            this.gridBand3.Columns.Add(this.colIdentitySerialNumber);
            this.gridBand3.Columns.Add(this.colIdentityRowNumber);
            this.gridBand3.Columns.Add(this.colIdentityProvinceName);
            this.gridBand3.Columns.Add(this.colIdentityDistrictName);
            this.gridBand3.Columns.Add(this.colIdentityNeighborhood);
            this.gridBand3.Columns.Add(this.colIdentityBindingNumber);
            this.gridBand3.Columns.Add(this.colIdentityFamilyRowNumber);
            this.gridBand3.Columns.Add(this.colIdentityPersonRowNumber);
            this.gridBand3.Columns.Add(this.colIdentityGivenPlace);
            this.gridBand3.Columns.Add(this.colIdentityGivenReason);
            this.gridBand3.Columns.Add(this.colIdentityRegisterNumber);
            this.gridBand3.Columns.Add(this.colIdentityGivenDate);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 150;
            // 
            // colIdentitySerialNumber
            // 
            this.colIdentitySerialNumber.Caption = "Seri No";
            this.colIdentitySerialNumber.CustomizationCaption = "Kimlik Seri No";
            this.colIdentitySerialNumber.FieldName = "IdentitySerialNumber";
            this.colIdentitySerialNumber.Name = "colIdentitySerialNumber";
            this.colIdentitySerialNumber.OptionsColumn.AllowEdit = false;
            this.colIdentitySerialNumber.StatusBarShortcut = null;
            this.colIdentitySerialNumber.StatusBarShortcutStatement = null;
            this.colIdentitySerialNumber.StatusBarStatement = null;
            // 
            // colIdentityRowNumber
            // 
            this.colIdentityRowNumber.Caption = "Sıra No";
            this.colIdentityRowNumber.CustomizationCaption = "Kimlik Sıra No";
            this.colIdentityRowNumber.FieldName = "IdentityRowNumber";
            this.colIdentityRowNumber.Name = "colIdentityRowNumber";
            this.colIdentityRowNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityRowNumber.StatusBarShortcut = null;
            this.colIdentityRowNumber.StatusBarShortcutStatement = null;
            this.colIdentityRowNumber.StatusBarStatement = null;
            // 
            // colIdentityProvinceName
            // 
            this.colIdentityProvinceName.Caption = "İl Adı";
            this.colIdentityProvinceName.CustomizationCaption = "Kimlik İl Adı";
            this.colIdentityProvinceName.FieldName = "IdentityProvinceName";
            this.colIdentityProvinceName.Name = "colIdentityProvinceName";
            this.colIdentityProvinceName.OptionsColumn.AllowEdit = false;
            this.colIdentityProvinceName.StatusBarShortcut = null;
            this.colIdentityProvinceName.StatusBarShortcutStatement = null;
            this.colIdentityProvinceName.StatusBarStatement = null;
            this.colIdentityProvinceName.Visible = true;
            // 
            // colIdentityDistrictName
            // 
            this.colIdentityDistrictName.Caption = "İlçe Adı";
            this.colIdentityDistrictName.CustomizationCaption = "Kimlik İlçe Adı";
            this.colIdentityDistrictName.FieldName = "IdentityDistrictName";
            this.colIdentityDistrictName.Name = "colIdentityDistrictName";
            this.colIdentityDistrictName.OptionsColumn.AllowEdit = false;
            this.colIdentityDistrictName.StatusBarShortcut = null;
            this.colIdentityDistrictName.StatusBarShortcutStatement = null;
            this.colIdentityDistrictName.StatusBarStatement = null;
            this.colIdentityDistrictName.Visible = true;
            // 
            // colIdentityNeighborhood
            // 
            this.colIdentityNeighborhood.Caption = "Mahalle / Köy";
            this.colIdentityNeighborhood.CustomizationCaption = "Kimlik Mahalle / Köy";
            this.colIdentityNeighborhood.FieldName = "IdentityNeighborhood";
            this.colIdentityNeighborhood.Name = "colIdentityNeighborhood";
            this.colIdentityNeighborhood.OptionsColumn.AllowEdit = false;
            this.colIdentityNeighborhood.StatusBarShortcut = null;
            this.colIdentityNeighborhood.StatusBarShortcutStatement = null;
            this.colIdentityNeighborhood.StatusBarStatement = null;
            // 
            // colIdentityBindingNumber
            // 
            this.colIdentityBindingNumber.Caption = "Cilt No";
            this.colIdentityBindingNumber.CustomizationCaption = "Kimlik Cilt No";
            this.colIdentityBindingNumber.FieldName = "IdentityBindingNumber";
            this.colIdentityBindingNumber.Name = "colIdentityBindingNumber";
            this.colIdentityBindingNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityBindingNumber.StatusBarShortcut = null;
            this.colIdentityBindingNumber.StatusBarShortcutStatement = null;
            this.colIdentityBindingNumber.StatusBarStatement = null;
            // 
            // colIdentityFamilyRowNumber
            // 
            this.colIdentityFamilyRowNumber.Caption = "Aile Sıra No";
            this.colIdentityFamilyRowNumber.CustomizationCaption = "Kimlik Aile Sıra No";
            this.colIdentityFamilyRowNumber.FieldName = "IdentityFamilyRowNumber";
            this.colIdentityFamilyRowNumber.Name = "colIdentityFamilyRowNumber";
            this.colIdentityFamilyRowNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityFamilyRowNumber.StatusBarShortcut = null;
            this.colIdentityFamilyRowNumber.StatusBarShortcutStatement = null;
            this.colIdentityFamilyRowNumber.StatusBarStatement = null;
            // 
            // colIdentityPersonRowNumber
            // 
            this.colIdentityPersonRowNumber.Caption = "Birey Sıra No";
            this.colIdentityPersonRowNumber.CustomizationCaption = "Kimlik Birey Sıra No";
            this.colIdentityPersonRowNumber.FieldName = "IdentityPersonRowNumber";
            this.colIdentityPersonRowNumber.Name = "colIdentityPersonRowNumber";
            this.colIdentityPersonRowNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityPersonRowNumber.StatusBarShortcut = null;
            this.colIdentityPersonRowNumber.StatusBarShortcutStatement = null;
            this.colIdentityPersonRowNumber.StatusBarStatement = null;
            // 
            // colIdentityGivenPlace
            // 
            this.colIdentityGivenPlace.Caption = "Verildiği Yer";
            this.colIdentityGivenPlace.CustomizationCaption = "Kimliğin Verildiği Yer";
            this.colIdentityGivenPlace.FieldName = "IdentityGivenPlace";
            this.colIdentityGivenPlace.Name = "colIdentityGivenPlace";
            this.colIdentityGivenPlace.OptionsColumn.AllowEdit = false;
            this.colIdentityGivenPlace.StatusBarShortcut = null;
            this.colIdentityGivenPlace.StatusBarShortcutStatement = null;
            this.colIdentityGivenPlace.StatusBarStatement = null;
            // 
            // colIdentityGivenReason
            // 
            this.colIdentityGivenReason.Caption = "Veriliş Sebebi";
            this.colIdentityGivenReason.CustomizationCaption = "Kimliğin Veriliş Sebebi";
            this.colIdentityGivenReason.FieldName = "IdentityGivenReason";
            this.colIdentityGivenReason.Name = "colIdentityGivenReason";
            this.colIdentityGivenReason.OptionsColumn.AllowEdit = false;
            this.colIdentityGivenReason.StatusBarShortcut = null;
            this.colIdentityGivenReason.StatusBarShortcutStatement = null;
            this.colIdentityGivenReason.StatusBarStatement = null;
            // 
            // colIdentityRegisterNumber
            // 
            this.colIdentityRegisterNumber.Caption = "Kayıt No";
            this.colIdentityRegisterNumber.CustomizationCaption = "Kimlik Kayıt No";
            this.colIdentityRegisterNumber.FieldName = "IdentityRegisterNumber";
            this.colIdentityRegisterNumber.Name = "colIdentityRegisterNumber";
            this.colIdentityRegisterNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityRegisterNumber.StatusBarShortcut = null;
            this.colIdentityRegisterNumber.StatusBarShortcutStatement = null;
            this.colIdentityRegisterNumber.StatusBarStatement = null;
            // 
            // colIdentityGivenDate
            // 
            this.colIdentityGivenDate.AppearanceCell.Options.UseTextOptions = true;
            this.colIdentityGivenDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdentityGivenDate.Caption = "Veriliş Tarihi";
            this.colIdentityGivenDate.ColumnEdit = this.repositoryItemDate;
            this.colIdentityGivenDate.CustomizationCaption = "Kimliğin Veriliş Tarihi";
            this.colIdentityGivenDate.FieldName = "IdentityGivenDate";
            this.colIdentityGivenDate.Name = "colIdentityGivenDate";
            this.colIdentityGivenDate.OptionsColumn.AllowEdit = false;
            this.colIdentityGivenDate.StatusBarShortcut = null;
            this.colIdentityGivenDate.StatusBarShortcutStatement = null;
            this.colIdentityGivenDate.StatusBarStatement = null;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colStatement);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 200;
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
            this.colStatement.Width = 200;
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
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "StudentListForm";
            this.Text = "Öğrenci Kartları";
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
        private UserControls.Grids.MyBandedGridColumn colTrIdentityNumber;
        private UserControls.Grids.MyBandedGridColumn colName;
        private UserControls.Grids.MyBandedGridColumn colLastname;
        private UserControls.Grids.MyBandedGridColumn colGender;
        private UserControls.Grids.MyBandedGridColumn colPhone;
        private UserControls.Grids.MyBandedGridColumn colFatherName;
        private UserControls.Grids.MyBandedGridColumn colMotherName;
        private UserControls.Grids.MyBandedGridColumn colBirthPlace;
        private UserControls.Grids.MyBandedGridColumn colBirthDate;
        private UserControls.Grids.MyBandedGridColumn colBloodGroups;
        private UserControls.Grids.MyBandedGridColumn colIdentitySerialNumber;
        private UserControls.Grids.MyBandedGridColumn colIdentityRowNumber;
        private UserControls.Grids.MyBandedGridColumn colIdentityProvinceName;
        private UserControls.Grids.MyBandedGridColumn colIdentityDistrictName;
        private UserControls.Grids.MyBandedGridColumn colIdentityNeighborhood;
        private UserControls.Grids.MyBandedGridColumn colIdentityBindingNumber;
        private UserControls.Grids.MyBandedGridColumn colIdentityFamilyRowNumber;
        private UserControls.Grids.MyBandedGridColumn colIdentityPersonRowNumber;
        private UserControls.Grids.MyBandedGridColumn colIdentityGivenPlace;
        private UserControls.Grids.MyBandedGridColumn colIdentityGivenReason;
        private UserControls.Grids.MyBandedGridColumn colIdentityRegisterNumber;
        private UserControls.Grids.MyBandedGridColumn colIdentityGivenDate;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode3Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode4Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode5Name;
        private UserControls.Grids.MyBandedGridColumn colStatement;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}