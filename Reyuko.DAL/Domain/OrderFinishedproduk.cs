using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderFinishedproduk
    {
        public int IdOrderFinishProduk { get; set; }
        public int? IdTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi{ get; set; }
        public int? IdProduk{ get; set; }
        public string Sku{ get; set; }
        public string NamaProduk{ get; set; }
        public int? IdSatuanDasar { get; set; }
        public string SatuanDasar{ get; set; }
        public double? TotalProduk { get; set; }
        public double? HargaProduk { get; set; }
        public double? TotalBiaya{ get; set; }
        public int? IdAkunPersediaan{ get; set; }
        public int? IdProyek{ get; set; }
        public int? IdDepartemen{ get; set; }
        public bool? CheckboxAktif { get; set; }
    }
}
