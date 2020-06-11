using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListOrderJual
    {
        public int Id { get; set; }
        public int? IdOrderJual { get; set; }
        public int? IdTransaksi { get; set; }
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
        public double? Jumlah { get; set; }
        public double? SalesBalance { get; set; }
        public double? TotalOrder { get; set; }
        public int? IdPajak { get; set; }
        public string Pajak { get; set; }
        public double? Persentase { get; set; }
        public double? TotalPajak { get; set; }
        public int? IdAkunPajakJual { get; set; }
        public int? IdTypeProduk { get; set; }
        public string TypeProduk { get; set; }
        public int? IdAkunHargaPokok { get; set; }
        public int? IdAkunPenjualan { get; set; }
        public int? IdAkunPersediaan { get; set; }
        public int? IdAkunPengirimanJual { get; set; }
        public int? IdAkunReturPenjualan { get; set; }
        public int? IdProyekProduk { get; set; }
        public int? IdDepartemenProduk { get; set; }
        public int? IdAsset { get; set; }
        public string NamaAsset { get; set; }
        public DateTime? TanggalPengiriman { get; set; }
        public bool? Checkbokaktif { get; set; }

    }
}
