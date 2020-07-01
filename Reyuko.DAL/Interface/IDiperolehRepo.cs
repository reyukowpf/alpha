using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDiperolehRepo : IRepository<Diperoleh>
    {
        IEnumerable<Diperoleh> GetPaged(int pageIndex, int pageSize);

    }
}
