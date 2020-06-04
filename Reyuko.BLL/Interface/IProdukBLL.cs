using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IProdukBLL
    {
        int AddProduk(produk oData);
        bool EditProduk(produk oData);
        bool RemoveProduk(int id);

    }
}
