using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListKontak
    {
        public int Id { get; set; }
        public int? IdKontak { get; set; }
        public string TypeKontak { get; set; }
        public string KlasifikasiKontak { get; set; }
        public string NamaA { get; set; }
        public string NoHPA { get; set; }
        public string EmailA { get; set; }
        public string NegaraA { get; set; }
        public string AlamatA { get; set; }
        public string KotaA { get; set; }

    }
}
