using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Config
{
    public class NoteTypeConfig : EntityTypeConfiguration<NoteType>
    {
        public NoteTypeConfig()
        {
            this.ToTable("note_type");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Type)
                .HasColumnName("note_type")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(m => m.Keterangan)
                .HasColumnName("keterangan")
                .HasMaxLength(255);

            this.Property(m => m.Template)
                  .HasColumnName("template")
                  .HasMaxLength(255);

        }
    }
}
