using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderProductioninput
    {
        public int IdOrderProduction { get; set; }
        public int? IdTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public int? IdProduk { get; set; }
        public string Sku { get; set; }
        public string NamaProduk { get; set; }
        public int? IdSatuanDasar { get; set; }
        public string SatuanDasar { get; set; }
        public double? HargaPokok { get; set; }
        public double? JumlahProduk { get; set; }
        public double? TotalOrderProduk { get; set; }
        public int? IdAkunPersediaan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? CheckboxAktif { get; set; }
    }
}
