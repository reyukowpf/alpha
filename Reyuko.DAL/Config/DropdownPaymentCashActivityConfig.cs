using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DropdownPaymentCashActivityConfig : EntityTypeConfiguration<DropdownPaymentCashActivity>
    {
        public DropdownPaymentCashActivityConfig()
        {
            this.ToTable("dropdown_payment_cash_activity");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.KategoriTransaksi)
                .HasColumnName("kategori_transaksi")
                .HasMaxLength(100);

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi")
                .HasMaxLength(100);
        }
    }
}
