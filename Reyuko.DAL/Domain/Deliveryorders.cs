using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Deliveryorders
    {
        public int Id { get; set; }
        public int? IdKodeTransaksi{ get; set; }
        public int? IdTransaksi{ get; set; }
        public string KodeTransaksi{ get; set; }
        public string NoDo{ get; set; }
        public int? IdPelanggan{ get; set; }
        public string NamePelanggan{ get; set; }
        public string NoHp{ get; set; }
        public string Email{ get; set; }
        public int? IdOrderPenjualan{ get; set; }
        public double? NomorOrderPenjualan{ get; set; }
        public int? IdReferalTransaksi{ get; set; }
        public int? IdMaatUang{ get; set; }
        public string MaatUang{ get; set; }
        public double? KursTukar{ get; set; }
        public DateTime? TanggalDo{ get; set; }
        public int? IdNoReferansiDokumen{ get; set; }
        public string NoReferansiDokumen{ get; set; }
        public int? IdLokasi{ get; set; }
        public string NameLokasi{ get; set; }
        public string Keterangan{ get; set; }
        public int? IdProyek{ get; set; }
        public int? IdDepartemen{ get; set; }
        public bool? CheckboxInclusivePajak{ get; set; }
        public DateTime? TanggalPengiriman{ get; set; }
        public int? IdPetugas{ get; set; }
        public string NamePetugas{ get; set; }
        public bool? CheckboxUnposted{ get; set; }
        public bool? CheckboxBerulang{ get; set; }
        public bool? DropdownBerulang{ get; set; }
        public double? DurationBerulang{ get; set; }
        public DateTime? TanggalBerulang{ get; set; }
        public int? IdAkunPersediaanProduk{ get; set; }
        public double? TotalDebitAkunPersediaanProduk{ get; set; }
        public double? TotalKreditAkunPersediaanProduk{ get; set; }
        public int? IdAkunPengirimanJualProduk{ get; set; }
        public double? TotalDebitAkunPengirimanJualProduk{ get; set; }
        public double? TotalKreditAkunPengirimanJualProduk{ get; set; }
        public double? TotalSebelumPajak{ get; set; }
        public double? TotalPajak { get; set; }
        public double? TotalSetelahPajak { get; set; }
        public double? SaldoTerhutang { get; set; }
        public double? CicilanPerBulan { get; set; }
        public double? DurasiCicilan { get; set; }
        public DateTime? DueDate{ get; set; }
        public int? IdUserId{ get; set; }
        public int? IdPeriodeAkuntansi{ get; set; }
        public string RealRecordingTime { get; set; }
        public int? IdOpsiAnnual{ get; set; }
        public string Annual { get; set; }

    }
}
