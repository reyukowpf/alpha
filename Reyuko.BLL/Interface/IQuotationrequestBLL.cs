using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IQuotationrequestBLL
    {
        int AddQuotationrequests(Quotationrequest oData);
        bool EditQuotationrequests(Quotationrequest oData);
        bool RemoveQuotationrequests(int id);
        bool EditOrderProdukBeli(ListOrderBeli oData, Quotationrequest oDatas, produk oDatap);
        bool EditOrderProdukBeli1(ListOrderBeli oData);
    }
}
