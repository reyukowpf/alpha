using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderCustomJualRepo : IRepository<OrderCustomJual>
    {
        IEnumerable<OrderCustomJual> GetPaged(int pageIndex, int pageSize);

    }
}
