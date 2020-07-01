using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IKategoriProdukRepo : IRepository<KategoriProduk>
    {
        IEnumerable<KategoriProduk> GetPaged(int pageIndex, int pageSize);
    }
}
