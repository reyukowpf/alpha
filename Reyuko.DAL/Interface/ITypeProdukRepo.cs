using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ITypeProdukRepo : IRepository<TypeProduk>
    {
        IEnumerable<TypeProduk> GetPaged(int pageIndex, int pageSize);
    }
}
