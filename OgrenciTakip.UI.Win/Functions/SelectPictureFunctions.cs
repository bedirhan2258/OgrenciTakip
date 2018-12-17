

using DevExpress.XtraBars;
using OgrenciTakip.Common.Message;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Functions
{
    public static class SelectPictureFunctions
    {
        #region Variables
        private static MyPictureEdit _pictureEdit;
        private static PopupMenu _popUpMenu;
        #endregion

        private static void RemoveEvents()
        {
            if (_pictureEdit == null) return;

            _pictureEdit.KeyDown -= _pictureEdit_KeyDown;
            _pictureEdit.DoubleClick -= _pictureEdit_DoubleClick;
            _pictureEdit.MouseUp -= PictureEdit_MouseUp;
            _popUpMenu.Popup -= _popUpMenu_Popup;

            foreach (BarItemLink link in _popUpMenu.ItemLinks)
                link.Item.ItemClick -= Buttons_ItemClick;

        }

        public static void Sec(this MyPictureEdit pictureEdit, PopupMenu popUpMenu)
        {
            RemoveEvents();

            _pictureEdit = pictureEdit;
            _popUpMenu = popUpMenu;


            _pictureEdit.KeyDown += _pictureEdit_KeyDown;
            _pictureEdit.DoubleClick += _pictureEdit_DoubleClick;
            _pictureEdit.MouseUp += PictureEdit_MouseUp;
            _popUpMenu.Popup += _popUpMenu_Popup;

            foreach (BarItemLink link in _popUpMenu.ItemLinks)
                link.Item.ItemClick += Buttons_ItemClick;

        }
        private static void ResimSec()
        {
            var resim = GeneralFunctions.ResimYukle();
            if (resim == null) return;
            _pictureEdit.EditValue = resim;
        }

        private static void ResimSil()
        {
            if (_pictureEdit.Image == null) return;
            if (Messages.SilMesaj("Resim") != DialogResult.Yes) return;
            _pictureEdit.EditValue = null;
        }

        private static void _pictureEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    ResimSil();
                    break;
                case Keys.Insert:
                case Keys.F4:
                case Keys.Down when e.Modifiers == Keys.Alt:
                    ResimSec();
                    break;

            }
        }

        private static void _pictureEdit_DoubleClick(object sender, System.EventArgs e)
        {
            ResimSec();
        }

        private static void PictureEdit_MouseUp(object sender, MouseEventArgs e)
        {
            e.ShowPopUpMenu(_popUpMenu);
        }

        private static void _popUpMenu_Popup(object sender, EventArgs e)
        {
            _popUpMenu.ItemLinks[1].Item.Enabled = _pictureEdit.Image != null;

        }

        private static void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == _popUpMenu.ItemLinks[0].Item)
                ResimSec();
            else if (e.Item == _popUpMenu.ItemLinks[1].Item)
                ResimSil();
        }

    }
}
