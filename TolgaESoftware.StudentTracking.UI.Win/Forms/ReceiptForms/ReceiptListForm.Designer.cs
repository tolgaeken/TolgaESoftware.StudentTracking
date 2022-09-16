namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms
{
    partial class ReceiptListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptListForm));
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colReceiptNumber = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colAccountType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colReceiptType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNumberOfAction = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colSumOfReceipt = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAccountName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpin)).BeginInit();
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
            this.repositoryItemCalc,
            this.repositoryItemDate,
            this.repositoryItemSpin});
            this.grid.Size = new System.Drawing.Size(1168, 639);
            this.grid.TabIndex = 3;
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
            this.colReceiptNumber,
            this.colDate,
            this.colAccountType,
            this.colReceiptType,
            this.colNumberOfAction,
            this.colSumOfReceipt,
            this.colAccountName});
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
            this.table.ViewCaption = "Makbuz Kartları";
            // 
            // colReceiptNumber
            // 
            this.colReceiptNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colReceiptNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptNumber.Caption = "Makbuz No";
            this.colReceiptNumber.FieldName = "Code";
            this.colReceiptNumber.Name = "colReceiptNumber";
            this.colReceiptNumber.OptionsColumn.AllowEdit = false;
            this.colReceiptNumber.OptionsColumn.AllowFocus = false;
            this.colReceiptNumber.StatusBarShortcut = null;
            this.colReceiptNumber.StatusBarShortcutStatement = null;
            this.colReceiptNumber.StatusBarStatement = null;
            this.colReceiptNumber.Visible = true;
            this.colReceiptNumber.VisibleIndex = 0;
            this.colReceiptNumber.Width = 100;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.Caption = "Tarih";
            this.colDate.ColumnEdit = this.repositoryItemDate;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.OptionsColumn.AllowFocus = false;
            this.colDate.StatusBarShortcut = null;
            this.colDate.StatusBarShortcutStatement = null;
            this.colDate.StatusBarStatement = null;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 100;
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
            // colAccountType
            // 
            this.colAccountType.Caption = "Hesap Türü";
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.OptionsColumn.AllowEdit = false;
            this.colAccountType.OptionsColumn.AllowFocus = false;
            this.colAccountType.StatusBarShortcut = null;
            this.colAccountType.StatusBarShortcutStatement = null;
            this.colAccountType.StatusBarStatement = null;
            this.colAccountType.Visible = true;
            this.colAccountType.VisibleIndex = 2;
            this.colAccountType.Width = 100;
            // 
            // colReceiptType
            // 
            this.colReceiptType.Caption = "Makbuz Türü";
            this.colReceiptType.FieldName = "ReceiptType";
            this.colReceiptType.Name = "colReceiptType";
            this.colReceiptType.OptionsColumn.AllowEdit = false;
            this.colReceiptType.OptionsColumn.AllowFocus = false;
            this.colReceiptType.StatusBarShortcut = null;
            this.colReceiptType.StatusBarShortcutStatement = null;
            this.colReceiptType.StatusBarStatement = null;
            this.colReceiptType.Visible = true;
            this.colReceiptType.VisibleIndex = 3;
            this.colReceiptType.Width = 150;
            // 
            // colNumberOfAction
            // 
            this.colNumberOfAction.Caption = "Hareket";
            this.colNumberOfAction.ColumnEdit = this.repositoryItemSpin;
            this.colNumberOfAction.FieldName = "NumberOfAction";
            this.colNumberOfAction.Name = "colNumberOfAction";
            this.colNumberOfAction.OptionsColumn.AllowEdit = false;
            this.colNumberOfAction.OptionsColumn.AllowFocus = false;
            this.colNumberOfAction.StatusBarShortcut = null;
            this.colNumberOfAction.StatusBarShortcutStatement = null;
            this.colNumberOfAction.StatusBarStatement = null;
            this.colNumberOfAction.Visible = true;
            this.colNumberOfAction.VisibleIndex = 4;
            this.colNumberOfAction.Width = 70;
            // 
            // repositoryItemSpin
            // 
            this.repositoryItemSpin.AutoHeight = false;
            this.repositoryItemSpin.DisplayFormat.FormatString = "{0:n0}";
            this.repositoryItemSpin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpin.Name = "repositoryItemSpin";
            // 
            // colSumOfReceipt
            // 
            this.colSumOfReceipt.Caption = "Makbuz Toplamı";
            this.colSumOfReceipt.ColumnEdit = this.repositoryItemCalc;
            this.colSumOfReceipt.FieldName = "SumOfReceipt";
            this.colSumOfReceipt.Name = "colSumOfReceipt";
            this.colSumOfReceipt.OptionsColumn.AllowEdit = false;
            this.colSumOfReceipt.OptionsColumn.AllowFocus = false;
            this.colSumOfReceipt.StatusBarShortcut = null;
            this.colSumOfReceipt.StatusBarShortcutStatement = null;
            this.colSumOfReceipt.StatusBarStatement = null;
            this.colSumOfReceipt.Visible = true;
            this.colSumOfReceipt.VisibleIndex = 5;
            this.colSumOfReceipt.Width = 100;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalc.DisplayFormat.FormatString = "{0:c2}";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "Hesap Adı";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.OptionsColumn.AllowEdit = false;
            this.colAccountName.OptionsColumn.AllowFocus = false;
            this.colAccountName.StatusBarShortcut = null;
            this.colAccountName.StatusBarShortcutStatement = null;
            this.colAccountName.StatusBarStatement = null;
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 6;
            this.colAccountName.Width = 250;
            // 
            // ReceiptListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ReceiptListForm";
            this.Text = "Makbuz Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView table;
        private UserControls.Grids.MyGridColumn colReceiptNumber;
        private UserControls.Grids.MyGridColumn colDate;
        private UserControls.Grids.MyGridColumn colAccountType;
        private UserControls.Grids.MyGridColumn colReceiptType;
        private UserControls.Grids.MyGridColumn colNumberOfAction;
        private UserControls.Grids.MyGridColumn colSumOfReceipt;
        private UserControls.Grids.MyGridColumn colAccountName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpin;
    }
}