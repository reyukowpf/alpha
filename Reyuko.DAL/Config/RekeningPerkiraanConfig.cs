using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class RekeningPerkiraanConfig : EntityTypeConfiguration<RekeningPerkiraan>
    {
        public RekeningPerkiraanConfig()
        {
            this.ToTable("rekening_perkiraan");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaRekeningPerkiraan)
                .HasColumnName("nama_rekening_perkiraan")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdKlasifikasiRekeningPerkiraan)
                .HasColumnName("id_klasifikasi_rekening_perkiraan")
                .IsRequired();

            this.Property(m => m.KlasifikasiRekeningPerkiraan)
                .HasColumnName("klasifikasi_rekening_perkiraan")
                .HasMaxLength(100);

            this.Property(m => m.KodeRekening)
                .HasColumnName("kode_rekening")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.RadioButtonStandarKasBankDebtLoan)
                .HasColumnName("radiobutton_standar_kasbank_debtloan");

            this.Property(m => m.CheckboxTidakAktif)
                .HasColumnName("checkbox_tidak_aktif");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.NamaDepartemen)
                .HasColumnName("nama_departemen");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang");

            this.Property(m => m.CheckboxPasswordLock)
                .HasColumnName("checkbox_password_lock");

            this.Property(m => m.Chekboxaktif)
               .HasColumnName("chekboxaktif");
        }
    }
}
