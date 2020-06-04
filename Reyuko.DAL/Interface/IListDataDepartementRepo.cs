using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListDataDepartemenRepo : IRepository<ListDataDepartemen>
    {
        IEnumerable<ListDataDepartemen> GetPaged(int pageIndex, int pageSize);
    }
}
