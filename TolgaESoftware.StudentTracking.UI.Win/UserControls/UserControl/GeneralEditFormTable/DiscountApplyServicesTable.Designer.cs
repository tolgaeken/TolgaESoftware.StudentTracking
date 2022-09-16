namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.GeneralEditFormTable
{
    partial class DiscountApplyServicesTable
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
            this.colServiceName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDiscountPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryPrice = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDiscountPercentage = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryPercentage = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryPrice,
            this.repositoryPercentage});
            this.grid.Size = new System.Drawing.Size(464, 300);
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
            this.colServiceName,
            this.colDiscountPrice,
            this.colDiscountPercentage});
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
            this.table.StatusBarShortcut = "Shift + Insert";
            this.table.StatusBarShortcutStatement = "Hizmet Kartı Ekle";
            this.table.StatusBarStatement = "İndirimin Uygulunacağı Hizmet Kartlarını Seçiniz";
            this.table.ViewCaption = "İndirim Uygulanacak Hizmetler";
            // 
            // colServiceName
            // 
            this.colServiceName.Caption = "Hizmet Adı";
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.OptionsColumn.AllowEdit = false;
            this.colServiceName.OptionsColumn.AllowFocus = false;
            this.colServiceName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServiceName.OptionsFilter.AllowAutoFilter = false;
            this.colServiceName.OptionsFilter.AllowFilter = false;
            this.colServiceName.StatusBarShortcut = null;
            this.colServiceName.StatusBarShortcutStatement = null;
            this.colServiceName.StatusBarStatement = null;
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 0;
            this.colServiceName.Width = 210;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.Caption = "Tutar";
            this.colDiscountPrice.ColumnEdit = this.repositoryPrice;
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscountPrice.OptionsFilter.AllowAutoFilter = false;
            this.colDiscountPrice.OptionsFilter.AllowFilter = false;
            this.colDiscountPrice.StatusBarShortcut = "F4 :";
            this.colDiscountPrice.StatusBarShortcutStatement = "Hesap Makinesi";
            this.colDiscountPrice.StatusBarStatement = "İndirim Tutarı Giriniz";
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 1;
            this.colDiscountPrice.Width = 100;
            // 
            // repositoryPrice
            // 
            this.repositoryPrice.AutoHeight = false;
            this.repositoryPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryPrice.DisplayFormat.FormatString = "c2";
            this.repositoryPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryPrice.EditFormat.FormatString = "c2";
            this.repositoryPrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryPrice.Mask.EditMask = "c2";
            this.repositoryPrice.Name = "repositoryPrice";
            this.repositoryPrice.NullValuePrompt = "0";
            // 
            // colDiscountPercentage
            // 
            this.colDiscountPercentage.AppearanceCell.Options.UseTextOptions = true;
            this.colDiscountPercentage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscountPercentage.Caption = "Oran (%)";
            this.colDiscountPercentage.ColumnEdit = this.repositoryPercentage;
            this.colDiscountPercentage.FieldName = "DiscountPercentage";
            this.colDiscountPercentage.Name = "colDiscountPercentage";
            this.colDiscountPercentage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscountPercentage.OptionsFilter.AllowAutoFilter = false;
            this.colDiscountPercentage.OptionsFilter.AllowFilter = false;
            this.colDiscountPercentage.StatusBarShortcut = null;
            this.colDiscountPercentage.StatusBarShortcutStatement = null;
            this.colDiscountPercentage.StatusBarStatement = "İndirim Oranı Giriniz";
            this.colDiscountPercentage.Visible = true;
            this.colDiscountPercentage.VisibleIndex = 2;
            this.colDiscountPercentage.Width = 100;
            // 
            // repositoryPercentage
            // 
            this.repositoryPercentage.AutoHeight = false;
            this.repositoryPercentage.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryPercentage.DisplayFormat.FormatString = "n0";
            this.repositoryPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryPercentage.EditFormat.FormatString = "n0";
            this.repositoryPercentage.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryPercentage.Mask.EditMask = "n0";
            this.repositoryPercentage.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryPercentage.Name = "repositoryPercentage";
            this.repositoryPercentage.NullValuePrompt = "0";
            // 
            // DiscountApplyServicesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "DiscountApplyServicesTable";
            this.Size = new System.Drawing.Size(464, 324);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colServiceName;
        private Grids.MyGridColumn colDiscountPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryPrice;
        private Grids.MyGridColumn colDiscountPercentage;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryPercentage;
    }
}
