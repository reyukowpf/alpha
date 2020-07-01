using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class KlasifikasiAkun
    {
        public int Id { get; set; }
        public string KategoriKA { get; set; }
        public int? IdParentKategoriKA { get; set; }
        public int? AkunLevel { get; set; }
        public string Kode { get; set; }
        public bool? CheckboxLock { get; set; }
        public string LabaRugi { get; set; }


    }
}
