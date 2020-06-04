using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IPenerimaanBarangRepo : IRepository<PenerimaanBarang>
    {
        IEnumerable<PenerimaanBarang> GetPaged(int pageIndex, int pageSize);
    }
}
