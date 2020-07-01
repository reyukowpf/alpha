using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class InternalNote
    {
        public int Id { get; set; }
        public int IdKontak { get; set; }
        public string NamaKontak { get; set; }
        public int? IdNoteType { get; set; }
        public string NoteType { get; set; }
        public string NoReferensi { get; set; }
        public int? IdEmployee { get; set; }
        public string NamaEmployee { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartemen { get; set; }
        public string Judul { get; set; }
        public DateTime? TanggalPengingat { get; set; }
        public int? IdDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public string Konten { get; set; }
        
    }
}
