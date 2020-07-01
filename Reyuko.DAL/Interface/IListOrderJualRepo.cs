using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListOrderJualRepo : IRepository<ListOrderJual>
    {
        IEnumerable<ListOrderJual> GetPaged(int pageIndex, int pageSize);
    }
}
