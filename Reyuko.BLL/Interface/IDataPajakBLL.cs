using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDataPajakBLL
    {
        int AddPajak(DataPajak oData);
        bool EditPajak(DataPajak oData);
        bool RemovePajak(int id);

    }
}
