using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DataDepartemenConfig : EntityTypeConfiguration<DataDepartemen>
    {
        public DataDepartemenConfig()
        {
            this.ToTable("data_departemen");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.KodeDepartemen)
                .HasColumnName("kode_departemen")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NamaDepartemen)
                .HasColumnName("nama_departemen")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdSubDepartemen)
                .HasColumnName("id_sub_departemen");

            this.Property(m => m.SubDepartemenDari)
                .HasColumnName("sub_departemen_dari");

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

            this.Property(m => m.PenanggungJawab)
                .HasColumnName("penanggung_jawab");

            this.Property(m => m.Deskripsi)
                .HasColumnName("deskripsi")
                .HasMaxLength(255);

            this.Property(m => m.CheckboxInActive)
                .HasColumnName("checkbox_inactive");

        }
    }
}
