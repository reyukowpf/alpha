using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class KlasifikasiKontak
    {
        public int Id { get; set; }
        public int? IdTypeKontak { get; set; }
        public string TypeKontak { get; set; }
        public string NamaKlasifikasiKontak { get; set; }
        public bool? CheckboxGender { get; set; }
        public bool? CheckboxPosition { get; set; }
        public bool? CheckboxTransaksi { get; set; }
        public bool? CheckboxOutstanding { get; set; }
        public bool? CheckboxPIC1 { get; set; }
        public string NamaPIC1 { get; set; }
        public bool? CheckboxGenderPIC1 { get; set; }
        public bool? CheckboxPositionPIC1 { get; set; }
        public bool? CheckboxPIC2 { get; set; }
        public string NamaPIC2 { get; set; }
        public bool? CheckboxGenderPIC2 { get; set; }
        public bool? CheckboxPositionPIC2 { get; set; }
        public bool? CheckboxPIC3 { get; set; }
        public string NamaPIC3{ get; set; }
        public bool? CheckboxGenderPIC3 { get; set; }
        public bool? CheckboxPositionPIC3 { get; set; }
        public string Note { get; set; }

    }
}
