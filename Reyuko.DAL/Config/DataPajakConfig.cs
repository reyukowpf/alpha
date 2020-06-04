using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DataPajakConfig : EntityTypeConfiguration<DataPajak>
    {
        public DataPajakConfig()
        {
            this.ToTable("data_pajak");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaPajak)
                .HasColumnName("nama_pajak")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.KodePajak)
                .HasColumnName("kode_pajak")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Persentase)
                .HasColumnName("persentase");

            this.Property(m => m.IdAkunBeli)
                .HasColumnName("id_akun_beli");

            this.Property(m => m.AkunBeli)
                .HasColumnName("akun_beli")
                .HasMaxLength(100);

            this.Property(m => m.IdAkunJual)
                .HasColumnName("id_akun_jual");

            this.Property(m => m.AkunJual)
                .HasColumnName("akun_jual")
                .HasMaxLength(100);

            this.Property(m => m.Keterangan)
               .HasColumnName("keterangan");

            this.Property(m => m.CheckBoxInAktif)
                .HasColumnName("checkbox_inaktif");

            this.Property(m => m.user_id)
                .HasColumnName("user_id");

            //this.HasRequired(m => m.ListDataPajak)
            //    .WithRequiredPrincipal(m => m.DataPajak);
        }
    }
}
