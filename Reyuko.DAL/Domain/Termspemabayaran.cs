using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Termspembayaran
    {
        public int IdTermPembayaran { get; set; }
        public string NamaSkema { get; set; }
        public double? GracePeriod { get; set; }
        public double? UangMuka { get; set; }
        public int? IdOptionAnnual { get; set; }
        public string Annual { get; set; }
        public int? TermPembayaran { get; set; }
        public double? BungaPerBulan { get; set; }
        public double? CicilanPerbulan { get; set; }
        public bool? CheckBoxInactive { get; set; }
    }
}
