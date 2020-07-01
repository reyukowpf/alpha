using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderCustomBeliConfig : EntityTypeConfiguration<OrderCustomBeli>
    {
        public OrderCustomBeliConfig()
        {
            this.ToTable("order_custom_beli");
            this.HasKey(m => m.IdOrderCustom);
            this.Property(m => m.IdOrderCustom)
                .HasColumnName("id_order_custom")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTransaksi)
     .HasColumnName("id_transaksi");

            this.Property(m => m.IdReferralTransaksi)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.NamaCustom)
                .HasColumnName("nama_custom");

            this.Property(m => m.DiskonCustom)
                .HasColumnName("diskon_custom");

            this.Property(m => m.HargaCustom)
                .HasColumnName("harga_custom");

            this.Property(m => m.JumlahCustom)
                .HasColumnName("jumlah_custom");

            this.Property(m => m.TotalCustom)
                .HasColumnName("total_custom");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.Checkboxaktif)
                .HasColumnName("checkboxaktif");
        }
    }
}
