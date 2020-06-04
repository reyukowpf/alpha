using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListProdukConfig : EntityTypeConfiguration<ListProduk>
    {
        public ListProdukConfig()
        {
            this.ToTable("list_produk");
            this.HasKey(m => m.IdListProduk);
            this.Property(m => m.IdListProduk)
                .HasColumnName("id_list_produk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdProduk)
              .HasColumnName("id_produk")
              .IsRequired();

            this.Property(m => m.Sku)
                .HasColumnName("sku")
                .HasMaxLength(100);

            this.Property(m => m.NamaProduk)
                .HasColumnName("nama_produk")
                .HasMaxLength(100);

            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang")
                .HasMaxLength(100);

            this.Property(m => m.JumlahStok)
                .HasColumnName("jumlah_stok");
                
            this.Property(m => m.SatuanDasar)
                .HasColumnName("satuan_dasar")
                .HasMaxLength(100);

            this.Property(m => m.HargaPokok)
               .HasColumnName("harga_pokok");

            this.Property(m => m.NilaiTotal)
               .HasColumnName("nilai_total");

        }
    }
}
