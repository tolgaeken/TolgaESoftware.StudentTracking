namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable
{
    partial class ExamInformationsTable
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
            this.colExamName = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colScoreType = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.colScore = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemScore = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colRanking = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colRankingPercentage = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemPercentage = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Size = new System.Drawing.Size(650, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.table;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemScore,
            this.repositoryItemCalc,
            this.repositoryItemPercentage});
            this.grid.Size = new System.Drawing.Size(650, 340);
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
            this.colExamName,
            this.colDate,
            this.colScoreType,
            this.colScore,
            this.colRanking,
            this.colRankingPercentage});
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
            this.table.StatusBarShortcutStatement = "Sınav Bilgisi Gir";
            this.table.StatusBarStatement = "Sınav Bilgilerini Giriniz";
            this.table.ViewCaption = "Sınav Bilgileri";
            // 
            // colExamName
            // 
            this.colExamName.Caption = "Sınav Adı";
            this.colExamName.FieldName = "ExamName";
            this.colExamName.Name = "colExamName";
            this.colExamName.StatusBarShortcut = null;
            this.colExamName.StatusBarShortcutStatement = null;
            this.colExamName.StatusBarStatement = "Sınav Adı Giriniz";
            this.colExamName.Visible = true;
            this.colExamName.VisibleIndex = 0;
            this.colExamName.Width = 120;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.Caption = "Tarih";
            this.colDate.ColumnEdit = this.repositoryItemDate;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.StatusBarShortcut = "F4 :";
            this.colDate.StatusBarShortcutStatement = "Seçim Yap";
            this.colDate.StatusBarStatement = "Tarih Seçiniz";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
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
            // colScoreType
            // 
            this.colScoreType.Caption = "Puan Türü";
            this.colScoreType.FieldName = "ScoreType";
            this.colScoreType.Name = "colScoreType";
            this.colScoreType.StatusBarShortcut = null;
            this.colScoreType.StatusBarShortcutStatement = null;
            this.colScoreType.StatusBarStatement = "Puan Türü Giriniz";
            this.colScoreType.Visible = true;
            this.colScoreType.VisibleIndex = 2;
            this.colScoreType.Width = 100;
            // 
            // colScore
            // 
            this.colScore.Caption = "Puanı";
            this.colScore.ColumnEdit = this.repositoryItemScore;
            this.colScore.FieldName = "Score";
            this.colScore.Name = "colScore";
            this.colScore.StatusBarShortcut = null;
            this.colScore.StatusBarShortcutStatement = null;
            this.colScore.StatusBarStatement = "Puan Giriniz";
            this.colScore.Visible = true;
            this.colScore.VisibleIndex = 3;
            this.colScore.Width = 100;
            // 
            // repositoryItemScore
            // 
            this.repositoryItemScore.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemScore.AutoHeight = false;
            this.repositoryItemScore.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemScore.DisplayFormat.FormatString = "n5";
            this.repositoryItemScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemScore.EditFormat.FormatString = "n5";
            this.repositoryItemScore.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemScore.Mask.EditMask = "n5";
            this.repositoryItemScore.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.repositoryItemScore.Name = "repositoryItemScore";
            // 
            // colRanking
            // 
            this.colRanking.Caption = "Sıralama";
            this.colRanking.ColumnEdit = this.repositoryItemCalc;
            this.colRanking.FieldName = "Ranking";
            this.colRanking.Name = "colRanking";
            this.colRanking.StatusBarShortcut = null;
            this.colRanking.StatusBarShortcutStatement = null;
            this.colRanking.StatusBarStatement = "Sıralama Giriniz";
            this.colRanking.Visible = true;
            this.colRanking.VisibleIndex = 4;
            this.colRanking.Width = 100;
            // 
            // repositoryItemCalc
            // 
            this.repositoryItemCalc.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemCalc.AutoHeight = false;
            this.repositoryItemCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalc.DisplayFormat.FormatString = "n0";
            this.repositoryItemCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.EditFormat.FormatString = "n0";
            this.repositoryItemCalc.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalc.Mask.EditMask = "n0";
            this.repositoryItemCalc.Name = "repositoryItemCalc";
            // 
            // colRankingPercentage
            // 
            this.colRankingPercentage.Caption = "Derece ( % )";
            this.colRankingPercentage.ColumnEdit = this.repositoryItemPercentage;
            this.colRankingPercentage.FieldName = "RankingPercentage";
            this.colRankingPercentage.Name = "colRankingPercentage";
            this.colRankingPercentage.StatusBarShortcut = null;
            this.colRankingPercentage.StatusBarShortcutStatement = null;
            this.colRankingPercentage.StatusBarStatement = "Yüzdelik Dilimi Giriniz";
            this.colRankingPercentage.Visible = true;
            this.colRankingPercentage.VisibleIndex = 5;
            this.colRankingPercentage.Width = 100;
            // 
            // repositoryItemPercentage
            // 
            this.repositoryItemPercentage.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemPercentage.AutoHeight = false;
            this.repositoryItemPercentage.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPercentage.DisplayFormat.FormatString = "n4";
            this.repositoryItemPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPercentage.EditFormat.FormatString = "n4";
            this.repositoryItemPercentage.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPercentage.Mask.EditMask = "n4";
            this.repositoryItemPercentage.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemPercentage.Name = "repositoryItemPercentage";
            // 
            // ExamInformationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "ExamInformationsTable";
            this.Size = new System.Drawing.Size(650, 364);
            this.Controls.SetChildIndex(this.InsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView table;
        private Grids.MyGridColumn colExamName;
        private Grids.MyGridColumn colDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private Grids.MyGridColumn colScoreType;
        private Grids.MyGridColumn colScore;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemScore;
        private Grids.MyGridColumn colRanking;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalc;
        private Grids.MyGridColumn colRankingPercentage;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemPercentage;
    }
}
