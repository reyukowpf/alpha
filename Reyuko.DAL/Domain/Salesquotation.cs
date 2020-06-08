using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Salesquotation
    {
        public int Id { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? IdTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public string NoPenawaranHarga { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdKontak { get; set; }
        public string NamaPelanggan { get; set; }
        public string NoHp { get; set; }
        public string Email { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? TanggalPenawaranHarga { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string Keterangan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? CheckboxInclusiveTax { get; set; }
        public DateTime? TanggalPenutupan { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public bool? DropdownTermPembayaran { get; set; }
        public bool? CheckboxBerulang { get; set; }
        public bool? DropdownBerulang { get; set; }
        public double? DurasiBerulang { get; set; }
        public DateTime? TanggalBerulang { get; set; }
        public double? TotalOrderProduk { get; set; }
        public double? TotalPajakProduk { get; set; }
        public double? TotalOrderJasa { get; set; }
        public double? TotalPajakJasa { get; set; }
        public double? TotalSebelumPajak { get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public double? LunasUangMuka { get; set; }
        public double? CicilanPerBulan { get; set; }
        public double? DurasiCicilan { get; set; }
        public DateTime? DueDate { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkutansi { get; set; }
        public DateTime? RealRecordingTime { get; set; }
        public bool? CheckboxSelesai { get; set; }
        public bool? CheckboxTunaiTermPembayaran { get; set; }
        public int? IdOpsiAnnual { get; set; }
        public string Annual { get; set; }
        public int? IdTermPembayaran { get; set; }
        public string TermPembayaran { get; set; }
    }
}
