using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class GolonganKontakConfig : EntityTypeConfiguration<GolonganKontak>
    {
        public GolonganKontakConfig()
        {
            this.ToTable("golongan_kontak");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaGolongan)
                .HasColumnName("nama_golongan")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.GajiPokok)
               .HasColumnName("gaji_pokok");

            this.Property(m => m.Tunjangan)
                .HasColumnName("tunjangan");

            this.Property(m => m.OvertimeHour)
                .HasColumnName("overtime_hour");

            this.Property(m => m.IncludeExcludePajak)
                .HasColumnName("include_exclude_pajak");

        }
    }
}
