using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Purchasereturn
    {
        public int IdReturPembelian { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxUnposted { get; set; }
        public bool? CheckboxTunaiTermPembayaran { get; set; }
        public bool? DropdownTermPembayaran { get; set; }
        public bool? DropdownBankKas { get; set; }
        public int? IdAkunStokProduk { get; set; }
        public double? TotalDebitAkunStokProduk { get; set; }
        public double? TotalKreditAkunStokProduk { get; set; }
        public double? IdAkunPembelianJasa { get; set; }
        public double? TotalDebitPembelianJasa { get; set; }
        public double? TotalKreditPembelianJasa { get; set; }
        public int? IdAkunPembelianCustom { get; set; }
        public double? TotalDebitPembelianCustom { get; set; }
        public double? TotalKreditPembelianCustom { get; set; }
        public int? IdAkunPajakProduk { get; set; }
        public double? TotalDebitAkunPajakProduk { get; set; }
        public double? TotalKreditAkunPajakProduk { get; set; }
        public int? IdAkunPajakJasa { get; set; }
        public double? TotalDebitAkunPajakJasa { get; set; }
        public double? TotalKreditAkunPajakJasa { get; set; }
        public int? IdAkunTunaiPembelian { get; set; }
        public double? TotalDebitAkunTunaiPembelian { get; set; }
        public double? TotalKreditAkunTunaiPembelian { get; set; }
        public int? IdAkunHutangPembelian { get; set; }
        public double? TotalDebitAkunHutangPembelian { get; set; }
        public double? TotalKreditAkunHutangPembelian { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public double? TotalSebelumPajak { get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public bool? CheckboxManual { get; set; }
        public int? IdReferalPa { get; set; }
        public double? LunasUangMuka { get; set; }
        public double? SaldoPiutang { get; set; }
        public double? CicilanPerBulan { get; set; }
        public bool? Angsuran { get; set; }
        public DateTime? DueDate { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkuntansi { get; set; }
        public string RealRecordingTime { get; set; }
        public int? IdTransaksi { get; set; }
        public string KodeTransaksi { get; set; }
        public double? NoReturPembelian { get; set; }
        public int? IdVendor { get; set; }
        public string NamaVendor { get; set; }
        public string NoHp { get; set; }
        public string Email { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public string NoReferensiTransaksi { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public double? KursTukar { get; set; }
        public DateTime? TanggalReturPembelian { get; set; }
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
        public int? IdTermPembayaran { get; set; }
        public string TermPembayaran { get; set; }

    }
}
