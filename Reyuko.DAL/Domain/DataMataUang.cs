using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DataMataUang
    {
        public int Id { get; set; }
        public bool? CheckBoxAktif { get; set; }
        public string NamaMataUang { get; set; }
        public string KodeMataUang { get; set; }
        public string SimbolMataUang { get; set; }
        public DateTime? TglKursMataUang { get; set; }
        public double? KursTukar { get; set; }
        public double? DefaultDataMataUang { get; set; }
        public int? IdDefaultMataUang { get; set; } 

        //public virtual ICollection<KursMataUang> KursMataUangs { get; set; }
    }
}
