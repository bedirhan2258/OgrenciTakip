using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class HizmetTuruBll : BaseGenelBll<HizmetTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public HizmetTuruBll() : base(KartTuru.HizmetTuru) { }
        public HizmetTuruBll(Control ctrl) : base(ctrl,KartTuru.HizmetTuru) { }
    }
}

