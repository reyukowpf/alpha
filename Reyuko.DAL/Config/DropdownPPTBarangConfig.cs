using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DropdownPPTBarangConfig : EntityTypeConfiguration<DropdownPPTBarang>
    {
        public DropdownPPTBarangConfig()
        {
            this.ToTable("dropdownppt_barang");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Action)
                .HasColumnName("action")
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
