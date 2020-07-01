using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class ListDataPajak
    {
        public int Id { get; set; }
        public int? IdPajak { get; set; }
        public string KodePajak { get; set; }
        public string NamaPajak { get; set; }
        public double? Persentase { get; set; }
        public bool? CheckBoxMengurangiHPP { get; set; }
        public string AkunBeli { get; set; }
        public string AkunJual{ get; set; }
        public string Keterangan { get; set; }

        //public virtual DataPajak DataPajak { get; set; }
    }
}
