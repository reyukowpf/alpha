using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class GrupProdukConfig : EntityTypeConfiguration<GrupProduk>
    {
        public GrupProdukConfig()
        {
            this.ToTable("grup_Produk");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaGrupProduk)
                .HasColumnName("nama_group_Produk")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.GrupSKU)
               .HasColumnName("grup_sku")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdKategoriProduk)
                .HasColumnName("id_kategori_produk")
                .IsRequired();

            this.Property(m => m.KategoriProduk)
                .HasColumnName("kategori_produk")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan")
                .HasMaxLength(255);

            this.Property(m => m.CheckboxDiskon)
                .HasColumnName("checkbox_diskon");

            this.Property(m => m.DiskonPersen)
                .HasColumnName("diskon_persen");

            this.Property(m => m.TanggalMulaiDiskon)
                .HasColumnName("tanggal_mulai_diskon");

            this.Property(m => m.TanggalAkhirDiskon)
                .HasColumnName("tanggal_akhir_diskon");

        }
    }
}
