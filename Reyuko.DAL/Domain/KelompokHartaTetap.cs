using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class KelompokHartaTetap
    {

        public int Id { get; set; }
        public string NamaKelompokHartaTetap { get; set; }
        public int? IdParent { get; set; }
        public string KodeKelompokHartaTetap {get;set;}
        public int? IdTabelPenyusutan { get; set; }
        public string NamaPenyusutan { get; set; }
        public int? UmurEkonomis { get; set; }
        public string Keterangan { get; set; }
        public int? IdAkunAsset { get; set; }
        public string KodeRekeningAsset { get; set; }
        public int? IdAkunAkumulasiPenyusutan { get; set; }
        public string KodeRekeningAkumulasiPenyusutan { get; set; }
        public int? IdAkunPenyusutan { get; set; }
        public string KodeRekeningPenyusutan { get; set; }
        public int? UserId { get; set; }
    }
}
