using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IProductionBLL
    {
        int AddProduction(production oData);
        bool EditProduction(production oData);
        bool RemoveProduction(int id);
        int AddOrderProdutioninput(OrderProductioninput oData);
        bool EditProductioninput(ListOrderProduction oData, production oDatas);
        int AddOrderProdutioncustom(OrderProductioncustom oData);
        int AddOrderFinishedproduk(OrderFinishedproduk oData);
        bool EditFinishedproduk(OrderFinishedproduk oData, production oDatas);
    }
}
