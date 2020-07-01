using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListLokasiRepo : IRepository<ListLokasi>
    {
        IEnumerable<ListLokasi> GetPaged(int pageIndex, int pageSize);
    }
}
