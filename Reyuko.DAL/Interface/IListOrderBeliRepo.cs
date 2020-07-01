using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListOrderBeliRepo : IRepository<ListOrderBeli>
    {
        IEnumerable<ListOrderBeli> GetPaged(int pageIndex, int pageSize);

    }
}
