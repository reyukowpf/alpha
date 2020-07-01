using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListDataMataUang
    {
        public int Id { get; set; }
        public int? IdDataMataUang { get; set; }
        public string NamaMataUang { get; set; }
        public string KodeMataUang { get; set; }
        public DateTime? TglKursMataUang { get; set; }
        public double? KursTukar { get; set; }

    }
}
