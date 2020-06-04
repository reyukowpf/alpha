using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Purchasedelivery
    {
        public int IdPengirimanBarangPembelian { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public bool? CheckboxTunaiTermPembayaran { get; set; }
        public bool? DropdownTermPembayaran { get; set; }
        public double? GracePeriod { get; set; }
        public double? UangMuka { get; set; }
        public int? IdOpsiAnnual { get; set; }
        public string Annual { get; set; }
        public double? Duration { get; set; }
        public double? Nominal { get; set; }
        public bool? CheckboxBerulang { get; set; }
        public bool? DropdownBerulang { get; set; }
        public double? DurationBerulang { get; set; }
        public DateTime? TanggalBerulang { get; set; }
        public int? AkunStokProduk { get; set; }
        public double? TotalDebitAkunStokProduk { get; set; }
        public double? TotalKreditAkunStokProduk { get; set; }
        public int? AkunPengirimanBeliProduk { get; set; }
        public double? TotalDebitAkunPengirimanBeliProduk { get; set; }
        public double? TotalKreditAkunPengirimanBeliProduk { get; set; }
        public double? TotalSebelumPajak { get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public double? SaldoTerhutang { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkuntansi { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public DateTime? RealRecordingTime { get; set; }
        public int? IdTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public double? NoPengirimanBarangPembelian { get; set; }
        public int? IdVendor { get; set; }
        public string NamaVendor { get; set; }
        public string NoHp { get; set; }
        public string Email { get; set; }
        public int? IdOrderPembelian { get; set; }
        public double? NoOrderPembelian { get; set; }
        public string IdReferalTransaksi { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? TanggalPengirimanBarangPembelian { get; set; }
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

    }
}
