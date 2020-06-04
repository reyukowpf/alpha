using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class RekeningAnggaranConfig : EntityTypeConfiguration<RekeningAnggaran>
    {
        public RekeningAnggaranConfig()
        {
            this.ToTable("rekening_anggaran");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NomorAnggaran)
                .HasColumnName("no_anggaran")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdRekeningPerkiraan)
                .HasColumnName("id_rekening_perkiraan")
                .IsRequired();

            this.Property(m => m.NamaAkun)
                .HasColumnName("nama_akun")
                .HasMaxLength(100);

            this.Property(m => m.Kode)
                .HasColumnName("kode")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Deskripsi)
                .HasColumnName("deskripsi");

            this.Property(m => m.Anggaran)
                .HasColumnName("anggaran");

            this.Property(m => m.Idproyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.TanggalAwal)
                .HasColumnName("tanggal_awal");

            this.Property(m => m.TanggalAkhir)
                .HasColumnName("tanggal_akhir");

            this.Property(m => m.IdPeriodeAkutansi)
                .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.UserID)
                .HasColumnName("user_id");

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_record_time");
        }
    }
}
