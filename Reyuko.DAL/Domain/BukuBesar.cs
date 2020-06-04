using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class BukuBesar
    {
        public int Id { get; set; }
        public int? IdOrigin { get; set; }
        public int? IdRekeningPerkiraan { get; set; }
        public string NoRekningPerkiraan { get; set; }
        public string NamaRekeningPerkiraan { get; set; }
        public int? IdKlasfikasi { get; set; }
        public string KlasifikasiAkun { get; set; }
        public int IdKodeTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public double? NoReferensiTransaksi { get; set; }
        public DateTime? Tanggal { get; set; }
        public string Deskripsi { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public double DebitMataUang { get; set; }
        public double? KreditMataUang { get; set; }
        public double? Debit { get; set; }
        public double? Kredit { get; set; }
        public bool? CashflowFlag { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdLokasi { get; set; }
        public int? IdKontak { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartmen { get; set; }
       public int? IdBiaya { get; set; }
       public string Penyesuaian { get; set; }
       public int? IdUserId { get; set; }
       public int? IdPeriodeAkuntansi { get; set; }
       public DateTime? RealRecordingTime { get; set; }
       public string Rekonsiliasi { get; set; }
   
    }
}
