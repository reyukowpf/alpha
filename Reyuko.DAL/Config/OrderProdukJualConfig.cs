using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderProdukJualConfig : EntityTypeConfiguration<OrderProdukJual>
    {
        public OrderProdukJualConfig()
        {
            this.ToTable("order_produk_jual");
            this.HasKey(m => m.IdOrderProdukJual);
            this.Property(m => m.IdOrderProdukJual)
                .HasColumnName("id_order_produk_jual")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_akun_stok");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_akun_pengiriman_jual");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_akun_retur_penjualan");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_proyek_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_departemen_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_asset");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("nama_asset");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("tanggal_pengiriman");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_form");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("tanggal");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_lokasi");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("produk_kategori");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("sku");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("nama_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("satuan_dasar");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("diskon_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("harga_jual");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("harga_pokok");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("jumlah_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("sales_balance");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("total_order_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_pajak");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("pajak");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("persentase");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("total_pajak");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_akun_pajak_jual");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_type_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("type_produk");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_akun_harga_pokok");

            this.Property(m => m.IdProyekProduk)
                .HasColumnName("id_akun_penjualan");

        }
    }
}
