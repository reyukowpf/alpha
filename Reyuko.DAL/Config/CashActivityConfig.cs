using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class CashActivityConfig : EntityTypeConfiguration<CashActivity>
    {
        public CashActivityConfig()
        {
            this.ToTable("cash_activity");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.PulldownCashActivities)
                .HasColumnName("pulldown_cash_activities");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");

            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi");

            this.Property(m => m.NoCashActivities)
                .HasColumnName("no_cash_activities");

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

            this.Property(m => m.NamaKontak)
                .HasColumnName("nama_kontak");

            this.Property(m => m.NoHp)
                .HasColumnName("no_hp");

            this.Property(m => m.Email)
                .HasColumnName("email");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
                .HasColumnName("kurs_tukar");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.CheckboxGiro)
                .HasColumnName("checkbox_giro");

            this.Property(m => m.IdDataGiro)
                .HasColumnName("id_data_giro");

            this.Property(m => m.IdNoReferensiDokumen)
                .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumen)
                .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.IdPetugas)
                .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");

            this.Property(m => m.CheckboxUnposted)
                .HasColumnName("checkbox_unposted");

            this.Property(m => m.IdAkunKas)
                .HasColumnName("id_akun_kas");

            this.Property(m => m.NamaAkunKas)
                .HasColumnName("nama_akun_kas");

            this.Property(m => m.Nilai)
                .HasColumnName("nilai");

            this.Property(m => m.IdUserId)
                .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntansi)
                .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordTime)
                .HasColumnName("real_record_time");

            this.Property(m => m.KategoriTransaksi)
                .HasColumnName("kategori_transaksi");
        }
    }
}
