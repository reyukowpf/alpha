using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OptionAnnualConfig : EntityTypeConfiguration<OptionAnnual>
    {
        public OptionAnnualConfig()
        {
            this.ToTable("option_annual");
            this.HasKey(m => m.IdOptionAnnual);
            this.Property(m => m.IdOptionAnnual)
                .HasColumnName("id_option_annual")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Annual)
                .HasColumnName("annual")
                .HasMaxLength(100)
                .IsRequired();


        }
    }
}
