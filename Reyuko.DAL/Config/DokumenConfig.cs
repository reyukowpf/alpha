using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DokumenConfig : EntityTypeConfiguration<Dokumen>
    {
        public DokumenConfig()
        {
            this.ToTable("dokumen");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTypeDokumen)
                .HasColumnName("id_type_dokumen");

            this.Property(m => m.TypeDokumen)
                .HasColumnName("type_dokumen")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NoReferensiDokumen)
                .HasColumnName("no_referensi_dokumen")
                .HasMaxLength(100);

            this.Property(m => m.TanggalDokumen)
                .HasColumnName("tanggal_dokumen");
                
            this.Property(m => m.IdKontak)
               .HasColumnName("id_kontak");

            this.Property(m => m.PelangganDokumen)
               .HasColumnName("pelanggan_dokumen")
               .HasMaxLength(100);

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartmen)
                .HasColumnName("id_departemen");

            this.Property(m => m.KeteranganDokumen)
             .HasColumnName("keterangan_dokumen")
             .HasMaxLength(100);

            this.Property(m => m.UploadFile1)
             .HasColumnName("upload_file1");

            this.Property(m => m.UploadFile2)
             .HasColumnName("upload_file2");

            this.Property(m => m.UploadFile3)
             .HasColumnName("upload_file3");

            this.Property(m => m.UploadFile4)
             .HasColumnName("upload_file4");
        }
    }
}
