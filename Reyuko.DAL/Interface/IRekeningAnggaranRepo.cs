using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IRekeningAnggaranRepo : IRepository<RekeningAnggaran>
    {
        IEnumerable<RekeningAnggaran> GetPaged(int pageIndex, int pageSize);
    }
}
