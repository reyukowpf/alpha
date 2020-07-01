using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ListKonsinyasiConfig : EntityTypeConfiguration<ListKonsinyasi>
    {
        public ListKonsinyasiConfig()
        {
            this.ToTable("list_konsinyasi");
            this.HasKey(m => m.IdListKonsinyasi);
            this.Property(m => m.IdListKonsinyasi)
                .HasColumnName("id_list_konsinyasi")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            this.Property(m => m.IdPenerimaanRetur)
               .HasColumnName("id_penerimaan_retur");

            this.Property(m => m.PenerimaanRetur)
                .HasColumnName("penerimaan_retur")
                .IsRequired();

            this.Property(m => m.NoKonsinyasi)
                .HasColumnName("no_konsinyasi");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdVendor)
                .HasColumnName("id_vendor");

            this.Property(m => m.NamaVendor)
                .HasColumnName("nama_vendor");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
               .HasColumnName("kurs_tukar");

            this.Property(m => m.NoHp)
              .HasColumnName("no_hp");

            this.Property(m => m.Email)
              .HasColumnName("email");

        }
    }
}
