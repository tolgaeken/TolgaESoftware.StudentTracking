namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceForms
{
    partial class ServiceListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceListForm));
            this.topPanel = new DevExpress.XtraEditors.PanelControl();
            this.txtServiceStartDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyDateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.longNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.table = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCode = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServiceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServiceTypeId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServiceTypeName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colStartDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colEndDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDecimalMoney = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimalMoney)).BeginInit();
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
            // topPanel
            // 
            this.topPanel.Controls.Add(this.txtServiceStartDate);
            this.topPanel.Controls.Add(this.labelControl1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 109);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1168, 35);
            this.topPanel.TabIndex = 2;
            this.topPanel.Visible = false;
            // 
            // txtServiceStartDate
            // 
            this.txtServiceStartDate.EditValue = null;
            this.txtServiceStartDate.EnterMoveNextControl = true;
            this.txtServiceStartDate.Location = new System.Drawing.Point(122, 8);
            this.txtServiceStartDate.MenuManager = this.ribbonControl;
            this.txtServiceStartDate.Name = "txtServiceStartDate";
            this.txtServiceStartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtServiceStartDate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtServiceStartDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtServiceStartDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtServiceStartDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtServiceStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtServiceStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtServiceStartDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtServiceStartDate.Size = new System.Drawing.Size(120, 20);
            this.txtServiceStartDate.StatusBarShortcut = "F4 : ";
            this.txtServiceStartDate.StatusBarShortcutStatement = "Tarih Seçiniz";
            this.txtServiceStartDate.StatusBarStatement = null;
            this.txtServiceStartDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hizmet Başlama Tarihi :";
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 748);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1168, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 144);
            this.grid.MainView = this.table;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemDecimalMoney});
            this.grid.Size = new System.Drawing.Size(1168, 604);
            this.grid.TabIndex = 4;
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
            this.colId,
            this.colCode,
            this.colServiceName,
            this.colServiceTypeId,
            this.colServiceTypeName,
            this.colStartDate,
            this.colEndDate,
            this.colPrice,
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
            this.table.ViewCaption = "Hizmet Kartları";
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
            // colCode
            // 
            this.colCode.AppearanceCell.Options.UseTextOptions = true;
            this.colCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.OptionsColumn.ShowInCustomizationForm = false;
            this.colCode.StatusBarShortcut = null;
            this.colCode.StatusBarShortcutStatement = null;
            this.colCode.StatusBarStatement = null;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 130;
            // 
            // colServiceName
            // 
            this.colServiceName.Caption = "Hizmet Adı";
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.OptionsColumn.AllowEdit = false;
            this.colServiceName.OptionsColumn.AllowFocus = false;
            this.colServiceName.StatusBarShortcut = null;
            this.colServiceName.StatusBarShortcutStatement = null;
            this.colServiceName.StatusBarStatement = null;
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 1;
            this.colServiceName.Width = 200;
            // 
            // colServiceTypeId
            // 
            this.colServiceTypeId.Caption = "HizmetTuruId";
            this.colServiceTypeId.FieldName = "ServiceTypeId";
            this.colServiceTypeId.Name = "colServiceTypeId";
            this.colServiceTypeId.OptionsColumn.AllowEdit = false;
            this.colServiceTypeId.OptionsColumn.AllowFocus = false;
            this.colServiceTypeId.OptionsColumn.ShowInCustomizationForm = false;
            this.colServiceTypeId.StatusBarShortcut = null;
            this.colServiceTypeId.StatusBarShortcutStatement = null;
            this.colServiceTypeId.StatusBarStatement = null;
            // 
            // colServiceTypeName
            // 
            this.colServiceTypeName.Caption = "Hizmet Türü Adı";
            this.colServiceTypeName.FieldName = "ServiceTypeName";
            this.colServiceTypeName.Name = "colServiceTypeName";
            this.colServiceTypeName.OptionsColumn.AllowEdit = false;
            this.colServiceTypeName.OptionsColumn.AllowFocus = false;
            this.colServiceTypeName.StatusBarShortcut = null;
            this.colServiceTypeName.StatusBarShortcutStatement = null;
            this.colServiceTypeName.StatusBarStatement = null;
            this.colServiceTypeName.Visible = true;
            this.colServiceTypeName.VisibleIndex = 2;
            this.colServiceTypeName.Width = 180;
            // 
            // colStartDate
            // 
            this.colStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartDate.Caption = "Başlama Tarihi";
            this.colStartDate.ColumnEdit = this.repositoryItemDate;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.OptionsColumn.AllowEdit = false;
            this.colStartDate.OptionsColumn.AllowFocus = false;
            this.colStartDate.StatusBarShortcut = null;
            this.colStartDate.StatusBarShortcutStatement = null;
            this.colStartDate.StatusBarStatement = null;
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            this.colStartDate.Width = 100;
            // 
            // colEndDate
            // 
            this.colEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndDate.Caption = "Bitiş Tarihi";
            this.colEndDate.ColumnEdit = this.repositoryItemDate;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.OptionsColumn.AllowEdit = false;
            this.colEndDate.OptionsColumn.AllowFocus = false;
            this.colEndDate.StatusBarShortcut = null;
            this.colEndDate.StatusBarShortcutStatement = null;
            this.colEndDate.StatusBarStatement = null;
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 4;
            this.colEndDate.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Ücret";
            this.colPrice.ColumnEdit = this.repositoryItemDecimalMoney;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.OptionsColumn.AllowFocus = false;
            this.colPrice.StatusBarShortcut = null;
            this.colPrice.StatusBarShortcutStatement = null;
            this.colPrice.StatusBarStatement = null;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 5;
            this.colPrice.Width = 70;
            // 
            // colStatement
            // 
            this.colStatement.Caption = "Açıklama";
            this.colStatement.FieldName = "Statement";
            this.colStatement.Name = "colStatement";
            this.colStatement.OptionsColumn.AllowEdit = false;
            this.colStatement.OptionsColumn.AllowFocus = false;
            this.colStatement.StatusBarShortcut = null;
            this.colStatement.StatusBarShortcutStatement = null;
            this.colStatement.StatusBarStatement = null;
            this.colStatement.Visible = true;
            this.colStatement.VisibleIndex = 6;
            this.colStatement.Width = 300;
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
            // repositoryItemDecimalMoney
            // 
            this.repositoryItemDecimalMoney.AutoHeight = false;
            this.repositoryItemDecimalMoney.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimalMoney.DisplayFormat.FormatString = "c2";
            this.repositoryItemDecimalMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimalMoney.Mask.EditMask = "c2";
            this.repositoryItemDecimalMoney.Name = "repositoryItemDecimalMoney";
            // 
            // ServiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 796);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Controls.Add(this.topPanel);
            this.IconOptions.ShowIcon = false;
            this.Name = "ServiceListForm";
            this.Text = "Hizmet Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimalMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl topPanel;
        private UserControls.Controls.MyDateEdit txtServiceStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView table;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colCode;
        private UserControls.Grids.MyGridColumn colServiceName;
        private UserControls.Grids.MyGridColumn colServiceTypeName;
        private UserControls.Grids.MyGridColumn colStartDate;
        private UserControls.Grids.MyGridColumn colEndDate;
        private UserControls.Grids.MyGridColumn colPrice;
        private UserControls.Grids.MyGridColumn colStatement;
        private UserControls.Grids.MyGridColumn colServiceTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimalMoney;
    }
}