using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DataDepartemen
    {
        public int Id { get; set; }
        public string KodeDepartemen { get; set; }
        public string NamaDepartemen { get; set; }
        public int? IdSubDepartemen{ get; set; }
        public string SubDepartemenDari { get; set; }
        public int? IdKontak { get; set; }
        public string PenanggungJawab { get; set; }
        public string Deskripsi { get; set; }
        public bool? CheckboxInActive { get; set; }

        
    }
}
