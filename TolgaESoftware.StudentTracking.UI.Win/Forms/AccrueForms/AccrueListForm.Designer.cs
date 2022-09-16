namespace TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms
{
    partial class AccrueListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccrueListForm));
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridView();
            this.colTrIdentityNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colFatherName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMotherName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colStudentNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSchoolNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colRegistrationDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEnrollmentType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEnrollmentStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colClass = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colForeignLanguageName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colComesFromSchool = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colQuota = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIncentName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGuideName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNextTermEnrollmentStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colNextTermEnrollmentStatusStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode1Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode3Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode4Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode5Name = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bndSelection = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDate.CalendarTimeProperties)).BeginInit();
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
            this.repositoryDate});
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
            this.bndSelection,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colStudentNumber,
            this.colSchoolNumber,
            this.colTrIdentityNumber,
            this.colName,
            this.colLastname,
            this.colFatherName,
            this.colMotherName,
            this.colRegistrationDate,
            this.colEnrollmentType,
            this.colEnrollmentStatus,
            this.colClass,
            this.colComesFromSchool,
            this.colQuota,
            this.colForeignLanguageName,
            this.colGuideName,
            this.colIncentName,
            this.colNextTermEnrollmentStatus,
            this.colNextTermEnrollmentStatusStatement,
            this.colSpecialCode1Name,
            this.colSpecialCode2Name,
            this.colSpecialCode3Name,
            this.colSpecialCode4Name,
            this.colSpecialCode5Name,
            this.colBranchName});
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
            this.table.ViewCaption = "Tahakkuk Kartları";
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
            this.colName.Width = 150;
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
            this.colLastname.Width = 150;
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
            this.colFatherName.Visible = true;
            this.colFatherName.Width = 150;
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
            this.colMotherName.Visible = true;
            this.colMotherName.Width = 150;
            // 
            // colStudentNumber
            // 
            this.colStudentNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colStudentNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStudentNumber.Caption = "Öğrenci No";
            this.colStudentNumber.FieldName = "Code";
            this.colStudentNumber.Name = "colStudentNumber";
            this.colStudentNumber.OptionsColumn.AllowEdit = false;
            this.colStudentNumber.StatusBarShortcut = null;
            this.colStudentNumber.StatusBarShortcutStatement = null;
            this.colStudentNumber.StatusBarStatement = null;
            this.colStudentNumber.Visible = true;
            this.colStudentNumber.Width = 100;
            // 
            // colSchoolNumber
            // 
            this.colSchoolNumber.Caption = "Okul No";
            this.colSchoolNumber.FieldName = "SchoolNumber";
            this.colSchoolNumber.Name = "colSchoolNumber";
            this.colSchoolNumber.OptionsColumn.AllowEdit = false;
            this.colSchoolNumber.StatusBarShortcut = null;
            this.colSchoolNumber.StatusBarShortcutStatement = null;
            this.colSchoolNumber.StatusBarStatement = null;
            this.colSchoolNumber.Visible = true;
            this.colSchoolNumber.Width = 100;
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colRegistrationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegistrationDate.Caption = "Kayıt Tarihi";
            this.colRegistrationDate.ColumnEdit = this.repositoryDate;
            this.colRegistrationDate.FieldName = "RegistrationDate";
            this.colRegistrationDate.Name = "colRegistrationDate";
            this.colRegistrationDate.OptionsColumn.AllowEdit = false;
            this.colRegistrationDate.StatusBarShortcut = null;
            this.colRegistrationDate.StatusBarShortcutStatement = null;
            this.colRegistrationDate.StatusBarStatement = null;
            this.colRegistrationDate.Visible = true;
            this.colRegistrationDate.Width = 100;
            // 
            // repositoryDate
            // 
            this.repositoryDate.AutoHeight = false;
            this.repositoryDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryDate.Name = "repositoryDate";
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
            this.colEnrollmentType.Width = 100;
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
            this.colEnrollmentStatus.Width = 100;
            // 
            // colClass
            // 
            this.colClass.Caption = "Sınıf";
            this.colClass.FieldName = "ClassName";
            this.colClass.Name = "colClass";
            this.colClass.OptionsColumn.AllowEdit = false;
            this.colClass.StatusBarShortcut = null;
            this.colClass.StatusBarShortcutStatement = null;
            this.colClass.StatusBarStatement = null;
            this.colClass.Visible = true;
            this.colClass.Width = 100;
            // 
            // colForeignLanguageName
            // 
            this.colForeignLanguageName.Caption = "Yanancı Dil";
            this.colForeignLanguageName.FieldName = "ForeignLanguageName";
            this.colForeignLanguageName.Name = "colForeignLanguageName";
            this.colForeignLanguageName.OptionsColumn.AllowEdit = false;
            this.colForeignLanguageName.StatusBarShortcut = null;
            this.colForeignLanguageName.StatusBarShortcutStatement = null;
            this.colForeignLanguageName.StatusBarStatement = null;
            this.colForeignLanguageName.Visible = true;
            this.colForeignLanguageName.Width = 100;
            // 
            // colComesFromSchool
            // 
            this.colComesFromSchool.Caption = "Geldiği Okul";
            this.colComesFromSchool.FieldName = "ComesFromSchoolName";
            this.colComesFromSchool.Name = "colComesFromSchool";
            this.colComesFromSchool.OptionsColumn.AllowEdit = false;
            this.colComesFromSchool.StatusBarShortcut = null;
            this.colComesFromSchool.StatusBarShortcutStatement = null;
            this.colComesFromSchool.StatusBarStatement = null;
            this.colComesFromSchool.Visible = true;
            this.colComesFromSchool.Width = 100;
            // 
            // colQuota
            // 
            this.colQuota.Caption = "Kontenjan Türü";
            this.colQuota.FieldName = "QuotaName";
            this.colQuota.Name = "colQuota";
            this.colQuota.OptionsColumn.AllowEdit = false;
            this.colQuota.StatusBarShortcut = null;
            this.colQuota.StatusBarShortcutStatement = null;
            this.colQuota.StatusBarStatement = null;
            this.colQuota.Visible = true;
            this.colQuota.Width = 100;
            // 
            // colIncentName
            // 
            this.colIncentName.Caption = "Teşvik Türü";
            this.colIncentName.FieldName = "IncentName";
            this.colIncentName.Name = "colIncentName";
            this.colIncentName.OptionsColumn.AllowEdit = false;
            this.colIncentName.StatusBarShortcut = null;
            this.colIncentName.StatusBarShortcutStatement = null;
            this.colIncentName.StatusBarStatement = null;
            this.colIncentName.Visible = true;
            this.colIncentName.Width = 100;
            // 
            // colGuideName
            // 
            this.colGuideName.Caption = "Rehber";
            this.colGuideName.FieldName = "GuideName";
            this.colGuideName.Name = "colGuideName";
            this.colGuideName.OptionsColumn.AllowEdit = false;
            this.colGuideName.StatusBarShortcut = null;
            this.colGuideName.StatusBarShortcutStatement = null;
            this.colGuideName.StatusBarStatement = null;
            this.colGuideName.Visible = true;
            this.colGuideName.Width = 100;
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
            this.colBranchName.Width = 100;
            // 
            // colNextTermEnrollmentStatus
            // 
            this.colNextTermEnrollmentStatus.Caption = "Kayıt Durumu";
            this.colNextTermEnrollmentStatus.CustomizationCaption = "Sonraki Dönem Kayıt Durumu";
            this.colNextTermEnrollmentStatus.FieldName = "NextTermEnrollmentStatus";
            this.colNextTermEnrollmentStatus.Name = "colNextTermEnrollmentStatus";
            this.colNextTermEnrollmentStatus.OptionsColumn.AllowEdit = false;
            this.colNextTermEnrollmentStatus.StatusBarShortcut = null;
            this.colNextTermEnrollmentStatus.StatusBarShortcutStatement = null;
            this.colNextTermEnrollmentStatus.StatusBarStatement = null;
            this.colNextTermEnrollmentStatus.Visible = true;
            this.colNextTermEnrollmentStatus.Width = 120;
            // 
            // colNextTermEnrollmentStatusStatement
            // 
            this.colNextTermEnrollmentStatusStatement.Caption = "Açıklama";
            this.colNextTermEnrollmentStatusStatement.CustomizationCaption = "Sonraki Dönem Kayıt Durumu Açıklama";
            this.colNextTermEnrollmentStatusStatement.FieldName = "NextTermEnrollmentStatusStatement";
            this.colNextTermEnrollmentStatusStatement.Name = "colNextTermEnrollmentStatusStatement";
            this.colNextTermEnrollmentStatusStatement.OptionsColumn.AllowEdit = false;
            this.colNextTermEnrollmentStatusStatement.StatusBarShortcut = null;
            this.colNextTermEnrollmentStatusStatement.StatusBarShortcutStatement = null;
            this.colNextTermEnrollmentStatusStatement.StatusBarStatement = null;
            this.colNextTermEnrollmentStatusStatement.Visible = true;
            this.colNextTermEnrollmentStatusStatement.Width = 120;
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
            this.colSpecialCode3Name.Width = 100;
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
            this.colSpecialCode4Name.Width = 100;
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
            this.colSpecialCode5Name.Width = 100;
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
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colTrIdentityNumber);
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Columns.Add(this.colLastname);
            this.gridBand1.Columns.Add(this.colFatherName);
            this.gridBand1.Columns.Add(this.colMotherName);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 700;
            // 
            // bndSelection
            // 
            this.bndSelection.Caption = "Seç";
            this.bndSelection.MinWidth = 50;
            this.bndSelection.Name = "bndSelection";
            this.bndSelection.Visible = false;
            this.bndSelection.VisibleIndex = -1;
            this.bndSelection.Width = 50;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colStudentNumber);
            this.gridBand2.Columns.Add(this.colSchoolNumber);
            this.gridBand2.Columns.Add(this.colRegistrationDate);
            this.gridBand2.Columns.Add(this.colEnrollmentType);
            this.gridBand2.Columns.Add(this.colEnrollmentStatus);
            this.gridBand2.Columns.Add(this.colClass);
            this.gridBand2.Columns.Add(this.colForeignLanguageName);
            this.gridBand2.Columns.Add(this.colComesFromSchool);
            this.gridBand2.Columns.Add(this.colQuota);
            this.gridBand2.Columns.Add(this.colIncentName);
            this.gridBand2.Columns.Add(this.colGuideName);
            this.gridBand2.Columns.Add(this.colBranchName);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1200;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Sonraki Dönem Kayıt Bilgileri";
            this.gridBand3.Columns.Add(this.colNextTermEnrollmentStatus);
            this.gridBand3.Columns.Add(this.colNextTermEnrollmentStatusStatement);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 240;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Özel Kod";
            this.gridBand4.Columns.Add(this.colSpecialCode1Name);
            this.gridBand4.Columns.Add(this.colSpecialCode2Name);
            this.gridBand4.Columns.Add(this.colSpecialCode3Name);
            this.gridBand4.Columns.Add(this.colSpecialCode4Name);
            this.gridBand4.Columns.Add(this.colSpecialCode5Name);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 500;
            // 
            // AccrueListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "AccrueListForm";
            this.Text = "Tahakkuk Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView table;
        private UserControls.Grids.MyBandedGridColumn colTrIdentityNumber;
        private UserControls.Grids.MyBandedGridColumn colName;
        private UserControls.Grids.MyBandedGridColumn colLastname;
        private UserControls.Grids.MyBandedGridColumn colFatherName;
        private UserControls.Grids.MyBandedGridColumn colMotherName;
        private UserControls.Grids.MyBandedGridColumn colStudentNumber;
        private UserControls.Grids.MyBandedGridColumn colSchoolNumber;
        private UserControls.Grids.MyBandedGridColumn colRegistrationDate;
        private UserControls.Grids.MyBandedGridColumn colEnrollmentType;
        private UserControls.Grids.MyBandedGridColumn colEnrollmentStatus;
        private UserControls.Grids.MyBandedGridColumn colClass;
        private UserControls.Grids.MyBandedGridColumn colForeignLanguageName;
        private UserControls.Grids.MyBandedGridColumn colComesFromSchool;
        private UserControls.Grids.MyBandedGridColumn colQuota;
        private UserControls.Grids.MyBandedGridColumn colIncentName;
        private UserControls.Grids.MyBandedGridColumn colGuideName;
        private UserControls.Grids.MyBandedGridColumn colBranchName;
        private UserControls.Grids.MyBandedGridColumn colNextTermEnrollmentStatus;
        private UserControls.Grids.MyBandedGridColumn colNextTermEnrollmentStatusStatement;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode3Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode4Name;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode5Name;
        private UserControls.Grids.MyBandedGridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSelection;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}