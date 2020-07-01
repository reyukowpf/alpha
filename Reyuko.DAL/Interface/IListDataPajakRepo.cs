using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListDataPajakRepo : IRepository<ListDataPajak>
    {
        IEnumerable<ListDataPajak> GetPaged(int pageIndex, int pageSize);
    }
}
