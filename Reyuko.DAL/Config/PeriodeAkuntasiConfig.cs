using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class PeriodeAkuntansiConfig : EntityTypeConfiguration<PeriodeAkuntansi>
    {
        public PeriodeAkuntansiConfig()
        {
            this.ToTable("periode_akuntansi");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.TahunBukuAwal)
                .HasColumnName("tahun_buku_awal")
                .IsRequired();

            this.Property(m => m.TahunBukuAkhir)
                .HasColumnName("tahun_buku_akhir")
                .IsRequired();

            this.Property(m => m.CheckboxAktif)
                .HasColumnName("checkbox_aktif");
        }
    }
}
