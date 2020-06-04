using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderInventori
    {
        public int IdOrderInventori { get; set; }
        public double? TotalJual { get; set; }
        public int? IdPajak { get; set; }
        public string Pajak { get; set; }
        public double? PersentasePajak { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public DateTime? TanggalMasuk { get; set; }
        public DateTime? TanggalKeluarTerjual { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string Keterangan { get; set; }
        public int? IdProduk { get; set; }
        public string Sku { get; set; }
        public string NamaProduk { get; set; }
        public string SatuanDasar { get; set; }
        public int? Masuk { get; set; }
        public int? Keluar { get; set; }
        public int? Terjual { get; set; }
        public double? SaldoItem { get; set; }
        public double? HargaBeli { get; set; }
        public double? HargaPokok { get; set; }
        public double? HargaJual { get; set; }
        public double? TotalBeli { get; set; }
        public string Diskon { get; set; }
        public double? TotalPajak { get; set; }
        public bool? CheckboxAktif { get; set; }
    }
}
