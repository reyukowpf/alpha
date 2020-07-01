using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DefaultAkunMataUang
    {
        public int Id { get; set; }
        public int? IdPiutangUsaha { get; set; }
        public int? IdHutangUsaha { get; set; }
        public int? IdPembayaranBank { get; set; }
        public int? IdPembayaranTunai { get; set; }
        public int? IdUangMukaPembelian { get; set; }
        public int? IdUangMukaPenjualan { get; set; }
        public int? IdPiutangGiro { get; set; }
        public int? IdHutangGiro { get; set; }
        public int? UserId { get; set; }


    }
}
