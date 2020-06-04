using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Reyuko.DAL.Domain
{
    public class OrderJurnalUmum
    {

        public int IdOrderJurnalUmum { get; set; }
        public int? IdTransaksiJurnalUmum { get; set; }
        public double? NoTransaksiJurnalUmum { get; set; }
        public int? IdKlasifikasi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? Kurs { get; set; }
        public string Keterangan { get; set; }
        public int? IdRekeningPerkiraan { get; set; }
        public string NoRekeningPerkiraan { get; set; }
        public string NamaRekeningPerkiraan { get; set; }
        public string KlasifikasiRekeningPerkiraan { get; set; }
        public double Debit { get; set; }
        public double Kredit { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public int? IdUserId { get; set; }
        public bool? CheckboxPosted { get; set; }
        public int IdKodeTransaksi { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdPeriodeAkuntasi { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? Chkaktif { get; set; }
        public IEnumerable<RekeningPerkiraan> rekeningPerkiraansa { get; set; }
    }
}