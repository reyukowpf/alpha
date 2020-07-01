using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListKontakConfig : EntityTypeConfiguration<ListKontak>
    {
        public ListKontakConfig()
        {
            this.ToTable("list_kontak");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak")
                .IsRequired();

            this.Property(m => m.TypeKontak)
                .HasColumnName("type_kontak")
                .HasMaxLength(100);

            this.Property(m => m.KlasifikasiKontak)
                .HasColumnName("klasifikasi_kontak")
                .IsRequired();          

            this.Property(m => m.NamaA)
                .HasColumnName("nama_a")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NoHPA)
                .HasColumnName("no_hp_a")
                .HasMaxLength(100);

            this.Property(m => m.EmailA)
                .HasColumnName("email_a")
                .HasMaxLength(100);

            this.Property(m => m.NegaraA)
                .HasColumnName("negara_a")
                .HasMaxLength(100);

            this.Property(m => m.AlamatA)
                .HasColumnName("alamat_a")
                .HasMaxLength(255);

            this.Property(m => m.KotaA)
                .HasColumnName("kota_a")
                .HasMaxLength(100);

        }
    }
}
