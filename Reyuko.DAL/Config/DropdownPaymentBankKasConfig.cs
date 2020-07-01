using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DropdownBankKasConfig : EntityTypeConfiguration<DropdownBankKas>
    {
        public DropdownBankKasConfig()
        {
            this.ToTable("dropdown_bank_kas");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.DropdownBankkas)
                .HasColumnName("dropdown_bank_kas")
                .HasMaxLength(100);

        }
    }
}
