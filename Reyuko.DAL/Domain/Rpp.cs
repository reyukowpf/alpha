using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Rpp
    {
        public int IdRpp {get; set; }
       public int? PulldownRpp {get; set; }
       public int? IdKodeTransaksi {get; set; }
       public int? IdTransaksi {get; set; }
       public string KodeTransaksi {get; set; }
       public double? NoPembayaran {get; set; }
       public int? IdPelanggan {get; set; }
       public string NamaPelanggan {get; set; }
       public double? NoHp {get; set; }
       public string Email {get; set; }
       public DateTime? TanggalTransaksi {get; set; }
       public bool? CheckboxGiro {get; set; }
       public int? IdDataGiro {get; set; }
       public int? IdNoReferensiDokumen {get; set; }
       public string NoReferensiDokumen {get; set; }
       public int? IdPetugas {get; set; }
       public string NamaPetugas {get; set; }
       public bool? CheckboxUnposted {get; set; }
       public int? IdAkunKas {get; set; }
       public string NamaAkunKas {get; set; }
       public double? TotalPembayaran {get; set; }
       public int? IdUserId {get; set; }
       public int? IdPeriodeAkuntansi {get; set; }
       public DateTime? RealRecordingTime {get; set; }
       public string Keterangan {get; set; }
       public int? IdReferalTransaksi { get; set; }
    }
}
