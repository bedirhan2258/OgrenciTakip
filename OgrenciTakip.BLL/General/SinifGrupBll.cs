using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class SinifGrupBll : BaseGenelBll<SinifGrup>, IBaseGenelBll, IBaseCommonBll
    {
        public SinifGrupBll() : base(KartTuru.SinifGrup) { }
        public SinifGrupBll(Control ctrl) : base(ctrl, KartTuru.SinifGrup) { }

    }
}
