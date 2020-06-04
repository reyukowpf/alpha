using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class PembayaranGaji
    {

        public int IdPembayaranGaji { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdAkunPembGaji { get; set; }
        public int? IdAkunBiayaGaji {get;set;}
        public bool? CheckboxPajakGaji { get; set; }
        public int? IdAkunPajakGaji { get; set; }
        public int? IdKontak { get; set; }
        public string NamaPetugas { get; set; }
        public double? TotalSalaryPayment { get; set; }
        public int? UserId { get; set; }
        public int? IdPeriodeAkuntasi { get; set; }
        public DateTime? RealRecordingTime { get; set; }
       
    }
}
