namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    partial class TermParameterEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtBranch = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls.MyButtonEdit();
            this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryItemDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.category = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.TermDates = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.TermStartDate = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.TermEndDate = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.EducationDates = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.EducationStartDate = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.EducationEndDate = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.category1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.ServiceStartDateCanEnteredBeforeDayDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.CancellationDateCanEnteredBeforeDayDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.ReceiptDateCanEnteredBeforeDayDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.ServiceStartDateCanEnteredAfterDayDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.CancellationDateCanEnteredAfterDayDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.ReceiptDateCanEnteredAfterDayDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.UseServiceAccruePenny = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.UseDiscountAccruePenny = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.UsePaymentPlanPenny = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.UseBillAccruePenny = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.category4 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.MaxInstallmentDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.NumberOfMaximumInstallment = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.HasRequiredSchoolToGoes = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.AuthorizationControlWillBeInstantly = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(438, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtBranch);
            this.myDataLayoutControl.Controls.Add(this.propertyGridControl);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(438, 451);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtBranch
            // 
            this.txtBranch.EditValue = "Lütfen Bir Şube Seçiniz...";
            this.txtBranch.Id = null;
            this.txtBranch.Location = new System.Drawing.Point(43, 12);
            this.txtBranch.MenuManager = this.ribbonControl;
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBranch.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBranch.Properties.NullText = "Bir Şube Seçiniz...";
            this.txtBranch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtBranch.Size = new System.Drawing.Size(383, 20);
            this.txtBranch.StatusBarShortcut = "F4 : ";
            this.txtBranch.StatusBarShortcutStatement = "Seçim Yap";
            this.txtBranch.StatusBarStatement = "Şube Seçimi Yapınız";
            this.txtBranch.StyleController = this.myDataLayoutControl;
            this.txtBranch.TabIndex = 5;
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.Appearance.RecordValue.Options.UseTextOptions = true;
            this.propertyGridControl.Appearance.RecordValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.propertyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl.Enabled = false;
            this.propertyGridControl.Location = new System.Drawing.Point(12, 36);
            this.propertyGridControl.MenuManager = this.ribbonControl;
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort;
            this.propertyGridControl.OptionsView.ShowButtons = false;
            this.propertyGridControl.RecordWidth = 90;
            this.propertyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDate,
            this.repositoryItemCheck,
            this.repositoryItemSpin});
            this.propertyGridControl.RowHeaderWidth = 110;
            this.propertyGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.category,
            this.category1,
            this.category2,
            this.category3,
            this.category4});
            this.propertyGridControl.Size = new System.Drawing.Size(414, 403);
            this.propertyGridControl.TabIndex = 4;
            this.propertyGridControl.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
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
            // repositoryItemCheck
            // 
            this.repositoryItemCheck.AutoHeight = false;
            this.repositoryItemCheck.Name = "repositoryItemCheck";
            // 
            // repositoryItemSpin
            // 
            this.repositoryItemSpin.AutoHeight = false;
            this.repositoryItemSpin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpin.DisplayFormat.FormatString = "{0:d0}";
            this.repositoryItemSpin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpin.EditFormat.FormatString = "{0:d0}";
            this.repositoryItemSpin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpin.Mask.EditMask = "d";
            this.repositoryItemSpin.MaxValue = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.repositoryItemSpin.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpin.Name = "repositoryItemSpin";
            // 
            // category
            // 
            this.category.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TermDates,
            this.EducationDates});
            this.category.Name = "category";
            this.category.OptionsRow.DblClickExpanding = false;
            this.category.Properties.Caption = "Dönem Tarihleri";
            // 
            // TermDates
            // 
            this.TermDates.Name = "TermDates";
            this.TermDates.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.TermStartDate,
            this.TermEndDate});
            // 
            // TermStartDate
            // 
            this.TermStartDate.Caption = "Dönem Başlama  - Bitiş Tarihleri";
            this.TermStartDate.FieldName = "TermStartDate";
            this.TermStartDate.Name = "TermStartDate";
            this.TermStartDate.RowEdit = this.repositoryItemDate;
            // 
            // TermEndDate
            // 
            this.TermEndDate.FieldName = "TermEndDate";
            this.TermEndDate.Name = "TermEndDate";
            this.TermEndDate.RowEdit = this.repositoryItemDate;
            // 
            // EducationDates
            // 
            this.EducationDates.Name = "EducationDates";
            this.EducationDates.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.EducationStartDate,
            this.EducationEndDate});
            // 
            // EducationStartDate
            // 
            this.EducationStartDate.Caption = "Eğitim Başlama - Bitiş Tarihleri";
            this.EducationStartDate.FieldName = "EducationStartDate";
            this.EducationStartDate.Name = "EducationStartDate";
            this.EducationStartDate.RowEdit = this.repositoryItemDate;
            // 
            // EducationEndDate
            // 
            this.EducationEndDate.FieldName = "EducationEndDate";
            this.EducationEndDate.Name = "EducationEndDate";
            this.EducationEndDate.RowEdit = this.repositoryItemDate;
            // 
            // category1
            // 
            this.category1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.ServiceStartDateCanEnteredBeforeDayDate,
            this.CancellationDateCanEnteredBeforeDayDate,
            this.ReceiptDateCanEnteredBeforeDayDate});
            this.category1.Name = "category1";
            this.category1.OptionsRow.DblClickExpanding = false;
            this.category1.Properties.Caption = "Günün Tarihinden Öncesine Girilebilir";
            // 
            // ServiceStartDateCanEnteredBeforeDayDate
            // 
            this.ServiceStartDateCanEnteredBeforeDayDate.Name = "ServiceStartDateCanEnteredBeforeDayDate";
            this.ServiceStartDateCanEnteredBeforeDayDate.Properties.Caption = "Hizmet Başlama Tarihi";
            this.ServiceStartDateCanEnteredBeforeDayDate.Properties.FieldName = "ServiceStartDateCanEnteredBeforeDayDate";
            this.ServiceStartDateCanEnteredBeforeDayDate.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // CancellationDateCanEnteredBeforeDayDate
            // 
            this.CancellationDateCanEnteredBeforeDayDate.Name = "CancellationDateCanEnteredBeforeDayDate";
            this.CancellationDateCanEnteredBeforeDayDate.Properties.Caption = "İptal Tarihi";
            this.CancellationDateCanEnteredBeforeDayDate.Properties.FieldName = "CancellationDateCanEnteredBeforeDayDate";
            this.CancellationDateCanEnteredBeforeDayDate.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // ReceiptDateCanEnteredBeforeDayDate
            // 
            this.ReceiptDateCanEnteredBeforeDayDate.Name = "ReceiptDateCanEnteredBeforeDayDate";
            this.ReceiptDateCanEnteredBeforeDayDate.Properties.Caption = "Makbuz Tarihi";
            this.ReceiptDateCanEnteredBeforeDayDate.Properties.FieldName = "ReceiptDateCanEnteredBeforeDayDate";
            this.ReceiptDateCanEnteredBeforeDayDate.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // category2
            // 
            this.category2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.ServiceStartDateCanEnteredAfterDayDate,
            this.CancellationDateCanEnteredAfterDayDate,
            this.ReceiptDateCanEnteredAfterDayDate});
            this.category2.Name = "category2";
            this.category2.OptionsRow.DblClickExpanding = false;
            this.category2.Properties.Caption = "Günün Tarihinden Sonrasına Girilebilir";
            // 
            // ServiceStartDateCanEnteredAfterDayDate
            // 
            this.ServiceStartDateCanEnteredAfterDayDate.Name = "ServiceStartDateCanEnteredAfterDayDate";
            this.ServiceStartDateCanEnteredAfterDayDate.Properties.Caption = "Hizmet Başlama Tarihi";
            this.ServiceStartDateCanEnteredAfterDayDate.Properties.FieldName = "ServiceStartDateCanEnteredAfterDayDate";
            this.ServiceStartDateCanEnteredAfterDayDate.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // CancellationDateCanEnteredAfterDayDate
            // 
            this.CancellationDateCanEnteredAfterDayDate.Name = "CancellationDateCanEnteredAfterDayDate";
            this.CancellationDateCanEnteredAfterDayDate.Properties.Caption = "İptal Tarihi";
            this.CancellationDateCanEnteredAfterDayDate.Properties.FieldName = "CancellationDateCanEnteredAfterDayDate";
            this.CancellationDateCanEnteredAfterDayDate.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // ReceiptDateCanEnteredAfterDayDate
            // 
            this.ReceiptDateCanEnteredAfterDayDate.Name = "ReceiptDateCanEnteredAfterDayDate";
            this.ReceiptDateCanEnteredAfterDayDate.Properties.Caption = "Makbuz Tarihi";
            this.ReceiptDateCanEnteredAfterDayDate.Properties.FieldName = "ReceiptDateCanEnteredAfterDayDate";
            this.ReceiptDateCanEnteredAfterDayDate.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // category3
            // 
            this.category3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.UseServiceAccruePenny,
            this.UseDiscountAccruePenny,
            this.UsePaymentPlanPenny,
            this.UseBillAccruePenny});
            this.category3.Name = "category3";
            this.category3.OptionsRow.DblClickExpanding = false;
            this.category3.Properties.Caption = "Kuruş Kullan";
            // 
            // UseServiceAccruePenny
            // 
            this.UseServiceAccruePenny.Name = "UseServiceAccruePenny";
            this.UseServiceAccruePenny.Properties.Caption = "Hizmet Bilgileri";
            this.UseServiceAccruePenny.Properties.FieldName = "UseServiceAccruePenny";
            this.UseServiceAccruePenny.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // UseDiscountAccruePenny
            // 
            this.UseDiscountAccruePenny.Name = "UseDiscountAccruePenny";
            this.UseDiscountAccruePenny.Properties.Caption = "İndirim Bilgileri";
            this.UseDiscountAccruePenny.Properties.FieldName = "UseDiscountAccruePenny";
            this.UseDiscountAccruePenny.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // UsePaymentPlanPenny
            // 
            this.UsePaymentPlanPenny.Name = "UsePaymentPlanPenny";
            this.UsePaymentPlanPenny.Properties.Caption = "Ödeme Bilgileri";
            this.UsePaymentPlanPenny.Properties.FieldName = "UsePaymentPlanPenny";
            this.UsePaymentPlanPenny.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // UseBillAccruePenny
            // 
            this.UseBillAccruePenny.Name = "UseBillAccruePenny";
            this.UseBillAccruePenny.Properties.Caption = "Fatura Bilgileri";
            this.UseBillAccruePenny.Properties.FieldName = "UseBillAccruePenny";
            this.UseBillAccruePenny.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // category4
            // 
            this.category4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.MaxInstallmentDate,
            this.NumberOfMaximumInstallment,
            this.HasRequiredSchoolToGoes,
            this.AuthorizationControlWillBeInstantly});
            this.category4.Name = "category4";
            this.category4.OptionsRow.DblClickExpanding = false;
            this.category4.Properties.Caption = "Diğer Parametreler";
            // 
            // MaxInstallmentDate
            // 
            this.MaxInstallmentDate.Name = "MaxInstallmentDate";
            this.MaxInstallmentDate.Properties.Caption = "Maksimum Taksit Tarihi";
            this.MaxInstallmentDate.Properties.FieldName = "MaxInstallmentDate";
            this.MaxInstallmentDate.Properties.RowEdit = this.repositoryItemDate;
            // 
            // NumberOfMaximumInstallment
            // 
            this.NumberOfMaximumInstallment.Name = "NumberOfMaximumInstallment";
            this.NumberOfMaximumInstallment.Properties.Caption = "Maksimum Taksit Sayısı";
            this.NumberOfMaximumInstallment.Properties.FieldName = "NumberOfMaximumInstallment";
            this.NumberOfMaximumInstallment.Properties.RowEdit = this.repositoryItemSpin;
            // 
            // HasRequiredSchoolToGoes
            // 
            this.HasRequiredSchoolToGoes.Name = "HasRequiredSchoolToGoes";
            this.HasRequiredSchoolToGoes.Properties.Caption = "Gittiği Okul Seçilmesi Zorunlu";
            this.HasRequiredSchoolToGoes.Properties.FieldName = "HasRequiredSchoolToGoes";
            this.HasRequiredSchoolToGoes.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // AuthorizationControlWillBeInstantly
            // 
            this.AuthorizationControlWillBeInstantly.Name = "AuthorizationControlWillBeInstantly";
            this.AuthorizationControlWillBeInstantly.Properties.Caption = "Kullanıcı Yetki Kontrolü Anlık Yapılsın";
            this.AuthorizationControlWillBeInstantly.Properties.FieldName = "AuthorizationControlWillBeInstantly";
            this.AuthorizationControlWillBeInstantly.Properties.RowEdit = this.repositoryItemCheck;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 100D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition3,
            rowDefinition4});
            this.layoutControlGroup.Size = new System.Drawing.Size(438, 451);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.Control = this.propertyGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(418, 407);
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
            this.layoutControlItem2.Control = this.txtBranch;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem2.Text = "Şube";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(28, 13);
            // 
            // TermParameterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 584);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MaximumSize = new System.Drawing.Size(440, 585);
            this.MinimumSize = new System.Drawing.Size(440, 585);
            this.Name = "TermParameterEditForm";
            this.Text = "Dönem Parametreleri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyButtonEdit txtBranch;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow TermDates;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties TermStartDate;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties TermEndDate;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow EducationDates;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties EducationStartDate;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties EducationEndDate;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow ServiceStartDateCanEnteredBeforeDayDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow CancellationDateCanEnteredBeforeDayDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow ReceiptDateCanEnteredBeforeDayDate;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow ServiceStartDateCanEnteredAfterDayDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow CancellationDateCanEnteredAfterDayDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow ReceiptDateCanEnteredAfterDayDate;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow UseServiceAccruePenny;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow UseDiscountAccruePenny;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow UsePaymentPlanPenny;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow UseBillAccruePenny;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MaxInstallmentDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow NumberOfMaximumInstallment;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow HasRequiredSchoolToGoes;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow AuthorizationControlWillBeInstantly;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpin;
    }
}