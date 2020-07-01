using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class DataHartaTetap
    {

        public int Id { get; set; }
        public int? IdDepartment { get; set; }
        public bool? Checkboxawalmingguke3 { get; set; }
        public int? AkumulasiBeban {get;set;}
        public int? BebanPertahunini { get; set; }
        public DateTime? TerhitungTanggal { get; set; }
        public int? NilaiBuku { get; set; }
        public int? BebanPerBulan { get; set; }
        public bool? checkboxincludedonserviceassignment { get; set; }
        public int? IdAkunAsset { get; set; }
        public string KodeRekeningAsset { get; set; }
        public int? IdAkunDepresiasi { get; set; }
        public string KodeRekeningDepresiasi { get; set; }
        public int? IdPeriodeAkutansi { get; set; }
	    public string UploadPhoto { get; set; }
	    public int? IdKodeTransaksi { get; set; }
	    public int? IdTransaksi { get; set; }
	    public string KodeTransaksi { get; set; }
	    public double? NoTransaksi { get; set; }
	    public double? NoHartaTetap { get; set; }
	    public string NamaHartaTetap { get; set; }
	    public int? IdKelompokHartaTetap { get; set; }
	    public string NamaKelompokHartaTetap { get; set; }
	    public DateTime? TanggalBeli { get; set; }
	    public DateTime? TanggalEntry { get; set; }
        public DateTime? TanggalPenghitung { get; set; }
	    public double? JumlahHari { get; set; }
	    public int? TahunDepresiasi { get; set; }
	    public int? BulanDepresiasi { get; set; }
	    public double? HargaBeli { get; set; }
	    public int? NilaiResidu { get; set; }
	    public int? UmurEkonimis { get; set; }
	    public int? IdLokasi { get; set; }
	    public string Lokasi { get; set; }
	    public int? IdPeroleh { get; set; }
	    public string Diperoleh { get; set; }
	    public int? IdKontak { get; set; }
	    public string Vendor { get; set; }
	    public int? IdAkun { get; set; }
	    public string NamaAkun { get; set; }
        public int? IdAkunAkumulasiDepresiasi { get; set; }
        public string KodeRekeningAkumulasiDepresiasi { get; set; }
    }
}
