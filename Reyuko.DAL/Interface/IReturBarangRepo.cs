using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IReturBarangRepo : IRepository<ReturBarang>
    {
        IEnumerable<ReturBarang> GetPaged(int pageIndex, int pageSize);
    }
}
