using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class production
    {
        public int Id { get; set; }
        public int? IdDocumentReference { get; set; }
       public string DokumenReference { get; set; }
       public DateTime? Tanggal { get; set; }
       public int? IdLokasi { get; set; }
       public string Location { get; set; }
       public string Note { get; set; }
       public double? ProductionNumber { get; set; }
       public int? IdAkunPersediaanProduk { get; set; }
       public double? TotalDebitAkunPersediaanProduk { get; set; }
       public double? TotalKreditAkunPersediaanProduk { get; set; }
       public int? IdAkunProductionCustom { get; set; }
       public double? TotalDebitProductionCustom { get; set; }
       public double? TotalKreditProductionCustom { get; set; }
       public int? IdKontak { get; set; }
       public string NamaPetugas { get; set; }
       public int? IdKodeTransaksi { get; set; }
       public int? IdTransaksi { get; set; }
       public int? IdProyek { get; set; }
       public int? IdDepartmen { get; set; }
       public double? Total { get; set; }
       public double? Balance { get; set; }

    }
}
