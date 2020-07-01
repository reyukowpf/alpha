using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class ReceivedgoodConfig : EntityTypeConfiguration<Receivedgood>
    {
        public ReceivedgoodConfig()
        {
            this.ToTable("received_goods");
            this.HasKey(m => m.IdOrder);
            this.Property(m => m.IdOrder)
                .HasColumnName("id_order")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.TanggalPengiriman)
                .HasColumnName("tanggal_pengiriman");

            this.Property(m => m.IdPetugas)
                .HasColumnName("id_petugas");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.CheckboxUnposted)
                .HasColumnName("checkbox_unposted");
               
            this.Property(m => m.CheckboxTunaiTermPembayaran)
                .HasColumnName("checkbox_tunai_term_pembayaran");

            this.Property(m => m.DropdownTermPembayaran)
                .HasColumnName("dropdown_term_payment");

            this.Property(m => m.GracePeriod)
                .HasColumnName("grace_period");

            this.Property(m => m.UangMuka)
                .HasColumnName("uang_muka");

            this.Property(m => m.IdOptionAnnual)
                .HasColumnName("id_option_annual");

            this.Property(m => m.Annual)
               .HasColumnName("annual");

            this.Property(m => m.Duration)
               .HasColumnName("duration");

            this.Property(m => m.Nominal)
               .HasColumnName("nominal");

            this.Property(m => m.DropdownBankKas)
               .HasColumnName("dropdown_bank_kas");

            this.Property(m => m.CheckboxBerulang)
               .HasColumnName("checkbox_berulang");

            this.Property(m => m.DropdownBerulang)
               .HasColumnName("dropdown_berulang");

            this.Property(m => m.DurasiBerulang)
               .HasColumnName("durasi_berulang");

            this.Property(m => m.TanggalBerulang)
               .HasColumnName("tanggal_berulang");

            this.Property(m => m.IdAkunPersediaanProduk)
               .HasColumnName("id_akun_persediaan_produk");

            this.Property(m => m.TotalDebitAkunPersediaanProduk)
               .HasColumnName("total_debit_akun_persediaan_produk");

            this.Property(m => m.TotalKreditAkunPersediaanProduk)
               .HasColumnName("total_kredit_akun_persediaan_produk");

            this.Property(m => m.IdAkunPengirimanBeliProduk)
               .HasColumnName("id_akun_pengiriman_beli_produk");

            this.Property(m => m.TotalDebitAkunPengirimanBeliProduk)
               .HasColumnName("total_debit_akun_pengiriman_beli_produk");

            this.Property(m => m.TotalKreditAkunPengirimanBeliProduk)
               .HasColumnName("total_kredit_akun_pengiriman_beli_produk");

            this.Property(m => m.IdAkunPembeliaanJasa)
               .HasColumnName("id_akun_pembelian_jasa");

            this.Property(m => m.TotalDebitPembeliaanJasa)
               .HasColumnName("total_debit_pembelian_jasa");

            this.Property(m => m.TotalKreditPembelianJasa)
               .HasColumnName("total_kredit_pembelian_jasa");

            this.Property(m => m.IdKodeTransaksi)
              .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdAkunPembelianCustom)
              .HasColumnName("id_akun_pembelian_custom");

            this.Property(m => m.TotalDebitPembelianCustom)
              .HasColumnName("total_debit_pembelian_custom");

            this.Property(m => m.TotalKreditPembelianCustom)
              .HasColumnName("total_kredit_pembelian_custom");

            this.Property(m => m.IdAkunPajakProduk)
              .HasColumnName("id_akun_pajak_produk");

            this.Property(m => m.TotalDebitAkunPajakProduk)
              .HasColumnName("total_debit_akun_pajak_produk");

            this.Property(m => m.TotalKreditAkunPajakProduk)
              .HasColumnName("total_kredit_akun_pajak_produk");

            this.Property(m => m.IdAkunPajakJasa)
              .HasColumnName("id_akun_pajak_jasa");

            this.Property(m => m.TotalDebitAkunPajakJasa)
              .HasColumnName("total_debit_akun_pajak_jasa");

            this.Property(m => m.TotalKreditAkunPajakJasa)
              .HasColumnName("total_kredit_akun_pajak_jasa");

            this.Property(m => m.IdAkunTunaiPembeliaan)
              .HasColumnName("id_akun_tunai_pembelian");

            this.Property(m => m.TotalDebitAkunTunaiPembeliaan)
              .HasColumnName("total_debit_akun_tunai_pembelian");

            this.Property(m => m.TotalKreditAkunTunaiPembeliaan)
              .HasColumnName("total_kredit_akun_tunai_pembelian");

            this.Property(m => m.IdAkunHutangPembeliaan)
              .HasColumnName("id_akun_hutang_pembelian");

            this.Property(m => m.TotalDebitAkunHutangPembeliaan)
              .HasColumnName("total_debit_akun_hutang_pembelian");

            this.Property(m => m.TotalKreditAkunHutangPembeliaan)
              .HasColumnName("total_kredit_akun_hutang_pembelian");

            this.Property(m => m.TotalSebelumPajak)
              .HasColumnName("total_sebelum_pajak");

            this.Property(m => m.TotalPajak)
              .HasColumnName("total_pajak");

            this.Property(m => m.TotalSetelahPajak)
              .HasColumnName("total_setelah_pajak");

            this.Property(m => m.CheckManual)
              .HasColumnName("Checkbox_Manual");

            this.Property(m => m.IdReferalPA)
              .HasColumnName("id_referal_PA");

            this.Property(m => m.LunasDibayarUangMuka)
              .HasColumnName("lunas/dibayar_uang_muka");

            this.Property(m => m.SaldoTerhutang)
              .HasColumnName("saldo_terhutang");

            this.Property(m => m.CicilanPerbulan)
              .HasColumnName("cicilan_per_bulan");

            this.Property(m => m.Angsuran)
              .HasColumnName("angsuran");

            this.Property(m => m.DueDate)
              .HasColumnName("due_date");

            this.Property(m => m.IdTransaksi)
              .HasColumnName("id_transaksi");

            this.Property(m => m.IdUserId)
              .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkutansi)
              .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordingTime)
              .HasColumnName("real_recording_time");
      
            this.Property(m => m.KodeTransaksi)
              .HasColumnName("kode_transaksi")
               .HasMaxLength(100);

            this.Property(m => m.NoOrder)
              .HasColumnName("no_order");

            this.Property(m => m.IdVendor)
              .HasColumnName("id_vendor");

            this.Property(m => m.NamaVendor)
              .HasColumnName("nama_vendor")
                .HasMaxLength(100);

            this.Property(m => m.NoHp)
              .HasColumnName("no_hp");

            this.Property(m => m.Email)
              .HasColumnName("email")
                .HasMaxLength(100);

            this.Property(m => m.IdOrderPembeliaan)
              .HasColumnName("id_order_pembelian");

            this.Property(m => m.NoOrderPembeliaan)
              .HasColumnName("no_order_pembelian");

            this.Property(m => m.IdPD)
              .HasColumnName("id_pd");

            this.Property(m => m.NoPD)
              .HasColumnName("no_pd");

            this.Property(m => m.IdReferalTransaksi)
              .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdMataUang)
              .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
              .HasColumnName("mata_uang")
               .HasMaxLength(100);

            this.Property(m => m.KursTukar)
              .HasColumnName("kurs_tukar");

            this.Property(m => m.TanggalOrder)
              .HasColumnName("tanggal_order");

            this.Property(m => m.IdNoReferensiDokumen)
              .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumentNi)
              .HasColumnName("no_referensi_dokumen_NI");

            this.Property(m => m.IdLokasi)
              .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
              .HasColumnName("Nama_Lokasi")
               .HasMaxLength(100);

            this.Property(m => m.Keterangan)
              .HasColumnName("keterangan")
               .HasMaxLength(100);

            this.Property(m => m.IdProyek)
              .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartmen)
              .HasColumnName("id_departemen");

            this.Property(m => m.CheckboxInclusiveTax)
              .HasColumnName("checkbox_inclusive_tax");

            this.Property(m => m.IdPaymentTerm)
              .HasColumnName("id_payment_term");

            this.Property(m => m.PaymentTerm)
              .HasColumnName("payment_term");

            this.Property(m => m.IdBankCash)
              .HasColumnName("id_bank_cash");

            this.Property(m => m.BankCash)
              .HasColumnName("bank_cash");

        }
    }
}
