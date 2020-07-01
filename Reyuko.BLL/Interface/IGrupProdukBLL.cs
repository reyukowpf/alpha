using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IGrupProdukBLL
    {
        int AddGrupProduk(GrupProduk oData);
        bool EditGrupProduk(GrupProduk oData);
        bool RemoveGrupProduk(int id);

    }
}
