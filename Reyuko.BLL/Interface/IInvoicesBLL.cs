using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IInvoicesBLL
    {
        int AddInvoices(invoice oData);
        bool EditInvoices(invoice oData);
        bool RemoveInvoices(int id);
        int AddOrderProdukjual(OrderProdukJual oData);
        bool EditOrderProdukJual(ListOrderJual oData, invoice oDatas);
        int AddOrderJasaJual(OrderJasaJual oData);
        int AddOrderCustomJual(OrderCustomJual oData);
    }
}
