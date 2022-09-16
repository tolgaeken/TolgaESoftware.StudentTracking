namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class EposInformationsTable
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
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colLastname = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemBank = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCardType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCardType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCardNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCardNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colExpirationDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemExpirationDate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSecurityCode = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSecurityCode = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCardType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemExpirationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSecurityCode)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 401);
            this.InsUptNavigator.Size = new System.Drawing.Size(840, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemBank,
            this.repositoryItemCardType,
            this.repositoryItemCardNumber,
            this.repositoryItemExpirationDate,
            this.repositoryItemSecurityCode});
            this.grid.Size = new System.Drawing.Size(840, 401);
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
            this.colName,
            this.colLastname,
            this.colBankId,
            this.colBankName,
            this.colCardType,
            this.colCardNumber,
            this.colExpirationDate,
            this.colSecurityCode});
            this.table.GridControl = this.grid;
            this.table.Name = "table";
            this.table.OptionsMenu.EnableColumnMenu = false;
            this.table.OptionsMenu.EnableFooterMenu = false;
            this.table.OptionsMenu.EnableGroupPanelMenu = false;
            this.table.OptionsNavigation.EnterMoveNextColumn = true;
            this.table.OptionsPrint.AutoWidth = false;
            this.table.OptionsPrint.PrintFooter = false;
            this.table.OptionsPrint.PrintGroupFooter = false;
            this.table.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.table.OptionsView.RowAutoHeight = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = null;
            this.table.StatusBarShortcutStatement = null;
            this.table.StatusBarStatement = "Epos Bilgileri Giriniz";
            this.table.ViewCaption = "Epos Bilgileri";
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsFilter.AllowAutoFilter = false;
            this.colName.OptionsFilter.AllowFilter = false;
            this.colName.StatusBarShortcut = null;
            this.colName.StatusBarShortcutStatement = null;
            this.colName.StatusBarStatement = "Kart Sahibinin Adını Giriniz";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 120;
            // 
            // colLastname
            // 
            this.colLastname.Caption = "Soyadı";
            this.colLastname.FieldName = "Lastname";
            this.colLastname.Name = "colLastname";
            this.colLastname.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLastname.OptionsFilter.AllowAutoFilter = false;
            this.colLastname.OptionsFilter.AllowFilter = false;
            this.colLastname.StatusBarShortcut = null;
            this.colLastname.StatusBarShortcutStatement = null;
            this.colLastname.StatusBarStatement = "Kart Sahibinin Soyadını Giriniz";
            this.colLastname.Visible = true;
            this.colLastname.VisibleIndex = 1;
            this.colLastname.Width = 120;
            // 
            // colBankId
            // 
            this.colBankId.Caption = "Banka Id";
            this.colBankId.FieldName = "BankId";
            this.colBankId.Name = "colBankId";
            this.colBankId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankId.StatusBarShortcut = null;
            this.colBankId.StatusBarShortcutStatement = null;
            this.colBankId.StatusBarStatement = null;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Banka Adı";
            this.colBankName.ColumnEdit = this.repositoryItemBank;
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankName.OptionsFilter.AllowAutoFilter = false;
            this.colBankName.OptionsFilter.AllowFilter = false;
            this.colBankName.StatusBarShortcut = "F4 :";
            this.colBankName.StatusBarShortcutStatement = "Seçim Yap";
            this.colBankName.StatusBarStatement = "Banka Seçiniz";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 2;
            this.colBankName.Width = 150;
            // 
            // repositoryItemBank
            // 
            this.repositoryItemBank.AutoHeight = false;
            this.repositoryItemBank.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemBank.Name = "repositoryItemBank";
            this.repositoryItemBank.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colCardType
            // 
            this.colCardType.AppearanceCell.Options.UseTextOptions = true;
            this.colCardType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardType.Caption = "Kart Türü";
            this.colCardType.ColumnEdit = this.repositoryItemCardType;
            this.colCardType.FieldName = "CardType";
            this.colCardType.Name = "colCardType";
            this.colCardType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCardType.OptionsFilter.AllowAutoFilter = false;
            this.colCardType.OptionsFilter.AllowFilter = false;
            this.colCardType.StatusBarShortcut = "F4 :";
            this.colCardType.StatusBarShortcutStatement = "Seçim Yap";
            this.colCardType.StatusBarStatement = "Kart Türü Seçiniz";
            this.colCardType.Visible = true;
            this.colCardType.VisibleIndex = 3;
            this.colCardType.Width = 100;
            // 
            // repositoryItemCardType
            // 
            this.repositoryItemCardType.AutoHeight = false;
            this.repositoryItemCardType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCardType.Name = "repositoryItemCardType";
            // 
            // colCardNumber
            // 
            this.colCardNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colCardNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCardNumber.Caption = "Kart No";
            this.colCardNumber.ColumnEdit = this.repositoryItemCardNumber;
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCardNumber.OptionsFilter.AllowAutoFilter = false;
            this.colCardNumber.OptionsFilter.AllowFilter = false;
            this.colCardNumber.StatusBarShortcut = null;
            this.colCardNumber.StatusBarShortcutStatement = null;
            this.colCardNumber.StatusBarStatement = "Kart Numarasını Giriniz";
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 4;
            this.colCardNumber.Width = 150;
            // 
            // repositoryItemCardNumber
            // 
            this.repositoryItemCardNumber.AutoHeight = false;
            this.repositoryItemCardNumber.Mask.EditMask = "\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?";
            this.repositoryItemCardNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.repositoryItemCardNumber.Name = "repositoryItemCardNumber";
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colExpirationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExpirationDate.Caption = "Son Kullanma Tarihi";
            this.colExpirationDate.ColumnEdit = this.repositoryItemExpirationDate;
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colExpirationDate.OptionsFilter.AllowAutoFilter = false;
            this.colExpirationDate.OptionsFilter.AllowFilter = false;
            this.colExpirationDate.StatusBarShortcut = null;
            this.colExpirationDate.StatusBarShortcutStatement = null;
            this.colExpirationDate.StatusBarStatement = "Son Kullanma Tarihini Giriniz (2 veya 4 Haneli Girilebilir)";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 5;
            this.colExpirationDate.Width = 100;
            // 
            // repositoryItemExpirationDate
            // 
            this.repositoryItemExpirationDate.AutoHeight = false;
            this.repositoryItemExpirationDate.Mask.EditMask = "(0?[1-9]|1[012])/([12][0-2])?[0-9][0-9]";
            this.repositoryItemExpirationDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemExpirationDate.Name = "repositoryItemExpirationDate";
            // 
            // colSecurityCode
            // 
            this.colSecurityCode.AppearanceCell.Options.UseTextOptions = true;
            this.colSecurityCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSecurityCode.Caption = "Güvenlik Kodu";
            this.colSecurityCode.ColumnEdit = this.repositoryItemSecurityCode;
            this.colSecurityCode.FieldName = "SecurityCode";
            this.colSecurityCode.Name = "colSecurityCode";
            this.colSecurityCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSecurityCode.OptionsFilter.AllowAutoFilter = false;
            this.colSecurityCode.OptionsFilter.AllowFilter = false;
            this.colSecurityCode.StatusBarShortcut = null;
            this.colSecurityCode.StatusBarShortcutStatement = null;
            this.colSecurityCode.StatusBarStatement = "Güvenlik Kodunu Giriniz";
            this.colSecurityCode.Visible = true;
            this.colSecurityCode.VisibleIndex = 6;
            // 
            // repositoryItemSecurityCode
            // 
            this.repositoryItemSecurityCode.AutoHeight = false;
            this.repositoryItemSecurityCode.Mask.EditMask = "\\d\\d\\d";
            this.repositoryItemSecurityCode.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemSecurityCode.Name = "repositoryItemSecurityCode";
            // 
            // EposInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "EposInformationsTable";
            this.Size = new System.Drawing.Size(840, 425);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCardType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemExpirationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSecurityCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colName;
        private Grids.MyGridColumn colLastname;
        private Grids.MyGridColumn colBankId;
        private Grids.MyGridColumn colBankName;
        private Grids.MyGridColumn colCardType;
        private Grids.MyGridColumn colCardNumber;
        private Grids.MyGridColumn colExpirationDate;
        private Grids.MyGridColumn colSecurityCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBank;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemCardType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemCardNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemExpirationDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemSecurityCode;
    }
}
