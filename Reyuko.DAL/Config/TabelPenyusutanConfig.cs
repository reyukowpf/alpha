using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class TabelPenyusutanConfig : EntityTypeConfiguration<TabelPenyusutan>
    {
        public TabelPenyusutanConfig()
        {
            this.ToTable("tabel_penyusutan");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdNamaPenyusutan)
                .HasColumnName("id_nama_penyusutan")
                .IsRequired();

            this.Property(m => m.NamaPenyusutan)
                .HasColumnName("nama_penyusutan")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Umur)
                .HasColumnName("umur");

            this.Property(m => m.CustomName)
                .HasColumnName("custom_name");

            this.Property(m => m.Total)
                .HasColumnName("total");

            this.Property(m => m.Tahun1)
                .HasColumnName("tahun_1");

            this.Property(m => m.Tahun2)
                .HasColumnName("tahun_2");

            this.Property(m => m.Tahun3)
                .HasColumnName("tahun_3");

            this.Property(m => m.Tahun4)
                .HasColumnName("tahun_4");

            this.Property(m => m.Tahun5)
                .HasColumnName("tahun_5");

            this.Property(m => m.Tahun6)
                .HasColumnName("tahun_6");

            this.Property(m => m.Tahun7)
                .HasColumnName("tahun_7");

            this.Property(m => m.Tahun8)
                .HasColumnName("tahun_8");

            this.Property(m => m.Tahun9)
                .HasColumnName("tahun_9");

            this.Property(m => m.Tahun10)
                .HasColumnName("tahun_10");

            this.Property(m => m.Tahun11)
                .HasColumnName("tahun_11");

            this.Property(m => m.Tahun12)
                .HasColumnName("tahun_12");

            this.Property(m => m.Tahun13)
                .HasColumnName("tahun_13");

            this.Property(m => m.Tahun14)
                .HasColumnName("tahun_14");

            this.Property(m => m.Tahun15)
                .HasColumnName("tahun_15");

            this.Property(m => m.Tahun16)
                .HasColumnName("tahun_16");

            this.Property(m => m.Tahun17)
                .HasColumnName("tahun_17");

            this.Property(m => m.Tahun18)
                .HasColumnName("tahun_18");

            this.Property(m => m.Tahun19)
                .HasColumnName("tahun_19");

            this.Property(m => m.Tahun20)
                .HasColumnName("tahun_20");

            this.Property(m => m.Tahun21)
                .HasColumnName("tahun_21");

            this.Property(m => m.Tahun22)
                .HasColumnName("tahun_22");

            this.Property(m => m.Tahun23)
                .HasColumnName("tahun_23");

            this.Property(m => m.Tahun24)
                .HasColumnName("tahun_24");

            this.Property(m => m.Tahun25)
                .HasColumnName("tahun_25");

            this.Property(m => m.Tahun26)
                .HasColumnName("tahun_26");

            this.Property(m => m.Tahun27)
                .HasColumnName("tahun_27");

            this.Property(m => m.Tahun28)
                .HasColumnName("tahun_28");

            this.Property(m => m.Tahun29)
                .HasColumnName("tahun_29");

            this.Property(m => m.Tahun30)
                .HasColumnName("tahun_30");


        }
    }
}
