using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderProdukBeliRepo : IRepository<OrderProdukBeli>
    {
        IEnumerable<OrderProdukBeli> GetPaged(int pageIndex, int pageSize);

    }
}
