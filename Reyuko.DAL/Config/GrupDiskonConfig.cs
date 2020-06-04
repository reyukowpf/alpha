using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class GrupDiskonConfig : EntityTypeConfiguration<GrupDiskon>
    {
        public GrupDiskonConfig()
        {
            this.ToTable("grup_diskon");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaGroupDiskon)
                .HasColumnName("nama_group_diskon")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Diskon)
               .HasColumnName("diskon");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan")
                .HasMaxLength(255);

        }
    }
}
