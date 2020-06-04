using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IProductionBLL
    {
        int AddProduction(production oData);
        bool EditProduction(production oData);
        bool RemoveProduction(int id);
        int AddOrderProdutioninput(OrderProductioninput oData);
        bool EditProductioninput(OrderProductioninput oData, production oDatas);
        int AddOrderProdutioncustom(OrderProductioncustom oData);
        bool EditProductioncustom(OrderProductioncustom oData, production oDatas);
        int AddOrderFinishedproduk(OrderFinishedproduk oData);
        bool EditFinishedproduk(OrderFinishedproduk oData, production oDatas);
    }
}
