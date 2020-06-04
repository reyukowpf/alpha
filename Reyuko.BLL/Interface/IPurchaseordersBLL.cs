using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IPurchaseordersBLL
    {
        int AddPurchaseorders(PurchaseOrder oData);
        bool EditPurchaseorders(PurchaseOrder oData);
        bool RemovePurchaseorders(int id);
        int AddOrderProdukbeli(OrderProdukBeli oData);
        bool EditOrderProdukbeli(OrderProdukBeli oData, PurchaseOrder oDatas);

    }
}
