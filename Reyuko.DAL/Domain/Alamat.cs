using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Alamat
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Kode { get; set; }
        public string Nama { get; set; }
        public int? IdParent { get; set; }


    }
}
