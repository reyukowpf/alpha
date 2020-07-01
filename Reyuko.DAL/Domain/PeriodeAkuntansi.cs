using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class PeriodeAkuntansi
    {
        public int Id { get; set; }
        public DateTime? TahunBukuAwal { get; set; }
        public DateTime? TahunBukuAkhir { get; set; }
        public bool? CheckboxAktif { get; set; }

    }
}
