using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class KelompokHartaTetapConfig : EntityTypeConfiguration<KelompokHartaTetap>
    {
        public KelompokHartaTetapConfig()
        {
            this.ToTable("kelompok_harta_tetap");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.NamaKelompokHartaTetap)
                .HasColumnName("nama_kelompok_harta_tetap")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.IdParent)
                .HasColumnName("id_parent");

            this.Property(m => m.KodeKelompokHartaTetap)
                .HasColumnName("kode_kelompok_harta_tetap")
                .HasMaxLength(100);

            this.Property(m => m.IdTabelPenyusutan)
                .HasColumnName("id_tabel_penyusutan");

            this.Property(m => m.NamaPenyusutan)
                .HasColumnName("nama_penyusutan");

            this.Property(m => m.UmurEkonomis)
                .HasColumnName("umur_ekonomis");

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan")
                .HasMaxLength(255);

            this.Property(m => m.IdAkunAsset)
                .HasColumnName("id_akun_asset");

            this.Property(m => m.KodeRekeningAsset)
                .HasColumnName("kode_rekening_asset");

            this.Property(m => m.IdAkunAkumulasiPenyusutan)
                .HasColumnName("id_akun_akumulasi_penyusutan");

            this.Property(m => m.KodeRekeningAkumulasiPenyusutan)
                .HasColumnName("kode_rekening_akumulasi_Penyusutan");

            this.Property(m => m.IdAkunPenyusutan)
                .HasColumnName("id_akun_penyusutan");

            this.Property(m => m.KodeRekeningPenyusutan)
                .HasColumnName("kode_rekening_penyusutan");

            this.Property(m => m.UserId)
                .HasColumnName("user_id");


        }
    }
}
