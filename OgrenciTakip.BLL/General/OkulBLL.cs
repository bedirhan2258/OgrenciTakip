using OgrenciTakip.BLL.Base;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class OkulBLL : BaseBll<Okul, OgrenciTakipContext>
    {
        public OkulBLL() { }
        public OkulBLL(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Okul,bool>> filter)
        {
            return BaseSingle(filter,)
        }
    }
}
