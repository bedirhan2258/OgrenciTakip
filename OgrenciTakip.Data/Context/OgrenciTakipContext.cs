namespace OgrenciTakip.Data.Context
{
    using Model;
    using Model.Entities;
    using OgrenciTakipMigration;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext, Configuration>
    {
        public OgrenciTakipContext()
        {
            //Birbiriyle ili�kili tablolarda select i�lemlerinde ili�ki kay�tlar�n bilgilerinin gelmesini engelledik.True olursa o bilgilerde gelir.Buda sorgular�m�z�n yava� �al��mas�na sebep olur.
            Configuration.LazyLoadingEnabled = false;
        }

        public OgrenciTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Bu i�lem table isimlerini �o�ulla�t�r�r. Bizim Okul s�n�f�m�z� database e yollarken Okuls olarak yollar. O nedenle bunu devre d��� b�rak�oruz.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Bire �ok ili�kili tablolarda ona ba�l� verileri silmek i�in kullan�l�r.Ama biz devre d��� b�rak�oruz.��nk� b�t�n database �zerinde
            //ge�erli olucak o y�zden gerekti�i yerlerde costum olarak biz kendimiz yaz�caz.
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //�le ba�l� birden �ok il�e olabilir demi�tik.
            modelBuilder.Entity<Il>().HasMany(x => x.Ilce).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Banka>().HasMany(x => x.BankaSube).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Indirim>().HasMany(x => x.IndiriminUygulanacagiHizmetBilgileri).WithRequired().WillCascadeOnDelete(true);
        }

        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<Filtre> Filtre { get; set; }
        public DbSet<AileBilgi> AileBilgi { get; set; }
        public DbSet<IptalNedeni> IptalNedeni { get; set; }
        public DbSet<YabanciDil> YabanciDil { get; set; }
        public DbSet<Tesvik> Tesvik { get; set; }
        public DbSet<Kontenjan> Kontenjan { get; set; }
        public DbSet<Rehber> Rehber { get; set; }
        public DbSet<SinifGrup> SinifGrup { get; set; }
        public DbSet<Meslek> Meslek { get; set; }
        public DbSet<Yakinlik> Yakinlik { get; set; }
        public DbSet<Isyeri> Isyeri { get; set; }
        public DbSet<Gorev> Gorev { get; set; }
        public DbSet<IndirimTuru> IndirimTuru { get; set; }
        public DbSet<Evrak> Evrak { get; set; }
        public DbSet<Donem> Donem { get; set; }
        public DbSet<Sube> Sube { get; set; }
        public DbSet<Promosyon> Promosyon { get; set; }
        public DbSet<Servis> Servis { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<HizmetTuru> HizmetTuru { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<OzelKod> OzelKod { get; set; }
        public DbSet<Kasa> Kasa { get; set; }
        public DbSet<Banka> Banka { get; set; }
        public DbSet<BankaSube> BankaSube { get; set; }
        public DbSet<Avukat> Avukat { get; set; }
        public DbSet<Cari> Cari { get; set; }
        public DbSet<OdemeTuru> OdemeTuru { get; set; }
        public DbSet<BankaHesap> BankaHesap { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Indirim> Indirim { get; set; }
        public DbSet<IndiriminUygulanacagiHizmetBilgileri> IndiriminUygulanacagiHizmetBilgileri { get; set; }
        public DbSet<Tahakkuk> Tahakkuk { get; set; }
        public DbSet<KardesBilgileri> KardesBilgileri { get; set; }
        public DbSet<AileBilgileri> AileBilgileri { get; set; }
        public DbSet<SinavBilgileri> SinavBilgileri { get; set; }
        public DbSet<EvrakBilgileri> EvrakBilgileri { get; set; }
        public DbSet<PromosyonBilgileri> PromosyonBilgileri { get; set; }
        public DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
        public DbSet<EposBilgileri> EposBilgileri { get; set; }
        public DbSet<BilgiNotlari> BilgiNotlari { get; set; }
        public DbSet<HizmetBilgileri> HizmetBilgileri { get; set; }
        public DbSet<IndirimBilgileri> IndirimBilgileri { get; set; }
        public DbSet<OdemeBilgileri> OdemeBilgileri { get; set; }
        public DbSet<GeriOdemeBilgileri> GeriOdemeBilgileri { get; set; }
        public DbSet<Makbuz> Makbuz { get; set; }
        public DbSet<MakbuzHareketleri> MakbuzHareketleri { get; set; }
        public DbSet<Rapor> Rapor { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<GecikmeAciklamalari> GecikmeAciklamalari { get; set; }
        public DbSet<DonemParametre> DonemParametre { get; set; }
        public DbSet<KullaniciParametre> KullaniciParametre { get; set; }
        public DbSet<MailParametre> MailParametre { get; set; }
        public DbSet<KurumBilgileri> KurumBilgileri { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolYetkileri> RolYetkileri { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<KullaniciBirimYetkileri> KullaniciBirimYetkileri { get; set; }
    }

}