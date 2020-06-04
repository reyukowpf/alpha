using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class TypeKontakConfig : EntityTypeConfiguration<TypeKontak>
    {
        public TypeKontakConfig()
        {
            this.ToTable("type_kontak");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Type)
                .HasColumnName("type_kontak")
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
