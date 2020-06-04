using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class PenerimaanBarang
    {
        public int IdPenerimaanBarangKonsinyasi { get; set; }
        public bool? CheckBooxBerulang { get; set; }
        public string DropdownBerulang { get; set; }
        public double? DurasiBerulang { get; set; }
        public DateTime? TanggalBerulang { get; set; }
        public double? TotalSebelumPajak { get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkutansi { get; set; }
        public DateTime? RealRecordingTime { get; set; } 
        public int? IdKodeTransaksi { get; set; }
        public int? IdTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public double? NoPenerimaanBarangKonsinyasi { get; set; }
        public int? IdVendor { get; set; }
        public string NamaVendor { get; set; }
        public double? NoHp { get; set; }
        public string Email { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public int? IdNoRefernsiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string Keterangan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? CheckboxInclusiveTax { get; set; }
        public DateTime? TanggalPenerimaan { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public int? IdOpsiAnnual { get; set; }
        public string Annual { get; set; }
    }
}
