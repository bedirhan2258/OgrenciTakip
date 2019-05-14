
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class MailBilgileriBll : BaseGenelBll<MailParametre>, IBaseGenelBll, IBaseCommonBll
    {
        public MailBilgileriBll() { }
        public MailBilgileriBll(Control ctrl) : base(ctrl) { }
    }
}
