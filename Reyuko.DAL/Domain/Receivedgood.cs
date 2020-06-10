using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Receivedgood
    {
        public int IdOrder { get; set; }
        public DateTime? TanggalPengiriman { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public bool? CheckboxTunaiTermPembayaran { get; set; }
        public bool? DropdownTermPembayaran { get; set; }
        public double? GracePeriod { get; set; }
        public double? UangMuka { get; set; }
        public int? IdOptionAnnual { get; set; }
        public string Annual { get; set; }
        public double? Duration { get; set; }
        public bool? Nominal { get; set; }
        public bool? DropdownBankKas { get; set; }
        public bool? CheckboxBerulang { get; set; }
        public bool? DropdownBerulang { get; set; }
        public double? DurasiBerulang { get; set; }
        public DateTime? TanggalBerulang { get; set; }
        public int? IdAkunPersediaanProduk{ get; set; }
        public double? TotalDebitAkunPersediaanProduk { get; set; }
        public double? TotalKreditAkunPersediaanProduk { get; set; }
        public double? IdAkunPengirimanBeliProduk { get; set; }
        public double? TotalDebitAkunPengirimanBeliProduk { get; set; }
        public double? TotalKreditAkunPengirimanBeliProduk { get; set; }
        public int? IdAkunPembeliaanJasa { get; set; }
        public double? TotalDebitPembeliaanJasa { get; set; }
        public double? TotalKreditPembelianJasa { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? IdAkunPembelianCustom { get; set; }
        public double? TotalDebitPembelianCustom { get; set; }
        public double? TotalKreditPembelianCustom { get; set; }
        public int? IdAkunPajakProduk { get; set; }
        public double? TotalDebitAkunPajakProduk { get; set; }
        public double? TotalKreditAkunPajakProduk { get; set; }
        public int? IdAkunPajakJasa { get; set; }
        public double? TotalDebitAkunPajakJasa { get; set; }
        public double? TotalKreditAkunPajakJasa { get; set; }
        public int? IdAkunTunaiPembeliaan { get; set; }
        public double? TotalDebitAkunTunaiPembeliaan { get; set; }
        public double? TotalKreditAkunTunaiPembeliaan { get; set; }
        public int? IdAkunHutangPembeliaan { get; set; }
        public double? TotalDebitAkunHutangPembeliaan { get; set; }
        public double? TotalKreditAkunHutangPembeliaan { get; set; }
        public double? TotalSebelumPajak { get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public bool? CheckManual { get; set; }
        public int? IdReferalPA { get; set; }
        public double? LunasDibayarUangMuka { get; set; }
        public double? SaldoTerhutang { get; set; }
        public double? CicilanPerbulan { get; set; }
        public bool? Angsuran { get; set; }
        public DateTime? DueDate { get; set; }
        public int? IdTransaksi { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkutansi { get; set; }
        public DateTime? RealRecordingTime { get; set; }
        public string KodeTransaksi { get; set; }
        public string NoOrder { get; set; }
        public int? IdVendor { get; set; }
        public string NamaVendor { get; set; }
        public string NoHp { get; set; }
        public string Email { get; set; }
        public int? IdOrderPembeliaan { get; set; }
        public double? NoOrderPembeliaan { get; set; }
        public int? IdPD { get; set; }
        public double? NoPD { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? TanggalOrder { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumentNi { get; set; }
        public int? IdLokasi { get; set; }
        public string NamaLokasi { get; set; }
        public string Keterangan { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartmen { get; set; }
        public bool? CheckboxInclusiveTax { get; set; }
        public int? IdPaymentTerm { get; set; }
        public string PaymentTerm { get; set; }
        public int? IdBankCash { get; set; }
        public string BankCash { get; set; } 
    }
}
