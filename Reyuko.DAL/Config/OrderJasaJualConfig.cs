using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderJasaJualConfig : EntityTypeConfiguration<OrderJasaJual>
    {
        public OrderJasaJualConfig()
        {
            this.ToTable("order_jasa_jual");
            this.HasKey(m => m.IdOrderJasa);
            this.Property(m => m.IdOrderJasa)
                .HasColumnName("id_order_jasa")
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
                .HasColumnName("nama_jasa");
         
            this.Property(m => m.DiskonJasa)
                .HasColumnName("diskon_jasa");

            this.Property(m => m.HargaJasa)
                .HasColumnName("harga_jasa");

            this.Property(m => m.JumlahJasa)
                .HasColumnName("jumlah_jasa");

            this.Property(m => m.TotalOrderJasa)
                .HasColumnName("total_order_jasa");

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

            this.Property(m => m.AkunJasa)
                .HasColumnName("akun_jasa");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.IdAsset)
                .HasColumnName("id_asset");

            this.Property(m => m.NamaAsset)
                .HasColumnName("nama_asset");

            this.Property(m => m.TanggalStartdate)
                .HasColumnName("delivery_start_date");

            this.Property(m => m.Checkbokaktif)
               .HasColumnName("checkboxaktif");

        }
    }
}
