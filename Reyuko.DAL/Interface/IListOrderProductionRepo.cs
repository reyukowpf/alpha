using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListOrderProductionRepo : IRepository<ListOrderProduction>
    {
        IEnumerable<ListOrderProduction> GetPaged(int pageIndex, int pageSize);

    }
}
