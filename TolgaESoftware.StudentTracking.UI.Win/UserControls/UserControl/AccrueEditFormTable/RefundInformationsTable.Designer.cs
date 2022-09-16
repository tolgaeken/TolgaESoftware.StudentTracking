namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class RefundInformationsTable
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
            this.colDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colAccountType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemAccountType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colAccountId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAccountName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemAccount = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemAccount,
            this.repositoryItemCalc,
            this.repositoryItemAccountType});
            this.grid.Size = new System.Drawing.Size(541, 340);
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
            this.colDate,
            this.colAccountType,
            this.colAccountId,
            this.colAccountName,
            this.colPrice,
            this.colStatement});
            this.table.GridControl = this.grid;
            this.table.Name = "table";
            this.table.OptionsCustomization.AllowColumnMoving = false;
            this.table.OptionsCustomization.AllowSort = false;
            this.table.OptionsMenu.EnableColumnMenu = false;
            this.table.OptionsMenu.EnableFooterMenu = false;
            this.table.OptionsMenu.EnableGroupPanelMenu = false;
            this.table.OptionsNavigation.EnterMoveNextColumn = true;
            this.table.OptionsPrint.PrintFooter = false;
            this.table.OptionsPrint.PrintGroupFooter = false;
            this.table.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.table.OptionsView.RowAutoHeight = true;
            this.table.OptionsView.ShowFooter = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarShortcut = "Shift + Insert :";
            this.table.StatusBarShortcutStatement = "Hareket Ekle";
            this.table.StatusBarStatement = "Geri Ödeme Bilgileri Giriniz";
            this.table.ViewCaption = "Geri Ödeme Bilgileri";
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.Caption = "Tarih";
            this.colDate.ColumnEdit = this.repositoryItemDate;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsFilter.AllowAutoFilter = false;
            this.colDate.OptionsFilter.AllowFilter = false;
            this.colDate.StatusBarShortcut = "F4 :";
            this.colDate.StatusBarShortcutStatement = "Seçim Yap";
            this.colDate.StatusBarStatement = "Tarih Seçiniz";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 100;
            // 
            // repositoryItemDate
            // 
            this.repositoryItemDate.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDate.AutoHeight = false;
            this.repositoryItemDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDate.Name = "repositoryItemDate";
            // 
            // colAccountType
            // 
            this.colAccountType.Caption = "Hesap Türü";
            this.colAccountType.ColumnEdit = this.repositoryItemAccountType;
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.OptionsFilter.AllowAutoFilter = false;
            this.colAccountType.OptionsFilter.AllowFilter = false;
            this.colAccountType.StatusBarShortcut = "F4 :";
            this.colAccountType.StatusBarShortcutStatement = "Seçim Yap";
            this.colAccountType.StatusBarStatement = "Hesap Türü Seçiniz";
            this.colAccountType.Visible = true;
            this.colAccountType.VisibleIndex = 1;
            this.colAccountType.Width = 100;
            // 
            // repositoryItemAccountType
            // 
            this.repositoryItemAccountType.AutoHeight = false;
            this.repositoryItemAccountType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemAccountType.Name = "repositoryItemAccountType";
            // 
            // colAccountId
            // 
            this.colAccountId.Caption = "Hesap Id";
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.OptionsColumn.AllowEdit = false;
            this.colAccountId.OptionsColumn.ShowInCustomizationForm = false;
            this.colAccountId.OptionsFilter.AllowAutoFilter = false;
            this.colAccountId.OptionsFilter.AllowFilter = false;
            this.colAccountId.StatusBarShortcut = null;
            this.colAccountId.StatusBarShortcutStatement = null;
            this.colAccountId.StatusBarStatement = null;
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "Hesap Adı";
            this.colAccountName.ColumnEdit = this.repositoryItemAccount;
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.OptionsFilter.AllowAutoFilter = false;
            this.colAccountName.OptionsFilter.AllowFilter = false;
            this.colAccountName.StatusBarShortcut = "F4 :";
            this.colAccountName.StatusBarShortcutStatement = "Seçim Yap";
            this.colAccountName.StatusBarStatement = "Banka Hesabı Seçiniz";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 2;
            this.colAccountName.Width = 200;
            // 
            // repositoryItemAccount
            // 
            this.repositoryItemAccount.AutoHeight = false;
            this.repositoryItemAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemAccount.Name = "repositoryItemAccount";
            this.repositoryItemAccount.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Tutar";
            this.colPrice.ColumnEdit = this.repositoryItemCalc;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsFilter.AllowAutoFilter = false;
            this.colPrice.OptionsFilter.AllowFilter = false;
            this.colPrice.StatusBarShortcut = "F4 :";
            this.colPrice.StatusBarShortcutStatement = "Hesap Makinesi";
            this.colPrice.StatusBarStatement = "Tutar Giriniz";
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:c2}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 100;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalc.DisplayFormat.FormatString = "c2";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.EditFormat.FormatString = "c2";
            this.repositoryItemCalc.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Mask.EditMask = "c2";
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // colStatement
            // 
            this.colStatement.Caption = "Açıklama";
            this.colStatement.FieldName = "Statement";
            this.colStatement.Name = "colStatement";
            this.colStatement.OptionsFilter.AllowAutoFilter = false;
            this.colStatement.OptionsFilter.AllowFilter = false;
            this.colStatement.StatusBarShortcut = null;
            this.colStatement.StatusBarShortcutStatement = null;
            this.colStatement.StatusBarStatement = "Açıklama Giriniz";
            this.colStatement.Visible = true;
            this.colStatement.VisibleIndex = 4;
            this.colStatement.Width = 250;
            // 
            // RefundInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "RefundInformationsTable";
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private Grids.MyGridColumn colAccountType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemAccountType;
        private Grids.MyGridColumn colAccountId;
        private Grids.MyGridColumn colAccountName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemAccount;
        private Grids.MyGridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private Grids.MyGridColumn colStatement;
    }
}
