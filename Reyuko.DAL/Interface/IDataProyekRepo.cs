using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDataProyekRepo : IRepository<DataProyek>
    {
        IEnumerable<DataProyek> GetPaged(int pageIndex, int pageSize);
    }
}
