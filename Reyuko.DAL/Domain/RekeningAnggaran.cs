using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class RekeningAnggaran
    {
        public int Id { get; set; }
        public string NomorAnggaran { get; set; }
        public int? IdRekeningPerkiraan { get; set; }
        public string NamaAkun { get; set; }
        public string Kode { get; set; }
        public string Deskripsi { get; set; }
        public int? Anggaran { get; set; }
        public int? Idproyek { get; set; }
        public int? IdDepartemen { get; set; }
        public int? IdLokasi { get; set; }
        public DateTime? TanggalAwal { get; set; }
        public DateTime? TanggalAkhir { get; set; }
        public int? IdPeriodeAkutansi { get; set; }
        public int? UserID { get; set; }
        public string RealRecordingTime { get; set; }
        public object KlasifikasiAkunSelected { get; set; }
    }
}
