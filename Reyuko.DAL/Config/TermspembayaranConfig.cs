using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class TermspembayaranConfig : EntityTypeConfiguration<Termspembayaran>
    {
        public TermspembayaranConfig()
        {
            this.ToTable("term_pembayaran");
            this.HasKey(m => m.IdTermPembayaran);
            this.Property(m => m.IdTermPembayaran)
                .HasColumnName("id_term_pembayaran")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaSkema)
                .HasColumnName("nama_skema")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.GracePeriod)
                .HasColumnName("grace_period");


            this.Property(m => m.UangMuka)
               .HasColumnName("uang_muka");


            this.Property(m => m.IdOptionAnnual)
             .HasColumnName("id_option_annual");

            this.Property(m => m.Annual)
              .HasColumnName("annual");

            this.Property(m => m.TermPembayaran)
              .HasColumnName("term_pembayaran");

            this.Property(m => m.BungaPerBulan)
              .HasColumnName("bunga_per_bulan");

            this.Property(m => m.CicilanPerbulan)
            .HasColumnName("cicilan_per_bulan");

            this.Property(m => m.CheckBoxInactive)
            .HasColumnName("checkbox_inactive");
        }
    }
}
