using System;
using System.Collections.Generic;

namespace Reyuko.DAL.Domain
{
    public class TypeProduk
    {
        public int Id { get; set; }
        public string NamaTypeProduk { get; set; }
        public int? IdMataUang { get; set; }
        public int? IdProdukKategori { get; set; }
        public string ProdukKategori { get; set; }
        public int? HargaPokokOption { get; set; }
        public int? IdAkunHargaPokok { get; set; }
        public bool? PenjualanOption { get; set; }
        public int? IdAkunPenjualan { get; set; }
        public bool? PersediaanOption { get; set; }
        public int? IdAkunPersediaan { get; set; }
        public bool? PengirimanBeliOption { get; set; }
        public int? IdAkunPengirimanBeli { get; set; }
        public bool? PengirimanJualOption { get; set; }
        public int? IdAkunPengirimanJual { get; set; }
        public bool? ReturPenjualanOption { get; set; }
        public int? IdAkunReturPenjualan { get; set; }
        public bool? ServiceOption { get; set; }
        public int? IdAkunService { get; set; }
        public int? UserId { get; set; }
    }
}
