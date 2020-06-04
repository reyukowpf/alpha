using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDataProyekBLL
    {
        int AddDataProyek(DataProyek oData);
        bool EditDataProyek(DataProyek oData);
        bool RemoveDataProyek(int id);

    }
}
