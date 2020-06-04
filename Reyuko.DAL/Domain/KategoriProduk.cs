using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reyuko.DAL.Domain
{
    public class KategoriProduk
    {
        public int Id { get; set; }
        public string ProdukKategori { get; set; }
        public int? IdProdukKategoriParent { get; set; }
        public string ProdukKategoriParent { get; set; }
        public string deskripsi { get; set; }
        
    }
}
