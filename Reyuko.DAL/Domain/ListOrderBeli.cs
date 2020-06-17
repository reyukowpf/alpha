using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListOrderBeli
    {
        public int Id { get; set; }
        public int? IdOrderBeli { get; set; }
        public int? IdTransaksi { get; set; }
        public int? Idquota { get; set; }
        public int? IdReferralTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public int? IdProduk { get; set; }
        public string ProdukKategori { get; set; }
        public string Sku { get; set; }
        public string NamaProduk { get; set; }
        public string SatuanDasar { get; set; }
        public double? Diskon { get; set; }
        public double? HargaBeli { get; set; }
        public double? Jumlah { get; set; }
        public double? PurchasedBalance { get; set; }
        public double? TotalOrderProduk { get; set; }
        public int? IdPajak { get; set; }
        public string NamaPajak { get; set; }
        public double? PersentasePajak { get; set; }
        public double? TotalPajakProduk { get; set; }
        public int? IdAkunPajak { get; set; }
        public int? IdTypeProduk { get; set; }
        public string TypeProduk { get; set; }
        public int? AkunPersediaan { get; set; }
        public int? AkunPengirimanBeli { get; set; }
        public int? IdAkunJasa { get; set; }
        public int? IdBudget { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public double? TotalOrderJasa { get; set; }
        public double? TotalPajakJasa { get; set; }
        public double? TotalOrder { get; set; }
        public double? TotalPajak { get; set; }
        public bool? Checkboxaktif { get; set; }
        
    }
}
