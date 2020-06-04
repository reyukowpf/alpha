using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderInventoriRepo : IRepository<OrderInventori>
    {
        IEnumerable<OrderInventori> GetPaged(int pageIndex, int pageSize);

    }
}
