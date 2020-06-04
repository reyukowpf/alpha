using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IAlamatRepo : IRepository<Alamat>
    {
        IEnumerable<Alamat> GetPaged(int pageIndex, int pageSize);
    }
}
