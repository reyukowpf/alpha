using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ShopingchartConfig : EntityTypeConfiguration<Shopingchart>
    {
        public ShopingchartConfig()
        {
            this.ToTable("shoping_cart");
            this.HasKey(m => m.IdPermintaanBarang);
            this.Property(m => m.IdPermintaanBarang)
                .HasColumnName("id_permintaan_barang")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.DurasiBerulang)
                .HasColumnName("durasi_berulang");

            this.Property(m => m.TanggalBerulang)
                .HasColumnName("tanggal_berulang");

            this.Property(m => m.Nilai)
                .HasColumnName("nilai");

            this.Property(m => m.IdUserId)
                .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntansi)
                .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");

            this.Property(m => m.CheckboxSelesai)
                .HasColumnName("checkbox_selesai");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.idTransaksi)
                .HasColumnName("id_transaksi");

            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi");

            this.Property(m => m.NoPermintaanBarang)
                .HasColumnName("no_permintaan_barang");

            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdEmployee)
                .HasColumnName("id_employee");

            this.Property(m => m.NamaManager)
                .HasColumnName("nama_manager");

            this.Property(m => m.Nohp)
                .HasColumnName("no_hp");

            this.Property(m => m.Email)
                .HasColumnName("email");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
                .HasColumnName("kurs_tukar");

            this.Property(m => m.TanggaldiBuat)
                .HasColumnName("tanggal_dibuat");

            this.Property(m => m.IdNoReferensiDokumen)
                .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumen)
                .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.TanggalDigunakan)
                .HasColumnName("tanggal_digunakan");

            this.Property(m => m.IdPetugas)
                .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");

            this.Property(m => m.CheckboxBerulang)
                .HasColumnName("checkbox_berulang");

            this.Property(m => m.IdOpsiAnnual)
               .HasColumnName("id_opsi_annual");

            this.Property(m => m.Annual)
                .HasColumnName("annual");
        }
    }
}
