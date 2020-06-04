using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListDataMataUangConfig : EntityTypeConfiguration<ListDataMataUang>
    {
        public ListDataMataUangConfig()
        {
            this.ToTable("list_data_mata_uang");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdDataMataUang)
                .HasColumnName("id_data_mata_uang")
                .IsRequired();

            this.Property(m => m.NamaMataUang)
                .HasColumnName("nama_mata_uang")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.KodeMataUang)
                .HasColumnName("kode_mata_uang")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.TglKursMataUang)
               .HasColumnName("tgl_kurs_mata_uang");

            this.Property(m => m.KursTukar)
               .HasColumnName("Kurs_Tukar");

        }
    }
}
