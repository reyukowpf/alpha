using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderProductioncustomConfig : EntityTypeConfiguration<OrderProductioncustom>
    {
        public OrderProductioncustomConfig()
        {
            this.ToTable("order_production_custom");
            this.HasKey(m => m.IdOrderProductionCustom);
            this.Property(m => m.IdOrderProductionCustom)
                .HasColumnName("id_production_custom")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdProduction)
                .HasColumnName("id_production");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.NamaCustom)
                .HasColumnName("nama_custom");

            this.Property(m => m.TotalCustom)
                .HasColumnName("total_custom");

            this.Property(m => m.JumlahCustom)
                .HasColumnName("jumlah_custom");

            this.Property(m => m.SatuanCustom)
                .HasColumnName("satuan_custom");

            this.Property(m => m.HargaCustom)
                .HasColumnName("harga_custom");

            this.Property(m => m.AkunCustom)
                .HasColumnName("akun_custom");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.CheckboxAktif)
                .HasColumnName("Chekboxaktif");
        }
    }
}
