using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IGrupDiskonBLL
    {
        int AddGrupDiskon(GrupDiskon oData);
        bool EditGrupDiskon(GrupDiskon oData);
        bool RemoveGrupDiskon(int id);

    }
}
