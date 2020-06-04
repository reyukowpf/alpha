using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDataDepartemenRepo : IRepository<DataDepartemen>
    {
        IEnumerable<DataDepartemen> GetPaged(int pageIndex, int pageSize);
    }
}
