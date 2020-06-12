using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderCustomJual
    {
        public int IdOrderCustom { get; set; }       
        public int? IdTransaksi { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string NamaCustom { get; set; }
        public double? DiskonCustom { get; set; }
        public double? HargaCustom { get; set; }
        public double? JumlahCustom { get; set; }
        public double? TotalCustom { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? Checkbokaktif { get; set; }
    }
}
