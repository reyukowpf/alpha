using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderJasaBeli
    {
        public int IdOrderJasa { get; set; }
        public int? IdTransaksi { get; set; }
        public int? IdReferralTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public int? IdProduk { get; set; }
        public string Sku { get; set; }
        public string NamaJasa { get; set; }
        public double? TotalJasa { get; set; }
        public double? HargaJasa { get; set; }
        public double? DiskonJasa { get; set; }
        public double? TotalOrderJasa { get; set; }       
        public int? IdPajak { get; set; }
        public string NamaPajak { get; set; }
        public double? PersentasePajak { get; set; }
        public double? TotalPajakJasa { get; set; }
        public int? IdAkunPajakJasa { get; set; }
        public int? IdAkunJasa { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }        
        public bool? Checkboxaktif { get; set; }
        
    }
}
