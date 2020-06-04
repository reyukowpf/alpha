using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderPembayaranGaji
    {

        public int Id { get; set; }
        public int? IdKontak { get; set; }
        public string NamaPetugas { get; set; }
        public int? IdKodeTransaksi {get;set;}
        public int? IdReferalTransaksi { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartment { get; set; }
        public int? UserId { get; set; }
        public int? IdPeriodeAkuntasi { get; set; }
        public string RealRecordingTime { get; set; }
        public int? IdPembayaranGaji { get; set; }
        public string NoPembayaranGaji { get; set; }
        public DateTime? Tanggal { get; set; }
        public string NamaEmployee { get; set; }
        public int? IdGroup { get; set; }
        public double? GajiPokok { get; set; }
        public double? Tunjangan { get; set; }
        public double? Overtime { get; set; }
        public double? OvertimeHour { get; set; }
        public double? TotalOvertime { get; set; }
        public string Lainlain { get; set; }
        public string Pajak { get; set; }
        public string Keterangan { get; set; }
        public string BankData { get; set; }
        public double? Total { get; set; }
        public bool? CheckboxAktif { get; set; }
        public int? IdAkunPembGaji { get; set; }
       public double? DebitAkunPembGaji { get; set; }
       public double? KreditAkunPembGaji { get; set; }
       public int? IdAkunPajakGaji { get; set; }
       public double? DebitAkunPajakGaji { get; set; }
       public double? KreditAkunPajakGaji { get; set; }
       public int? IdAkunBiayaGaji { get; set; }
       public double? DebitAkunBiayaGaji { get; set; }
       public double? KreditAkunBiayaGaji { get; set; }
    }
}
