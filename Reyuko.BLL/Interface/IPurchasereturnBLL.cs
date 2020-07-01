using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IPurchasereturnBLL
    {
        int AddPurchasereturn(Purchasereturn oData);
        bool EditPurchasereturn(Purchasereturn oData);
        bool RemovePurchasereturn(int id);
        bool EditOrderCustomBeli(ListOrderBeli oData, Purchasereturn oDatas);
    }
}
