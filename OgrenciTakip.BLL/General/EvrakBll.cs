using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class EvrakBll : BaseGenelBll<Evrak>, IBaseCommonBll
    {
        public EvrakBll() : base(KartTuru.Evrak) { }
        public EvrakBll(Control ctrl) : base(ctrl, KartTuru.Evrak) { }
    }
}
