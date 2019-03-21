using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using System;

namespace OgrenciTakip.Model.Entities
{
    public class Fatura : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public DateTime PlanTarih { get; set; }
        public decimal PlanTutar { get; set; }
        public decimal PlanIndirimTutar { get; set; }
        public decimal PlanNetTutar { get; set; }
        public string Aciklama { get; set; }
        public int? FaturaNo { get; set; }
        public DateTime? TahakkukTarih { get; set; }
        public decimal? TahakkukTutar { get; set; }
        public decimal? TahakkukIndirimTutar { get; set; }
        public decimal? TahakkukNetTutar { get; set; }
        public KdvSekli? KdvSekli { get; set; }
        public byte? KdvOrani { get; set; }
        public decimal? KdvHaricTutar { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? TopamTutar { get; set; }
        public string TutarYazi { get; set; }
        public string FaturaAdres { get; set; }
        public long? FaturaAdresIlId { get; set; }
        public long? FaturaAdresIlceId { get; set; }

        public Tahakkuk Tahakkuk { get; set; }
        public Il FaturaAdresIl { get; set; }
        public Ilce FaturaAdresIlce { get; set; }
    }
}
