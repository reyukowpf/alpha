using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class KursMataUangConfig : EntityTypeConfiguration<KursMataUang>
    {
        public KursMataUangConfig()
        {
            this.ToTable("kurs_mata_uang");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdDataMataUang)
                .HasColumnName("id_mata_Uang")
                .IsRequired();

            this.Property(m => m.KodeMataUang)
                .HasColumnName("kode_mata_uang")
                .HasMaxLength(100);

            this.Property(m => m.Tanggal)
               .HasColumnName("tanggal");

            this.Property(m => m.Exrate)
               .HasColumnName("exrate");

        }
    }
}
