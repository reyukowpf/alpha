using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListOrderProductionConfig : EntityTypeConfiguration<ListOrderProduction>
    {
        public ListOrderProductionConfig()
        {
            this.ToTable("list_order_production");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdOrder)
                .HasColumnName("id_order_production");

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

            this.Property(m => m.Jumlah)
                .HasColumnName("jumlah");

            this.Property(m => m.TotalOrder)
                .HasColumnName("total_order");

            this.Property(m => m.IdAkunPersediaan)
                .HasColumnName("id_akun_persediaan");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.IdAkunCustom)
                .HasColumnName("id_akun_custom");

            this.Property(m => m.AkunCustom)
                .HasColumnName("akun_custom");

            this.Property(m => m.CheckboxAktif)
                .HasColumnName("Chekboxaktif");
        }
    }
}
