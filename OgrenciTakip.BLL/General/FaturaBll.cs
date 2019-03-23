
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.BLL.General
{
    public class FaturaBll : BaseHareketBll<Fatura, OgrenciTakipContext>, IBaseHareketSelectBll<Fatura>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<Fatura, bool>> filter)
        {
            return List(filter, x => new FaturaPlaniL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Aciklama = x.Aciklama,
                PlanTarih = x.PlanTarih,
                PlanTutar = x.PlanTutar,
                PlanIndirimTutar = x.PlanIndirimTutar,
                PlanNetTutar = x.PlanNetTutar,
                FaturaNo = x.FaturaNo,
                TahakkukTarih = x.TahakkukTarih,
                TahakkukTutar = x.TopamTutar,
                TahakkukIndirimTutar = x.TahakkukIndirimTutar,
                TahakkukNetTutar = x.TahakkukNetTutar

            }).OrderBy(x => x.PlanTarih).ToList();
        }

        public IEnumerable<DateTime> FaturaDonemList(Expression<Func<Fatura, bool>> filter)
        {
            return List(filter, x => new
            {
                x.PlanTarih
            }).GroupBy(x => x.PlanTarih).Select(x => x.Key).ToList();
        }

        public int MaxFaturaNo(Expression<Func<Fatura, bool>> filter)
        {
            return List(filter, x => new
            {
                x.FaturaNo
            }).DefaultIfEmpty().Max(x => x.FaturaNo ?? 0);
        }
    }
}
