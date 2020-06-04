using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ISalesOrderBLL
    {
        int AddSalesOrder(SalesOrder oData);
        bool EditSalesOrder(SalesOrder oData);
        bool RemoveSalesOrder(int id);

    }
}
