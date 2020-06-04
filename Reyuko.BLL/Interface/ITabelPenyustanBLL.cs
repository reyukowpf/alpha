using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ITabelPenyusutanBLL
    {
        int AddTabelPenyusutan(TabelPenyusutan oData);
        bool EditTabelPenyusutan(TabelPenyusutan oData);
        bool RemoveTabelPenyusutan(int id);

    }
}
