using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DataGiro
    {
        public int Id { get; set; }
        public double? NomorGiro { get; set; }
        public DateTime? JatuhTempoGiro { get; set; }
        public string NamaBank { get; set; }
        public double? NomorRekeningGiro { get; set; }


    }
}
