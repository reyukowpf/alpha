using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDataHartaTetapRepo : IRepository<DataHartaTetap>
    {
        IEnumerable<DataHartaTetap> GetPaged(int pageIndex, int pageSize);
    }
}
