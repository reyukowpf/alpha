using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IHargaPokokRepo : IRepository<HargaPokok>
    {
        IEnumerable<HargaPokok> GetPaged(int pageIndex, int pageSize);
    }
}
