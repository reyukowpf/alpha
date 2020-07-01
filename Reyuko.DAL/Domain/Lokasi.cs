using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Lokasi
    {
        public int Id { get; set; }
        public string NamaTempatLokasi { get; set; }
        public string NoTelpLokasi { get; set; }
        public string EmailLokasi { get; set; }
        public int? IdNegara { get; set; }
        public string NamaNegara { get; set; }
        public string AlamatLokasi { get; set; }
        public string KotaLokasi { get; set; }
        public int? IdPropinsi { get; set; }
        public string PropinsiLokasi { get; set; }
        public int? KodePosLokasi { get; set; }
        public string MapLocationLokasi { get; set; }
        public bool? CheckboxDefault { get; set; }
        public bool? CheckboxNotActive { get; set; }
        
    }
}
