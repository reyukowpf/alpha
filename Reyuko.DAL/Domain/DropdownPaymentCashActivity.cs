using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DropdownPaymentCashActivity
    {
        public int Id { get; set; }
        public string KategoriTransaksi { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
    }
}
