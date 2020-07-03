using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class produkConfig : EntityTypeConfiguration<produk>
    {
        public produkConfig()
        {
            this.ToTable("produk");
            this.HasKey(m => m.IdProduk);
            this.Property(m => m.IdProduk)
                .HasColumnName("id_produk")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.JumlahStok)
                .HasColumnName("jumlah_stok");
                
            this.Property(m => m.BatasStokMin)
                .HasColumnName("batas_stok_min");


            this.Property(m => m.TipeHargaPokok)
               .HasColumnName("tipe_harga_pokok");


            this.Property(m => m.IdTipeProduk)
             .HasColumnName("id_tipe_produk");

            this.Property(m => m.TipeProduk)
              .HasColumnName("tipe_produk");

            this.Property(m => m.IdAkunHargaPokok)
              .HasColumnName("id_akun_harga_pokok");

            this.Property(m => m.IdAkunPenjualan)
              .HasColumnName("id_akun_penjualan");

            this.Property(m => m.IdAkunPersediaan)
            .HasColumnName("id_akun_persediaan");

            this.Property(m => m.IdAkunPengirimanBeli)
            .HasColumnName("id_akun_pengiriman_beli");

            this.Property(m => m.IdAkunPengirimanJual)
           .HasColumnName("id_akun_pengiriman_jual");

            this.Property(m => m.IdAkunReturPenjualan)
           .HasColumnName("id_akun_retur_penjualan");

            this.Property(m => m.IdAkunJasa)
           .HasColumnName("id_akun_jasa");

            this.Property(m => m.Keterangan)
           .HasColumnName("keterangan");

            this.Property(m => m.CheckboxPajak)
           .HasColumnName("checkbox_pajak");

            this.Property(m => m.IdPajak)
           .HasColumnName("id_pajak");

            this.Property(m => m.Pajak)
           .HasColumnName("pajak");

            this.Property(m => m.PersentasePajak)
           .HasColumnName("persentase_pajak");

            this.Property(m => m.IdAkunPajak)
           .HasColumnName("id_akun_pajak");

            this.Property(m => m.CheckBoxInclusiveTax)
           .HasColumnName("checkbox_inclusive_tax");

            this.Property(m => m.Panjang)
           .HasColumnName("panjang");

            this.Property(m => m.Lebar)
           .HasColumnName("lebar");

            this.Property(m => m.Tinggi)
           .HasColumnName("tinggi");

            this.Property(m => m.Berat)
           .HasColumnName("berat");

            this.Property(m => m.UploadImage0)
           .HasColumnName("upload_image0");

            this.Property(m => m.UploadImage1)
           .HasColumnName("upload_image1");

            this.Property(m => m.UploadImage2)
           .HasColumnName("upload_image2");

            this.Property(m => m.CheckBoxTidakAktif)
           .HasColumnName("check_box_tidak_aktif");

            this.Property(m => m.UploadImage3)
           .HasColumnName("upload_image3");

            this.Property(m => m.IdKontak)
           .HasColumnName("id_kontak");

            this.Property(m => m.SuplierA)
           .HasColumnName("suplier_a");

            this.Property(m => m.KeteranganSuplierA)
           .HasColumnName("keterangan_suplier_a");

            this.Property(m => m.SuplierB)
           .HasColumnName("suplier_b");

            this.Property(m => m.KeteranganSuplierB)
           .HasColumnName("keterangan_suplier_b");

            this.Property(m => m.SuplierC)
           .HasColumnName("suplier_c");

            this.Property(m => m.KeteranganSuplierC)
           .HasColumnName("keterangan_suplier_c");

            this.Property(m => m.SuplierD)
           .HasColumnName("suplier_d");

            this.Property(m => m.KeteranganSuplierD)
           .HasColumnName("keterangan_suplier_d");

            this.Property(m => m.CheckboxService)
           .HasColumnName("checkbox_service");

            this.Property(m => m.IdProdukKategori)
           .HasColumnName("id_produk_kategori");

            this.Property(m => m.ProdukKategori)
           .HasColumnName("produk_kategori");

            this.Property(m => m.SKU)
           .HasColumnName("sku");

            this.Property(m => m.IdGroupProduk)
           .HasColumnName("id_group_produk");

            this.Property(m => m.NamaGroupProduk)
           .HasColumnName("nama_group_produk");

            this.Property(m => m.NamaProduk)
           .HasColumnName("nama_produk");

            this.Property(m => m.HargaPokokAverage)
           .HasColumnName("harga_pokok_average");

            this.Property(m => m.HargaBeli)
           .HasColumnName("harga_beli");

            this.Property(m => m.HargaJual)
           .HasColumnName("harga_jual");

            this.Property(m => m.IdMataUang)
           .HasColumnName("id_mata_uang");

            this.Property(m => m.MataUang)
           .HasColumnName("mata_uang");

            this.Property(m => m.TimeBasedUnit)
           .HasColumnName("time_based_unit");

            this.Property(m => m.N1Calculation)
           .HasColumnName("n_1_calculation");

            this.Property(m => m.CheckboxKalender)
           .HasColumnName("check_box_kalender");

            this.Property(m => m.IdSatuanDasar)
           .HasColumnName("id_satuan_dasar");

            this.Property(m => m.SatuanDasar)
           .HasColumnName("satuan_dasar");
            
            this.Property(m => m.MinPemesanan)
           .HasColumnName("min_pemesanan");

            this.Property(m => m.CheckboxDiskonProduk)
           .HasColumnName("checkbox_diskon_produk");

            this.Property(m => m.CheckboxUbahHarga)
           .HasColumnName("checkbox_ubah_harga");

            this.Property(m => m.DiskonProdukPersen)
           .HasColumnName("diskon_produk_persen");

            this.Property(m => m.TanggalMulaiDiskonProduk)
           .HasColumnName("tanggal_mulai_diskon_produk");

            this.Property(m => m.TanggalBerakhirDiskonProduk)
           .HasColumnName("tanggal_berakhir_diskon_produk");

            this.Property(m => m.CheckboxManageStok)
           .HasColumnName("checkbox_manage_stok");

            this.Property(m => m.IdLokasi)
          .HasColumnName("id_lokasi");

            this.Property(m => m.NamaLokasi)
          .HasColumnName("nama_lokasi");

            this.Property(m => m.Tanggal)
          .HasColumnName("tanggal");

            this.Property(m => m.ReceivedNumber)
          .HasColumnName("received_number");

            this.Property(m => m.IdDropdownBankkas)
          .HasColumnName("id_dropdown_bank_kas");

            this.Property(m => m.DropdownBankkas)
          .HasColumnName("dropdown_bank_kas");

            this.Property(m => m.AKtif)
       .HasColumnName("aktif");
        }
    }
}
