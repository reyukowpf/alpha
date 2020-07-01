using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderInventoriConfig : EntityTypeConfiguration<OrderInventori>
    {
        public OrderInventoriConfig()
        {
            this.ToTable("order_inventori");
            this.HasKey(m => m.IdOrderInventori);
            this.Property(m => m.IdOrderInventori)
                .HasColumnName("id_order_inventori")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.TotalJual)
                .HasColumnName("total_jual");

            this.Property(m => m.IdPajak)
                .HasColumnName("id_pajak");

            this.Property(m => m.Pajak)
                .HasColumnName("pajak");

            this.Property(m => m.PersentasePajak)
                .HasColumnName("persentase_pajak");

            this.Property(m => m.IdNoReferensiDokumen)
                .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumen)
                .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.TanggalMasuk)
                .HasColumnName("tanggal_masuk");

            this.Property(m => m.TanggalKeluarTerjual)
                .HasColumnName("tanggal_keluar_terjual");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_lokasi");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.IdProduk)
                .HasColumnName("id_produk");

            this.Property(m => m.Sku)
                .HasColumnName("sku");

            this.Property(m => m.NamaProduk)
                .HasColumnName("nama_produk");

            this.Property(m => m.SatuanDasar)
                .HasColumnName("satuan_dasar");

            this.Property(m => m.Masuk)
                .HasColumnName("masuk");

            this.Property(m => m.Keluar)
                .HasColumnName("keluar");

            this.Property(m => m.Terjual)
                .HasColumnName("terjual");

            this.Property(m => m.SaldoItem)
                .HasColumnName("saldo_item");

            this.Property(m => m.HargaBeli)
                .HasColumnName("harga_beli");

            this.Property(m => m.HargaPokok)
                .HasColumnName("harga_pokok");

            this.Property(m => m.HargaJual)
                .HasColumnName("harga_jual");

            this.Property(m => m.TotalBeli)
               .HasColumnName("total_beli");

            this.Property(m => m.Diskon)
               .HasColumnName("diskon");

            this.Property(m => m.TotalPajak)
               .HasColumnName("total_pajak");

            this.Property(m => m.CheckboxAktif)
                .HasColumnName("Checkboxaktif");
        }
    }
}
