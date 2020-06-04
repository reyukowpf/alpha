using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDataDepartemenBLL
    {
        int AddDataDepartemen(DataDepartemen oData);
        bool EditDataDepartemen(DataDepartemen oData);
        bool RemoveDataDepartemen(int id);

    }
}
