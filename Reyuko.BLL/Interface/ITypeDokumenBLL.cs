using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ITypeDokumenBLL
    {
        int AddTypeDokumen(TypeDokumen oData);
        bool EditTypeDokumen(TypeDokumen oData);
        bool RemoveTypeDokumen(int id);

    }
}
