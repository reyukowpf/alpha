using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class KontakConfig : EntityTypeConfiguration<Kontak>
    {
        public KontakConfig()
        {
            this.ToTable("kontak");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdTypeKontak)
                .HasColumnName("id_type_kontak")
                .IsRequired();

            this.Property(m => m.TypeKontak)
                .HasColumnName("type_kontak")
                .HasMaxLength(100);

            this.Property(m => m.IdKlasifikasiKontak)
                .HasColumnName("id_klasifikasi_kontak")
                .IsRequired();

            this.Property(m => m.KlasifikasiKontak)
                .HasColumnName("klasifikasi_kontak")
                .HasMaxLength(100);

            this.Property(m => m.KontakID)
                .HasColumnName("kontakid")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NamaA)
                .HasColumnName("nama_a")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.NoHPA)
                .HasColumnName("no_hp_a")
                .HasMaxLength(100);

            this.Property(m => m.EmailA)
                .HasColumnName("email_a")
                .HasMaxLength(100);

            this.Property(m => m.GenderA)
                .HasColumnName("gender_a");

            this.Property(m => m.IdNegaraA)
                .HasColumnName("id_negara_a");

            this.Property(m => m.NegaraA)
                .HasColumnName("negara_a")
                .HasMaxLength(100);

            this.Property(m => m.AlamatA)
                .HasColumnName("alamat_a")
                .HasMaxLength(255);

            this.Property(m => m.KotaA)
                .HasColumnName("kota_a")
                .HasMaxLength(100);

            this.Property(m => m.IdPropinsiA)
                .HasColumnName("id_propinsi_a");

            this.Property(m => m.PropinsiA)
                .HasColumnName("propinsi_a")
                .HasMaxLength(100);

            this.Property(m => m.KodePosA)
                .HasColumnName("kode_pos_a")
                .HasMaxLength(100);

            this.Property(m => m.MapLocationA)
                .HasColumnName("map_location_a")
                .HasMaxLength(255);

            this.Property(m => m.PositionA)
                .HasColumnName("position_a")
                .HasMaxLength(255);

            this.Property(m => m.KeteranganA)
                .HasColumnName("keterangan_a")
                .HasMaxLength(255);

            this.Property(m => m.UploadPhotoA)
                .HasColumnName("upload_photo_a")
                .HasMaxLength(255);

            this.Property(m => m.NamaB)
                .HasColumnName("nama_b")
                .HasMaxLength(100);

            this.Property(m => m.NoHPB)
                .HasColumnName("no_hp_b")
                .HasMaxLength(100);

            this.Property(m => m.EmailB)
                .HasColumnName("email_b")
                .HasMaxLength(100);

            this.Property(m => m.GenderB)
                .HasColumnName("gender_b");

            this.Property(m => m.IdNegaraB)
                .HasColumnName("id_negara_b");

            this.Property(m => m.NegaraB)
                .HasColumnName("negara_b")
                .HasMaxLength(100);

            this.Property(m => m.AlamatB)
                .HasColumnName("alamat_b")
                .HasMaxLength(255);

            this.Property(m => m.KotaB)
                .HasColumnName("kota_b")
                .HasMaxLength(100);

            this.Property(m => m.IdPropinsiB)
                .HasColumnName("id_propinsi_b");

            this.Property(m => m.PropinsiB)
                .HasColumnName("propinsi_b")
                .HasMaxLength(100);

            this.Property(m => m.KodePosB)
                .HasColumnName("kode_pos_b")
                .HasMaxLength(100);

            this.Property(m => m.MapLocationB)
                .HasColumnName("map_location_b")
                .HasMaxLength(255);

            this.Property(m => m.PositionB)
                .HasColumnName("position_b")
                .HasMaxLength(255);

            this.Property(m => m.KeteranganB)
                .HasColumnName("keterangan_b")
                .HasMaxLength(255);

            this.Property(m => m.UploadPhotoB)
                .HasColumnName("upload_photo_b")
                .HasMaxLength(255);

            this.Property(m => m.NamaC)
                .HasColumnName("nama_c")
                .HasMaxLength(100);

            this.Property(m => m.NoHPC)
                .HasColumnName("no_hp_c")
                .HasMaxLength(100);

            this.Property(m => m.EmailC)
                .HasColumnName("email_c")
                .HasMaxLength(100);

            this.Property(m => m.GenderC)
                .HasColumnName("gender_c");

            this.Property(m => m.IdNegaraC)
                .HasColumnName("id_negara_c");

            this.Property(m => m.NegaraC)
                .HasColumnName("negara_c")
                .HasMaxLength(100);

            this.Property(m => m.AlamatC)
                .HasColumnName("alamat_c")
                .HasMaxLength(255);

            this.Property(m => m.KotaC)
                .HasColumnName("kota_c")
                .HasMaxLength(100);

            this.Property(m => m.IdPropinsiC)
                .HasColumnName("id_propinsi_c");

            this.Property(m => m.PropinsiC)
                .HasColumnName("propinsi_c")
                .HasMaxLength(100);

            this.Property(m => m.KodePosC)
                .HasColumnName("kode_pos_c")
                .HasMaxLength(100);

            this.Property(m => m.MapLocationC)
                .HasColumnName("map_location_c")
                .HasMaxLength(255);

            this.Property(m => m.PositionC)
                .HasColumnName("position_c")
                .HasMaxLength(255);

            this.Property(m => m.KeteranganC)
                .HasColumnName("keterangan_c")
                .HasMaxLength(255);

            this.Property(m => m.UploadPhotoC)
                .HasColumnName("upload_photo_c")
                .HasMaxLength(255);

            this.Property(m => m.NamaD)
                .HasColumnName("nama_d")
                .HasMaxLength(100);

            this.Property(m => m.NoHPD)
                .HasColumnName("no_hp_d")
                .HasMaxLength(100);

            this.Property(m => m.EmailD)
                .HasColumnName("email_d")
                .HasMaxLength(100);

            this.Property(m => m.GenderD)
                .HasColumnName("gender_d");

            this.Property(m => m.IdNegaraD)
                .HasColumnName("id_negara_d");

            this.Property(m => m.NegaraD)
                .HasColumnName("negara_d")
                .HasMaxLength(100);

            this.Property(m => m.AlamatD)
                .HasColumnName("alamat_d")
                .HasMaxLength(255);

            this.Property(m => m.KotaD)
                .HasColumnName("kota_d")
                .HasMaxLength(100);

            this.Property(m => m.IdPropinsiD)
                .HasColumnName("id_propinsi_d");

            this.Property(m => m.PropinsiD)
                .HasColumnName("propinsi_d")
                .HasMaxLength(100);

            this.Property(m => m.KodePosD)
                .HasColumnName("kode_pos_d")
                .HasMaxLength(100);

            this.Property(m => m.MapLocationD)
                .HasColumnName("map_location_d")
                .HasMaxLength(255);

            this.Property(m => m.PositionD)
                .HasColumnName("position_d")
                .HasMaxLength(255);

            this.Property(m => m.KeteranganD)
                .HasColumnName("keterangan_d")
                .HasMaxLength(255);

            this.Property(m => m.UploadPhotoD)
                .HasColumnName("upload_photo_d")
                .HasMaxLength(255);

            this.Property(m => m.IdGrupDiskon)
               .HasColumnName("id_grup_diskon");

            this.Property(m => m.NamaGrupDiskon)
               .HasColumnName("nama_grup_diskon")
               .HasMaxLength(100);

            this.Property(m => m.IdGolongan)
               .HasColumnName("id_golongan");

            this.Property(m => m.NamaGolongan)
               .HasColumnName("nama_golongan")
               .HasMaxLength(100);

            this.Property(m => m.GajiPokok)
               .HasColumnName("gaji_pokok");

            this.Property(m => m.Tunjangan)
               .HasColumnName("tunjangan");

            this.Property(m => m.OvertimeHour)
               .HasColumnName("overtime_hour");

            this.Property(m => m.IncludePajak)
               .HasColumnName("include_exclude_pajak");

            this.Property(m => m.IdDepartemen)
               .HasColumnName("id_departemen");

            this.Property(m => m.NamaDepartemen)
               .HasColumnName("nama_departemen")
               .HasMaxLength(100);

            this.Property(m => m.IdLokasi)
               .HasColumnName("id_lokasi");

            this.Property(m => m.Lokasi)
               .HasColumnName("lokasi")
               .HasMaxLength(100);

            this.Property(m => m.IdProyek)
               .HasColumnName("id_proyek");

            this.Property(m => m.Proyek)
               .HasColumnName("proyek")
               .HasMaxLength(100);

            this.Property(m => m.NPWPA)
               .HasColumnName("npwp_a");
             
            this.Property(m => m.BatasKreditA)
               .HasColumnName("batas_kredit_a");

            this.Property(m => m.NamaBankA)
               .HasColumnName("nama_bank_a")
               .HasMaxLength(100);

            this.Property(m => m.NoRekA)
               .HasColumnName("no_rek_a");
               
            this.Property(m => m.NamaBukuRekening)
               .HasColumnName("nama_buku_rekening")
               .HasMaxLength(100);

            this.Property(m => m.IdUserId)
               .HasColumnName("id_user_id");

            this.Property(m => m.RealTimeRecording)
               .HasColumnName("real_time_recording");
        }
    }
}
