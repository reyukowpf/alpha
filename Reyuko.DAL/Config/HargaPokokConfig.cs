using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class HargaPokokConfig : EntityTypeConfiguration<HargaPokok>
    {
        public HargaPokokConfig()
        {
            this.ToTable("harga_pokok");
            this.HasKey(m => m.IdTipeHargaPokok);
            this.Property(m => m.IdTipeHargaPokok)
                .HasColumnName("id_tipe_harga_pokok")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.TipeHargaPokok)
                .HasColumnName("tipe_harga_pokok")
                .IsRequired();

        }
    }
}
