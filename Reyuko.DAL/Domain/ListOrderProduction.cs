using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListOrderProduction
    {
        public int Id { get; set; }
        public int? IdOrder { get; set; }
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
        public double? Jumlah { get; set; }
        public double? TotalOrder { get; set; }
        public int? IdAkunPersediaan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public int? IdAkunCustom { get; set; }
        public string AkunCustom { get; set; }
        public bool? CheckboxAktif { get; set; }
    }
}
