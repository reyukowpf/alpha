using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListDataPajakConfig : EntityTypeConfiguration<ListDataPajak>
    {
        public ListDataPajakConfig()
        {
            this.ToTable("list_data_pajak");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasKey(m => m.IdPajak);
            this.Property(m => m.IdPajak)
                .HasColumnName("id_pajak")
                .IsRequired();

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

            this.Property(m => m.CheckBoxMengurangiHPP)
                .HasColumnName("checkbox_mengurangi_hpp");

            this.Property(m => m.AkunBeli)
                .HasColumnName("akun_beli")
                .HasMaxLength(100);

            this.Property(m => m.AkunJual)
                .HasColumnName("akun_jual")
                .HasMaxLength(100);

            this.Property(m => m.Keterangan)
               .HasColumnName("keterangan");

            //this.HasRequired(m => m.DataPajak)
            //    .WithRequiredDependent()
            //    .Map(m => m.MapKey("id_pajak"));

        }
    }
}
