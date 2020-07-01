using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class SatuanDasarConfig : EntityTypeConfiguration<SatuanDasar>
    {
        public SatuanDasarConfig()
        {
            this.ToTable("satuan_dasar");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.CheckboxUnitDasar)
                .HasColumnName("checkbox_unit_dasar");

            this.Property(m => m.TipeUnit)
                .HasColumnName("tipe_unit");

            this.Property(m => m.KodeSatuan)
                .HasColumnName("kode_satuan")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NamaSatuan)
                .HasColumnName("nama_satuan")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.JumlahSatuan)
                .HasColumnName("jumlah_satuan");

            this.Property(m => m.ParentId)
                .HasColumnName("parent_id");

            this.Property(m => m.DetailSatuan)
                .HasColumnName("detail_satuan")
                .HasMaxLength(255);

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan")
                .HasMaxLength(255);

            this.Property(m => m.UserId)
                .HasColumnName("user_id");


        }
    }
}
