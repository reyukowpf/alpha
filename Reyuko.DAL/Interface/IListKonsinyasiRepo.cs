using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListKonsinyasiRepo : IRepository<ListKonsinyasi>
    {
        IEnumerable<ListKonsinyasi> GetPaged(int pageIndex, int pageSize);
    }
}
