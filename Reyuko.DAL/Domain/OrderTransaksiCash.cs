using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class OrderTransaksiCash
    {
       public int IdOrderTransaksiCash { get; set; }
       public int? IdDepartemen { get; set; }
       public int? IdReferalTransaksi2 { get; set; }
       public double? NoReferensiTransaksi { get; set; }
       public int? IdAkunHutangPiutangReferensi { get; set; }
       public double? Debit { get; set; }
       public double? Kredit { get; set; }
       public int? IdUserId { get; set; }
       public int? IdPeriodeTransaksi { get; set; }
       public DateTime? RealRecordingTime { get; set; }
       public int? IdTransaksiPaymentCashActivity { get; set; }
       public int? IdDropdownPaymentCashActivity { get; set; }
       public int? IdKodeTransaksi { get; set; }
       public string KodeTransaksi { get; set; }
       public int? IdPelanggan { get; set; }
       public string NamaPelanggan { get; set; }
       public double? NoHp { get; set; }
       public string Email { get; set; }
       public int? IdMataUang { get; set; }
       public string MataUang { get; set; }
       public double? KursTukar { get; set; }
       public int? IdNoReferensiDokumen { get; set; }
       public string NoReferensiDokumen { get; set; }
       public DateTime? TanggalTransaksi { get; set; }
       public DateTime? DueDate { get; set; }
       public string Keterangan { get; set; }
       public bool? CheckboxGiro { get; set; }
       public int? IdDataGiro { get; set; }
       public int? IdPetugas { get; set; }
       public string NamaPetugas { get; set; }
       public int? IdProyek { get; set; }
       public string KategoriTransaksi { get; set; }
       public bool? Checkboxaktif { get; set; }
       public double? Debit1 { get; set; }
        public double? Kredit1 { get; set; }
        public string NoReferensiTransaksi1 { get; set; }
        public int? IdAkunHutangPiutangReferensi1 { get; set; }
        public string NamaAkunHutangPiutang { get; set; }

    }
}
