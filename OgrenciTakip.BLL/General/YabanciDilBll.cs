using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class YabanciDilBll : BaseGenelBll<YabanciDil>, IBaseGenelBll, IBaseCommonBll
    {
        public YabanciDilBll() : base(KartTuru.YabanciDil) { }
        public YabanciDilBll(Control control) : base(control, KartTuru.YabanciDil) { }
    }
}
