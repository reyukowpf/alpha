using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class PermPenyTransferBarangConfig : EntityTypeConfiguration<PermPenyTransferBarang>
    {
        public PermPenyTransferBarangConfig()
        {
            this.ToTable("pem_peny_transfer_barang");
            this.HasKey(m => m.IdPemPenydanTransferBarang);
            this.Property(m => m.IdPemPenydanTransferBarang)
                .HasColumnName("id_pem_peny_dan_transfer_barang")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");

            this.Property(m => m.DropdownPemakaianTransferBarang)
                .HasColumnName("dropdown_pemakaian_transafer_barang");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");
            
            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.NoPemPenydanTransferBarang)
                .HasColumnName("no_pem_peny_dan_transfer_barang");

            this.Property(m => m.IdNoReferensiDokumen)
                .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumen)
                .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.IdPetugas)
                .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");

            this.Property(m => m.CheckboxPosted)
                .HasColumnName("checkbox_posted");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.IdLokasiDari)
                .HasColumnName("id_lokasi_dari");

            this.Property(m => m.NamaDariLokasi)
                .HasColumnName("nama_dari_lokasi");

            this.Property(m => m.IdAkunDari)
                .HasColumnName("id_akun_dari");

            this.Property(m => m.TotalDebitDari)
               .HasColumnName("total_debit_dari");

            this.Property(m => m.TotalKreditDari)
               .HasColumnName("total_kredit_dari");

            this.Property(m => m.IdLokasiKe)
               .HasColumnName("id_lokasi_ke");

            this.Property(m => m.NamaKeLokasi)
               .HasColumnName("nama_ke_lokasi");

            this.Property(m => m.IdAkunKe)
               .HasColumnName("id_akun_ke");

            this.Property(m => m.TotalDebitKe)
              .HasColumnName("total_debit_ke");

            this.Property(m => m.TotalKreditKe)
              .HasColumnName("total_kredit_ke");

            this.Property(m => m.IdUserId)
              .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntansi)
              .HasColumnName("id_periode_akuntansi");

        }
    }
}
