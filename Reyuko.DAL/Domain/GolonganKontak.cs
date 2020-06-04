using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class GolonganKontak
    {
        public int Id { get; set; }
        public string NamaGolongan { get; set; }
        public int? GajiPokok { get; set; }
        public int? Tunjangan { get; set; }
        public int? OvertimeHour { get; set; }
        public bool? IncludeExcludePajak { get; set; }
        
    }
}
