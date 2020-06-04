using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class PembayaranGajiConfig : EntityTypeConfiguration<PembayaranGaji>
    {
        public PembayaranGajiConfig()
        {
            this.ToTable("pembayaran_gaji");
            this.HasKey(m => m.IdPembayaranGaji);
            this.Property(m => m.IdPembayaranGaji)
                .HasColumnName("id_pembayaran_gaji")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");
               
            this.Property(m => m.IdAkunPembGaji)
                .HasColumnName("id_akun_pemb_gaji");

            this.Property(m => m.IdAkunBiayaGaji)
                .HasColumnName("id_akun_biaya_gaji");
           
            this.Property(m => m.CheckboxPajakGaji)
               .HasColumnName("checkbox_pajak_gaji");

            this.Property(m => m.IdAkunPajakGaji)
               .HasColumnName("id_akun_pajak_gaji");

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");

            this.Property(m => m.TotalSalaryPayment)
                .HasColumnName("total_salary_payment");

            this.Property(m => m.UserId)
                .HasColumnName("user_id");

            this.Property(m => m.IdPeriodeAkuntasi)
                .HasColumnName("id_periode_akuntasi");

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");
       
        }
    }
}
