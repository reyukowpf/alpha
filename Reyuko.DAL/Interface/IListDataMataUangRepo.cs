using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IListDataMataUangRepo : IRepository<ListDataMataUang>
    {
        IEnumerable<ListDataMataUang> GetPaged(int pageIndex, int pageSize);
    }
}
