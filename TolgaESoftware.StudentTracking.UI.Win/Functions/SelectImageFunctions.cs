using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Utils;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public static class SelectImageFunctions
    {
        #region Variables
        private static MyPictureEdit _pictureEdit;
        private static PopupMenu _popupMenu; 
        #endregion

        private static void RemoveEvents()
        {
            if(_pictureEdit==null)return;

            _pictureEdit.KeyDown -= pictureEdit_KeyDown;
            _pictureEdit.DoubleClick -= pictureEdit_DoubleClick;
            _pictureEdit.MouseUp -= pictureEdit_MouseUp;
            _popupMenu.Popup -= popupMenu_Popup;

            foreach (BarItemLink link in _popupMenu.ItemLinks)
            {
                link.Item.ItemClick -= Buttons_ItemClick;
            }
            
        }

        public static void Select(this MyPictureEdit pictureEdit,PopupMenu popupMenu)
        {
            RemoveEvents();

            _pictureEdit = pictureEdit;
            _popupMenu = popupMenu;

            _pictureEdit.KeyDown += pictureEdit_KeyDown;
            _pictureEdit.DoubleClick += pictureEdit_DoubleClick;
            _pictureEdit.MouseUp += pictureEdit_MouseUp;
            _popupMenu.Popup += popupMenu_Popup;

            foreach (BarItemLink link in _popupMenu.ItemLinks)
            {
                link.Item.ItemClick += Buttons_ItemClick;
            }
        }

        private static void SelectImage()
        {
            var image = GeneralFunctions.UploadImage();
            if(image==null) return;
            _pictureEdit.EditValue = image;
        }

        private static void DeleteImage()
        {
            if(_pictureEdit.Image==null) return;
            if (Messages.DeletionMessage("Resim") != DialogResult.Yes) return;
            _pictureEdit.Image = null;
        }

        private static void pictureEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteImage();
                    break;
                case Keys.Insert:
                case Keys.F4:
                case Keys.Down when e.Modifiers==Keys.Alt:
                    SelectImage();
                    break;

            }
        }

        private static void pictureEdit_DoubleClick(object sender, System.EventArgs e)
        {
            SelectImage();
        }

        private static void pictureEdit_MouseUp(object sender, MouseEventArgs e)
        {
            e.ShowPopupMenu(_popupMenu);
        }

        private static void popupMenu_Popup(object sender, EventArgs e)
        {
            _popupMenu.ItemLinks[1].Item.Enabled = _pictureEdit.Image != null;
        }

        private static void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(e.Item==_popupMenu.ItemLinks[0].Item) SelectImage();
            else if (e.Item==_popupMenu.ItemLinks[1].Item) DeleteImage();
        }

    }
}