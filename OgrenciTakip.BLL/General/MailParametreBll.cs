
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class MailParametreBll : BaseGenelBll<MailParametre>, IBaseGenelBll, IBaseCommonBll
    {
        public MailParametreBll() { }
        public MailParametreBll(Control ctrl) : base(ctrl) { }
    }
}
