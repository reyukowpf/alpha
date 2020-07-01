using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DefaultAkunMataUangConfig : EntityTypeConfiguration<DefaultAkunMataUang>
    {
        public DefaultAkunMataUangConfig()
        {
            this.ToTable("default_akun_mata_uang");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdPiutangUsaha)
                .HasColumnName("id_piutang_usaha");

            this.Property(m => m.IdHutangUsaha)
                .HasColumnName("id_hutang_usaha");

            this.Property(m => m.IdPembayaranBank)
                .HasColumnName("id_pembayaran_bank");

            this.Property(m => m.IdPembayaranTunai)
                .HasColumnName("id_pembayaran_tunai");

            this.Property(m => m.IdUangMukaPembelian)
                .HasColumnName("id_uang_muka_pembelian");

            this.Property(m => m.IdUangMukaPenjualan)
                .HasColumnName("id_uang_muka_penjualan");

            this.Property(m => m.IdPiutangGiro)
                .HasColumnName("id_piutang_giro");

            this.Property(m => m.IdHutangGiro)
                .HasColumnName("id_hutang_giro");

            this.Property(m => m.UserId)
               .HasColumnName("user_id");

        }
    }
}
