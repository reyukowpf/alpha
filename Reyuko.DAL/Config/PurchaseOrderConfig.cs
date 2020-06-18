using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class PurchaseOrderConfig : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderConfig()
        {
            this.ToTable("purchase_order");
            this.HasKey(m => m.IdOrderPembelian);
            this.Property(m => m.IdOrderPembelian)
                .HasColumnName("id_order_pembelian")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");
                
            this.Property(m => m.CheckboxUnposted)
                .HasColumnName("checkbox_unposted");

            this.Property(m => m.CheckboxTunaiTermPembayaran)
           .HasColumnName("checkbox_tunai_term_pembayaran");

            this.Property(m => m.GracePeriod)
      .HasColumnName("grace_period");

            this.Property(m => m.UangMuka)
      .HasColumnName("uang_muka");

            this.Property(m => m.IdOpsiAnnual)
      .HasColumnName("id_opsi_annual");

            this.Property(m => m.Annual)
      .HasColumnName("annual");

            this.Property(m => m.Duration)
      .HasColumnName("duration");

            this.Property(m => m.Nominal)
      .HasColumnName("nominal");

            this.Property(m => m.CheckboxBerulang)
      .HasColumnName("checkbox_berulang");

            this.Property(m => m.DropdownBerulang)
      .HasColumnName("dropdown_berulang");

            this.Property(m => m.DurasiBerulang)
      .HasColumnName("durasi_berulang");

            this.Property(m => m.TanggalBerulang)
      .HasColumnName("tanggal_berulang");

            this.Property(m => m.TotalOrderProduk)
      .HasColumnName("total_order_produk");

            this.Property(m => m.TotalPajakProduk)
      .HasColumnName("total_pajak_produk");

            this.Property(m => m.TotalOrderJasa)
      .HasColumnName("total_order_jasa");

            this.Property(m => m.TotalPajakJasa)
      .HasColumnName("total_pajak_jasa");

            this.Property(m => m.TotalSebelumPajak)
      .HasColumnName("total_sebelum_pajak");

            this.Property(m => m.TotalPajak)
      .HasColumnName("total_pajak");

            this.Property(m => m.TotalSetelahPajak)
      .HasColumnName("total_setelah_pajak");

            this.Property(m => m.LunasUangMuka)
      .HasColumnName("lunas_uang_muka");

            this.Property(m => m.SaldoTerhutang)
      .HasColumnName("saldo_terhutang");

            this.Property(m => m.CicilanPerBulan)
      .HasColumnName("cicilan_per_bulan");

            this.Property(m => m.Angsuran)
      .HasColumnName("angsuran");

            this.Property(m => m.DueDate)
      .HasColumnName("due_date");

            this.Property(m => m.IdKodeTransaksi)
      .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdUserId)
      .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntansi)
      .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordingTime)
      .HasColumnName("real_recording_time");

            this.Property(m => m.CheckboxSelesai)
      .HasColumnName("checkbox_selesai");

            this.Property(m => m.IdTransaksi)
      .HasColumnName("id_transaksi");

            this.Property(m => m.KodeTransaksi)
      .HasColumnName("kode_transaksi");

            this.Property(m => m.NoOrderPembelian)
      .HasColumnName("no_order_pembelian");

            this.Property(m => m.IdVendor)
      .HasColumnName("id_vendor");

            this.Property(m => m.NamaVendor)
      .HasColumnName("nama_vendor");

            this.Property(m => m.NoHp)
      .HasColumnName("no_hp");

            this.Property(m => m.Email)
      .HasColumnName("email");

            this.Property(m => m.IdPermintaanPenawaranHarga)
      .HasColumnName("id_permintaan_penawaran_harga");

            this.Property(m => m.NoPermintaanPenawaranHarga)
      .HasColumnName("no_permintaan_penawaran_harga");

            this.Property(m => m.IdReferalTransaksi)
      .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdMataUang)
      .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
      .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
      .HasColumnName("kurs_tukar");

            this.Property(m => m.TanggalOrderPembelian)
      .HasColumnName("tanggal_order_pembelian");

            this.Property(m => m.IdNoReferensiDokumen)
      .HasColumnName("id_no_referensi_dokumen");
            
            this.Property(m => m.NoReferensiDokumen)
      .HasColumnName("no_referensi_dokumen");

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

            this.Property(m => m.IdTermPembayaran)
     .HasColumnName("id_term_pembayaran");

            this.Property(m => m.TermPembayaran)
     .HasColumnName("term_pembayaran");


        }
    }
}
