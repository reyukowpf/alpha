using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class GrupProduk
    {
        public int Id { get; set; }
        public string NamaGrupProduk { get; set; }
        public string GrupSKU { get; set; }
        public int IdKategoriProduk { get; set; }
        public string KategoriProduk { get; set; }
        public string Keterangan { get; set; }
        public bool? CheckboxDiskon { get; set; }
        public double? DiskonPersen { get; set; }
        public DateTime? TanggalMulaiDiskon { get; set; }
        public DateTime? TanggalAkhirDiskon { get; set; }
    }
}
