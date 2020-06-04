using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class KodeTransaksi
    {
        public int Id { get; set; }
        public string Kode { get; set; }
        public string Keterangan { get; set; }
        public string Tabel { get; set; }
        
    }
}
