using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IGrupProdukRepo : IRepository<GrupProduk>
    {
        IEnumerable<GrupProduk> GetPaged(int pageIndex, int pageSize);
    }
}
