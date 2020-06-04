using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderFinishedprodukConfig : EntityTypeConfiguration<OrderFinishedproduk>
    {
        public OrderFinishedprodukConfig()
        {
            this.ToTable("order_finished_produk");
            this.HasKey(m => m.IdOrderFinishProduk);
            this.Property(m => m.IdOrderFinishProduk)
                .HasColumnName("id_order_finish_produk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdProduction)
                .HasColumnName("id_production");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.IdProduk)
                .HasColumnName("id_produk");

            this.Property(m => m.Sku)
                .HasColumnName("sku");

            this.Property(m => m.NamaProduk)
                .HasColumnName("nama_produk");

            this.Property(m => m.SatuanDasar)
                .HasColumnName("satuan_dasar");

            this.Property(m => m.TotalProduk)
                .HasColumnName("total_produk");

            this.Property(m => m.HargaProduk)
                .HasColumnName("harga_produk");

            this.Property(m => m.TotalBiaya)
                .HasColumnName("total_biaya");

            this.Property(m => m.IdAkunPersediaan)
                .HasColumnName("id_akun_persediaan");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.CheckboxAktif)
                .HasColumnName("Checkboxaktif");
        }
    }
}
