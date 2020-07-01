using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class CashActivity
    {
        public int Id { get; set; }
        public int? PulldownCashActivities { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? IdTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public double? NoCashActivities { get; set; }
        public int? IdKontak { get; set; }
        public string NamaKontak { get; set; }
        public double? NoHp { get; set; }
        public string Email { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? Tanggal { get; set; }
        public bool? CheckboxGiro { get; set; }
        public int? IdDataGiro { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public int? IdAkunKas { get; set; }
        public string NamaAkunKas { get; set; }
        public double? Nilai { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkuntansi { get; set; }
        public DateTime? RealRecordTime { get; set; }
        public string KategoriTransaksi { get; set; }


    }
}
