using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderProductioncustom
    {
        public int IdOrderProductionCustom { get; set; }
        public int? IdProduction { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string NamaCustom { get; set; }
        public double? TotalCustom { get; set; }
        public double? JumlahCustom { get; set; }
        public string SatuanCustom { get; set; }
        public double? HargaCustom { get; set; }
        public int? AkunCustom { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? CheckboxAktif { get; set; }
    }
}
