using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderJasaBeliRepo : IRepository<OrderJasaBeli>
    {
        IEnumerable<OrderJasaBeli> GetPaged(int pageIndex, int pageSize);

    }
}
