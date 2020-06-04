using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListProduk
    {
        public int IdListProduk { get; set; }
        public int? IdProduk { get; set; }
        public string Sku { get; set; }
        public string NamaProduk { get; set; }
        public string MataUang { get; set; }
        public double? JumlahStok { get; set; }
        public string SatuanDasar { get; set; }
        public double? HargaPokok { get; set; }
        public double? NilaiTotal { get; set; }

    }
}
