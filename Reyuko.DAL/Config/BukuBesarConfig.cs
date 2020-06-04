using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class BukuBesarConfig : EntityTypeConfiguration<BukuBesar>
    {
        public BukuBesarConfig()
        {
            this.ToTable("buku_besar");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdOrigin)
                .HasColumnName("id_origin");

            this.Property(m => m.IdRekeningPerkiraan)
                .HasColumnName("id_rekening_perkiraan");

            this.Property(m => m.NoRekningPerkiraan)
                .HasColumnName("no_rekning_perkiraan");

            this.Property(m => m.NamaRekeningPerkiraan)
                .HasColumnName("nama_rekening_perkiraan");

            this.Property(m => m.IdKlasfikasi)
                .HasColumnName("id_klasifikasi");

            this.Property(m => m.KlasifikasiAkun)
                .HasColumnName("klasifikasi_akun")
                .HasMaxLength(100);

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi")
                .HasMaxLength(100);

            this.Property(m => m.NoReferensiTransaksi)
               .HasColumnName("no_referensi_transaksi");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.Deskripsi)
                .HasColumnName("deskripsi");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
                .HasColumnName("kurs_tukar");

            this.Property(m => m.DebitMataUang)
                .HasColumnName("debit_mata_uang");

            this.Property(m => m.KreditMataUang)
                .HasColumnName("kredit_mata_uang");

            this.Property(m => m.Debit)
                .HasColumnName("debit");

            this.Property(m => m.Kredit)
                .HasColumnName("kredit");

            this.Property(m => m.CashflowFlag)
                .HasColumnName("cashflow_flag");

            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdEmployee)
                .HasColumnName("id_employee");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartmen)
                .HasColumnName("id_departmen");

            this.Property(m => m.IdBiaya)
               .HasColumnName("id_biaya");

            this.Property(m => m.Penyesuaian)
               .HasColumnName("penyesuaian");

            this.Property(m => m.IdUserId)
               .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntansi)
               .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordingTime)
               .HasColumnName("real_recording_time");

            this.Property(m => m.Rekonsiliasi)
             .HasColumnName("rekonsiliasi");

            
        }
    }
}
