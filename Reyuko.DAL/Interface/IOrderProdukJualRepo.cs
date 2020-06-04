using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderProdukJualRepo : IRepository<OrderProdukJual>
    {
        IEnumerable<OrderProdukJual> GetPaged(int pageIndex, int pageSize);

    }
}
