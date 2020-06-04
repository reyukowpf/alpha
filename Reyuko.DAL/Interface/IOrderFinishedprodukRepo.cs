using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderFinishedprodukRepo : IRepository<OrderFinishedproduk>
    {
        IEnumerable<OrderFinishedproduk> GetPaged(int pageIndex, int pageSize);

    }
}
