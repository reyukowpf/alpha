using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderTransaksiCashConfig : EntityTypeConfiguration<OrderTransaksiCash>
    {
        public OrderTransaksiCashConfig()
        {
            this.ToTable("order_transaksi_cash");
            this.HasKey(m => m.IdOrderTransaksiCash);
            this.Property(m => m.IdOrderTransaksiCash)
                .HasColumnName("id_order_transaksi_cash")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.IdReferalTransaksi2)
                .HasColumnName("id_referal_transaksi_2");

            this.Property(m => m.NoReferensiTransaksi)
                .HasColumnName("no_referensi_transaksi");

            this.Property(m => m.IdAkunHutangPiutangReferensi)
                .HasColumnName("id_akun_hutang_piutang_referensi");

            this.Property(m => m.Debit)
                .HasColumnName("debit");

            this.Property(m => m.Kredit)
                .HasColumnName("kredit");

            this.Property(m => m.IdUserId)
                .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeTransaksi)
                .HasColumnName("id_periode_transaksi");

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");

            this.Property(m => m.IdTransaksiPaymentCashActivity)
                .HasColumnName("id_transaksi_payment_cash_activity");

            this.Property(m => m.IdDropdownPaymentCashActivity)
                .HasColumnName("id_dropdown_payment_cash_activity");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi");

            this.Property(m => m.IdPelanggan)
                .HasColumnName("id_pelanggan");

            this.Property(m => m.NamaPelanggan)
                .HasColumnName("nama_pelanggan");

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

            this.Property(m => m.IdNoReferensiDokumen)
                .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumen)
                .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.TanggalTransaksi)
                .HasColumnName("tanggal_transaksi");

            this.Property(m => m.DueDate)
                .HasColumnName("due_date");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.CheckboxGiro)
                .HasColumnName("checkbox_giro");

            this.Property(m => m.IdDataGiro)
                .HasColumnName("id_data_giro");

            this.Property(m => m.IdPetugas)
                .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.KategoriTransaksi)
               .HasColumnName("kategori_transaksi");

            this.Property(m => m.Checkboxaktif)
               .HasColumnName("Checkboxaktif");

            this.Property(m => m.Debit1)
               .HasColumnName("debit1");

            this.Property(m => m.Kredit1)
               .HasColumnName("kredit1");

            this.Property(m => m.NoReferensiTransaksi1)
              .HasColumnName("no_referensi_transaksi1");

            this.Property(m => m.IdAkunHutangPiutangReferensi1)
              .HasColumnName("id_akun_hutang_piutang_referensi1");

            this.Property(m => m.NamaAkunHutangPiutang)
           .HasColumnName("nama_akun_hutang_piutang");
        }
    }
}
