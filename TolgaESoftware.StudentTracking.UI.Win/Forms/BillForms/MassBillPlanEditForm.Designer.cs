namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms
{
    partial class MassBillPlanEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtMonthInfo = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.txtSummaryAccrueStatement = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtSummaryAccrue = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.txtFixPrice = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyMoneyCalcEdit();
            this.txtQuantity = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MySpinEdit();
            this.txtFirstBillDate = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyDateEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProgress = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummaryAccrueStatement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummaryAccrue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstBillDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstBillDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProgress)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(518, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.progressBarControl);
            this.myDataLayoutControl.Controls.Add(this.txtMonthInfo);
            this.myDataLayoutControl.Controls.Add(this.txtSummaryAccrueStatement);
            this.myDataLayoutControl.Controls.Add(this.txtSummaryAccrue);
            this.myDataLayoutControl.Controls.Add(this.txtFixPrice);
            this.myDataLayoutControl.Controls.Add(this.txtQuantity);
            this.myDataLayoutControl.Controls.Add(this.txtFirstBillDate);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(518, 146);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(12, 108);
            this.progressBarControl.MenuManager = this.ribbonControl;
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.ShowTitle = true;
            this.progressBarControl.Size = new System.Drawing.Size(494, 26);
            this.progressBarControl.StyleController = this.myDataLayoutControl;
            this.progressBarControl.TabIndex = 10;
            // 
            // txtMonthInfo
            // 
            this.txtMonthInfo.EnterMoveNextControl = true;
            this.txtMonthInfo.Location = new System.Drawing.Point(186, 84);
            this.txtMonthInfo.MenuManager = this.ribbonControl;
            this.txtMonthInfo.Name = "txtMonthInfo";
            this.txtMonthInfo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtMonthInfo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMonthInfo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMonthInfo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtMonthInfo.Size = new System.Drawing.Size(72, 20);
            this.txtMonthInfo.StatusBarShortcut = "F4 : ";
            this.txtMonthInfo.StatusBarShortcutStatement = "Seçim Yap";
            this.txtMonthInfo.StatusBarStatement = "Ay Bilgisi Seçiniz";
            this.txtMonthInfo.StyleController = this.myDataLayoutControl;
            this.txtMonthInfo.TabIndex = 5;
            // 
            // txtSummaryAccrueStatement
            // 
            this.txtSummaryAccrueStatement.EnterMoveNextControl = true;
            this.txtSummaryAccrueStatement.Location = new System.Drawing.Point(262, 60);
            this.txtSummaryAccrueStatement.MenuManager = this.ribbonControl;
            this.txtSummaryAccrueStatement.Name = "txtSummaryAccrueStatement";
            this.txtSummaryAccrueStatement.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSummaryAccrueStatement.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSummaryAccrueStatement.Properties.MaxLength = 50;
            this.txtSummaryAccrueStatement.Size = new System.Drawing.Size(244, 20);
            this.txtSummaryAccrueStatement.StatusBarStatement = "Açıklama Giriniz";
            this.txtSummaryAccrueStatement.StyleController = this.myDataLayoutControl;
            this.txtSummaryAccrueStatement.TabIndex = 4;
            // 
            // txtSummaryAccrue
            // 
            this.txtSummaryAccrue.EnterMoveNextControl = true;
            this.txtSummaryAccrue.Location = new System.Drawing.Point(186, 60);
            this.txtSummaryAccrue.MenuManager = this.ribbonControl;
            this.txtSummaryAccrue.Name = "txtSummaryAccrue";
            this.txtSummaryAccrue.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSummaryAccrue.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSummaryAccrue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSummaryAccrue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtSummaryAccrue.Size = new System.Drawing.Size(72, 20);
            this.txtSummaryAccrue.StatusBarShortcut = "F4 : ";
            this.txtSummaryAccrue.StatusBarShortcutStatement = "Seçim Yap";
            this.txtSummaryAccrue.StatusBarStatement = "Özet Tahakkuk Seçiniz";
            this.txtSummaryAccrue.StyleController = this.myDataLayoutControl;
            this.txtSummaryAccrue.TabIndex = 3;
            // 
            // txtFixPrice
            // 
            this.txtFixPrice.EnterMoveNextControl = true;
            this.txtFixPrice.Location = new System.Drawing.Point(262, 36);
            this.txtFixPrice.MenuManager = this.ribbonControl;
            this.txtFixPrice.Name = "txtFixPrice";
            this.txtFixPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtFixPrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtFixPrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtFixPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFixPrice.Properties.DisplayFormat.FormatString = "c2";
            this.txtFixPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFixPrice.Properties.Mask.EditMask = "c2";
            this.txtFixPrice.Size = new System.Drawing.Size(91, 20);
            this.txtFixPrice.StatusBarShortcut = "F4 : ";
            this.txtFixPrice.StatusBarShortcutStatement = "Hesap Makinesi";
            this.txtFixPrice.StatusBarStatement = "Tutar Giriniz";
            this.txtFixPrice.StyleController = this.myDataLayoutControl;
            this.txtFixPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.EnterMoveNextControl = true;
            this.txtQuantity.Location = new System.Drawing.Point(186, 36);
            this.txtQuantity.MenuManager = this.ribbonControl;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtQuantity.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtQuantity.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Properties.Mask.EditMask = "d";
            this.txtQuantity.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Size = new System.Drawing.Size(72, 20);
            this.txtQuantity.StatusBarStatement = "Adet Giriniz";
            this.txtQuantity.StyleController = this.myDataLayoutControl;
            this.txtQuantity.TabIndex = 1;
            // 
            // txtFirstBillDate
            // 
            this.txtFirstBillDate.EditValue = null;
            this.txtFirstBillDate.EnterMoveNextControl = true;
            this.txtFirstBillDate.Location = new System.Drawing.Point(186, 12);
            this.txtFirstBillDate.MenuManager = this.ribbonControl;
            this.txtFirstBillDate.Name = "txtFirstBillDate";
            this.txtFirstBillDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtFirstBillDate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFirstBillDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtFirstBillDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtFirstBillDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtFirstBillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFirstBillDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFirstBillDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtFirstBillDate.Size = new System.Drawing.Size(167, 20);
            this.txtFirstBillDate.StatusBarShortcut = "F4 : ";
            this.txtFirstBillDate.StatusBarShortcutStatement = "Tarih Seçiniz";
            this.txtFirstBillDate.StatusBarStatement = null;
            this.txtFirstBillDate.StyleController = this.myDataLayoutControl;
            this.txtFirstBillDate.TabIndex = 0;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlProgress});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 250D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 35D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 60D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 150D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 30D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup.Size = new System.Drawing.Size(518, 146);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.Control = this.txtFirstBillDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem1.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem1.Text = "İlk Fatura Tarihi";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.Control = this.txtQuantity;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem2.Text = "Adet / Sabit Tutar";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.Control = this.txtFixPrice;
            this.layoutControlItem3.Location = new System.Drawing.Point(250, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(95, 24);
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
            this.layoutControlItem4.Control = this.txtSummaryAccrue;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem4.Text = "Özet Tahakkuk / Açıklama";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.Control = this.txtSummaryAccrueStatement;
            this.layoutControlItem5.Location = new System.Drawing.Point(250, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(248, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.Control = this.txtMonthInfo;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem6.Text = "Açıklama Bölümünde Ay Bilgisi";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlProgress
            // 
            this.layoutControlProgress.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlProgress.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlProgress.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlProgress.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlProgress.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlProgress.Control = this.progressBarControl;
            this.layoutControlProgress.Location = new System.Drawing.Point(0, 96);
            this.layoutControlProgress.MinSize = new System.Drawing.Size(197, 18);
            this.layoutControlProgress.Name = "layoutControlProgress";
            this.layoutControlProgress.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlProgress.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlProgress.Size = new System.Drawing.Size(498, 30);
            this.layoutControlProgress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlProgress.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlProgress.TextVisible = false;
            // 
            // MassBillPlanEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 279);
            this.Controls.Add(this.myDataLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 280);
            this.Name = "MassBillPlanEditForm";
            this.Text = "Fatura Planı Oluştur";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummaryAccrueStatement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummaryAccrue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstBillDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstBillDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private UserControls.Controls.MyComboBoxEdit txtMonthInfo;
        private UserControls.Controls.MyTextEdit txtSummaryAccrueStatement;
        private UserControls.Controls.MyComboBoxEdit txtSummaryAccrue;
        private UserControls.Controls.MyMoneyCalcEdit txtFixPrice;
        private UserControls.Controls.MySpinEdit txtQuantity;
        private UserControls.Controls.MyDateEdit txtFirstBillDate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProgress;
    }
}