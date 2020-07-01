using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListProdukRepo : IRepository<ListProduk>
    {
        IEnumerable<ListProduk> GetPaged(int pageIndex, int pageSize);
    }
}
