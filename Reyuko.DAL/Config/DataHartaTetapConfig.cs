using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DataHartaTetapConfig : EntityTypeConfiguration<DataHartaTetap>
    {
        public DataHartaTetapConfig()
        {
            this.ToTable("data_harta_tetap");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdDepartment)
                .HasColumnName("id_departemen")
                .IsRequired();

            this.Property(m => m.Checkboxawalmingguke3)
                .HasColumnName("checkbox_awalmingguke3");

            this.Property(m => m.AkumulasiBeban)
                .HasColumnName("akumulasi_beban");
        
            this.Property(m => m.BebanPertahunini)
                .HasColumnName("beban_per_tahun_ini");

            this.Property(m => m.TerhitungTanggal)
                .HasColumnName("terhitung_tanggal");

            this.Property(m => m.NilaiBuku)
                .HasColumnName("nilai_buku");

            this.Property(m => m.BebanPerBulan)
                .HasColumnName("beban_perbulan");

            this.Property(m => m.checkboxincludedonserviceassignment)
                .HasColumnName("checkbox_included_on_service_assignment");

            this.Property(m => m.IdAkunAsset)
                .HasColumnName("id_akun_asset");

            this.Property(m => m.KodeRekeningAsset)
                .HasColumnName("kode_rekening_asset");

            this.Property(m => m.IdAkunDepresiasi)
                .HasColumnName("id_akun_depresiasi");

            this.Property(m => m.KodeRekeningDepresiasi)
                .HasColumnName("kode_rekening_depresiasi");

            this.Property(m => m.IdPeriodeAkutansi)
                .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.UploadPhoto)
                .HasColumnName("upload_photo");

	        this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

	        this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");

	        this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi");

	        this.Property(m => m.NoTransaksi)
                .HasColumnName("no_transaksi");

	        this.Property(m => m.NoHartaTetap)
                .HasColumnName("no_harta_tetap");

	        this.Property(m => m.NamaHartaTetap)
                .HasColumnName("nama_harta_tetap");

	        this.Property(m => m.IdKelompokHartaTetap)
                .HasColumnName("id_kelompok_harta_tetap");

	        this.Property(m => m.NamaKelompokHartaTetap)
                .HasColumnName("nama_kelompok_harta_tetap");

	        this.Property(m => m.TanggalBeli)
                .HasColumnName("tanggal_beli");

	        this.Property(m => m.TanggalEntry)
                .HasColumnName("tanggal_entry");

	        this.Property(m => m.TanggalPenghitung)
                .HasColumnName("tanggal_penghitung");

	        this.Property(m => m.JumlahHari)
                .HasColumnName("jumlah_hari");

	        this.Property(m => m.TahunDepresiasi)
                .HasColumnName("tahun_depresiasi");

	        this.Property(m => m.BulanDepresiasi)
                .HasColumnName("bulan_depresiasi");

	        this.Property(m => m.HargaBeli)
                .HasColumnName("harga_beli");

	        this.Property(m => m.NilaiResidu)
                .HasColumnName("nilai_residu");

	        this.Property(m => m.UmurEkonimis)
                .HasColumnName("umur_ekonomis");

	        this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

	        this.Property(m => m.Lokasi)
                .HasColumnName("lokasi");

	        this.Property(m => m.IdPeroleh)
                .HasColumnName("id_peroleh");

	        this.Property(m => m.Diperoleh)
                .HasColumnName("diperoleh");

	        this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

	        this.Property(m => m.Vendor)
                .HasColumnName("vendor");

	        this.Property(m => m.IdAkun)
                .HasColumnName("id_akun");

	        this.Property(m => m.NamaAkun)
                .HasColumnName("nama_akun");

            this.Property(m => m.IdAkunAkumulasiDepresiasi)
                 .HasColumnName("id_akun_akumulasi_depresiasi");

            this.Property(m => m.KodeRekeningAkumulasiDepresiasi)
                .HasColumnName("kode_rekening_akumulasi_depresiasi");
        }
    }
}
