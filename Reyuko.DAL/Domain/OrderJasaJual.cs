using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderJasaJual
    {
        public int IdOrderJasa { get; set; }       
        public int? IdTransaksi { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public int? IdProduk { get; set; }
        public string ProdukKategori { get; set; }
        public string Sku { get; set; }
        public string NamaProduk { get; set; }
        public double? DiskonJasa { get; set; }
        public double? HargaJasa { get; set; }
        public double? JumlahJasa { get; set; }
        public double? TotalOrderJasa { get; set; }
        public int? IdPajak { get; set; }
        public string Pajak { get; set; }
        public double? Persentase { get; set; }
        public double? TotalPajak { get; set; }
        public int? IdAkunPajakJual { get; set; }
        public int? AkunJasa { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public int? IdAsset { get; set; }
        public string NamaAsset { get; set; }
        public DateTime? TanggalStartdate { get; set; }
        public bool? Checkbokaktif { get; set; }

    }
}
