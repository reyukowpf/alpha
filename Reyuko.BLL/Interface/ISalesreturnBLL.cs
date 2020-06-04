using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ISalesreturnBLL
    {
        int AddSalesreturns(Salesreturn oData);
        bool EditSalesreturns(Salesreturn oData);
        bool RemoveSalesreturns(int id);


    }
}
