using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DataMataUangConfig : EntityTypeConfiguration<DataMataUang>
    {
        public DataMataUangConfig()
        {
            this.ToTable("data_mata_uang");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.CheckBoxAktif)
                .HasColumnName("checkbox_aktif");

            this.Property(m => m.NamaMataUang)
                .HasColumnName("nama_mata_uang")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.KodeMataUang)
                .HasColumnName("kode_mata_uang")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.SimbolMataUang)
                .HasColumnName("simbol_mata_uang")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.TglKursMataUang)
               .HasColumnName("tgl_kurs_mata_uang");

            this.Property(m => m.KursTukar)
               .HasColumnName("Kurs_Tukar");

            this.Property(m => m.DefaultDataMataUang)
                .HasColumnName("default_data_mata_uang");

            this.Property(m => m.IdDefaultMataUang)
                .HasColumnName("id_default_mata_uang");
        }
    }
}
