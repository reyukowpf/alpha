using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class Kontak
    {
        public int Id { get; set; }
        public int? IdTypeKontak { get; set; }
        public string TypeKontak { get; set; }
        public int? IdKlasifikasiKontak { get; set; }
        public string KlasifikasiKontak { get; set; }
        public string KontakID { get; set; }
        public string NamaA { get; set; }
        public string NoHPA { get; set; }
        public string EmailA { get; set; }
        public bool? GenderA { get; set; }
        public int? IdNegaraA { get; set; }
        public string NegaraA { get; set; }
        public string AlamatA { get; set; }
        public string KotaA { get; set; }
        public int? IdPropinsiA { get; set; }
        public string PropinsiA { get; set; }
        public string KodePosA { get; set; }
        public string MapLocationA { get; set; }
        public string PositionA { get; set; }
        public string KeteranganA { get; set; }
        public string UploadPhotoA { get; set; }

        public string NamaB { get; set; }
        public string NoHPB { get; set; }
        public string EmailB { get; set; }
        public bool? GenderB { get; set; }
        public int? IdNegaraB { get; set; }
        public string NegaraB { get; set; }
        public string AlamatB { get; set; }
        public string KotaB { get; set; }
        public int? IdPropinsiB { get; set; }
        public string PropinsiB { get; set; }
        public string KodePosB { get; set; }
        public string MapLocationB { get; set; }
        public string PositionB { get; set; }
        public string KeteranganB { get; set; }
        public string UploadPhotoB { get; set; }

        public string NamaC { get; set; }
        public string NoHPC { get; set; }
        public string EmailC { get; set; }
        public bool? GenderC { get; set; }
        public int? IdNegaraC { get; set; }
        public string NegaraC { get; set; }
        public string AlamatC { get; set; }
        public string KotaC { get; set; }
        public int? IdPropinsiC { get; set; }
        public string PropinsiC { get; set; }
        public string KodePosC { get; set; }
        public string MapLocationC { get; set; }
        public string PositionC { get; set; }
        public string KeteranganC { get; set; }
        public string UploadPhotoC { get; set; }

        public string NamaD { get; set; }
        public string NoHPD { get; set; }
        public string EmailD { get; set; }
        public bool? GenderD { get; set; }
        public int? IdNegaraD { get; set; }
        public string NegaraD { get; set; }
        public string AlamatD { get; set; }
        public string KotaD { get; set; }
        public int? IdPropinsiD { get; set; }
        public string PropinsiD { get; set; }
        public string KodePosD { get; set; }
        public string MapLocationD { get; set; }
        public string PositionD { get; set; }
        public string KeteranganD { get; set; }
        public string UploadPhotoD { get; set; }


        public int? IdGrupDiskon { get; set; }
        public string NamaGrupDiskon { get; set; }
        public int? IdGolongan { get; set; }
        public string NamaGolongan { get; set; }
        public double? GajiPokok { get; set; }
        public double? Tunjangan { get; set; }
        public double? OvertimeHour { get; set; }
        public bool? IncludePajak { get; set; }
        public int? IdDepartemen { get; set; }
        public string NamaDepartemen { get; set; }
        public int? IdLokasi { get; set; }
        public string Lokasi { get; set; }
        public int? IdProyek { get; set; }
        public string Proyek { get; set; }
        public string NPWPA { get; set; }
        public string BatasKreditA { get; set; }
        public string NamaBankA { get; set; }
        public double? NoRekA { get; set; }
        public string NamaBukuRekening { get; set; }
        public int? IdUserId { get; set; }
        public DateTime? RealTimeRecording { get; set; }

    }
}
