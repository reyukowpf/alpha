using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IGrupDiskonRepo : IRepository<GrupDiskon>
    {
        IEnumerable<GrupDiskon> GetPaged(int pageIndex, int pageSize);
    }
}
