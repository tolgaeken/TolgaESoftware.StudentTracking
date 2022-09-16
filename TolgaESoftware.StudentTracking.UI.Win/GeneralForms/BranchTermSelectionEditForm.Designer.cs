namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    partial class BranchTermSelectionEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.termNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.SmallNavigator();
            this.branchNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.SmallNavigator();
            this.termGrid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.termTable = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colTermId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTermName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.branchGrid = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridControl();
            this.branchTable = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridView();
            this.colBranchId = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.termNavigator);
            this.myDataLayoutControl.Controls.Add(this.branchNavigator);
            this.myDataLayoutControl.Controls.Add(this.termGrid);
            this.myDataLayoutControl.Controls.Add(this.branchGrid);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(635, 245);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // termNavigator
            // 
            this.termNavigator.Location = new System.Drawing.Point(319, 217);
            this.termNavigator.Name = "termNavigator";
            this.termNavigator.Size = new System.Drawing.Size(312, 24);
            this.termNavigator.TabIndex = 7;
            // 
            // branchNavigator
            // 
            this.branchNavigator.Location = new System.Drawing.Point(4, 217);
            this.branchNavigator.Name = "branchNavigator";
            this.branchNavigator.Size = new System.Drawing.Size(311, 24);
            this.branchNavigator.TabIndex = 6;
            // 
            // termGrid
            // 
            this.termGrid.Location = new System.Drawing.Point(319, 4);
            this.termGrid.MainView = this.termTable;
            this.termGrid.MenuManager = this.ribbonControl;
            this.termGrid.Name = "termGrid";
            this.termGrid.Size = new System.Drawing.Size(312, 209);
            this.termGrid.TabIndex = 5;
            this.termGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.termTable});
            // 
            // termTable
            // 
            this.termTable.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.termTable.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.termTable.Appearance.FooterPanel.Options.UseFont = true;
            this.termTable.Appearance.FooterPanel.Options.UseForeColor = true;
            this.termTable.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.termTable.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.termTable.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.termTable.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.termTable.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.termTable.Appearance.ViewCaption.Options.UseForeColor = true;
            this.termTable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTermId,
            this.colTermName});
            this.termTable.GridControl = this.termGrid;
            this.termTable.Name = "termTable";
            this.termTable.OptionsMenu.EnableColumnMenu = false;
            this.termTable.OptionsMenu.EnableFooterMenu = false;
            this.termTable.OptionsMenu.EnableGroupPanelMenu = false;
            this.termTable.OptionsNavigation.EnterMoveNextColumn = true;
            this.termTable.OptionsPrint.AutoWidth = false;
            this.termTable.OptionsPrint.PrintFooter = false;
            this.termTable.OptionsPrint.PrintGroupFooter = false;
            this.termTable.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.termTable.OptionsView.RowAutoHeight = true;
            this.termTable.OptionsView.ShowColumnHeaders = false;
            this.termTable.OptionsView.ShowGroupPanel = false;
            this.termTable.OptionsView.ShowViewCaption = true;
            this.termTable.StatusBarShortcut = null;
            this.termTable.StatusBarShortcutStatement = null;
            this.termTable.StatusBarStatement = "Kulanıcı\'nın Yetkili Olduğu Dönemler";
            this.termTable.ViewCaption = "Dönem Kartları";
            // 
            // colTermId
            // 
            this.colTermId.Caption = "Id";
            this.colTermId.FieldName = "TermId";
            this.colTermId.Name = "colTermId";
            this.colTermId.OptionsColumn.AllowEdit = false;
            this.colTermId.OptionsColumn.ShowInCustomizationForm = false;
            this.colTermId.StatusBarShortcut = null;
            this.colTermId.StatusBarShortcutStatement = null;
            this.colTermId.StatusBarStatement = null;
            // 
            // colTermName
            // 
            this.colTermName.Caption = "Dönem Adı";
            this.colTermName.FieldName = "TermName";
            this.colTermName.Name = "colTermName";
            this.colTermName.OptionsColumn.AllowEdit = false;
            this.colTermName.StatusBarShortcut = null;
            this.colTermName.StatusBarShortcutStatement = null;
            this.colTermName.StatusBarStatement = null;
            this.colTermName.Visible = true;
            this.colTermName.VisibleIndex = 0;
            // 
            // branchGrid
            // 
            this.branchGrid.Location = new System.Drawing.Point(4, 4);
            this.branchGrid.MainView = this.branchTable;
            this.branchGrid.MenuManager = this.ribbonControl;
            this.branchGrid.Name = "branchGrid";
            this.branchGrid.Size = new System.Drawing.Size(311, 209);
            this.branchGrid.TabIndex = 4;
            this.branchGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.branchTable});
            // 
            // branchTable
            // 
            this.branchTable.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.branchTable.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.branchTable.Appearance.FooterPanel.Options.UseFont = true;
            this.branchTable.Appearance.FooterPanel.Options.UseForeColor = true;
            this.branchTable.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.branchTable.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.branchTable.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.branchTable.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.branchTable.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.branchTable.Appearance.ViewCaption.Options.UseForeColor = true;
            this.branchTable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchId,
            this.colBranchName});
            this.branchTable.GridControl = this.branchGrid;
            this.branchTable.Name = "branchTable";
            this.branchTable.OptionsMenu.EnableColumnMenu = false;
            this.branchTable.OptionsMenu.EnableFooterMenu = false;
            this.branchTable.OptionsMenu.EnableGroupPanelMenu = false;
            this.branchTable.OptionsNavigation.EnterMoveNextColumn = true;
            this.branchTable.OptionsPrint.AutoWidth = false;
            this.branchTable.OptionsPrint.PrintFooter = false;
            this.branchTable.OptionsPrint.PrintGroupFooter = false;
            this.branchTable.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.branchTable.OptionsView.RowAutoHeight = true;
            this.branchTable.OptionsView.ShowColumnHeaders = false;
            this.branchTable.OptionsView.ShowGroupPanel = false;
            this.branchTable.OptionsView.ShowViewCaption = true;
            this.branchTable.StatusBarShortcut = null;
            this.branchTable.StatusBarShortcutStatement = null;
            this.branchTable.StatusBarStatement = "Kulanıcı\'nın Yetkili Olduğu Şubeler";
            this.branchTable.ViewCaption = "Şube Kartları";
            // 
            // colBranchId
            // 
            this.colBranchId.Caption = "Id";
            this.colBranchId.FieldName = "BranchId";
            this.colBranchId.Name = "colBranchId";
            this.colBranchId.OptionsColumn.AllowEdit = false;
            this.colBranchId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBranchId.StatusBarShortcut = null;
            this.colBranchId.StatusBarShortcutStatement = null;
            this.colBranchId.StatusBarStatement = null;
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
            this.colBranchName.VisibleIndex = 0;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 28D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup.Size = new System.Drawing.Size(635, 245);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.Control = this.branchGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(315, 213);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.Control = this.termGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(315, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(316, 213);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.Control = this.branchNavigator;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 213);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(159, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(315, 28);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.Control = this.termNavigator;
            this.layoutControlItem4.Location = new System.Drawing.Point(315, 213);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(159, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(316, 28);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // BranchTermSelectionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 378);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "BranchTermSelectionEditForm";
            this.Text = "Şube ve Dönem Seçimi";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.termGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Navigators.SmallNavigator termNavigator;
        private UserControls.Navigators.SmallNavigator branchNavigator;
        private UserControls.Grids.MyGridControl termGrid;
        private UserControls.Grids.MyGridView termTable;
        private UserControls.Grids.MyGridColumn colTermId;
        private UserControls.Grids.MyGridColumn colTermName;
        private UserControls.Grids.MyGridControl branchGrid;
        private UserControls.Grids.MyGridView branchTable;
        private UserControls.Grids.MyGridColumn colBranchId;
        private UserControls.Grids.MyGridColumn colBranchName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}