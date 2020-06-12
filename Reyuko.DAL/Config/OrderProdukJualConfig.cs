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

            this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");

            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.IdProduk)
                .HasColumnName("id_produk");

            this.Property(m => m.ProdukKategori)
                .HasColumnName("produk_kategori");

            this.Property(m => m.Sku)
                .HasColumnName("sku");

            this.Property(m => m.NamaProduk)
                .HasColumnName("nama_produk");

            this.Property(m => m.SatuanDasar)
                .HasColumnName("satuan_dasar");

            this.Property(m => m.DiskonProduk)
                .HasColumnName("diskon_produk");

            this.Property(m => m.HargaJual)
                .HasColumnName("harga_jual");

            this.Property(m => m.HargaPokok)
                .HasColumnName("harga_pokok");

            this.Property(m => m.JumlahProduk)
                .HasColumnName("jumlah_produk");

            this.Property(m => m.SalesBalance)
                .HasColumnName("sales_balance");

            this.Property(m => m.TotalOrderProduk)
                .HasColumnName("total_order_produk");

            this.Property(m => m.IdPajak)
                .HasColumnName("id_pajak");

            this.Property(m => m.Pajak)
                .HasColumnName("pajak");

            this.Property(m => m.Persentase)
                .HasColumnName("persentase");

            this.Property(m => m.TotalPajak)
                .HasColumnName("total_pajak");

            this.Property(m => m.IdAkunPajakJual)
                .HasColumnName("id_akun_pajak_jual");

            this.Property(m => m.IdTypeProduk)
                .HasColumnName("id_type_produk");

            this.Property(m => m.TypeProduk)
                .HasColumnName("type_produk");

            this.Property(m => m.IdAkunHargaPokok)
                .HasColumnName("id_akun_harga_pokok");

            this.Property(m => m.IdAkunPenjualan)
                .HasColumnName("id_akun_penjualan");

            this.Property(m => m.IdAkunPersediaan)
                .HasColumnName("id_akun_persediaan");

            this.Property(m => m.IdAkunPengirimanJual)
                .HasColumnName("id_akun_pengiriman_jual");

            this.Property(m => m.IdAkunReturPenjualan)
                .HasColumnName("id_akun_retur_penjualan");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek_produk");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen_produk");

            this.Property(m => m.IdAsset)
                .HasColumnName("id_asset");

            this.Property(m => m.NamaAsset)
                .HasColumnName("nama_asset");

            this.Property(m => m.TanggalPengiriman)
                .HasColumnName("tanggal_pengiriman");

            this.Property(m => m.Checkbokaktif)
               .HasColumnName("Checkboxaktif");

        }
    }
}
