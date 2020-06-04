using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Validation;
using Reyuko.DAL.Interface;
using Reyuko.DAL.Repositories;
using Reyuko.Utils.Error;

namespace Reyuko.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private ReyukoContext _context = null;
        public UnitOfWork(string contextName)
            : this(new ReyukoContext(contextName))
        {
            DataMataUang = new DataMataUangRepo(_context);
            ListDataMataUang = new ListDataMataUangRepo(_context);
            KursMataUang = new KursMataUangRepo(_context);
            DataPajak = new DataPajakRepo(_context);
            ListDataPajak = new ListDataPajakRepo(_context);
            NamaPenyusutan = new NamaPenyusutanRepo(_context);
            OptionAnnual = new OptionAnnualRepo(_context);
            TabelPenyusutan = new TabelPenyusutanRepo(_context);
            TypeDokumen = new TypeDokumenRepo(_context);
            NoteType = new NoteTypeRepo(_context);
            KelompokHartaTetap = new KelompokHartaTetapRepo(_context);
            PeriodeAkuntansi = new PeriodeAkuntansiRepo(_context);
            KodeTransaksi = new KodeTransaksiRepo(_context);
            KategoriProduk = new KategoriProdukRepo(_context);
            SatuanDasar = new SatuanDasarRepo(_context);
            GrupDiskon = new GrupDiskonRepo(_context);
            GolonganKontak = new GolonganKontakRepo(_context);
            TypeKontak = new TypeKontakRepo(_context);
            Kontak = new KontakRepo(_context);
            ListKontak = new ListKontakRepo(_context);
            KlasifikasiKontak = new KlasifikasiKontakRepo(_context);
            DataDepartemen = new DataDepartemenRepo(_context);
            ListDataDepartemen = new ListDataDepartemenRepo(_context);
            Lokasi = new LokasiRepo(_context);
            ListLokasi = new ListLokasiRepo(_context);
            DataProyek = new DataProyekRepo(_context);
            Alamat = new AlamatRepo(_context);
            Termspembayaran = new TermspembayaranRepo(_context);
            Receivedgood = new ReceivedgoodRepo(_context);
            produk = new produkRepo(_context);
            ListProduk = new ListProdukRepo(_context);
            HargaPokok = new HargaPokokRepo(_context);
            GrupProduk = new GrupProdukRepo(_context);
            Dokumen = new DokumenRepo(_context);
            InternalNote = new InternalNoteRepo(_context);
            KlasifikasiAkun = new KlasifikasiAkunRepo(_context);
            DefaultAkunMataUang = new DefaultAkunMataUangRepo(_context);
            TypeProduk = new TypeProdukRepo(_context);
            RekeningPerkiraan = new RekeningPerkiraanRepo(_context);
            PenerimaanBarang = new PenerimaanBarangRepo(_context);
            ReturBarang = new ReturBarangRepo(_context);
            Radiobuttonrekper = new RadiobuttonrekperRepo(_context);
            DataHartaTetap = new DataHartaTetapRepo(_context);
            Diperoleh = new DiperolehRepo(_context);
            RekeningAnggaran = new RekeningAnggaranRepo(_context);
            TransaksiJurnalUmum = new TransaksiJurnalUmumRepo(_context);
            OrderJurnalUmum = new OrderJurnalUmumRepo(_context);
            Invoice = new invoiceRepo(_context);
            BukuBesar = new BukuBesarRepo(_context);
            OrderPembayaranGaji = new OrderPembayaranGajiRepo(_context);
            PembayaranGaji = new PembayaranGajiRepo(_context);
            DropdownPPTBarang = new DropdownPPTBarangRepo(_context);
            PermPenyTransferBarang = new PermPenyTransferBarangRepo(_context);
            OrderInventori = new OrderInventoriRepo(_context);
            CashActivity = new CashActivityRepo(_context);
            DropdownPaymentCashActivity = new DropdownPaymentCashActivityRepo(_context);
            DataGiro = new DataGiroRepo(_context);
            OrderTransaksiCash = new OrderTransaksiCashRepo(_context);
            Production = new productionRepo(_context);
            DropdownBankKas = new DropdownBankKasRepo(_context);
            ListKonsinyasi = new ListKonsinyasiRepo(_context);
            SalesOrder = new SalesOrderRepo(_context);
            Shopingchart = new ShopingchartRepo(_context);
            Quotationrequest = new QuotationrequestRepo(_context);
            Salesquotation = new SalesquotationRepo(_context);
            DeliveryOrder = new DeliveryorderRepo(_context);
            PurchaseOrder = new PurchaseOrderRepo(_context);
            PurchaseDelivery = new PurchasedeliveryRepo(_context);
            PurchaseReturn = new PurchasereturnRepo(_context);
            SalesReturn = new SalesreturnRepo(_context);
            OrderProductioninput = new OrderProductioninputRepo(_context);
            OrderProductioncustom = new OrderProductioncustomRepo(_context);
            OrderFinishedproduk = new OrderFinishedprodukRepo(_context);
            OrderProdukBeli = new OrderProdukBeliRepo(_context);
            Rpp = new RppRepo(_context);
            Recap = new RecapRepo(_context);
            Typelist = new TypelistRepo(_context);
            OrderProdukJual = new OrderProdukJualRepo(_context);
        }


        public UnitOfWork(ReyukoContext context)
        {
            _context = context;
            string timeOut = ConfigurationManager.AppSettings.Get("CommandTimeOut");
            if (!string.IsNullOrEmpty(timeOut))
                _context.Database.CommandTimeout = int.Parse(timeOut);
        }


        public IDataMataUangRepo DataMataUang { get; private set; }
        public IListDataMataUangRepo ListDataMataUang { get; private set; }
        public IKursMataUangRepo KursMataUang { get; private set; }
        public IDataPajakRepo DataPajak { get; private set; }
        public IListDataPajakRepo ListDataPajak { get; private set; }
        public INamaPenyusutanRepo NamaPenyusutan { get; private set; }
        public IOptionAnnualRepo OptionAnnual { get; private set; }
        public ITabelPenyusutanRepo TabelPenyusutan { get; private set; }
        public ITypeDokumenRepo TypeDokumen { get; private set; }
        public INoteTypeRepo NoteType { get; private set; }
        public IKelompokHartaTetapRepo KelompokHartaTetap { get; private set; }
        public IPeriodeAkuntansiRepo PeriodeAkuntansi { get; private set; }
        public IKodeTransaksiRepo KodeTransaksi { get; private set; }
        public IKategoriProdukRepo KategoriProduk { get; private set; }
        public ISatuanDasarRepo SatuanDasar { get; private set; }
        public IGrupDiskonRepo GrupDiskon { get; private set; }
        public IGolonganKontakRepo GolonganKontak { get; private set; }
        public ITypeKontakRepo TypeKontak { get; private set; }
        public IKontakRepo Kontak { get; private set; }
        public IListKontakRepo ListKontak { get; private set; }
        public IKlasifikasiKontakRepo KlasifikasiKontak { get; private set; }
        public IDataDepartemenRepo DataDepartemen { get; private set; }
        public IListDataDepartemenRepo ListDataDepartemen { get; private set; }
        public ILokasiRepo Lokasi { get; private set; }
        public IListLokasiRepo ListLokasi { get; private set; }
        public IDataProyekRepo DataProyek { get; private set; }
        public IAlamatRepo Alamat { get; private set; }
        public ITermspembayaranRepo Termspembayaran { get; private set; }
        public IReceivedgoodRepo Receivedgood { get; private set; }
        public IprodukRepo produk { get; private set; }
        public IListProdukRepo ListProduk { get; private set; }
        public IHargaPokokRepo HargaPokok { get; private set; }
        public IGrupProdukRepo GrupProduk { get; private set; }
        public IDokumenRepo Dokumen { get; private set; }
        public IInternalNoteRepo InternalNote { get; private set; }
        public IKlasifikasiAkunRepo KlasifikasiAkun { get; private set; }
        public IDefaultAkunMataUangRepo DefaultAkunMataUang { get; private set; }
        public ITypeProdukRepo TypeProduk { get; private set; }
        public IRekeningPerkiraanRepo RekeningPerkiraan { get; private set; }
        public IPenerimaanBarangRepo PenerimaanBarang { get; private set; }
        public IReturBarangRepo ReturBarang { get; private set; }
        public IRadiobuttonrekperRepo Radiobuttonrekper { get; private set; }
        public IDataHartaTetapRepo DataHartaTetap { get; private set; }
        public IDiperolehRepo Diperoleh { get; private set; }
        public IRekeningAnggaranRepo RekeningAnggaran { get; private set; }
        public ITransaksiJurnalUmumRepo TransaksiJurnalUmum { get; private set; }
        public IOrderJurnalUmumRepo OrderJurnalUmum { get; private set; }
        public IinvoiceRepo Invoice { get; private set; }
        public IBukuBesarRepo BukuBesar { get; private set; }
        public IOrderPembayaranGajiRepo OrderPembayaranGaji { get; private set; }
        public IPembayaranGajiRepo PembayaranGaji { get; private set; }
        public IDropdownPPTBarangRepo DropdownPPTBarang { get; private set; }
        public IPermPenyTransferBarangRepo PermPenyTransferBarang { get; private set; }
        public IOrderInventoriRepo OrderInventori { get; private set; }
        public ICashActivityRepo CashActivity { get; private set; }
        public IDropdownPaymentCashActivityRepo DropdownPaymentCashActivity { get; private set; }
        public IDataGiroRepo DataGiro { get; private set; }
        public IOrderTransaksiCashRepo OrderTransaksiCash { get; private set; }
        public IproductionRepo Production { get; private set; }
        public IDropdownBankKasRepo DropdownBankKas { get; private set; }
        public IListKonsinyasiRepo ListKonsinyasi { get; private set; }
        public ISalesOrderRepo SalesOrder { get; private set; }
        public IShopingchartRepo Shopingchart { get; private set; }
        public IQuotationrequestRepo Quotationrequest { get; private set; }
        public ISalesquotationRepo Salesquotation { get; private set; }
        public IDeliveryorderRepo DeliveryOrder { get; private set; }
        public IPurchaseOrderRepo PurchaseOrder { get; private set; }
        public IPurchasedeliveryRepo PurchaseDelivery { get; private set; }
        public IPurchasereturnRepo PurchaseReturn { get; private set; }
        public ISalesreturnRepo SalesReturn { get; private set; }
        public IOrderProductioninputRepo OrderProductioninput { get; private set; }
        public IOrderProductioncustomRepo OrderProductioncustom { get; private set; }
        public IOrderFinishedprodukRepo OrderFinishedproduk { get; private set; }
        public IOrderProdukBeliRepo OrderProdukBeli { get; private set; }
        public IRppRepo Rpp { get; private set; }
        public IRecapRepo Recap { get; private set; }
        public ITypelistRepo Typelist { get; private set; }
        public IOrderProdukJualRepo OrderProdukJual { get; private set; }

        public IDBTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.Snapshot)
        {
            return new DBTransaction(_context, isolationLevel);
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                string message = "";
                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    message += DateTime.Now.ToString() + ": Entity of type " + eve.Entry.Entity.GetType().Name + " in state " + eve.Entry.State + " has the following validation errors: <br/>";
                    foreach (var ve in eve.ValidationErrors)
                        message += "- Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage + " <br/>";
                }

                throw new AppException(501, "dbContext", 1, e);
            }
        }

        private bool _disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _context.Dispose();
            }

            _disposed = true;
        }


    }
}
