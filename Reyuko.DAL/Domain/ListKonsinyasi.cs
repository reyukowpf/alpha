using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListKonsinyasi
    {
        public int IdListKonsinyasi { get; set; }
        public int? IdPenerimaanRetur { get; set; }
        public string PenerimaanRetur { get; set; }
        public double? NoKonsinyasi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdVendor { get; set; }
        public string NamaVendor { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang{ get; set; }
        public double? KursTukar { get; set; }
        public double? NoHp { get; set; }
        public string Email { get; set; }

    }
}
