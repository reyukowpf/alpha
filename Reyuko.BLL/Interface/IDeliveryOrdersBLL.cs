using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDeliveryOrdersBLL
    {
        int AddDeliveryOrder(Deliveryorders oData);
        bool EditDeliveryOrder(Deliveryorders oData);
        bool RemoveDeliveryOrder(int id);
        int AddOrderProdukjual(OrderProdukJual oData);
        bool EditOrderProdukjual(OrderProdukJual oData, Deliveryorders oDatas);

    }
}
