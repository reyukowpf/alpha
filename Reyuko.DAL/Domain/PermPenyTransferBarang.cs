using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class PermPenyTransferBarang
    {
        public int IdPemPenydanTransferBarang { get; set; }
        public DateTime? RealRecordingTime { get; set; }
        public int? DropdownPemakaianTransferBarang { get; set; }
        public int? IdKodeTransaksi { get; set; }
        public int? IdReferalTransaksi { get; set; }
        public double? NoPemPenydanTransferBarang { get; set; }
        public int? IdNoReferensiDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public DateTime? Tanggal { get; set; }
        public string Keterangan { get; set; }
        public int? IdPetugas { get; set; }
        public string NamaPetugas { get; set; }
        public bool? CheckboxPosted { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public int? IdLokasiDari { get; set; }
        public string NamaDariLokasi { get; set; }
        public int? IdAkunDari { get; set; }
        public double? TotalDebitDari { get; set; }
        public double? TotalKreditDari { get; set; }
        public int? IdLokasiKe { get; set; }
        public string NamaKeLokasi { get; set; }
        public int? IdAkunKe { get; set; }
        public double? TotalDebitKe { get; set; }
        public double? TotalKreditKe { get; set; }
        public int? IdUserId { get; set; }
        public int? IdPeriodeAkuntansi { get; set; }

    }
}
