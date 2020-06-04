using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class GrupDiskon
    {
        public int Id { get; set; }
        public string NamaGroupDiskon { get; set; }
        public double? Diskon { get; set; }
        public string Keterangan { get; set; }
        
    }
}
