using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListLokasiConfig : EntityTypeConfiguration<ListLokasi>
    {
        public ListLokasiConfig()
        {
            this.ToTable("list_lokasi");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdLokasi)
              .HasColumnName("id_lokasi")
              .IsRequired();

            this.Property(m => m.NamaTempatLokasi)
                .HasColumnName("nama_tempat_lokasi")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.AlamatLokasi)
                .HasColumnName("alamat_lokasi")
                .HasMaxLength(255);

            this.Property(m => m.KotaLokasi)
                .HasColumnName("kota_lokasi")
                .HasMaxLength(100);

            this.Property(m => m.NegaraLokasi)
                .HasColumnName("negara_lokasi")
                .HasMaxLength(100);


        }
    }
}
