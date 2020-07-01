using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class OrderJurnalUmumConfig : EntityTypeConfiguration<OrderJurnalUmum>
    {
        public OrderJurnalUmumConfig()
        {
            this.ToTable("order_jurnal_umum");
            this.HasKey(m => m.IdOrderJurnalUmum);
            this.Property(m => m.IdOrderJurnalUmum)
                .HasColumnName("id_order_jurnal_umum")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTransaksiJurnalUmum)
                .HasColumnName("id_transaksi_jurnal_umum");

            this.Property(m => m.IdKlasifikasi)
             .HasColumnName("idklasifikasi");

            this.Property(m => m.NoTransaksiJurnalUmum)
                .HasColumnName("no_transaksi_jurnal_umum");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");
            
            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang")
                .HasMaxLength(100);

            this.Property(m => m.Kurs)
                .HasColumnName("kurs");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.IdRekeningPerkiraan)
               .HasColumnName("id_rekening_perkiraan");

            this.Property(m => m.NoRekeningPerkiraan)
               .HasColumnName("no_rekening_perkiraan");

            this.Property(m => m.NamaRekeningPerkiraan)
               .HasColumnName("nama_rekening_perkiraan");

            this.Property(m => m.KlasifikasiRekeningPerkiraan)
               .HasColumnName("klasifikasi_rekening_perkiraan");

            this.Property(m => m.Debit)
               .HasColumnName("debit");
            
            this.Property(m => m.Kredit)
               .HasColumnName("kredit");

            this.Property(m => m.IdPetugas)
               .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
               .HasColumnName("nama_petugas");

            this.Property(m => m.IdUserId)
               .HasColumnName("id_user_id");

            this.Property(m => m.CheckboxPosted)
                .HasColumnName("checkbox_posted");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdPeriodeAkuntasi)
                .HasColumnName("id_periode_akuntasi");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.Chkaktif)
                .HasColumnName("chkaktif");

        }
    }
}
