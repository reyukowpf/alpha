using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderJasaJualRepo : IRepository<OrderJasaJual>
    {
        IEnumerable<OrderJasaJual> GetPaged(int pageIndex, int pageSize);

    }
}
