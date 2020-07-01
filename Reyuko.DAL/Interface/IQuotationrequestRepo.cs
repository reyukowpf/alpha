using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IQuotationrequestRepo : IRepository<Quotationrequest>
    {
        IEnumerable<Quotationrequest> GetPaged(int pageIndex, int pageSize);
    }
}
