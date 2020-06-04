using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class productionConfig : EntityTypeConfiguration<production>
    {
        public productionConfig()
        {
            this.ToTable("production");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdDocumentReference)
                .HasColumnName("id_document_reference");

            this.Property(m => m.DokumenReference)
                .HasColumnName("dokumen_reference");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdLokasi)
                .HasColumnName("id_lokasi");

            this.Property(m => m.Location)
                .HasColumnName("location");

            this.Property(m => m.Note)
                .HasColumnName("note");

            this.Property(m => m.ProductionNumber)
                .HasColumnName("production_number");

            this.Property(m => m.IdAkunPersediaanProduk)
                .HasColumnName("id_akun_persediaan_produk");

            this.Property(m => m.TotalDebitAkunPersediaanProduk)
                .HasColumnName("total_debit_akun_persediaan_produk");

            this.Property(m => m.TotalKreditAkunPersediaanProduk)
                .HasColumnName("total_kredit_akun_persediaan_produk");

            this.Property(m => m.IdAkunProductionCustom)
                .HasColumnName("id_akun_production_custom");

            this.Property(m => m.TotalDebitProductionCustom)
                .HasColumnName("total_debit_production_custom");

            this.Property(m => m.TotalKreditProductionCustom)
                .HasColumnName("total_kredit_production_custom");

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

            this.Property(m => m.NamaPetugas)
                .HasColumnName("nama_petugas");

            this.Property(m => m.IdKodeTransaksi)
                .HasColumnName("id_kode_transaksi");

            this.Property(m => m.IdTransaksi)
                .HasColumnName("id_transaksi");

            this.Property(m => m.IdProyek)
                .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartmen)
                .HasColumnName("id_departmen");

            this.Property(m => m.Total)
                .HasColumnName("total");

            this.Property(m => m.Balance)
                .HasColumnName("balance");

        }
    }
}
