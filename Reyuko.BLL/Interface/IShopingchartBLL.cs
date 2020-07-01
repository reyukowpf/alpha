using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IShopingchartBLL
    {
        int AddShopingcharts(Shopingchart oData);
        bool EditShopingcharts(Shopingchart oData);
        bool RemoveShopingcharts(int id);
        int AddOrderProdukbeli(OrderProdukBeli oData);
        int AddOrderJasabeli(OrderJasaBeli oData);
        int AddOrderCustombeli(OrderCustomBeli oData);
        bool EditOrderProdukBeli(ListOrderBeli oData, Shopingchart oDatas);
    }
}
