using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class RppConfig : EntityTypeConfiguration<Rpp>
    {
        public RppConfig()
        {
            this.ToTable("r_pp");
            this.HasKey(m => m.IdRpp);
            this.Property(m => m.IdRpp)
                .HasColumnName("id_rp_p")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.PulldownRpp)
                     .HasColumnName("pulldown_rp_p");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");
            
            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi");
       
            this.Property(m => m.NoPembayaran)
                .HasColumnName("no_pembayaran");
       
            this.Property(m => m.IdPelanggan)
                .HasColumnName("id_pelanggan");
       
            this.Property(m => m.NamaPelanggan)
                .HasColumnName("nama_pelanggan");
       
            this.Property(m => m.NoHp)
                .HasColumnName("no_hp");
       
            this.Property(m => m.Email)
                .HasColumnName("email");
       
            this.Property(m => m.TanggalTransaksi)
                .HasColumnName("tanggal_transaksi");
       
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
       
            this.Property(m => m.TotalPembayaran)
                .HasColumnName("total_pembayaran");
       
            this.Property(m => m.IdUserId)
                .HasColumnName("id_user_id");
       
            this.Property(m => m.IdPeriodeAkuntansi)
                .HasColumnName("id_periode_akuntansi");
       
            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");
       
            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");
            
            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");
       
        }
    }
}
