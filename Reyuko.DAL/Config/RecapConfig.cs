using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class RecapConfig : EntityTypeConfiguration<Recap>
    {
        public RecapConfig()
        {
            this.ToTable("recap");
            this.HasKey(m => m.IdRecap);
            this.Property(m => m.IdRecap)
                .HasColumnName("id_recap")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Recaps)
                .HasColumnName("recaps")
                .HasMaxLength(100)
                .IsRequired();

            
        }
    }
}
