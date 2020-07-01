using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderProductioninputConfig : EntityTypeConfiguration<OrderProductioninput>
    {
        public OrderProductioninputConfig()
        {
            this.ToTable("order_production_input");
            this.HasKey(m => m.IdOrderProduction);
            this.Property(m => m.IdOrderProduction)
                .HasColumnName("id_order_production")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");

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

            this.Property(m => m.IdSatuanDasar)
               .HasColumnName("id_satuan_dasar");

            this.Property(m => m.SatuanDasar)
                .HasColumnName("satuan_dasar");

            this.Property(m => m.HargaPokok)
                .HasColumnName("harga_pokok");

            this.Property(m => m.JumlahProduk)
                .HasColumnName("jumlah_produk");

            this.Property(m => m.TotalOrderProduk)
                .HasColumnName("total_order_produk");

            this.Property(m => m.IdAkunPersediaan)
                .HasColumnName("id_akun_persediaan");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.CheckboxAktif)
                .HasColumnName("Chekboxaktif");
        }
    }
}
