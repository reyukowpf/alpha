using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DataProyek
    {
        public int Id { get; set; }
        public string NomorProyek { get; set; }
        public string NamaProyek { get; set; }
        public int? IdKontakPemesan { get; set; }
        public string PemesanKontak { get; set; }
        public int? IdKontakPIC { get; set; }
        public string PICKontak { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? NilaiProyek { get; set; }
        public DateTime? TanggalMulai { get; set; }
        public DateTime? TanggalBerakhir { get; set; }
        public int? idStatus { get; set; }
        public string Status { get; set; }
        public string Keterangan { get; set; }
        public bool? CheckboxInAtive { get; set; }

    }
}
