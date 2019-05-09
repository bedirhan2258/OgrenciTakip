using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class KurumBll : BaseGenelYonetimBll<Kurum>, IBaseGenelBll, IBaseCommonBll
    {
        public KurumBll() : base(KartTuru.Kurum) { }
        public KurumBll(Control ctrl) : base(ctrl, KartTuru.Kurum) { }
    }
}
