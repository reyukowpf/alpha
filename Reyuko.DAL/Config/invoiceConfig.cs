using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class invoiceConfig : EntityTypeConfiguration<invoice>
    {
        public invoiceConfig()
        {
            this.ToTable("invoice");
            this.HasKey(m => m.IdInvoice);
            this.Property(m => m.IdInvoice)
                .HasColumnName("id_invoice")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.TanggalPengiriman)
                .HasColumnName("tanggal_pengiriman");

            this.Property(m => m.IdPetugas)
                .HasColumnName("id_petugas");
         
            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas")
                .HasMaxLength(100);

            this.Property(m => m.CheckboxUnposted)
                .HasColumnName("checkbox_unposted");
                
            this.Property(m => m.CheckboxTunaiTermPembayaran)
               .HasColumnName("checkbox_tunai_term_pembayaran");

            this.Property(m => m.DropdownTermPembayaran)
               .HasColumnName("dropdown_term_pembayaran");
      
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

            this.Property(m => m.IdAkunHargaPokokProduk)
                .HasColumnName("id_akun_harga_pokok_produk");

            this.Property(m => m.TotalDebitAkunHargaPokokProduk)
                .HasColumnName("total_debit_akun_harga_pokok_produk");

            this.Property(m => m.TotalKreditAkunHargaPokokProduk)
                .HasColumnName("total_kredit_akun_harga_pokok_produk");

            this.Property(m => m.IdAkunPenjualanProduk)
                .HasColumnName("id_akun_penjualan_produk");

            this.Property(m => m.TotalDebitAkunPenjualanProduk)
                .HasColumnName("total_debit_akun_penjualan_produk");

            this.Property(m => m.TotalKreditAkunPenjualanProduk)
                .HasColumnName("total_kredit_akun_penjualan_produk");

            this.Property(m => m.IdAkunPersediaanProduk)
                .HasColumnName("id_akun_persediaan_produk");

            this.Property(m => m.TotalDebitAkunPersediaanProduk)
                .HasColumnName("total_debit_akun_persediaan_produk");

            this.Property(m => m.TotalKreditAkunPersediaanProduk)
                .HasColumnName("total_kredit_akun_persediaan_produk");

            this.Property(m => m.IdAkunPengirimanJual)
                .HasColumnName("id_akun_pengiriman_jual");

            this.Property(m => m.TotalDebitdAkunPengirimanJual)
                .HasColumnName("total_debit_id_akun_pengiriman_jual");

            this.Property(m => m.TotalKreditIdAkunPengirimanJual)
                .HasColumnName("total_kredit_id_akun_pengiriman_jual");

            this.Property(m => m.IdAkunPenjualanJasa)
                .HasColumnName("id_akun_penjualan_jasa");

            this.Property(m => m.TotalDebitPenjualanJasa)
                .HasColumnName("total_debit_penjualan_jasa");

            this.Property(m => m.TotalKreditPenjualanJasa)
                .HasColumnName("total_kredit_penjualan_jasa");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdAkunPenjualanCustom)
                .HasColumnName("id_akun_penjualan_custom");

            this.Property(m => m.TotalDebitPenjualanCustom)
                .HasColumnName("total_debit_penjualan_custom");

            this.Property(m => m.TotalKreditPenjualanCustom)
                .HasColumnName("total_kredit_penjualan_custom");

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

            this.Property(m => m.IdAkunTunaiPenjualan)
                .HasColumnName("id_akun_tunai_penjualan");

            this.Property(m => m.TotalDebitAkunTunaiPenjualan)
                .HasColumnName("total_debit_akun_tunai_penjualan");

            this.Property(m => m.TotalKreditAkunTunaiPenjualan)
                .HasColumnName("total_kredit_akun_tunai_penjualan");

            this.Property(m => m.IdAkunPiutangPenjualan)
                .HasColumnName("id_akun_piutang_penjualan");

            this.Property(m => m.TotalDebitAkunPiutangPenjualan)
                .HasColumnName("total_debit_akun_piutang_penjualan");

            this.Property(m => m.TotalKreditAkunPiutangPenjualan)
                .HasColumnName("total_kredit_akun_piutang_penjualan");

            this.Property(m => m.TotalSebelumPajak)
                .HasColumnName("total_sebelum_pajak");

            this.Property(m => m.TotalPajak)
                .HasColumnName("total_pajak");

            this.Property(m => m.TotalSetelahPajak)
                .HasColumnName("total_setelah_pajak");

            this.Property(m => m.CheckboxManual)
                .HasColumnName("Checkbox_Manual");

            this.Property(m => m.IdReferalSA)
                .HasColumnName("id_referal_SA");

            this.Property(m => m.LunasDibayarUangMuka)
                .HasColumnName("lunas_dibayar_uang_muka");

            this.Property(m => m.SaldoTerhutang)
                .HasColumnName("saldo_terhutang");

            this.Property(m => m.CicilanPerBulan)
                .HasColumnName("cicilan_per_bulan");

            this.Property(m => m.Angsuran)
                .HasColumnName("angsuran");

            this.Property(m => m.DueDate)
                .HasColumnName("due_date");

            this.Property(m => m.IdUserId)
                .HasColumnName("id_user_id");

            this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");

            this.Property(m => m.IdPeriodeAkuntansi)
                .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordingTime)
                .HasColumnName("real_recording_time");

            this.Property(m => m.KodeTransaksi)
                .HasColumnName("kode_transaksi");

            this.Property(m => m.NoInvoice)
                .HasColumnName("no_invoice");

            this.Property(m => m.IdPelanggan)
                .HasColumnName("id_pelanggan");

            this.Property(m => m.NamaPelanggan)
                .HasColumnName("nama_pelanggan");

            this.Property(m => m.NoHp)
                .HasColumnName("no_hp");

            this.Property(m => m.Email)
                .HasColumnName("email");

            this.Property(m => m.IdOrderPenjualan)
                .HasColumnName("id_order_penjualan");

            this.Property(m => m.NoOrderPenjualan)
                .HasColumnName("no_order_penjualan");

            this.Property(m => m.IdDo)
                .HasColumnName("id_do");

            this.Property(m => m.NoDo)
                .HasColumnName("no_do");

            this.Property(m => m.IdReferalTransaksi)
                .HasColumnName("id_referal_transaksi");

            this.Property(m => m.IdMataUang)
                .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
                .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
                .HasColumnName("kurs_tukar");

            this.Property(m => m.TanggalInvoice)
                .HasColumnName("tanggal_invoice");

            this.Property(m => m.IdNoReferensiDokumen)
                .HasColumnName("id_no_referensi_dokumen");

            this.Property(m => m.NoReferensiDokumen)
                .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
                .HasColumnName("nama_Lokasi");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
                .HasColumnName("id_departemen");

            this.Property(m => m.CheckboxInclusiveTax)
                .HasColumnName("checkbox_inclusive_tax");

            this.Property(m => m.IdBankCash)
               .HasColumnName("Id_bank_cash");

            this.Property(m => m.BankCash)
                .HasColumnName("bank_cash");

            this.Property(m => m.IdOpsiAnnual)
               .HasColumnName("id_opsi_annual");

            this.Property(m => m.Annual)
                .HasColumnName("annual");

            this.Property(m => m.IdTermPembayaran)
               .HasColumnName("id_term_pembayaran");

            this.Property(m => m.TermPembayaran)
                .HasColumnName("term_pembayaran");

            this.Property(m => m.NoReferalTransaksi)
                .HasColumnName("no_referal_transaksi");
        }
    }
}
