using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IBukuBesarRepo : IRepository<BukuBesar>
    {
        IEnumerable<BukuBesar> GetPaged(int pageIndex, int pageSize);
    }
}
