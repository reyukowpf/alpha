using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DataGiroConfig : EntityTypeConfiguration<DataGiro>
    {
        public DataGiroConfig()
        {
            this.ToTable("data_giro");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NomorGiro)
                .HasColumnName("nomor_giro");

            this.Property(m => m.JatuhTempoGiro)
                .HasColumnName("jatuh_tempo_giro");

            this.Property(m => m.NamaBank)
                .HasColumnName("nama_bank")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NomorRekeningGiro)
                .HasColumnName("nomor_rekening_giro");


        }
    }
}
