using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ILokasiRepo : IRepository<Lokasi>
    {
        IEnumerable<Lokasi> GetPaged(int pageIndex, int pageSize);
    }
}
