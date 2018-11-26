using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class FiltreBLL : BaseGenelBll<Filtre>, IBaseCommonBll
    {
        public FiltreBLL() : base(KartTuru.Filtre) { }
        public FiltreBLL(Control ctrl) : base(ctrl, KartTuru.Filtre) { }
   
    }
}
