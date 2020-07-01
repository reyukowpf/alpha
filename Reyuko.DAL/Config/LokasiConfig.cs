using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class LokasiConfig : EntityTypeConfiguration<Lokasi>
    {
        public LokasiConfig()
        {
            this.ToTable("lokasi");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaTempatLokasi)
                .HasColumnName("nama_tempat_lokasi")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NoTelpLokasi)
                .HasColumnName("no_telp_lokasi")
                .HasMaxLength(100);

            this.Property(m => m.EmailLokasi)
                .HasColumnName("email_lokasi")
                .HasMaxLength(100);

            this.Property(m => m.IdNegara)
                .HasColumnName("id_negara");

            this.Property(m => m.NamaNegara)
                .HasColumnName("nama_negara")
                .HasMaxLength(100);

            this.Property(m => m.AlamatLokasi)
                .HasColumnName("alamat_lokasi")
                .HasMaxLength(255);

            this.Property(m => m.KotaLokasi)
                .HasColumnName("kota_lokasi")
                .HasMaxLength(100);

            this.Property(m => m.IdPropinsi)
                .HasColumnName("id_propinsi");

            this.Property(m => m.PropinsiLokasi)
                .HasColumnName("propinsi_lokasi")
                .HasMaxLength(100);

            this.Property(m => m.KodePosLokasi)
                .HasColumnName("kode_pos_lokasi");
              
            this.Property(m => m.MapLocationLokasi)
                .HasColumnName("map_location_lokasi")
                .HasMaxLength(255);

            this.Property(m => m.CheckboxDefault)
                .HasColumnName("checkbox_default");

            this.Property(m => m.CheckboxNotActive)
                .HasColumnName("checkbox_not_active");


        }
    }
}
