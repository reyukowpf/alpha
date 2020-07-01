using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDataGiroBLL
    {
        int AddDataGiro(DataGiro oData);
        bool EditDataGiro(DataGiro oData);
        bool RemoveDataGiro(int id);

    }
}
