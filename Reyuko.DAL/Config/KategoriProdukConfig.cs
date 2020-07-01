using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class KategoriProdukConfig : EntityTypeConfiguration<KategoriProduk>
    {
        public KategoriProdukConfig()
        {
            this.ToTable("kategori_produk");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.ProdukKategori)
                .HasColumnName("produk_kategori")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdProdukKategoriParent)
                .HasColumnName("id_produk_kategori_parent");

            this.Property(m => m.ProdukKategoriParent)
               .HasColumnName("produk_kategori_parent")
               .HasMaxLength(100);

            this.Property(m => m.deskripsi)
                .HasColumnName("deskripsi")
                .HasMaxLength(255);

        }
    }
}
