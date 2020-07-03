using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Reyuko.DAL.Domain
{
    public class produk
    {
        public int IdProduk { get; set; }
        public double? JumlahStok { get; set; }
        public int? BatasStokMin { get; set; }
        public string TipeHargaPokok { get; set; }
        public int? IdTipeProduk { get; set; }
        public string TipeProduk { get; set; }
        public int? IdAkunHargaPokok { get; set; }
        public int? IdAkunPenjualan { get; set; }
        public int? IdAkunPersediaan { get; set; }
        public int? IdAkunPengirimanBeli { get; set; }
        public int? IdAkunPengirimanJual { get; set; }
        public int? IdAkunReturPenjualan { get; set; }
        public int? IdAkunJasa { get; set; }
        public string Keterangan { get; set; }
        public bool? CheckboxPajak { get; set; }
        public int? IdPajak { get; set; }
        public string Pajak { get; set; }
        public double PersentasePajak { get; set; }
        public int IdAkunPajak { get; set; }
        public bool? CheckBoxInclusiveTax { get; set; }
        public string Panjang { get; set; }
        public string Lebar { get; set; }
        public string Tinggi { get; set; }
        public string Berat { get; set; }
        public string UploadImage0 { get; set; }
        public string UploadImage1 { get; set; }
        public string UploadImage2 { get; set; }
        public bool? CheckBoxTidakAktif { get; set; }
        public string UploadImage3 { get; set; }
        public int? IdKontak { get; set; }
        public string SuplierA { get; set; }
        public string KeteranganSuplierA { get; set; }
        public string SuplierB { get; set; }
        public string KeteranganSuplierB { get; set; }
        public string SuplierC { get; set; }
        public string KeteranganSuplierC { get; set; }
        public string SuplierD { get; set; }
        public string KeteranganSuplierD { get; set; }
        public bool? CheckboxService { get; set; }
        public int? IdProdukKategori { get; set; }
        public string ProdukKategori { get; set; }
        public string SKU { get; set; }
        public int? IdGroupProduk { get; set; }
        public string NamaGroupProduk { get; set; }
        public string NamaProduk { get; set; }
        public double? HargaPokokAverage { get; set; }
        public double? HargaBeli { get; set; }
        public double? HargaJual { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public bool? TimeBasedUnit { get; set; }
        public bool? N1Calculation { get; set; }
        public bool? CheckboxKalender { get; set; }
        public int? IdSatuanDasar { get; set; }
        public string SatuanDasar { get; set; }
        public double? MinPemesanan { get; set; }
        public bool? CheckboxDiskonProduk { get; set; }
        public bool? CheckboxUbahHarga { get; set; }
        public string DiskonProdukPersen { get; set; }
        public  DateTime? TanggalMulaiDiskonProduk { get; set; }
        public DateTime? TanggalBerakhirDiskonProduk { get; set; }
        public bool? CheckboxManageStok { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public DateTime? Tanggal { get; set; }
        public string ReceivedNumber { get; set; }
        public int? IdDropdownBankkas { get; set; }
        public string DropdownBankkas { get; set; }
        public bool? AKtif { get; set; }
    }
}
