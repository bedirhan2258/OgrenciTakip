
using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.BLL.General
{
    public class KullaniciParametreBll : BaseGenelBll<KullaniciParametre>, IBaseGenelBll
    {
        public KullaniciParametreBll() : base(KartTuru.KullaniciParametre) { }
        public KullaniciParametreBll(Control ctrl) : base(ctrl, KartTuru.KullaniciParametre) { }

        public override BaseEntity Single(Expression<Func<KullaniciParametre, bool>> filter)
        {
            return BaseSingle(filter, x => new KullaniciParametreS
            {

                Id = x.Id,
                Kod = x.Kod,
                KullaniciId = x.KullaniciId,
                DefaultAvukatHesapId = x.DefaultAvukatHesapId,
                DefaultAvukatHesapAdi = x.DefaultAvukatHesap.AdiSoyadi,
                DefaultBankaHesapId = x.DefaultBankaHesapId,
                DefaultBankaHesapAdi = x.DefaultBankaHesap.HesapAdi,
                DefaultKasaHesapId = x.DefaultKasaHesapId,
                DefaultKasaHesapAdi = x.DefaultKasaHesap.KasaAdi,
                RaporlariOnayAlmadanKapat = x.RaporlariOnayAlmadanKapat,
                TableViewCaptionForeColor = x.TableViewCaptionForeColor,
                TableColumnHeaderForeColor = x.TableColumnHeaderForeColor,
                TableBandPanelForeColor = x.TableBandPanelForeColor,
                ArkaPlanResim = x.ArkaPlanResim,

            });
        }
    }
}
