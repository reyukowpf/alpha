using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IprodukRepo : IRepository<produk>
    {
        IEnumerable<produk> GetPaged(int pageIndex, int pageSize);
    }
}
