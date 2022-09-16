namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base
{
    partial class BaseTable
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
            this.components = new System.ComponentModel.Container();
            this.InsUptNavigator = new TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators.InsUptNavigator();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAddAction = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteActon = new DevExpress.XtraBars.BarButtonItem();
            this.btnCardEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocumentActions = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeselectAll = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // InsUptNavigator
            // 
            this.InsUptNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InsUptNavigator.Location = new System.Drawing.Point(0, 340);
            this.InsUptNavigator.Name = "InsUptNavigator";
            this.InsUptNavigator.Size = new System.Drawing.Size(541, 24);
            this.InsUptNavigator.TabIndex = 0;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddAction),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteActon),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCardEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDocumentActions),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelectAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeselectAll)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // btnAddAction
            // 
            this.btnAddAction.Caption = "Hareket Ekle";
            this.btnAddAction.Id = 0;
            this.btnAddAction.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.addfile_16x16;
            this.btnAddAction.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert));
            this.btnAddAction.Name = "btnAddAction";
            // 
            // btnDeleteActon
            // 
            this.btnDeleteActon.Caption = "Hareket Sil";
            this.btnDeleteActon.Id = 1;
            this.btnDeleteActon.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnDeleteActon.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.btnDeleteActon.Name = "btnDeleteActon";
            // 
            // btnCardEdit
            // 
            this.btnCardEdit.Caption = "Kart Düzenle";
            this.btnCardEdit.Id = 2;
            this.btnCardEdit.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.edit_16x16;
            this.btnCardEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnCardEdit.Name = "btnCardEdit";
            this.btnCardEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "İptal Et";
            this.btnCancel.Id = 3;
            this.btnCancel.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.removeitem_16x16;
            this.btnCancel.ImageOptions.LargeImage = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.removeitem_32x32;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShortcutKeyDisplayString = "Ctrl + T";
            this.btnCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnCancelUndo
            // 
            this.btnCancelUndo.Caption = "İptali Geri Al";
            this.btnCancelUndo.Id = 4;
            this.btnCancelUndo.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.historyitem_16x16;
            this.btnCancelUndo.ImageOptions.LargeImage = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.historyitem_32x32;
            this.btnCancelUndo.Name = "btnCancelUndo";
            this.btnCancelUndo.ShortcutKeyDisplayString = "Ctrl + R";
            this.btnCancelUndo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnDocumentActions
            // 
            this.btnDocumentActions.Caption = "Belge Hareketleri";
            this.btnDocumentActions.Id = 5;
            this.btnDocumentActions.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.documentmap_16x16;
            this.btnDocumentActions.Name = "btnDocumentActions";
            this.btnDocumentActions.ShortcutKeyDisplayString = "F6";
            this.btnDocumentActions.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Caption = "Tümünü Seç";
            this.btnSelectAll.Id = 6;
            this.btnSelectAll.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.task_16x16;
            this.btnSelectAll.ImageOptions.LargeImage = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.task_32x32;
            this.btnSelectAll.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Caption = "Tüm Seçimleri Kaldır";
            this.btnDeselectAll.Id = 7;
            this.btnDeselectAll.ImageOptions.Image = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.highlightactiveelements_16x16;
            this.btnDeselectAll.ImageOptions.LargeImage = global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.highlightactiveelements_32x32;
            this.btnDeselectAll.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K));
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddAction,
            this.btnDeleteActon,
            this.btnCardEdit,
            this.btnCancel,
            this.btnCancelUndo,
            this.btnDocumentActions,
            this.btnSelectAll,
            this.btnDeselectAll});
            this.barManager.MaxItemId = 8;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(541, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 364);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(541, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 364);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(541, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 364);
            // 
            // BaseTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InsUptNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseTable";
            this.Size = new System.Drawing.Size(541, 364);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.BarButtonItem btnCardEdit;
        protected DevExpress.XtraBars.BarButtonItem btnCancel;
        protected DevExpress.XtraBars.BarButtonItem btnCancelUndo;
        protected DevExpress.XtraBars.BarButtonItem btnDeleteActon;
        protected DevExpress.XtraBars.BarButtonItem btnDocumentActions;
        protected internal Navigators.InsUptNavigator InsUptNavigator;
        protected DevExpress.XtraBars.BarButtonItem btnAddAction;
        protected DevExpress.XtraBars.BarButtonItem btnSelectAll;
        protected DevExpress.XtraBars.BarButtonItem btnDeselectAll;
        protected DevExpress.XtraBars.PopupMenu popupMenu;
    }
}
