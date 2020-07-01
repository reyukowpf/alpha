using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class NamaPenyusutanConfig : EntityTypeConfiguration<NamaPenyusutan>
    {
        public NamaPenyusutanConfig()
        {
            this.ToTable("nama_penyusutan");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Nama)
                .HasColumnName("nama_penyusutan")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Formula)
                .HasColumnName("formula")
                .HasMaxLength(255);

        }
    }
}
