using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderProdukJual
    {
        public int IdOrderProdukJual { get; set; }
        public int? IdAkunStok { get; set; }
        public int? IdAkunPengirimanJual { get; set; }
        public int? IdAkunReturPenjualan { get; set; }
        public int? IdProyekProduk { get; set; }
        public int? IdDepartemenProduk { get; set; }
        public int? IdAsset { get; set; }
        public string NamaAsset { get; set; }
        public DateTime? TanggalPengiriman { get; set; }
        public int? IdForm { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public int? IdProduk { get; set; }
        public string ProdukKategori { get; set; }
        public string Sku { get; set; }
        public string NamaProduk { get; set; }
        public string SatuanDasar { get; set; }
        public double? DiskonProduk { get; set; }
        public double? HargaJual { get; set; }
        public double? HargaPokok { get; set; }
        public double? JumlahProduk { get; set; }
        public double? SalesBalance { get; set; }
        public double? TotalOrderProduk { get; set; }
        public int? IdPajak { get; set; }
        public string Pajak { get; set; }
        public double? Persentase { get; set; }
        public double? TotalPajak { get; set; }
       public int? IdAkunPajakJual { get; set; }
       public int? IdTypeProduk { get; set; }
       public string TypeProduk { get; set; }
       public int? IdAkunHargaPokok { get; set; }
       public int? IdAkunPenjualan { get; set; }
    }
}
