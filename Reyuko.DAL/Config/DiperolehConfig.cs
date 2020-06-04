using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DiperolehConfig : EntityTypeConfiguration<Diperoleh>
    {
        public DiperolehConfig()
        {
            this.ToTable("diperoleh");
            this.HasKey(m => m.IdDiperoleh);
            this.Property(m => m.IdDiperoleh)
                .HasColumnName("id_diperoleh")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.diperoleh)
                .HasColumnName("diperoleh")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Status)
             .HasColumnName("status");

            this.Property(m => m.Keterangan)
             .HasColumnName("keterangan");


        }
    }
}
