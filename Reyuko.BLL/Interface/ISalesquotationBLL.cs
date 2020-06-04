using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ISalesquotationBLL
    {
        int AddSalesquotation(Salesquotation oData);
        bool EditSalesquotation(Salesquotation oData);
        bool RemoveSalesquotation(int id);

    }
}
