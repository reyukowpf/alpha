using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Reyuko.DAL.Domain
{
    public class RekeningPerkiraan
    {
        public int Id { get; set; }
        public string NamaRekeningPerkiraan { get; set; }
        public int? IdKlasifikasiRekeningPerkiraan { get; set; }
        public string KlasifikasiRekeningPerkiraan { get; set; }
        public string KodeRekening { get; set; }
        public string RadioButtonStandarKasBankDebtLoan { get; set; }
        public bool? CheckboxTidakAktif { get; set; }
        public int? IdDepartemen { get; set; }
        public string NamaDepartemen { get; set; }
        public int? IdMataUang { get; set; }
        public string MataUang { get; set; }
        public bool? CheckboxPasswordLock { get; set; }
        public object rekeningPerkiraansa { get; set; }
        public bool? Chekboxaktif { get; set; }
        
    }
}
