using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IQuotationrequestBLL
    {
        int AddQuotationrequests(Quotationrequest oData);
        bool EditQuotationrequests(Quotationrequest oData);
        bool RemoveQuotationrequests(int id);

    }
}
