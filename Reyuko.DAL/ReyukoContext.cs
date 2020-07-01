using System.Data.Entity;
using Reyuko.DAL.Config;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL
{
    public class ReyukoContext : DbContext
    {

        public ReyukoContext(string contextName)
            : base(contextName)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<DataMataUang> DataMataUang { get; set; }
        public virtual DbSet<ListDataMataUang> ListDataMataUang { get; set; }
        public virtual DbSet<KursMataUang> KursMataUang { get; set; }
        public virtual DbSet<DataPajak> DataPajak { get; set; }
        public virtual DbSet<ListDataPajak> ListDataPajak { get; set; }
        public virtual DbSet<NamaPenyusutan> NamaPenyusutan { get; set; }
        public virtual DbSet<OptionAnnual> OptionAnnual { get; set; }
        public virtual DbSet<TabelPenyusutan> TabelPenyusutan { get; set; }
        public virtual DbSet<TypeDokumen> TypeDokumen { get; set; }
        public virtual DbSet<NoteType> NoteType { get; set; }
        public virtual DbSet<KelompokHartaTetap> KelompokHartaTetap { get; set; }
        public virtual DbSet<PeriodeAkuntansi> PeriodeAkuntansi { get; set; }
        public virtual DbSet<KodeTransaksi> KodeTransaksi { get; set; }
        public virtual DbSet<KategoriProduk> KategoriProduk { get; set; }
        public virtual DbSet<SatuanDasar> SatuanDasar { get; set; }
        public virtual DbSet<GrupDiskon> GrupDiskon { get; set; }
        public virtual DbSet<GolonganKontak> GolonganKontak { get; set; }
        public virtual DbSet<TypeKontak> TypeKontak { get; set; }
        public virtual DbSet<Kontak> Kontak { get; set; }
        public virtual DbSet<ListKontak> ListKontak { get; set; }
        public virtual DbSet<KlasifikasiKontak> KlasifikasiKontak { get; set; }
        public virtual DbSet<DataDepartemen> DataDepartemen { get; set; }
        public virtual DbSet<ListDataDepartemen> ListDataDepartemen { get; set; }
        public virtual DbSet<Lokasi> Lokasi { get; set; }
        public virtual DbSet<ListLokasi> ListLokasi { get; set; }
        public virtual DbSet<DataProyek> DataProyek { get; set; }
        public virtual DbSet<Alamat> Alamat { get; set; }
        public virtual DbSet<Termspembayaran> Termspembayaran { get; set; }
        public virtual DbSet<Receivedgood> Receivedgood { get; set; }
        public virtual DbSet<produk> produk { get; set; }
        public virtual DbSet<ListProduk> ListProduk { get; set; }
        public virtual DbSet<HargaPokok> HargaPokok { get; set; }
        public virtual DbSet<GrupProduk> GrupProduk { get; set; }
        public virtual DbSet<Dokumen> Dokumen { get; set; }
        public virtual DbSet<InternalNote> Intenalnote { get; set; }
        public virtual DbSet<KlasifikasiAkun> KlasifikasiAkun { get; set; }
        public virtual DbSet<DefaultAkunMataUang> DefaultAkunMata { get; set; }
        public virtual DbSet<TypeProduk> TypeProduk { get; set; }
        public virtual DbSet<RekeningPerkiraan> RekeningPerkiraan { get; set; }
        public virtual DbSet<PenerimaanBarang> PenerimaanBarang { get; set; }
        public virtual DbSet<ReturBarang> ReturBarang { get; set; }
        public virtual DbSet<Radiobuttonrekper> Radiobuttonrekper { get; set; }
        public virtual DbSet<DataHartaTetap> DataHartaTetap { get; set; }
        public virtual DbSet<Diperoleh> Diperoleh { get; set; }
        public virtual DbSet<RekeningAnggaran> RekeningAnggaran { get; set; }
        public virtual DbSet<TransaksiJurnalUmum> TransaksiJurnalUmum { get; set; }
        public virtual DbSet<OrderJurnalUmum> OrderJurnalUmum { get; set; }
        public virtual DbSet<invoice> Invoice { get; set; }
        public virtual DbSet<BukuBesar> BukuBesar { get; set; }
        public virtual DbSet<OrderPembayaranGaji> OrderPembayaranGaji { get; set; }
        public virtual DbSet<PembayaranGaji> PembayaranGaji { get; set; }
        public virtual DbSet<DropdownPPTBarang> DropdownPPTBarang { get; set; }
        public virtual DbSet<PermPenyTransferBarang> PermPenyTransferBarang { get; set; }
        public virtual DbSet<OrderInventori> OrderInventori { get; set; }
        public virtual DbSet<CashActivity> CashActivitie { get; set; }
        public virtual DbSet<DropdownPaymentCashActivity> DropdownPaymentCashActivity { get; set; }
        public virtual DbSet<DataGiro> DataGiro { get; set; }
        public virtual DbSet<OrderTransaksiCash> OrderTransaksiCash { get; set; }
        public virtual DbSet<production> Production { get; set; }
        public virtual DbSet<DropdownBankKas> DropdownBankKas { get; set; }
        public virtual DbSet<ListKonsinyasi> ListKonsinyasi { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<Shopingchart> Shopingchart { get; set; }
        public virtual DbSet<Quotationrequest> Quotationrequests { get; set; }
        public virtual DbSet<Salesquotation> Salesquotations { get; set; }
        public virtual DbSet<Deliveryorders> DeliveryOrders { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Purchasedelivery> PurchaseDeliverys { get; set; }
        public virtual DbSet<Purchasereturn> PurchaseReturns { get; set; }
        public virtual DbSet<Salesreturn> Salesreturns { get; set; }
        public virtual DbSet<OrderProductioninput> OrderProductioninput { get; set; }
        public virtual DbSet<OrderProductioncustom> OrderProductioncustom { get; set; }
        public virtual DbSet<OrderFinishedproduk> OrderFinishedproduk { get; set; }
        public virtual DbSet<OrderProdukBeli> OrderProdukBeli { get; set; }
        public virtual DbSet<Rpp> Rpp { get; set; }
        public virtual DbSet<Recap> Recap { get; set; }
        public virtual DbSet<Typelist> Typelist { get; set; }
        public virtual DbSet<OrderProdukJual> OrderProdukJual { get; set; }
        public virtual DbSet<ListOrderJual> ListOrderJual { get; set; }
        public virtual DbSet<OrderJasaJual> OrderJasaJual { get; set; }
        public virtual DbSet<OrderCustomJual> OrderCustomJual { get; set; }
        public virtual DbSet<ListOrderProduction> ListOrderProduction { get; set; }
        public virtual DbSet<OrderJasaBeli> OrderJasaBeli { get; set; }
        public virtual DbSet<ListOrderBeli> ListOrderBeli { get; set; }
        public virtual DbSet<OrderCustomBeli> OrderCustomBeli { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DataMataUangConfig());
            modelBuilder.Configurations.Add(new ListDataMataUangConfig());
            modelBuilder.Configurations.Add(new KursMataUangConfig());
            modelBuilder.Configurations.Add(new DataPajakConfig());
            modelBuilder.Configurations.Add(new ListDataPajakConfig());
            modelBuilder.Configurations.Add(new NamaPenyusutanConfig());
            modelBuilder.Configurations.Add(new OptionAnnualConfig());
            modelBuilder.Configurations.Add(new TabelPenyusutanConfig());
            modelBuilder.Configurations.Add(new TypeDokumenConfig());
            modelBuilder.Configurations.Add(new NoteTypeConfig());
            modelBuilder.Configurations.Add(new KelompokHartaTetapConfig());
            modelBuilder.Configurations.Add(new PeriodeAkuntansiConfig());
            modelBuilder.Configurations.Add(new KodeTransaksiConfig());
            modelBuilder.Configurations.Add(new KategoriProdukConfig());
            modelBuilder.Configurations.Add(new SatuanDasarConfig());
            modelBuilder.Configurations.Add(new GrupDiskonConfig());
            modelBuilder.Configurations.Add(new GolonganKontakConfig());
            modelBuilder.Configurations.Add(new TypeKontakConfig());
            modelBuilder.Configurations.Add(new KontakConfig());
            modelBuilder.Configurations.Add(new ListKontakConfig());
            modelBuilder.Configurations.Add(new KlasifikasiKontakConfig());
            modelBuilder.Configurations.Add(new DataDepartemenConfig());
            modelBuilder.Configurations.Add(new ListDataDepartemenConfig());
            modelBuilder.Configurations.Add(new LokasiConfig());
            modelBuilder.Configurations.Add(new ListLokasiConfig());
            modelBuilder.Configurations.Add(new DataProyekConfig());
            modelBuilder.Configurations.Add(new AlamatConfig());
            modelBuilder.Configurations.Add(new TermspembayaranConfig());
            modelBuilder.Configurations.Add(new ReceivedgoodConfig());
            modelBuilder.Configurations.Add(new produkConfig());
            modelBuilder.Configurations.Add(new ListProdukConfig());
            modelBuilder.Configurations.Add(new HargaPokokConfig());
            modelBuilder.Configurations.Add(new GrupProdukConfig());
            modelBuilder.Configurations.Add(new DokumenConfig());
            modelBuilder.Configurations.Add(new InternalNoteConfig());
            modelBuilder.Configurations.Add(new KlasifikasiAkunConfig());
            modelBuilder.Configurations.Add(new DefaultAkunMataUangConfig());
            modelBuilder.Configurations.Add(new TypeProdukConfig());
            modelBuilder.Configurations.Add(new RekeningPerkiraanConfig());
            modelBuilder.Configurations.Add(new PenerimaanBarangConfig());
            modelBuilder.Configurations.Add(new ReturBarangConfig());
            modelBuilder.Configurations.Add(new RadiobuttonrekperConfig());
            modelBuilder.Configurations.Add(new DataHartaTetapConfig());
            modelBuilder.Configurations.Add(new DiperolehConfig());
            modelBuilder.Configurations.Add(new RekeningAnggaranConfig());
            modelBuilder.Configurations.Add(new TransaksiJurnalUmumConfig());
            modelBuilder.Configurations.Add(new OrderJurnalUmumConfig());
            modelBuilder.Configurations.Add(new invoiceConfig());
            modelBuilder.Configurations.Add(new BukuBesarConfig());
            modelBuilder.Configurations.Add(new OrderPembayaranGajiConfig());
            modelBuilder.Configurations.Add(new PembayaranGajiConfig());
            modelBuilder.Configurations.Add(new DropdownPPTBarangConfig());
            modelBuilder.Configurations.Add(new PermPenyTransferBarangConfig());
            modelBuilder.Configurations.Add(new OrderInventoriConfig());
            modelBuilder.Configurations.Add(new CashActivityConfig());
            modelBuilder.Configurations.Add(new DropdownPaymentCashActivityConfig());
            modelBuilder.Configurations.Add(new DataGiroConfig());
            modelBuilder.Configurations.Add(new OrderTransaksiCashConfig());
            modelBuilder.Configurations.Add(new productionConfig());
            modelBuilder.Configurations.Add(new DropdownBankKasConfig());
            modelBuilder.Configurations.Add(new ListKonsinyasiConfig());
            modelBuilder.Configurations.Add(new SalesOrderConfig());
            modelBuilder.Configurations.Add(new ShopingchartConfig());
            modelBuilder.Configurations.Add(new QuotationrequestConfig());
            modelBuilder.Configurations.Add(new SalesquotationConfig());
            modelBuilder.Configurations.Add(new DeliveryorderConfig());
            modelBuilder.Configurations.Add(new PurchaseOrderConfig());
            modelBuilder.Configurations.Add(new PurchasedeliveryConfig());
            modelBuilder.Configurations.Add(new PurchasereturnConfig());
            modelBuilder.Configurations.Add(new SalesreturnConfig());
            modelBuilder.Configurations.Add(new OrderProductioninputConfig());
            modelBuilder.Configurations.Add(new OrderProductioncustomConfig());
            modelBuilder.Configurations.Add(new OrderFinishedprodukConfig());
            modelBuilder.Configurations.Add(new OrderProdukBeliConfig());
            modelBuilder.Configurations.Add(new RppConfig());
            modelBuilder.Configurations.Add(new RecapConfig());
            modelBuilder.Configurations.Add(new TypelistConfig());
            modelBuilder.Configurations.Add(new OrderProdukJualConfig());
            modelBuilder.Configurations.Add(new ListOrderJualConfig());
            modelBuilder.Configurations.Add(new OrderJasaJualConfig());
            modelBuilder.Configurations.Add(new OrderCustomJualConfig());
            modelBuilder.Configurations.Add(new ListOrderProductionConfig());
            modelBuilder.Configurations.Add(new OrderJasaBeliConfig());
            modelBuilder.Configurations.Add(new ListOrderBeliConfig());
            modelBuilder.Configurations.Add(new OrderCustomBeliConfig());
        }
    }
}
