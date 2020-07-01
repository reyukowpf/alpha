using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ReturBarangConfig : EntityTypeConfiguration<ReturBarang>
    {
        public ReturBarangConfig()
        {
            this.ToTable("retur_barang_konsinyasi");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdKodeTransaksi)
               .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");

            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi");

            this.Property(m => m.NoReturBarangKonsinyasi)
                .HasColumnName("no_retur_barang_konsinyasi");

            this.Property(m => m.IdVendor)
               .HasColumnName("id_vendor");

            this.Property(m => m.NamaVendor)
               .HasColumnName("nama_vendor");

            this.Property(m => m.NoHp)
               .HasColumnName("no_hp");

            this.Property(m => m.Email)
               .HasColumnName("email");

            this.Property(m => m.IdReferalTransaksi)
               .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdMataUang)
               .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
               .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
               .HasColumnName("kurs_tukar");

            this.Property(m => m.IdNoRefernsiDokumen)
               .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumen)
               .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.Tanggal)
               .HasColumnName("tanggal");

            this.Property(m => m.IdLokasi)
               .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
               .HasColumnName("nama_lokasi");

            this.Property(m => m.Keterangan)
               .HasColumnName("keterangan");

            this.Property(m => m.IdProyek)
               .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
               .HasColumnName("id_departemen");

            this.Property(m => m.CheckboxInclusiveTax)
               .HasColumnName("checkbox_inclusive_tax");

            this.Property(m => m.TanggalPengantaran)
               .HasColumnName("tanggal_pengantaran");

            this.Property(m => m.IdPetugas)
               .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
               .HasColumnName("nama_petugas");

            this.Property(m => m.CheckboxUnposted)
               .HasColumnName("checkbox_unposted");

            this.Property(m => m.CheckBooxBerulang)
                .HasColumnName("checkbox_berulang");

            this.Property(m => m.DropdownBerulang)
                .HasColumnName("dropdown_berulang");

            this.Property(m => m.DurasiBerulang)
                .HasColumnName("durasi_berulang");

            this.Property(m => m.TanggalBerulang)
                .HasColumnName("tanggal_berulang");

            this.Property(m => m.TotalSebelumPajak)
                .HasColumnName("total_sebelum_pajak");

            this.Property(m => m.TotalPajak)
                .HasColumnName("total_pajak");

            this.Property(m => m.TotalSetelahPajak)
                .HasColumnName("total_setelah_pajak");

            this.Property(m => m.IdUserId)
                .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkutansi)
                .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");

            this.Property(m => m.IdOpsiAnnual)
               .HasColumnName("id_opsi_annual");

            this.Property(m => m.Annual)
               .HasColumnName("annual");

        }
    }
}
