using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDataGiroRepo : IRepository<DataGiro>
    {
        IEnumerable<DataGiro> GetPaged(int pageIndex, int pageSize);
    }
}
