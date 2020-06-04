using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDataPajakRepo : IRepository<DataPajak>
    {
        IEnumerable<DataPajak> GetPaged(int pageIndex, int pageSize);
    }
}
