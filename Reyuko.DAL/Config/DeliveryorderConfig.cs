using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class DeliveryorderConfig : EntityTypeConfiguration<Deliveryorders>
    {
        public DeliveryorderConfig()
        {
            this.ToTable("delivery_order");
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

            this.Property(m => m.NoDo)
      .HasColumnName("no_do");

            this.Property(m => m.IdPelanggan)
      .HasColumnName("id_pelanggan");

            this.Property(m => m.NamePelanggan)
      .HasColumnName("name_pelanggan");

            this.Property(m => m.NoHp)
      .HasColumnName("no_hp");

            this.Property(m => m.Email)
      .HasColumnName("email");

            this.Property(m => m.IdOrderPenjualan)
      .HasColumnName("id_order_penjualan");

            this.Property(m => m.NomorOrderPenjualan)
      .HasColumnName("nomor_order_penjualan");

            this.Property(m => m.IdReferalTransaksi)
      .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdMaatUang)
      .HasColumnName("id_maat_uang");

            this.Property(m => m.MaatUang)
      .HasColumnName("maat_uang");

            this.Property(m => m.KursTukar)
      .HasColumnName("kurs_tukar");

            this.Property(m => m.TanggalDo)
      .HasColumnName("tanggal_do");

            this.Property(m => m.IdNoReferansiDokumen)
      .HasColumnName("id_no_referansi_dokumen");

            this.Property(m => m.NoReferansiDokumen)
      .HasColumnName("no_referansi_dokumen");

            this.Property(m => m.IdLokasi)
      .HasColumnName("id_lokasi");

            this.Property(m => m.NameLokasi)
      .HasColumnName("name_lokasi");

            this.Property(m => m.Keterangan)
      .HasColumnName("keterangan");

            this.Property(m => m.IdProyek)
      .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
      .HasColumnName("id_departemen");

            this.Property(m => m.CheckboxInclusivePajak)
      .HasColumnName("checkbox_inclusive_pajak");

            this.Property(m => m.TanggalPengiriman)
      .HasColumnName("tanggal_pengiriman");

            this.Property(m => m.IdPetugas)
      .HasColumnName("id_petugas");

            this.Property(m => m.NamePetugas)
      .HasColumnName("name_petugas");

            this.Property(m => m.CheckboxUnposted)
      .HasColumnName("checkbox_unposted");

            this.Property(m => m.CheckboxBerulang)
      .HasColumnName("checkbox_berulang");

            this.Property(m => m.DropdownBerulang)
      .HasColumnName("dropdown_berulang");

            this.Property(m => m.DurationBerulang)
      .HasColumnName("duration_berulang");

            this.Property(m => m.TanggalBerulang)
      .HasColumnName("tanggal_berulang");

            this.Property(m => m.IdAkunPersediaanProduk)
      .HasColumnName("id_akun_persediaan_produk");

            this.Property(m => m.TotalDebitAkunPersediaanProduk)
      .HasColumnName("total_debit_akun_persediaan_produk");

            this.Property(m => m.TotalKreditAkunPersediaanProduk)
      .HasColumnName("total_kredit_akun_persediaan_produk");

            this.Property(m => m.IdAkunPengirimanJualProduk)
      .HasColumnName("id_akun_pengiriman_jual_produk");

            this.Property(m => m.TotalDebitAkunPengirimanJualProduk)
      .HasColumnName("total_debit_akun_pengiriman_jual_produk");

            this.Property(m => m.TotalKreditAkunPengirimanJualProduk)
      .HasColumnName("total_kredit_akun_pengiriman_jual_produk");

            this.Property(m => m.TotalSebelumPajak)
      .HasColumnName("total_sebelum_pajak");

            this.Property(m => m.TotalPajak)
      .HasColumnName("total_pajak");

            this.Property(m => m.TotalSetelahPajak)
      .HasColumnName("total_setelah_pajak");

            this.Property(m => m.SaldoTerhutang)
      .HasColumnName("saldo_terhutang");

            this.Property(m => m.CicilanPerBulan)
      .HasColumnName("cicilan_per_bulan");

            this.Property(m => m.DurasiCicilan)
      .HasColumnName("durasi_cicilan");

            this.Property(m => m.DueDate)
      .HasColumnName("due_date");

            this.Property(m => m.IdUserId)
      .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntansi)
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
