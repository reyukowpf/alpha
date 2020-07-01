using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface INamaPenyusutanBLL
    {
        int AddNamaPenyusutan(NamaPenyusutan oData);
        bool EditNamaPenyusutan(NamaPenyusutan oData);
        bool RemoveNamaPenyusutan(int id);

    }
}
