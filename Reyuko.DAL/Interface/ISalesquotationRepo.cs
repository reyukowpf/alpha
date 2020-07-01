using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ISalesquotationRepo : IRepository<Salesquotation>
    {
        IEnumerable<Salesquotation> GetPaged(int pageIndex, int pageSize);
    }
}
