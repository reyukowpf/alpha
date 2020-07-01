using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class TransaksiJurnalUmumConfig : EntityTypeConfiguration<TransaksiJurnalUmum>
    {
        public TransaksiJurnalUmumConfig()
        {
            this.ToTable("transaksi_jurnal_umum");
            this.HasKey(m => m.IdTransaksiJurnalUmum);
            this.Property(m => m.IdTransaksiJurnalUmum)
                .HasColumnName("id_transaksi_jurnal_umum")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NoTransaksiJurnalUmum)
                .HasColumnName("no_transaksi_jurnal_umum");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");
            
            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang")
                .HasMaxLength(100);

            this.Property(m => m.Kurs)
                .HasColumnName("kurs");
                
            this.Property(m => m.IdNoRefensiDokumen)
               .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoRefensiDokumen)
               .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.TotalDebit)
             .HasColumnName("total_debit");
            
            this.Property(m => m.TotalKredit)
             .HasColumnName("total_kredit");

            this.Property(m => m.Balance)
             .HasColumnName("balance");

            this.Property(m => m.IdPetugas)
             .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
             .HasColumnName("nama_petugas");

            this.Property(m => m.CheckboxPosted)
           .HasColumnName("checkbox_posted");

            this.Property(m => m.IdKodeTransaksi)
           .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdReferalTransaksi)
           .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdUserId)
           .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntasi)
           .HasColumnName("id_periode_akuntasi");

            this.Property(m => m.RealRecordingTime)
           .HasColumnName("real_recording_time");
        }
    }
}
