using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ITypeKontakBLL
    {
        int AddTypeKontak(TypeKontak oData);
        bool EditTypeKontak(TypeKontak oData);
        bool RemoveTypeKontak(int id);

    }
}
