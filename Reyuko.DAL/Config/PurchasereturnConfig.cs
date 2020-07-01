using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class PurchasereturnConfig : EntityTypeConfiguration<Purchasereturn>
    {
        public PurchasereturnConfig()
        {
            this.ToTable("purchase_return");
            this.HasKey(m => m.IdReturPembelian);
            this.Property(m => m.IdReturPembelian)
                .HasColumnName("id_retur_pembelian")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");
                
            this.Property(m => m.CheckboxUnposted)
                .HasColumnName("checkbox_unposted");

            this.Property(m => m.CheckboxTunaiTermPembayaran)
           .HasColumnName("checkbox_tunai_term_pembayaran");

            this.Property(m => m.DropdownTermPembayaran)
      .HasColumnName("dropdown_term_pembayaran");

            this.Property(m => m.DropdownBankKas)
      .HasColumnName("dropdown_bank_kas");

            this.Property(m => m.IdAkunStokProduk)
      .HasColumnName("id_akun_stok_produk");

            this.Property(m => m.TotalDebitAkunStokProduk)
      .HasColumnName("total_debit_akun_stok_produk");

            this.Property(m => m.TotalKreditAkunStokProduk)
      .HasColumnName("total_kredit_akun_stok_produk");

            this.Property(m => m.IdAkunPembelianJasa)
      .HasColumnName("id_akun_pembelian_jasa");

            this.Property(m => m.TotalDebitPembelianJasa)
      .HasColumnName("total_debit_pembelian_jasa");

            this.Property(m => m.TotalKreditPembelianJasa)
      .HasColumnName("total_kredit_pembelian_jasa");

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

            this.Property(m => m.TotalKreditAkunPajakJasa )
      .HasColumnName("total_kredit_akun_pajak_jasa");

            this.Property(m => m.IdAkunTunaiPembelian)
      .HasColumnName("id_akun_tunai_pembelian");

            this.Property(m => m.TotalDebitAkunTunaiPembelian)
      .HasColumnName("total_debit_akun_tunai_pembelian");

            this.Property(m => m.TotalKreditAkunTunaiPembelian)
      .HasColumnName("total_kredit_akun_tunai_pembelian");

            this.Property(m => m.IdAkunHutangPembelian)
      .HasColumnName("id_akun_hutang_pembelian");

            this.Property(m => m.TotalDebitAkunHutangPembelian)
      .HasColumnName("total_debit_akun_hutang_pembelian");

            this.Property(m => m.TotalKreditAkunHutangPembelian)
      .HasColumnName("total_kredit_akun_hutang_pembelian");

            this.Property(m => m.IdKodeTransaksi)
      .HasColumnName("id_kode_transaksi");

            this.Property(m => m.TotalSebelumPajak)
      .HasColumnName("total_sebelum_pajak");

            this.Property(m => m.TotalPajak)
      .HasColumnName("total_pajak");

            this.Property(m => m.TotalSetelahPajak)
      .HasColumnName("total_setelah_pajak");

            this.Property(m => m.CheckboxManual)
      .HasColumnName("checkbox_manual");

            this.Property(m => m.IdReferalPa)
      .HasColumnName("id_referal_pa");

            this.Property(m => m.LunasUangMuka)
      .HasColumnName("lunas_uang_muka");

            this.Property(m => m.SaldoPiutang)
      .HasColumnName("saldo_piutang");

            this.Property(m => m.CicilanPerBulan)
      .HasColumnName("cicilan_per_bulan");

            this.Property(m => m.Angsuran)
      .HasColumnName("angsuran");

            this.Property(m => m.DueDate)
      .HasColumnName("due_date");

            this.Property(m => m.IdUserId)
      .HasColumnName("id_user_id");

            this.Property(m => m.IdPeriodeAkuntansi)
      .HasColumnName("id_periode_akuntansi");

            this.Property(m => m.RealRecordingTime)
      .HasColumnName("real_recording_time");

            this.Property(m => m.IdTransaksi)
      .HasColumnName("id_transaksi");

            this.Property(m => m.KodeTransaksi)
      .HasColumnName("kode_transaksi");

            this.Property(m => m.NoReturPembelian)
      .HasColumnName("no_retur_pembelian");
            
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

            this.Property(m => m.NoReferensiTransaksi)
     .HasColumnName("no_referensi_transaksi");

            this.Property(m => m.IdMataUang)
     .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
     .HasColumnName("mata_uang");

            this.Property(m => m.KursTukar)
     .HasColumnName("kurs_tukar");
            
            this.Property(m => m.TanggalReturPembelian)
           .HasColumnName("tanggal_retur_pembelian");

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
