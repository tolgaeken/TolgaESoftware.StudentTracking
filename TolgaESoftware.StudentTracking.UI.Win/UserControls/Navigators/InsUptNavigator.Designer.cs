namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Navigators
{
    partial class InsUptNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsUptNavigator));
            this.navigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // navigator
            // 
            this.navigator.Buttons.Append.ImageIndex = 6;
            this.navigator.Buttons.CancelEdit.Visible = false;
            this.navigator.Buttons.Edit.Visible = false;
            this.navigator.Buttons.EndEdit.Visible = false;
            this.navigator.Buttons.First.ImageIndex = 0;
            this.navigator.Buttons.ImageList = this.imageCollection;
            this.navigator.Buttons.Last.ImageIndex = 5;
            this.navigator.Buttons.Next.ImageIndex = 3;
            this.navigator.Buttons.NextPage.ImageIndex = 4;
            this.navigator.Buttons.NextPage.Visible = false;
            this.navigator.Buttons.Prev.ImageIndex = 2;
            this.navigator.Buttons.PrevPage.ImageIndex = 1;
            this.navigator.Buttons.PrevPage.Visible = false;
            this.navigator.Buttons.Remove.ImageIndex = 7;
            this.navigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigator.Location = new System.Drawing.Point(0, 0);
            this.navigator.Name = "navigator";
            this.navigator.Size = new System.Drawing.Size(738, 24);
            this.navigator.TabIndex = 0;
            this.navigator.Text = "controlNavigator1";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.first_16x16, "first_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x16");
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.doubleprev_16x16, "doubleprev_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x16");
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.prev_16x16, "prev_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "prev_16x16");
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.next_16x16, "next_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "next_16x16");
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.doublenext_16x16, "doublenext_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 4);
            this.imageCollection.Images.SetKeyName(4, "doublenext_16x16");
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.last_16x16, "last_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 5);
            this.imageCollection.Images.SetKeyName(5, "last_16x16");
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.addfile_16x16, "addfile_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 6);
            this.imageCollection.Images.SetKeyName(6, "addfile_16x16");
            this.imageCollection.InsertImage(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::TolgaESoftware.StudentTracking.UI.Win.Properties.Resources), 7);
            this.imageCollection.Images.SetKeyName(7, "deletelist_16x16");
            // 
            // InsUptNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigator);
            this.Name = "InsUptNavigator";
            this.Size = new System.Drawing.Size(738, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection imageCollection;
        protected internal DevExpress.XtraEditors.ControlNavigator navigator;
    }
}
