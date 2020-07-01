using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IPurchasedeliveryBLL
    {
        int AddPurchasedelivery(Purchasedelivery oData);
        bool EditPurchasedelivery(Purchasedelivery oData);
        bool RemovePurchasedelivery(int id);
        int AddOrderProdukbeli(OrderProdukBeli oData);
        bool EditOrderProdukBeli(ListOrderBeli oData);

    }
}
