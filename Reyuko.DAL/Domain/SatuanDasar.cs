using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class SatuanDasar
    {
        public int Id { get; set; }
        public bool? CheckboxUnitDasar { get; set; }
        public int? TipeUnit { get; set; }
        public string KodeSatuan { get; set; }
        public string NamaSatuan { get; set; }
        public double? JumlahSatuan { get; set; }
        public int? ParentId { get; set; }
        public string DetailSatuan { get; set; }
        public string Keterangan { get; set; }
        public int? UserId { get; set; }
    }
}
