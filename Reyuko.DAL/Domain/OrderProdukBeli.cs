using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderProdukBeli
    {
        public int IdOrderProdukBeli { get; set; }
        public int? IdTransaksi { get; set; }
        public int? IdReferralTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public int? IdProduk { get; set; }
        public string ProdukKategori { get; set; }
        public string Sku { get; set; }
        public string NamaProduk { get; set; }
        public string SatuanDasar { get; set; }
        public double? DiskonProduk { get; set; }
        public double? HargaBeli { get; set; }
        public double? TotalProduk { get; set; }
        public double? PurchasedBalance { get; set; }
        public double? TotalOrderProduk { get; set; }
        public int? IdPajak { get; set; }
        public string NamaPajak { get; set; }
        public double? PersentasePajak { get; set; }
        public double? TotalPajakProduk { get; set; }
        public int? IdAkunPajakProduk { get; set; }
        public int? IdTypeProduk { get; set; }
        public string TypeProduk { get; set; }
        public int? AkunPersediaan { get; set; }
        public int? AkunPengirimanBeli { get; set; }
        public int? IdBudget { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }        
        public bool? Checkboxaktif { get; set; }
        
    }
}
