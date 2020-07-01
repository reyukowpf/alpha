using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class TypeDokumenConfig : EntityTypeConfiguration<TypeDokumen>
    {
        public TypeDokumenConfig()
        {
            this.ToTable("type_dokumen");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Type)
                .HasColumnName("type_dokumen")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan")
                .HasMaxLength(255);

        }
    }
}
