using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class KlasifikasiKontakConfig : EntityTypeConfiguration<KlasifikasiKontak>
    {
        public KlasifikasiKontakConfig()
        {
            this.ToTable("klasifikasi_kontak");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTypeKontak)
                .HasColumnName("id_type_kontak")
                .IsRequired();

            this.Property(m => m.TypeKontak)
                .HasColumnName("type_kontak")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NamaKlasifikasiKontak)
                .HasColumnName("nama_klasifikasi_kontak")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.CheckboxGender)
                .HasColumnName("checkbox_gender");

            this.Property(m => m.CheckboxPosition)
                .HasColumnName("checkbox_position");

            this.Property(m => m.CheckboxTransaksi)
                .HasColumnName("checkbox_transaksi");

            this.Property(m => m.CheckboxOutstanding)
                .HasColumnName("checkbox_outstanding");

            this.Property(m => m.CheckboxPIC1)
                .HasColumnName("checkbox_pic1");

            this.Property(m => m.NamaPIC1)
                .HasColumnName("nama_pic1");

            this.Property(m => m.CheckboxGenderPIC1)
                .HasColumnName("checkbox_gender_pic1");

            this.Property(m => m.CheckboxPositionPIC1)
                .HasColumnName("checkbox_position_pic1");

            this.Property(m => m.CheckboxPIC2)
                .HasColumnName("checkbox_pic2");

            this.Property(m => m.NamaPIC2)
                .HasColumnName("nama_pic2");

            this.Property(m => m.CheckboxGenderPIC2)
                .HasColumnName("checkbox_gender_pic2");

            this.Property(m => m.CheckboxPositionPIC2)
                .HasColumnName("checkbox_position_pic2");

            this.Property(m => m.CheckboxPIC3)
                .HasColumnName("checkbox_pic3");

            this.Property(m => m.NamaPIC3)
                .HasColumnName("nama_pic3");

            this.Property(m => m.CheckboxGenderPIC3)
                .HasColumnName("checkbox_gender_pic3");

            this.Property(m => m.CheckboxPositionPIC3)
                .HasColumnName("checkbox_position_pic3");

            this.Property(m => m.Note)
                .HasColumnName("note")
                .HasMaxLength(255);

        }
    }
}
