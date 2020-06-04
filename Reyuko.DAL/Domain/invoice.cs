using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class invoice
    {

        public int IdInvoice { get; set; }
        public DateTime? TanggalPengiriman { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public bool? CheckboxTunaiTermPembayaran { get; set; }
        public bool? DropdownTermPembayaran { get; set; }
        public bool? DropdownBankKas { get; set; }
        public bool? CheckboxBerulang { get; set; }
        public bool? DropdownBerulang { get; set; }
        public double? DurasiBerulang { get; set; }
        public DateTime? TanggalBerulang { get; set; }
        public int? IdAkunHargaPokokProduk { get; set; }
        public double? TotalDebitAkunHargaPokokProduk { get; set; }
        public double? TotalKreditAkunHargaPokokProduk { get; set; }
        public int? IdAkunPenjualanProduk { get; set; }
        public double? TotalDebitAkunPenjualanProduk { get; set; }
        public double? TotalKreditAkunPenjualanProduk { get; set; }
        public int? IdAkunPersediaanProduk { get; set; }
        public double? TotalDebitAkunPersediaanProduk { get; set; }
        public double? TotalKreditAkunPersediaanProduk { get; set; }
        public int? IdAkunPengirimanJual { get; set; }
        public double? TotalDebitdAkunPengirimanJual { get; set; }
        public double? TotalKreditIdAkunPengirimanJual { get; set; }
        public int? IdAkunPenjualanJasa { get; set; }
        public double? TotalDebitPenjualanJasa { get; set; }
        public double? TotalKreditPenjualanJasa { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? IdAkunPenjualanCustom { get; set; }
        public double? TotalDebitPenjualanCustom { get; set; }
        public double? TotalKreditPenjualanCustom { get; set; }
        public int? IdAkunPajakProduk { get; set; }
        public double? TotalDebitAkunPajakProduk { get; set; }
        public double? TotalKreditAkunPajakProduk { get; set; }
        public int? IdAkunPajakJasa { get; set; }
        public double? TotalDebitAkunPajakJasa { get; set; }
        public double? TotalKreditAkunPajakJasa { get; set; }
        public int? IdAkunTunaiPenjualan { get; set; }
        public double? TotalDebitAkunTunaiPenjualan { get; set; }
        public double? TotalKreditAkunTunaiPenjualan { get; set; }
        public int? IdAkunPiutangPenjualan { get; set; }
        public double? TotalDebitAkunPiutangPenjualan { get; set; }
        public double? TotalKreditAkunPiutangPenjualan { get; set; }
        public double? TotalSebelumPajak { get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public bool? CheckboxManual { get; set; }
        public int? IdReferalSA { get; set; }
        public double? LunasDibayarUangMuka { get; set; }
        public double? SaldoTerhutang { get; set; }
        public double? CicilanPerBulan { get; set; }
        public bool? Angsuran { get; set; }
        public DateTime? DueDate { get; set; }
        public int? IdUserId { get; set; }
        public int? IdTransaksi { get; set; }
        public int? IdPeriodeAkuntansi { get; set; }
        public string RealRecordingTime { get; set; }
        public string KodeTransaksi { get; set; }
        public string NoInvoice { get; set; }
        public int? IdPelanggan { get; set; }
        public string NamaPelanggan { get; set; }
        public string NoHp { get; set; }
        public string Email { get; set; }
        public int? IdOrderPenjualan { get; set; }
        public double? NoOrderPenjualan { get; set; }
        public int? IdDo { get; set; }
        public string NoDo { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? TanggalInvoice { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string Keterangan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public bool? CheckboxInclusiveTax { get; set; }
        public int? IdBankCash { get; set; }
        public string BankCash { get; set; }
        public int? IdOpsiAnnual { get; set; }
        public string Annual { get; set; }
        public int? IdTermPembayaran { get; set; }
        public string TermPembayaran { get; set; }
        public double? NoReferalTransaksi { get; set; }
    }
}
