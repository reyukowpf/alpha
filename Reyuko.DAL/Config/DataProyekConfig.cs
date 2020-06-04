using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DataProyekConfig : EntityTypeConfiguration<DataProyek>
    {
        public DataProyekConfig()
        {
            this.ToTable("data_proyek");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NomorProyek)
                .HasColumnName("nomor_proyek")
                .IsRequired();

            this.Property(m => m.NamaProyek)
               .HasColumnName("nama_proyek")
               .HasMaxLength(100)
               .IsRequired();

            this.Property(m => m.IdKontakPemesan)
               .HasColumnName("id_kontak_pemesan");

            this.Property(m => m.PemesanKontak)
               .HasColumnName("pemesan_kontak");

            this.Property(m => m.IdKontakPIC)
               .HasColumnName("id_kontak_pic");

            this.Property(m => m.PICKontak)
               .HasColumnName("pic_kontak");

            this.Property(m => m.IdMataUang)
               .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
               .HasColumnName("mata_uang");

            this.Property(m => m.NilaiProyek)
               .HasColumnName("nilai_proyek");

            this.Property(m => m.TanggalMulai)
               .HasColumnName("tanggal_mulai");

            this.Property(m => m.TanggalBerakhir)
               .HasColumnName("tanggal_berakhir");

            this.Property(m => m.idStatus)
                .HasColumnName("id_status");

            this.Property(m => m.Status)
               .HasColumnName("status");

            this.Property(m => m.Keterangan)
               .HasColumnName("keterangan");

            this.Property(m => m.CheckboxInAtive)
               .HasColumnName("checkbox_inactive");


        }
    }
}
