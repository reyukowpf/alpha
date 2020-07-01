using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderProductioncustomRepo : IRepository<OrderProductioncustom>
    {
        IEnumerable<OrderProductioncustom> GetPaged(int pageIndex, int pageSize);

    }
}
