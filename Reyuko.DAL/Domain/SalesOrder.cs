using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class SalesOrder
    {
        public int IdOrderPenjualan { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public bool? CheckboxTunaiTermPembayaran { get; set; }
        public bool? DropdownTermPembayaran { get; set; }
        public bool? CheckboxBerulang { get; set; }
        public bool? DropdownBerulang { get; set; }
        public double? DurasiBerulang { get; set; }
        public DateTime? TanggalBerulang { get; set; }
        public double? TotalOrderProduk { get; set; }
        public double? TotalPajakProduk { get; set; }
        public double? TotalSebelumPajak { get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public double? LunasUangMuka { get; set; }
        public double? CicilanPerBulan { get; set; }
        public double? DurasiCicilan { get; set; }
        public DateTime? DueDate { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkuntansi { get; set; }
        public string RealRecordingTime { get; set; }
        public bool? CheckboxSelesai { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? IdTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public double? NoOrderPenjualan { get; set; }
        public int? IdPelanggan { get; set; }
        public string NamaPelanggan { get; set; }
        public int? NoHp { get; set; }
        public string Email { get; set; }
        public int? IdPenawaran { get; set; }
        public double? NoPenawaran { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? TanggalOrderPenjualan { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string Keterangan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? CheckboxInclusiveTax { get; set; }
        public DateTime? TanggalPengantaran { get; set; }
        public int? IdPetugas { get; set; }
        public int? IdOpsiAnnual { get; set; }
        public string Annual { get; set; }
        public int? IdTermPembayaran { get; set; }
        public string TermPembayaran { get; set; }
    }
}
