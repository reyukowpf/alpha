using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class KlasifikasiAkunConfig : EntityTypeConfiguration<KlasifikasiAkun>
    {
        public KlasifikasiAkunConfig()
        {
            this.ToTable("klasifikasi_akun");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.KategoriKA)
                .HasColumnName("kategori_ka")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdParentKategoriKA)
                .HasColumnName("id_parent_kategori_ka");

            this.Property(m => m.AkunLevel)
                .HasColumnName("akun_level");

            this.Property(m => m.Kode)
                .HasColumnName("kode")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.CheckboxLock)
                .HasColumnName("checkbox_lock");

            this.Property(m => m.LabaRugi)
                .HasColumnName("laba_rugi");

        }
    }
}
