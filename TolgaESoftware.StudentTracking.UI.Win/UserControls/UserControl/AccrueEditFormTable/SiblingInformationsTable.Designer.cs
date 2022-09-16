namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class SiblingInformationsTable
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
            this.colClassName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colEnrollmentType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colEnrollmentStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCancelStatus = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBranchName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 475);
            this.InsUptNavigator.Size = new System.Drawing.Size(974, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(974, 475);
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
            this.colClassName,
            this.colEnrollmentType,
            this.colEnrollmentStatus,
            this.colCancelStatus,
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
            this.table.StatusBarShortcut = "Shift + Insert :";
            this.table.StatusBarShortcutStatement = "Seçim Yap";
            this.table.StatusBarStatement = "Kardeş Öğrencileri Seçiniz";
            this.table.ViewCaption = "Kardeş Bilgileri";
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ShowInCustomizationForm = false;
            this.colName.StatusBarShortcut = null;
            this.colName.StatusBarShortcutStatement = null;
            this.colName.StatusBarStatement = null;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
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
            this.colLastname.VisibleIndex = 1;
            this.colLastname.Width = 120;
            // 
            // colClassName
            // 
            this.colClassName.Caption = "Sınıf";
            this.colClassName.FieldName = "ClassName";
            this.colClassName.Name = "colClassName";
            this.colClassName.OptionsColumn.AllowEdit = false;
            this.colClassName.StatusBarShortcut = null;
            this.colClassName.StatusBarShortcutStatement = null;
            this.colClassName.StatusBarStatement = null;
            this.colClassName.Visible = true;
            this.colClassName.VisibleIndex = 2;
            this.colClassName.Width = 120;
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
            this.colEnrollmentType.VisibleIndex = 3;
            this.colEnrollmentType.Width = 120;
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
            this.colEnrollmentStatus.VisibleIndex = 4;
            this.colEnrollmentStatus.Width = 120;
            // 
            // colCancelStatus
            // 
            this.colCancelStatus.Caption = "İptal Durumu";
            this.colCancelStatus.FieldName = "CancelStatus";
            this.colCancelStatus.Name = "colCancelStatus";
            this.colCancelStatus.OptionsColumn.AllowEdit = false;
            this.colCancelStatus.StatusBarShortcut = null;
            this.colCancelStatus.StatusBarShortcutStatement = null;
            this.colCancelStatus.StatusBarStatement = null;
            this.colCancelStatus.Visible = true;
            this.colCancelStatus.VisibleIndex = 5;
            this.colCancelStatus.Width = 120;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "Şube";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.OptionsColumn.AllowEdit = false;
            this.colBranchName.StatusBarShortcut = null;
            this.colBranchName.StatusBarShortcutStatement = null;
            this.colBranchName.StatusBarStatement = null;
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 6;
            this.colBranchName.Width = 150;
            // 
            // SiblingInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SiblingInformationsTable";
            this.Size = new System.Drawing.Size(974, 499);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colName;
        private Grids.MyGridColumn colLastname;
        private Grids.MyGridColumn colClassName;
        private Grids.MyGridColumn colEnrollmentType;
        private Grids.MyGridColumn colEnrollmentStatus;
        private Grids.MyGridColumn colCancelStatus;
        private Grids.MyGridColumn colBranchName;
    }
}
