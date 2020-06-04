using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListKontakRepo : IRepository<ListKontak>
    {
        IEnumerable<ListKontak> GetPaged(int pageIndex, int pageSize);
    }
}
