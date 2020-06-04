using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class TypelistConfig : EntityTypeConfiguration<Typelist>
    {
        public TypelistConfig()
        {
            this.ToTable("type_list");
            this.HasKey(m => m.IdTypeList);
            this.Property(m => m.IdTypeList)
                .HasColumnName("id_type_list")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.TypesList)
                .HasColumnName("types_list")
                .HasMaxLength(100)
                .IsRequired();

            
        }
    }
}
