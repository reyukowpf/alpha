using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class TransaksiJurnalUmum
    {

        public int IdTransaksiJurnalUmum { get; set; }
        public double? NoTransaksiJurnalUmum { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang {get;set;}
        public double? Kurs { get; set; }
        public int? IdNoRefensiDokumen { get; set; }
        public string NoRefensiDokumen { get; set; }
        public DateTime? Tanggal { get; set; }
        public string Keterangan { get; set; }
        public double? TotalDebit { get; set; }
        public double? TotalKredit { get; set; }
        public double? Balance { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxPosted { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkuntasi { get; set; }
        public DateTime? RealRecordingTime { get; set; }
    }
}
