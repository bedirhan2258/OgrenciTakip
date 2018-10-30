
using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.Common.Enums;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru islemTuru;
        protected internal long id;
        protected internal bool refresh;

        public BaseEditForm()
        {
            InitializeComponent();
        }
        protected internal void Yukle()
        {

        }
    }
}