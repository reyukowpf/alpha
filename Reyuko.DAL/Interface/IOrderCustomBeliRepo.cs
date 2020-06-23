using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderCustomBeliRepo : IRepository<OrderCustomBeli>
    {
        IEnumerable<OrderCustomBeli> GetPaged(int pageIndex, int pageSize);

    }
}
