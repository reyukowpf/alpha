using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderPembayaranGajiConfig : EntityTypeConfiguration<OrderPembayaranGaji>
    {
        public OrderPembayaranGajiConfig()
        {
            this.ToTable("order_pembayaran_gaji");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas")
                .HasMaxLength(100);
            
            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");
           
            this.Property(m => m.IdProyek)
               .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartment)
               .HasColumnName("id_department");

            this.Property(m => m.UserId)
                .HasColumnName("user_id");

            this.Property(m => m.IdPeriodeAkuntasi)
                .HasColumnName("id_periode_akuntasi");

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");

            this.Property(m => m.IdPembayaranGaji)
                .HasColumnName("id_pembayaran_gaji");

            this.Property(m => m.NoPembayaranGaji)
                .HasColumnName("no_pembayaran_gaji");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.NamaEmployee)
                .HasColumnName("nama_employee");

            this.Property(m => m.IdGroup)
                .HasColumnName("id_group");

            this.Property(m => m.GajiPokok)
                .HasColumnName("gaji_pokok");

            this.Property(m => m.Tunjangan)
                .HasColumnName("tunjangan");

            this.Property(m => m.Overtime)
                .HasColumnName("overtime");

            this.Property(m => m.OvertimeHour)
                .HasColumnName("overtime_hour");

            this.Property(m => m.TotalOvertime)
                .HasColumnName("total_overtime");

            this.Property(m => m.Lainlain)
                .HasColumnName("lainlain");

            this.Property(m => m.Pajak)
                .HasColumnName("pajak");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.BankData)
                .HasColumnName("bank_data");

            this.Property(m => m.Total)
                .HasColumnName("total");

            this.Property(m => m.CheckboxAktif)
                .HasColumnName("Checboxaktif");

            this.Property(m => m.IdAkunPembGaji)
                .HasColumnName("id_akun_pemb_gaji");

            this.Property(m => m.DebitAkunPembGaji)
                .HasColumnName("debit_akun_pemb_gaji");

            this.Property(m => m.KreditAkunPembGaji)
                .HasColumnName("kredit_akun_pemb_gaji");

            this.Property(m => m.IdAkunPajakGaji)
                .HasColumnName("id_akun_pajak_gaji");

            this.Property(m => m.DebitAkunPajakGaji)
                .HasColumnName("debit_akun_pajak_gaji");

            this.Property(m => m.KreditAkunPajakGaji)
                .HasColumnName("kredit_akun_pajak_gaji");

            this.Property(m => m.IdAkunBiayaGaji)
                .HasColumnName("id_akun_biaya_gaji");

            this.Property(m => m.DebitAkunBiayaGaji)
                .HasColumnName("debit_akun_biaya_gaji");

            this.Property(m => m.KreditAkunBiayaGaji)
                .HasColumnName("kredit_akun_biaya_gaji");
        }
    }
}
