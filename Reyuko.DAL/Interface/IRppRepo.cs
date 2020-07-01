using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IRppRepo : IRepository<Rpp>
    {
        IEnumerable<Rpp> GetPaged(int pageIndex, int pageSize);
    }
}
