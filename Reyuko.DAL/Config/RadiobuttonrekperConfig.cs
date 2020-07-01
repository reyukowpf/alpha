using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class RadiobuttonrekperConfig : EntityTypeConfiguration<Radiobuttonrekper>
    {
        public RadiobuttonrekperConfig()
        {
            this.ToTable("radiobutton_rekper");
            this.HasKey(m => m.IdRadioButtonRekper);
            this.Property(m => m.IdRadioButtonRekper)
                .HasColumnName("id_radiobutton_rekper")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaRadioButton)
                .HasColumnName("nama_radiobutton")
                .HasMaxLength(100)
                .IsRequired();


        }
    }
}
