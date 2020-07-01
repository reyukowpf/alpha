using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IReturBarangBLL
    {
        int AddReturBarang(ReturBarang oData);
        bool EditReturBarang(ReturBarang oData);
        bool RemoveReturBarang(int id);
        bool EditInventory(OrderInventori oData, ReturBarang oDatas);

    }
}
