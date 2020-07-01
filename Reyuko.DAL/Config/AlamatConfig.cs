using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class AlamatConfig : EntityTypeConfiguration<Alamat>
    {
        public AlamatConfig()
        {
            this.ToTable("alamat");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Type)
                .HasColumnName("type")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Kode)
                .HasColumnName("kode")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Nama)
                .HasColumnName("Nama")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdParent)
                .HasColumnName("id_parent");


        }
    }
}
