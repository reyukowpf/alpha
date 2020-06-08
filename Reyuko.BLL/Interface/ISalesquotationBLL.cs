using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ISalesquotationBLL
    {
        int AddSalesquotation(Salesquotation oData);
        bool EditSalesquotation(Salesquotation oData);
        bool RemoveSalesquotation(int id);
        int AddOrderProdukjual(OrderProdukJual oData);
        bool EditOrderProdukjual(OrderProdukJual oData, Salesquotation oDatas);

    }
}
