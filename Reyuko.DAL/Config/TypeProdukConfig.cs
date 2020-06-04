using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class TypeProdukConfig : EntityTypeConfiguration<TypeProduk>
    {
        public TypeProdukConfig()
        {
            this.ToTable("type_produk");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaTypeProduk)
                .HasColumnName("nama_type_produk")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdMataUang)
               .HasColumnName("id_mata_uang");

            this.Property(m => m.IdProdukKategori)
               .HasColumnName("id_produk_kategori");

            this.Property(m => m.ProdukKategori)
               .HasColumnName("produk_kategori");

            this.Property(m => m.HargaPokokOption)
               .HasColumnName("harga_pokok_option");

            this.Property(m => m.IdAkunHargaPokok)
               .HasColumnName("id_akun_harga_pokok");

            this.Property(m => m.PenjualanOption)
               .HasColumnName("penjualan_option");

            this.Property(m => m.IdAkunPenjualan)
               .HasColumnName("id_akun_penjualan");

            this.Property(m => m.PersediaanOption)
               .HasColumnName("persediaan_option");

            this.Property(m => m.IdAkunPersediaan)
               .HasColumnName("id_akun_persediaan");

            this.Property(m => m.PengirimanBeliOption)
               .HasColumnName("pengiriman_beli_option");

            this.Property(m => m.IdAkunPengirimanBeli)
               .HasColumnName("id_akun_pengiriman_beli");

            this.Property(m => m.PengirimanJualOption)
               .HasColumnName("pengiriman_jual_option");

            this.Property(m => m.IdAkunPengirimanJual)
               .HasColumnName("id_akun_pengiriman_jual");

            this.Property(m => m.ReturPenjualanOption)
               .HasColumnName("retur_penjualan_option");

            this.Property(m => m.IdAkunReturPenjualan)
               .HasColumnName("id_akun_retur_penjualan");

            this.Property(m => m.ServiceOption)
               .HasColumnName("service_option");

            this.Property(m => m.IdAkunService)
               .HasColumnName("id_akun_service");

            this.Property(m => m.UserId)
               .HasColumnName("user_id");
        }
    }
}
