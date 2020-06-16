using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Shopingchart
    {
        public int IdPermintaanBarang { get; set; }
        public double? DurasiBerulang { get; set; }
        public DateTime? TanggalBerulang { get; set; }
        public double? Nilai { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkuntansi { get; set; }
        public DateTime? RealRecordingTime { get; set; }
        public bool? CheckboxSelesai { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? idTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public string NoPermintaanBarang { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdEmployee { get; set; }
        public string NamaManager { get; set; }
        public string Nohp { get; set; }
        public string Email { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? TanggaldiBuat { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string Keterangan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public DateTime? TanggalDigunakan { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxBerulang { get; set; }
        public bool? DropdownBerulang { get; set; }
        public int? IdOpsiAnnual { get; set; }
        public string Annual { get; set; }
    }
}
