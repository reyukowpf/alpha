using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListLokasi
    {
        public int Id { get; set; }
        public int IdLokasi { get; set; }
        public string NamaTempatLokasi { get; set; }
        public string AlamatLokasi { get; set; }
        public string KotaLokasi { get; set; }
        public string NegaraLokasi { get; set; }

    }
}
