using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class KodeTransaksiConfig : EntityTypeConfiguration<KodeTransaksi>
    {
        public KodeTransaksiConfig()
        {
            this.ToTable("kode_transaksi");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Kode)
                .HasColumnName("kode_transaksi")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan")
                .HasMaxLength(255);

            this.Property(m => m.Tabel)
              .HasColumnName("tabel")
              .HasMaxLength(255);
        }
    }
}
