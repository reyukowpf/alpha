using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderJasaBeliConfig : EntityTypeConfiguration<OrderJasaBeli>
    {
        public OrderJasaBeliConfig()
        {
            this.ToTable("order_jasa_beli");
            this.HasKey(m => m.IdOrderJasa);
            this.Property(m => m.IdOrderJasa)
                .HasColumnName("id_order_jasa")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTransaksi)
                 .HasColumnName("id_transaksi");

            this.Property(m => m.IdReferralTransaksi)
                .HasColumnName("id_referral_transaksi");

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

            this.Property(m => m.NamaJasa)
                .HasColumnName("nama_jasa");

            this.Property(m => m.TotalJasa)
                .HasColumnName("total_jasa");

            this.Property(m => m.DiskonJasa)
                .HasColumnName("diskon_jasa");

            this.Property(m => m.HargaJasa)
                .HasColumnName("harga_jasa");

            this.Property(m => m.TotalOrderJasa)
                .HasColumnName("total_order_jasa");

            this.Property(m => m.IdPajak)
                .HasColumnName("id_pajak");

            this.Property(m => m.NamaPajak)
                .HasColumnName("pajak");

            this.Property(m => m.PersentasePajak)
                .HasColumnName("persentase");

            this.Property(m => m.TotalPajakJasa)
                .HasColumnName("total_pajak_jasa");

            this.Property(m => m.IdAkunPajakJasa)
                .HasColumnName("id_akun_pajak_jasa");

            this.Property(m => m.IdAkunJasa)
                .HasColumnName("id_akun_jasa");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen"); 

            this.Property(m => m.Checkboxaktif)
                .HasColumnName("checkboxaktif");
        }
    }
}
