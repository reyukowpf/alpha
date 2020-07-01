using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DataPajak
    {
        public int Id { get; set; }
        public string KodePajak { get; set; }
        public string NamaPajak { get; set; }
        public double? Persentase { get; set; }
        public int? IdAkunBeli { get; set; }
        public string AkunBeli { get; set; }
        public int? IdAkunJual { get; set; }
        public string AkunJual{ get; set; }
        public string Keterangan { get; set; }
        public bool? CheckBoxInAktif { get; set; }
        public int? user_id { get; set; }

        //public virtual ListDataPajak ListDataPajak { get; set; }

    }
}
