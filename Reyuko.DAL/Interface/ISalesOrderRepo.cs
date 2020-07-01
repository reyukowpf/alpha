using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ISalesOrderRepo : IRepository<SalesOrder>
    {
        IEnumerable<SalesOrder> GetPaged(int pageIndex, int pageSize);
    }
}
