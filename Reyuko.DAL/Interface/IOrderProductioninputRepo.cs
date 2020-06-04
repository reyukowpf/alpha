using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderProductioninputRepo : IRepository<OrderProductioninput>
    {
        IEnumerable<OrderProductioninput> GetPaged(int pageIndex, int pageSize);

    }
}
