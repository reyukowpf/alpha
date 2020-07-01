using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IKategoriProdukBLL
    {
        int AddKategoriProduk(KategoriProduk oData);
        bool EditKategoriProduk(KategoriProduk oData);
        bool RemoveKategoriProduk(int id);

    }
}
