using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class InternalNoteConfig : EntityTypeConfiguration<InternalNote>
    {
        public InternalNoteConfig()
        {
            this.ToTable("internal_note");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.IdKontak)
                .HasColumnName("id_kontak");

            this.Property(m => m.NamaKontak)
                .HasColumnName("nama_kontak")
                .HasMaxLength(250)
                .IsRequired();

            this.Property(m => m.IdNoteType)
                .HasColumnName("id_note_type");

            this.Property(m => m.NoteType)
                .HasColumnName("note_type");
                
            this.Property(m => m.NoReferensi)
               .HasColumnName("no_referensi");

            this.Property(m => m.IdEmployee)
               .HasColumnName("id_employee");

            this.Property(m => m.NamaEmployee)
                .HasColumnName("nama_employee");

            this.Property(m => m.Tanggal)
                .HasColumnName("tanggal");

            this.Property(m => m.IdProyek)
             .HasColumnName("id_proyek");

            this.Property(m => m.IdDepartemen)
             .HasColumnName("id_departemen");

            this.Property(m => m.Judul)
             .HasColumnName("judul");

            this.Property(m => m.TanggalPengingat)
             .HasColumnName("tanggal_pengingat");

            this.Property(m => m.IdDokumen)
             .HasColumnName("id_dokumen");

            this.Property(m => m.NoReferensiDokumen)
            .HasColumnName("no_referensi_dokumen");

            this.Property(m => m.Konten)
            .HasColumnName("konten");
        }
    }
}
