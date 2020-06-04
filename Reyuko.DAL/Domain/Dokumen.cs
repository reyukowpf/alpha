using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Dokumen
    {
        public int Id { get; set; }
        public int IdTypeDokumen { get; set; }
        public string TypeDokumen { get; set; }
        public string NoReferensiDokumen { get; set; }
        public DateTime? TanggalDokumen { get; set; }
        public int? IdKontak { get; set; }
        public string PelangganDokumen { get; set; }
        public int? IdProyek { get; set; }
        public int? IdDepartmen { get; set; } 
        public string KeteranganDokumen { get; set; }
        public string UploadFile1 { get; set; }
        public string UploadFile2 { get; set; }
        public string UploadFile3 { get; set; }
        public string UploadFile4 { get; set; }

    }
}
