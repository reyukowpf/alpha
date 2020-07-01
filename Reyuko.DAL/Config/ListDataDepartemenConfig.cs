using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListDataDepartemenConfig : EntityTypeConfiguration<ListDataDepartemen>
    {
        public ListDataDepartemenConfig()
        {
            this.ToTable("list_data_departemen");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdDepartemen)
              .HasColumnName("id_departemen")
              .IsRequired();

            this.Property(m => m.NamaDepartemen)
                .HasColumnName("nama_departemen")
                .HasMaxLength(100);

            this.Property(m => m.PenanggungJawab)
                .HasColumnName("penanggung_jawab");

        }
    }
}
