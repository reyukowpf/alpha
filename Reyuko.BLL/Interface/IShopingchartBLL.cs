using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IShopingchartBLL
    {
        int AddShopingcharts(Shopingchart oData);
        bool EditShopingcharts(Shopingchart oData);
        bool RemoveShopingcharts(int id);

    }
}
