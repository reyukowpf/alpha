using System;

namespace Reyuko.DAL.Domain
{
    public class KursMataUang
    {
        public int Id { get; set; }
        public int? IdDataMataUang { get; set; }
        public string KodeMataUang { get; set; }
        public DateTime? Tanggal { get; set; }
        public Double? Exrate { get; set; }

        //public virtual DataMataUang DataMataUang { get; set; }
    }
}
